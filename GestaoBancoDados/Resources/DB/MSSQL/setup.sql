USE master;
GO

CREATE DATABASE filmesDB;
GO

USE filmesDB;
GO

CREATE TABLE filme (
    id INT PRIMARY KEY IDENTITY,
    nome VARCHAR(100),
    genero VARCHAR(50),
    ano INT
);
GO

INSERT INTO filme (nome, genero, ano)
VALUES 
('O Poderoso Chefão', 'Crime', 1972),
('O Senhor dos Anéis: A Sociedade do Anel', 'Fantasia', 2001),
('Interestelar', 'Ficção Científica', 2014),
('A Origem', 'Ficção Científica', 2010),
('Clube da Luta', 'Drama', 1999),
('Forrest Gump', 'Drama', 1994),
('Matrix', 'Ficção Científica', 1999),
('O Silêncio dos Inocentes', 'Crime', 1991),
('Os Sete Samurais', 'Drama', 1954),
('Cidade de Deus', 'Crime', 2002),
('A Lista de Schindler', 'Drama', 1993),
('Vingadores: Ultimato', 'Ação', 2019),
('Titanic', 'Romance', 1997),
('O Rei Leão', 'Animação', 1994),
('Avatar', 'Ficção Científica', 2009),
('Jurassic Park', 'Aventura', 1993),
('Star Wars: Episódio IV - Uma Nova Esperança', 'Ficção Científica', 1977),
('A Viagem de Chihiro', 'Animação', 2001),
('O Resgate do Soldado Ryan', 'Guerra', 1998),
('O Labirinto do Fauno', 'Fantasia', 2006);
GO
