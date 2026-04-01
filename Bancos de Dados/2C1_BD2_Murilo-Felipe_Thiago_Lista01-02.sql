/*
Resolva os exercícios abaixo:
*/
-- 1) Crie o banco de Dados Locadora e coloque-o em uso

/* 2) Crie as seguintes tabelas:
tbClientes(
	CodCli inteiro, -chave primária 
	Nome texto(50), 
	Endereco texto(50),
	Cidade  texto(50),
	Sexo caracter(1),
	Datanasc datahora,
	CNH texto(25),
	DataHabilitacao data,
)

tbCarros (
	CodCarro inteiro, -chave primária
	Marca texto(30),
	Modelo texto(30),
	Placa texto(8),
	ValorDiaria moeda,
	Fornecedor texto(50),
)

tbAluguel(
	CodAluguel inteiro, -chave primária
	CodCli inteiro, 
	CodCarro inteiro,
	DataRet datahora,
	DataDev datahora,
	ValorPago moeda
)

*/

-- 3) Acrescentar o campo Estado (caracter 2) na tabela de Clientes

-- 4) Acrescentar o campo Categoria (texto 30) na tabela de Carros

-- 5) Acrescentar o campo Cor (texto 20) na tabela de Carros

-- 6) Remova o campo DataHabilitacao da tabela de Clientes

-- 7) Remova o campo Fornecedor da tabela de Carros

-- 8) Renomeie o campo DataRet da tabela tbAluguel para DataRetirada

-- 9) Renomeie o campo DataDev da tabela tbAluguel para DataDevolucao

-- 10) Renomeie o campo Nome da tabela tbClientes para NomeCliente


create database locadora

use locadora

create table tbclientes (
    codcli int primary key,
    nome varchar(50),
    endereco varchar(50),
    cidade varchar(50),
    sexo char(1),
    datanasc date,
    cnh varchar(25),
    datahabilitacao date
)

create table tbcarros (
    codcarro int primary key,
    marca varchar(30),
    modelo varchar(30),
    placa varchar(8),
    valordiaria money,
    fornecedor varchar(50)
)

create table tbaluguel (
    codaluguel int primary key,
    codcli int,
    codcarro int,
    dataret date,
    datadev date,
    valorpago money
)
 --3
alter table tbclientes
add estado char(2)

--4
alter table tbcarros
add categoria varchar(30)

--5
alter table tbcarros
add cor varchar(20)

--6
alter table tbclientes
drop column datahabilitacao

--7
alter table tbcarros
drop column fornecedor

--8
exec sp_rename 'tbaluguel.dataret', 'dataretirada', 'column'

--9
exec sp_rename 'tbaluguel.datadev', 'datadevolucao', 'column'

--10
exec sp_rename 'tbclientes.nome', 'nomecliente', 'column'

select * from tbcarros

select * from tbclientes

select * from tbaluguel

--Lista 2

--1
insert into tbclientes (codcli, nomecliente, endereco, cidade, sexo, datanasc, cnh)
values (1,'josé de oliveira','av. jatobá','jundiaí','m','1965-05-11','0009'),
(2,'maria da silva','av. presidente','itatiba','f','1979-10-08','0008'),
(3,'antonio carlos','r. florenca','jundiaí','m','1980-09-20','0007'),
(4,'luisa de souza','av. jequitibá','jundiaí','f','1975-10-10','0005')

--2
insert into tbcarros (codcarro, marca, modelo, placa, valordiaria, categoria)
values (1,'ford','ka','aaa-0001',180.00,'econômico'),
(2,'gm','onix','aaa-0002',180.00,'econômico'),
(3,'honda','hrv','aaa-0003',270.00,'suv'),
(4,'jeep','compass','aaa-0004',310.00,'suv média'),
(5,'vw','jetta','aaa-0005',270.00,'sedan'),
(6,'fiat','mobi','aaa-0006',130.00,'compacto')

--3
insert into tbaluguel (codaluguel, codcli, codcarro, dataretirada, datadevolucao, valorpago)
values (1,1,1, '2019-08-02', '2019-08-07', 900),
(2,2,3, '2019-08-12', '2019-08-15', 500),
(3,3,2, '2019-08-02', '2019-08-07', 900),
(4,4,5, '2019-08-12', '2019-08-15', 700)

--4
update tbclientes
set estado = 'SP'

--5 
update tbcarros
set valordiaria = 350
where modelo = 'compass'

--6
update tbclientes
set cidade = 'vinhedo'
where codcli = 2

--7
delete from tbcarros
where modelo = 'mobi'

--8
delete from tbaluguel
where codcli = 3

--9
delete from tbaluguel
where codcarro = 2

--10 
update tbcarros
set valordiaria = valordiaria * 1.07