CREATE TABLE filme (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    genero VARCHAR(100) NOT NULL,
    ano INTEGER NOT NULL
);

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

