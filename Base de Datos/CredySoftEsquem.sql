CREATE TABLE cliente (
    id_cliente        VARCHAR2(12) NOT NULL,
    primernombre      VARCHAR2(20),
    segundonombre     VARCHAR2(20),
    primerapellido    VARCHAR2(20),
    segundoapellido   VARCHAR2(20),
    genero            CHAR(1),
    celular           VARCHAR2(10),
    direccion         VARCHAR2(35)
);

ALTER TABLE cliente ADD CONSTRAINT cliente_pk PRIMARY KEY ( id_cliente );

CREATE TABLE credito (
    sk_cuota             NUMBER(3) NOT NULL,
    valorcredito         NUMBER(12, 2),
    tasainteres          NUMBER(6, 2),
    fechainicial         DATE,
    fechafinal           DATE,
    numerocuotas         NUMBER(3),
    valorcuota           NUMBER(12, 2),
    cuotaspagadas        NUMBER(3),
    cliente_id_cliente   VARCHAR2(12) NOT NULL
);

ALTER TABLE credito ADD CONSTRAINT credito_pk PRIMARY KEY ( sk_cuota );

CREATE TABLE cuota (
    numerocuota          NUMBER(2) NOT NULL,
    fecha                DATE,
    valorcuota           NUMBER(9, 2),
    credito_sk_cuota     NUMBER(3) NOT NULL,
    cliente_id_cliente   VARCHAR2(12) NOT NULL
);

ALTER TABLE cuota ADD CONSTRAINT cuota_cliente_pk PRIMARY KEY ( credito_sk_cuota,cliente_id_cliente );
ALTER TABLE credito MODIFY fechafinal varchar2(15);
ALTER TABLE credito MODIFY fechainicial varchar2(15);

ALTER TABLE credito
    ADD CONSTRAINT credito_cliente_fk FOREIGN KEY ( cliente_id_cliente )
        REFERENCES cliente ( id_cliente );

ALTER TABLE cuota
    ADD CONSTRAINT cuota_cliente_fk FOREIGN KEY ( cliente_id_cliente )
        REFERENCES cliente ( id_cliente );

ALTER TABLE cuota
    ADD CONSTRAINT cuota_credito_fk FOREIGN KEY ( credito_sk_cuota )
        REFERENCES credito ( sk_cuota );

ALTER TABLE cliente ADD EMAIL varchar2(30);

CREATE TABLE MovimientoUsuarios(usuario varchar2(15),fecha varchar2(15), Tabla varchar2(15));
--SECUENCIAS
CREATE SEQUENCE SEQUENCE_CREDITO INCREMENT BY 1 START WITH 1 MAXVALUE 1000 MINVALUE 1;


--TRIGGERS
CREATE OR REPLACE TRIGGER ACTUALIZAR_SEQUENCIA
BEFORE INSERT ON Credito
FOR EACH ROW
BEGIN
    SELECT SEQUENCE_CREDITO.nextval
    INTO:new.sk_cuota
    FROM DUAL;
END;

CREATE OR REPLACE TRIGGER UPDATE_CUOTA
AFTER INSERT ON CUOTA
FOR EACH ROW
BEGIN
    UPDATE credito SET cuotaspagadas=:new.numerocuota
    WHERE sk_cuota=:new.credito_sk_cuota;
END;

CREATE OR REPLACE TRIGGER MOVIMIENTO_CLIENTE
AFTER INSERT OR UPDATE OR DELETE ON cliente
FOR EACH ROW
DECLARE
    V_FECHA varchar2(15);
BEGIN
    SELECT TO_CHAR (SYSDATE, 'MM-DD-YYYY HH24:MI:SS') INTO V_FECHA FROM DUAL;
    INSERT INTO movimientousuarios(usuario,fecha,tabla)
    VALUES(user,V_FECHA,'Cliente');
END;

CREATE OR REPLACE TRIGGER MOVIMIENTO_CREDITO
AFTER INSERT OR UPDATE OR DELETE ON CREDITO
FOR EACH ROW
DECLARE
    V_FECHA varchar2(15);
BEGIN
    SELECT TO_CHAR (SYSDATE, 'MM-DD-YYYY HH24:MI:SS') INTO V_FECHA FROM DUAL;
    INSERT INTO movimientousuarios(usuario,fecha,tabla)
    VALUES(user,V_FECHA,'Credito');
END;

CREATE OR REPLACE TRIGGER MOVIMIENTO_CUOTA
AFTER INSERT OR UPDATE OR DELETE ON Cuota
FOR EACH ROW
DECLARE
    V_FECHA varchar2(15);
BEGIN
    SELECT TO_CHAR (SYSDATE, 'MM-DD-YYYY HH24:MI:SS') INTO V_FECHA FROM DUAL;
    INSERT INTO movimientousuarios(usuario,fecha,tabla)
    VALUES(user,V_FECHA,'Cuota');
END;


        
CREATE OR REPLACE PACKAGE PAQUETECUOTA
IS
    PROCEDURE CREARCUOTA(v_numerocuota in number,v_fecha in varchar2,v_valorcuota in number,v_credito in number, v_cedula in varchar2);
    PROCEDURE TotalPagado(registro OUT SYS_REFCURSOR);
    PROCEDURE TotalFIltrado(registro OUT SYs_refcursor, v_credito in number);
    PROCEDURE TotalRecaudado(registro out SYS_Refcursor);
END PAQUETECUOTA;

ALTER TABLE Cuota modify fecha varchar2(15);

CREATE OR REPLACE PACKAGE BODY PAQUETECUOTA
IS
    PROCEDURE CREARCUOTA(v_numerocuota in number,v_fecha in varchar2,v_valorcuota in number,v_credito in number, v_cedula in varchar2)
    AS
    BEGIN
        INSERT INTO Cuota(numerocuota,fecha,valorcuota,credito_sk_cuota,cliente_id_cliente)
        VALUES(v_numerocuota,v_fecha,v_valorcuota,v_credito,v_cedula);
    END CREARCUOTA;
    
    PROCEDURE TotalPagado(registro OUT SYS_REFCURSOR)
    AS
    BEGIN
        OPEN registro For SELECT sum(c.valorcuota) FROM Cuota c JOIN credito cr
                          ON(cr.sk_cuota=c.credito_sk_cuota);
    END TotalPagado;
    
    PROCEDURE TotalFIltrado(registro OUT SYs_refcursor, v_credito in number)
    AS
    BEGIN
        OPEN registro FOR SELECT SUM(valorcuota) FROM Cuota
                          WHERE credito_sk_cuota=v_credito;      
    END TotalFIltrado;
    
    PROCEDURE TotalRecaudado(registro out SYS_Refcursor)
    AS
    BEGIN
        OPEN registro FOR SELECT SUM(valorcuota) FROM Cuota;
    END;
END PAQUETECUOTA;

CREATE OR REPLACE PACKAGE PAQUETECLIENTE
IS
    PROCEDURE GuardarCliente(v_id_cliente in varchar2,v_primernombre in varchar2,v_segundonombre in varchar2,
                                           v_primerapellido in varchar2,v_segundoapellido in varchar2,v_genero in char,
                                           v_celular in varchar2,v_direccion in varchar2, v_email in varchar2);
                                           
    PROCEDURE ConsultarClientes(registro OUT SYS_REFCURSOR);
    PROCEDURE FIltrarClientes(registro OUT SYS_REFCURSOR,v_genero in varchar2);
    PROCEDURE FiltroCedulta(registro OUT SYS_REFCURSOR,v_Cedula in varchar2);
    PROCEDURE BuscarCliente(registro OUT SYS_REFCURSOR,v_cedula in varchar2);
END PAQUETECLIENTE;

CREATE OR REPLACE PACKAGE BODY PAQUETECLIENTE
IS
    PROCEDURE GuardarCliente(v_id_cliente in varchar2,v_primernombre in varchar2,v_segundonombre in varchar2,
                                           v_primerapellido in varchar2,v_segundoapellido in varchar2,v_genero in char,
                                           v_celular in varchar2,v_direccion in varchar2,v_email in varchar2)
    AS
    BEGIN
        INSERT INTO cliente(id_cliente,primernombre,segundonombre,primerapellido,segundoapellido,genero,celular,direccion,Email)
        VALUES(v_id_cliente,v_primernombre,v_segundonombre,v_primerapellido,v_segundoapellido,v_genero,v_celular,v_direccion,v_email);
    END GuardarCliente;
    
    PROCEDURE ConsultarClientes(registro OUT SYS_REFCURSOR)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM cliente;
    END ConsultarClientes;
    
    PROCEDURE FIltrarClientes(registro OUT SYS_REFCURSOR,v_genero in varchar2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM cliente WHERE GENERO=v_genero;
    END FIltrarClientes;
    
    PROCEDURE FiltroCedulta(registro OUT SYS_REFCURSOR,v_Cedula in varchar2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM cliente where id_cliente like v_cedula;
    END FiltroCedulta;
    
    PROCEDURE BuscarCliente(registro OUT SYS_REFCURSOR,v_cedula in varchar2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM cliente where id_cliente =v_cedula;
    END BuscarCliente;
END PAQUETECLIENTE;

CREATE OR REPLACE PACKAGE PAQUETECREDITO
IS
    PROCEDURE GuardarCredito(v_valorcredito in number,v_tasainteres in number,v_fechainicial in date,
                                           v_fechafinal in date,v_numerocuotas in number,v_valorcuota in number,
                                           v_cuotaspagas in number, v_cliente_id in varchar2);
    PROCEDURE ConsultarCreditosCliente(registro OUT SYS_REFCURSOR,v_cedula in varchar2);
    PROCEDURE TotalPrestado(registro OUT SYS_REFCURSOR);
END PAQUETECREDITO;

CREATE OR REPLACE PACKAGE BODY PAQUETECREDITO
IS
    PROCEDURE GuardarCredito(v_valorcredito in number,v_tasainteres in number,v_fechainicial in date,
                                           v_fechafinal in date,v_numerocuotas in number,v_valorcuota in number,
                                           v_cuotaspagas in number, v_cliente_id in varchar2)
    AS
    BEGIN
        INSERT INTO credito(valorcredito,tasainteres,fechainicial,fechafinal,numerocuotas,valorcuota,cuotaspagadas,cliente_id_cliente)
        VALUES(v_valorcredito,v_tasainteres,v_fechainicial,v_fechafinal,v_numerocuotas,v_valorcuota,v_cuotaspagas,v_cliente_id);
    END GuardarCredito;
    
    PROCEDURE ConsultarCreditosCliente(registro OUT SYS_REFCURSOR,v_cedula in varchar2)
    AS
    BEGIN
        OPEN registro FOR SELECT * FROM credito
                          WHERE cliente_id_cliente=v_cedula;
    END ConsultarCreditosCliente;
    
    PROCEDURE TotalPrestado(registro OUT SYS_REFCURSOR)
    AS
    BEGIN
        OPEN registro FOR SELECT SUM(VALORCREDITO) FROM credito;
    END TotalPrestado;
END PAQUETECREDITO;


