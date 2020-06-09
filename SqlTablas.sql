use proyectodb

CREATE TABLE beneficiarios (
    sk_beneficiario            int NOT NULL,
    subsidio_sk_subsidio       int NOT NULL,
    subsidio_id_personarepre   varchar(12) NOT NULL,
    bonomercado                decimal NOT NULL,
    "Beca%"                    decimal NOT NULL
);

CREATE UNIQUE INDEX beneficiarios__idx ON
    beneficiarios (
        subsidio_sk_subsidio
    ASC );

CREATE UNIQUE INDEX beneficiarios__idxv1 ON
    beneficiarios (
        subsidio_sk_subsidio
    ASC,
        subsidio_id_personarepre
    ASC );

ALTER TABLE beneficiarios ADD CONSTRAINT beneficiarios_pk PRIMARY KEY ( sk_beneficiario );

CREATE TABLE etnia (
    sk_etnia   int NOT NULL,
    nombre     VARCHAR(25) NOT NULL
);

ALTER TABLE etnia ADD CONSTRAINT etnia_pk PRIMARY KEY ( sk_etnia );

CREATE TABLE familiares (
    id_cliente                 VARCHAR(12) NOT NULL,
    subsidio_sk_subsidio       int NOT NULL,
    subsidio_id_personarepre   VARCHAR(12) NOT NULL,
    etnia_sk_etnia             int NOT NULL,
    primernombre               VARCHAR(25) NOT NULL,
    segundonombre              VARCHAR(25),
    primerapellido             VARCHAR(25) NOT NULL,
    segundoapellido1           VARCHAR(25),
    discapacidad               VARCHAR(25),
    ciudad                     VARCHAR(20),
    departamento               VARCHAR(25),
    direccion                  VARCHAR(30)
);

ALTER TABLE familiares ADD CONSTRAINT familiares_pk PRIMARY KEY ( id_cliente );

CREATE TABLE subsidio (
    sk_subsidio        int NOT NULL,
    id_personarepre    VARCHAR(12) NOT NULL,
    salariodevengado   int NOT NULL,
    integrantes        int NOT NULL,
    estrado            int,
    puntajesisben      decimal NOT NULL,
    correo             VARCHAR(50)
);

ALTER TABLE subsidio ADD CONSTRAINT subsidio_pk PRIMARY KEY ( sk_subsidio,
                                                              id_personarepre );

ALTER TABLE beneficiarios
    ADD CONSTRAINT beneficiarios_subsidio_fk FOREIGN KEY ( subsidio_sk_subsidio,
                                                           subsidio_id_personarepre )
        REFERENCES subsidio ( sk_subsidio,
                              id_personarepre );

ALTER TABLE familiares
    ADD CONSTRAINT familiares_etnia_fk FOREIGN KEY ( etnia_sk_etnia )
        REFERENCES etnia ( sk_etnia );

ALTER TABLE familiares
    ADD CONSTRAINT familiares_subsidio_fk FOREIGN KEY ( subsidio_sk_subsidio,
                                                        subsidio_id_personarepre )
        REFERENCES subsidio ( sk_subsidio,
                              id_personarepre );