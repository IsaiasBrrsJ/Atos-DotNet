create database empresa_db;
USE empresa_db;

create table departamento
(
	idDepartamento INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(60),
	localizacao VARCHAR(60),
	orcamento DECIMAL
)

create table empregado
(
	idEmpregado INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(60),
	idGerente INTEGER NULL,
	funcao VARCHAR(60),
	idDepartamento INTEGER,
	dataAdmissao DATE,
	salario DECIMAL,
	comissao DECIMAL,
	
	FOREIGN KEY (idDepartamento) REFERENCES departamento(idDepartamento),
	FOREIGN KEY (idGerente) REFERENCES empregado(idEmpregado)
)


INSERT INTO Departamento VALUES('Banco de Dados','Porto Alegre',2346);
INSERT INTO Departamento VALUES('Balconistas','Pelotas',10000);
INSERT INTO Departamento VALUES('Intelig�ncia Artific','Pelotas',333);
INSERT INTO Departamento VALUES('Compiladores','Novo Hamburgo',5050);
INSERT INTO Departamento VALUES('Redes','Taquara',12122);

SELECT * FROM departamento;

INSERT INTO Empregado VALUES('Mariewa',NULL,'Gerente',1,'2000-04-05',2300,0);
INSERT INTO Empregado VALUES('Zico',1,'Oper�rio',1,'1999-08-13',100,0);
INSERT INTO Empregado VALUES('Lula',NULL,'Presidente',5,'1950-01-01',10000,0);
INSERT INTO Empregado VALUES('Vera Fixer',5,'Balconista',2,'1999-05-05',3300,0);
INSERT INTO Empregado VALUES('Luana Pyovany',NULL,'Gerente',2,'1998-06-23',2300,0);
INSERT INTO Empregado VALUES('Daniela Schicarelli',NULL,'Gerente',3,'1999-10-10',2300,0);
INSERT INTO Empregado VALUES('Luize Altenhofen',NULL,'Gerente',4,'1999-04-26',2300,0);
INSERT INTO Empregado VALUES('Helo Pinheiro',NULL,'Gerente',5,'1997-09-25',2300,0);
INSERT INTO Empregado VALUES('Pel�',1,'Oper�rio',1,'2000-09-09',100,NULL);
INSERT INTO Empregado VALUES('Rom�rio',1,'Oper�rio',5,'2001-12-25',100,0);
INSERT INTO Empregado VALUES('Malu Mader',5,'Balconista',2,'2001-10-20',3400,0);
INSERT INTO Empregado VALUES('Ant�nio Fagundes',7,'Vendedor',3,'2002-12-22',5000,10);

DELETE empregado WHERE empregado.idEmpregado = 13;
SELECT * FROM Empregado;

-- 1) Selecione todos os departamentos cujo or�amento mensal
--	  seja maior que 10000. Apresente o Nome de tal departamento
--	  e seu or�amento anual, que ser� obtido multiplicando-se o
--	  or�amento mensal por 12

SELECT departamento.nome, departamento.orcamento FROM departamento WHERE ( orcamento * 12 ) > 10000;

-- 2) Apresente a instru��o anterior por�m ao inv�s dos
--	  'feios' DepNome e DepOrca, os T�tulos Departamento e Or�amento.

SELECT departamento.nome AS 'Titulo Departamento', departamento.orcamento AS 'Or�amento' FROM departamento WHERE ( orcamento * 12 ) > 10000;

--  3) Apresente todos os cargos existentes na empresa,
--	   por�m omita eventuais duplicidades.

SELECT DISTINCT(empregado.funcao) AS 'Cargo existente' FROM empregado;

-- 4) Apresente os nomes e fun��es da cada funcion�rio contidos
--	  na tabela empregado, por�m classificados alfabeticamente (A..Z)
--    e depois alfabeticamente invertido (Z..A).

SELECT  empregado.nome, empregado.nome FROM empregado ORDER BY empregado.nome;
SELECT  empregado.nome, empregado.nome FROM empregado ORDER BY empregado.nome DESC;

-- 5) Selecione os Empregados cujos sal�rios sejam
--	  menores que 1000 ou maiores que 3500.

SELECT  *  FROM empregado WHERE (empregado.salario < 1000 OR  empregado.salario > 3500);


-- 6) Apresente todos os funcion�rios com sal�rios
--	  entre 3400 e 4000 e que sejam balconistas.

SELECT * FROM empregado WHERE ( (empregado.salario > 3400 AND empregado.salario < 4000) AND empregado.funcao = 'Balconista');

-- 7) Apresente o nome de todos os empregados em letras min�sculas.

SELECT  LOWER(empregado.nome) FROM empregado; 

-- 8) Apresente o nome de todos os empregados (somente as 5 primeiras letras).

SELECT SUBSTRING(empregado.nome,1, 5) FROM empregado;

-- 9) Apresente a M�dia, o Maior, o Menor e tamb�m a Somat�ria
--	  dos Sal�rios pagos aos empregados.

SELECT AVG(empregado.salario) as 'M�dia Sal�rios', MAX(empregado.salario) as 'Maior Sal�rio',
MIN(empregado.salario) as 'Menor Sal�rio', SUM(empregado.salario) as 'Somat�rio Geral' FROM empregado;

-- 8) Apresente a m�dia de comiss�o pagos por departamento.

SELECT departamento.nome, AVG(empregado.comissao) as 'M�dia Comiss�o' FROM empregado INNER JOIN departamento on 
(departamento.idDepartamento = empregado.idDepartamento AND empregado.comissao > 0) GROUP BY departamento.nome;


--  9) Retome o problema anterior, por�m apresente resposta
--  apenas para departamentos com mais de 2 empregados.

SELECT departamento.nome, AVG(empregado.comissao) as 'M�dia Comiss�o' FROM empregado INNER JOIN departamento on 
(departamento.idDepartamento = empregado.idDepartamento AND empregado.comissao > 0) GROUP BY departamento.nome
HAVING COUNT(departamento.orcamento) > 2;

-- 10) Listar Nomes de Empregados, Cargos e
--	   Nome do Departamento onde o empregado trabalha.

SELECT empregado.nome, empregado.funcao, departamento.nome as 'Departamento' FROM empregado INNER JOIN departamento
	   on empregado.idDepartamento = departamento.idDepartamento;

-- 11) Liste os C�digos de Cada Funcion�rio, seus Nomes, seus Cargos
--	   e o nome do Gerente ao qual este se relaciona.

SELECT A.idEmpregado as 'C�digo Funcion�rio', A.nome, A.funcao, B.nome as 'Gerente' FROM empregado A, Empregado B where A.idGerente = B.idEmpregado;

-- 12) execute e avalie os comandos
--    INSERT
INSERT INTO Departamento (idDepartamento, nome, localizacao, orcamento) VALUES ('70','PRODUCAO','RIO DE JANEIRO','1200');
SELECT * FROM departamento;

-- 13) UPDATE
UPDATE Empregado 
SET Empregado.salario = Empregado.salario * 1.2 
WHERE Empregado.salario< 1000;

SELECT * FROM empregado;

-- 14) DELETE
DELETE FROM Empregado
WHERE Empregado.salario > 5000;

SELECT * FROM empregado;

-- 15) Relacione todos os nomes de funcion�rios e seus respectivos
--	   cargos, desde que o or�amento do departamento seja igual a 10000

SELECT empregado.nome, empregado.funcao FROM empregado INNER JOIN departamento on 
empregado.idDepartamento = departamento.idDepartamento AND departamento.orcamento = 10000; 

-- 16) Relacione todos os departamentos que possuem
--	   empregados com remunera��o maior que 3000.

SELECT * FROM departamento INNER JOIN empregado on departamento.idDepartamento = empregado.idDepartamento AND empregado.salario > 3000;