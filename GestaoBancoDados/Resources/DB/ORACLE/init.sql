CREATE SEQUENCE filme_id_seq START WITH 1 INCREMENT BY 1;

CREATE TABLE filme (
    id NUMBER PRIMARY KEY,
    nome VARCHAR2(255),
    genero VARCHAR2(100),
    ano NUMBER
);

-- Criação do gatilho para autoincrementar a coluna "id"
CREATE OR REPLACE TRIGGER filme_id_trigger
BEFORE INSERT ON filme
FOR EACH ROW
BEGIN
    SELECT filme_id_seq.NEXTVAL INTO :new.id FROM dual;
END;

INSERT INTO filme (nome, genero, ano) VALUES ('Titanic', 'Drama', 1997);
INSERT INTO filme (nome, genero, ano) VALUES ('Cidade dos Anjos', 'Romance', 1998);
INSERT INTO filme (nome, genero, ano) VALUES ('Gente Grande', 'Comedia', 2010);
INSERT INTO filme (nome, genero, ano) VALUES ('Shrek 2', 'Animacao', 2004);
INSERT INTO filme (nome, genero, ano) VALUES ('ToyStory', 'Animacao', 1995);
INSERT INTO filme (nome, genero, ano) VALUES ('Divertidamente', 'Animacao', 2013);
INSERT INTO filme (nome, genero, ano) VALUES ('Click', 'Comedia', 2006);
INSERT INTO filme (nome, genero, ano) VALUES ('Matrix', 'Acao', 1999);
INSERT INTO filme (nome, genero, ano) VALUES ('Ate o ultimo homem', 'Documentario', 2016);
INSERT INTO filme (nome, genero, ano) VALUES ('Vingadores Ultimato', 'Acao', 2019);
INSERT INTO filme (nome, genero, ano) VALUES ('Vingadores Guerra Infinita', 'Acao', 2017);
