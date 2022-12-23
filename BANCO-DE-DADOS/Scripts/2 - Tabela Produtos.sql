--DROP TABLE IF EXISTS dbo.Produtos

--CREATE TABLE Produtos (
--	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
--	Nome varchar(255) NOT NULL,
--	Cor varchar(50) NULL,
--	Preco decimal(13, 2) NOT NULL,
--	Tamanho varchar(5) NULL,
--	Genero char(1) NULL
--)

--INSERT INTO Produtos VALUES ('Mountain Bike Socks, M','Branco','9.50','M','U')
--INSERT INTO Produtos VALUES ('Mountain Bike Socks, L','Branco','9.50','G','U')
--INSERT INTO Produtos VALUES ('AWC Logo Cap','Colorido','8.99','','U')
--INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, S','Colorido','49.99','P','U')
--INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, M','Colorido','49.99','M','U')
--INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, L','Colorido','49.99','G','U')
--INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, XL','Colorido','49.99','GG','U')
--INSERT INTO Produtos VALUES ('Mens Sports Shorts, S','Preto','59.99','P','M')
--INSERT INTO Produtos VALUES ('Mens Sports Shorts, M','Preto','59.99','M','M')
--INSERT INTO Produtos VALUES ('Mens Sports Shorts, L','Preto','59.99','G','M')
--INSERT INTO Produtos VALUES ('Mens Sports Shorts, XL','Preto','59.99','GG','M')
--INSERT INTO Produtos VALUES ('Womens Tights, S','Preto','74.99','P','F')
--INSERT INTO Produtos VALUES ('Womens Tights, M','Preto','74.99','M','F')
--INSERT INTO Produtos VALUES ('Womens Tights, L','Preto','74.99','G','F')
--INSERT INTO Produtos VALUES ('Mens Bib-Shorts, S','Colorido','89.99','P','M')
--INSERT INTO Produtos VALUES ('Mens Bib-Shorts, M','Colorido','89.99','M','M')
--INSERT INTO Produtos VALUES ('Mens Bib-Shorts, L','Colorido','89.99','G','M')
--INSERT INTO Produtos VALUES ('Half-Finger Gloves, S','Preto','24.49','P','U')
--INSERT INTO Produtos VALUES ('Half-Finger Gloves, M','Preto','24.49','M','U')
--INSERT INTO Produtos VALUES ('Half-Finger Gloves, L','Preto','24.49','G','U')
--INSERT INTO Produtos VALUES ('Full-Finger Gloves, S','Preto','37.99','P','U')
--INSERT INTO Produtos VALUES ('Full-Finger Gloves, M','Preto','37.99','M','U')
--INSERT INTO Produtos VALUES ('Full-Finger Gloves, L','Preto','37.99','G','U')
--INSERT INTO Produtos VALUES ('Classic Vest, S','Blue','63.50','P','U')
--INSERT INTO Produtos VALUES ('Classic Vest, M','Blue','63.50','M','U')
--INSERT INTO Produtos VALUES ('Classic Vest, L','Blue','63.50','G','U')
--INSERT INTO Produtos VALUES ('Womens Mountain Shorts, S','Preto','69.99','P','F')
--INSERT INTO Produtos VALUES ('Womens Mountain Shorts, M','Preto','69.99','M','F')
--INSERT INTO Produtos VALUES ('Womens Mountain Shorts, L','Preto','69.99','G','F')
--INSERT INTO Produtos VALUES ('Racing Socks, M','Branco','8.99','M','U')
--INSERT INTO Produtos VALUES ('Racing Socks, L','Branco','8.99','G','U')
--INSERT INTO Produtos VALUES ('Short-Sleeve Classic Jersey, S','Amarelo','53.99','P','U')
--INSERT INTO Produtos VALUES ('Short-Sleeve Classic Jersey, M','Amarelo','53.99','M','U')
--INSERT INTO Produtos VALUES ('Short-Sleeve Classic Jersey, L','Amarelo','53.99','G','U')
--INSERT INTO Produtos VALUES ('Short-Sleeve Classic Jersey, XL','Amarelo','53.99','GG','U')

--select COUNT(*) QuantidadeProdutos from Produtos;

--select COUNT(*) QuantidadeProdutos from Produtos WHERE Tamanho = 'M';

--SELECT SUM(Preco) PrecotTotal FROM Produtos;
--SELECT SUM(Preco) PrecotTotalProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M';

--SELECT Max(Preco) ProdutoMaisCaro FROM Produtos;

--SELECT Max(Preco) ProdutoMaisCaroTamanhoM FROM Produtos WHERE Tamanho = 'M';

--SELECT Min(Preco) ProdutoMaisBarato FROM Produtos;

--SELECT Min(Preco) ProdutoMaisBaratoTamanhoM FROM Produtos WHERE Tamanho = 'M';

--SELECT AVG(Preco) MediaPrecoProdutos From Produtos;

SELECT
	Nome + ', COR: ' + Cor as NomeProdutoCompleto,
	UPPER(Nome) as Nome,
	LOWER(Cor)	as Cor,
	FORMAT(DataCadastro, 'dd-MM-yyyy HH:mm') Data
FROM Produtos;

ALTER TABLE Produtos
ADD DataCadastro DATETIME2

UPDATE Produtos set DataCadastro = GETDATE();

select
Tamanho,
Count(*) Quantidade From Produtos
Where Tamanho <> ''
GROUP BY Tamanho
ORDER BY Quantidade DESC

select * from Clientes;

CREATE TABLE Endereco
(
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	IdCliente int null,
	Rua varchar(255) null,
	Bairro varchar(255) NULL,
	Cidade varchar(255) NULL,
	Estado char(2) null
	
	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY (IdCliente)
	REFERENCES Clientes(Id)
);

insert into Endereco values(4, 'Rua teste', 'Bairro teste', 'Cidade teste', 'SP');

select * from Endereco;

select * from Clientes INNER JOIN Endereco on Clientes.Id = Endereco.IdCliente
WHERE Clientes.Id = 4;

Alter table Produtos
ADD UNIQUE(Nome)

Alter table Produtos
ADD CONSTRAINT CHK_ColunaGenero CHECK(Genero = 'U' OR Genero = 'M' OR Genero = 'F')

insert into Produtos(Nome, Preco, Tamanho, Genero)
VALUES
('Teste', 355, 'G', 'M');

ALTER TABLE Produtos
ADD DEFAULT GETDATE() FOR DataCadastro;

ALTER TABLE Produtos
DROP CONSTRAINT  CHK_ColunaGenero

CREATE PROCEDURE InserirNovoProduto
@Nome varchar(255),
@Cor varchar(50),
@Preco decimal,
@Tamanho varchar(5),
@Genero char(1)

AS

INSERT INTO Produtos(Nome, Cor, PReco, Tamanho, Genero)
VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero)

EXEC InserirNovoProduto
'NOVO PRODUTO PROCEDURE',
'COLORIDO',
50,
'M',
'U';

CREATE PROCEDURE ObterTodosProdutos
AS
SELECT * FROM Produtos;

CREATE PROCEDURE ObterProdutosPorTamanho
@TamanhoProduto varchar(5)

AS 
SELECT * FROM Produtos WHERE Tamanho = @TamanhoProduto

EXEC ObterProdutosPorTamanho 
@TamanhoProduto = 'G'


EXEC ObterTodosProdutos

SELECT
	NOME,
	Preco,
	dbo.CalcularDesconto(Preco, 30) PrecoComDesconto
FROM Produtos WHERE Tamanho = 'M';

CREATE FUNCTION CalcularDesconto(@Preco DECIMAL(13,2), @Porcentagem INT)
RETURNS DECIMAL(13,2)
BEGIN
RETURN @Preco - (@Preco / 100 * @Porcentagem)
END



