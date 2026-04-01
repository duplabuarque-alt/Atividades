/* CONSULTAS COM OPERADORES */
/* Operadores Aritméticos 
	+	|	Soma
	-	|	Subtração
	*	|	Multiplicação
	/	|	Divisão
	%	|	Resto de Divisão
*/


use Empresa

select * from Funcionarios

select (1 + 2) * 3 - 4 as totalconta


select 12 * 7 as mult, 12 + 7 as soma, 12 - 7 as sub, 12 / 7 as divisao

select (1 + 2) * 3 as soma


select * from Funcionarios



select nome, cargo from funcionarios

-- Mostre o nome e salário dos funcionários 
select nome, salario from funcionarios

-- Mostre o nome e salário 
-- de todos os funcionarios que ganham acima de 2000
select nome, salario from funcionarios
where salario > 2000 

-- Mostre o nome e salário 
-- de todos os funcionarios que ganham acima de 2000 e
-- sejam do cargo de TI
select salario, nome, cargo from funcionarios
where salario > 2000 and cargo = 'TI'

-- exiba nome e salario,  crie
-- uma nova coluna somando 10% no salário
SELECT nome, salario, salario*1.1 as novosalario  
FROM Funcionarios


--Atualize o salario de todos os funcionários
-- acrescentando 100 reais
update funcionarios set salario = salario + 100

select nome, salario from funcionario


select nome, salario, salario * 1.10 as novosalario from funcionario

 

update Funcionario set salario = salario * 0.9 

/*Operadores Relacionais					Operadores Lógicos
--                                                                            (and) cond1 cond2 Resultado  (or) cond1 cond2 Resultado  (not) cond1  resultado
		>	|	maior						AND - OPERADOR DE CONJUNÇÃO E			v		v	v				v		v		v				V		F
		<	|	menor						OR - OPERADOR DE DISJUNÇÃO	OU			v		f	F				V		F		V				F		V	
		=	|	igual					    NOT - OPERADOR DE NEGAÇÃO NÃO			F		f	F				F		V		V
   != ou <>	|	diferente--															F		F	F				F		F		F
		>=	|	maior ou igual
		<=	|	menor ou igual
*/
-- Mostre o nome, salário e pais somente dos funcionários
-- que tenham salário entre 9000 e 11800 e sejam dos EUA
select nome, salario, pais
from Funcionarios
where salario >= 9000 and Salario <= 11800 and Pais = 'EUA'

-- Mostre o nome, salário e estado somente dos funcionários
-- que tenham salário entre 9000 e 11800 ou sejam dos EUA
select nome, salario, pais
from Funcionarios
where  (salario >= 9000 and salario <=11800) or (pais = 'EUA')

/*Operadores Auxiliares
	IS NULL - Verifica se uma coluna é vazia
	BETWEEN - Verifica uma faixa de valores
	IN	    - Verifica se um valor existe na tabela
	LIKE	- Verifica um valor buscando semelhantes
	        Coringas % um ou mais caracteres em qualquer posição da string
			_ underline substitui um unico caracter naquela posição específica

*/

select * from funcionarios
-- Exiba nome, salario e estado dos funcionários que ganham
-- entre 1100 e 1180.
select nome, salario, pais
from Funcionarios
where salario between 9000 and 11800
 
-- Exiba nome, cidade dos funcionários que não moram
-- na cidade Seattle
select nome, cidade
from Funcionarios
where  not  cidade = 'Seattle'

select nome, cidade
from Funcionarios
where  cidade !='Seattle'

select nome,cidade
from Funcionarios
where  cidade <> 'Seattle'

SELECT nome,cidade
FROM FUNCIONARIOS
WHERE not  CIDADE IN ('Seattle','Redmond')


-- Exiba nome, cargo dos funcionarios cuja cargo
-- esteja vazio

select * from clientes
select Nome, Cidade, Regiao
from clientes
where  not Regiao is null 


-- Exiba todas as pessoas que comecem no nome a letra A
select nome
from Clientes
where nome like '%Ana%'
