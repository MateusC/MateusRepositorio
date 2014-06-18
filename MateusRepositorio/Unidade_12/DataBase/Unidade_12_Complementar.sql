
						  --1) Crie as tabelas em sua base de dados e faça a relação entre elas.


						  --2) Preencha as tabelas com valores aleatórios para que possamos fazer consultas.


						  --3)(Listar nome e sobrenome com ordenação pelo sobrenome)
--select PrimeiroNome, SobreNome from Funcionario order by SobreNome


						  --4) Listar todos os campos de funcionários ordenados por função.
--SELECT * FROM Funcionario ORDER BY Funcao


						  --5) Liste os funcionários que têm salário superior a R$ 1.000,00 ordenados pelo nome completo.
--SELECT * FROM Funcionario WHERE Salario >1000 ORDER BY PrimeiroNome, SobreNome


						  --6) Liste o total da folha de pagamento de todos os funcionários.
--SELECT SUM(Salario) as Pagamentos FROM Funcionario


						  --7) Liste o nome, o nome do departamento e a função de todos os funcionários ordenado por nome.
--SELECT PrimeiroNome as Nome,Funcao as Emprego, d.Nome as Lugar FROM Funcionario as F inner join Departamento as D on (F.Departamento_Id = D.Id) ORDER BY F.PrimeiroNome asc 


						  --8) Liste o valor da folha de pagamento de cada departamento
--select Departamento.Nome  as Secao , sum(Funcionario.Salario) as Folha_Pagamento from Funcionario inner join Departamento on (Funcionario.Departamento_Id = Departamento.Id) group by Departamento.Nome

					
						  --9) Exclua os funcionarios que não tenham departamento.
--DELETE FROM Funcionario WHERE Departamento_Id = NULL


						  --10)  Liste os departamentos dos funcionários que têm a função de supervisor.
--SELECT  Departamento.Nome as Secao FROM Departamento inner join Funcionario on (Funcionario.Departamento_Id = Departamento.Id) where Funcao = 'Supervisor' 


						  --11)  Liste os funcionários que têm salário entre R$ 500,00 e 1.500,00 ordenados pelo nome.
--SELECT PrimeiroNome as Nome, Salario FROM Funcionario where Salario between 500 and 1500 order by PrimeiroNome asc


						  --12)  Liste os nomes de funcionários que começam com a letra ‘M’ ordenados pro nome de departamento.
--select PrimeiroNome as Nome, Departamento.Nome as Secao from Funcionario inner join Departamento on (Funcionario.Departamento_Id = Departamento.Id) where PrimeiroNome like 'M%' order by Departamento.Nome asc


						  --13)  Liste a quantidade de funcionários desta empresa.
--select count(*) FROM Funcionario


						  --14)Liste a quantidade de funcionários de cada departamento.
--SELECT D.Nome, count(*) from Funcionario as F inner join Departamento as D on (F.Departamento_Id = D.Id) group by D.Nome


						  --15)  Liste o salário médio pago pela empresa. (Existe um comando)
--select avg(Funcionario.Salario) as Media_Salario from Funcionario


						  --16)  Liste o menor salário pago pela empresa em cada departamento.
--SELECT Departamento.Nome as Secao, min(Funcionario.Salario) from Funcionario inner join Departamento on (Funcionario.Departamento_Id = Departamento.Id) group by Departamento.Nome


						  --17)  Liste o maior salário pago pela empresa em cada departamento.
--SELECT Departamento.Nome as Secao, MAX(Funcionario.Salario) from Funcionario inner join Departamento on (Funcionario.Departamento_Id = Departamento.Id) group by Departamento.Nome


						  --18)  Liste o nome do departamento e do funcionário ordenados por departamento e funcionário.
--SELECT D.Nome as Secao, F.PrimeiroNome as Funcionario FROM Funcionario as F inner join Departamento as D on(F.Departamento_Id = D.Id) group by D.Nome,F.PrimeiroNome






