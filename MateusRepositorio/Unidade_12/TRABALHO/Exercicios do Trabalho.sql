
	--1) Faça um comando SQL para matricular o aluno “Pedro César” no curso de Informática. Os dados devem ser inseridos na tabela TBMATRÍCULA. 

--Inserido manualmente pelo Table Data
--INSERT INTO TBAluno (Nome,DataNascimento,Email,Sexo) VALUES ('Tiburcio','1995/02/1880','tiburcio@gmail.com','M')
--INSERT INTO TBMatricula (Curso_Id,Aluno_Id) values (5,7)

	--2) Escreva um comando SQL que retorne os nomes dos alunos e do(s) cursos em que estão matriculados. Os dados deverão estar ordenados pelo nome do curso. 

--select A.Nome, C.Nome from TBAluno as A INNER JOIN TBMatricula as M ON A.Id = M.Aluno_Id INNER JOIN TBCurso as C ON M.Curso_Id = C.Id ORDER BY C.Nome

	--3) Crie um comando SQL que retorne o e-mail de todos os alunos maiores de idade. 

--select A.Email FROM TBAluno as A where DataNascimento <= '01/01/1996'

	--4) Desenvolva um comando SQL que mostre o total de alunos. 

--SELECT COUNT(*) as Quantidade_Total from TBAluno

	--5) Escreva um comando SQL para listar o total de alunos matriculados em cada curso. 

--SELECT C.Nome, COUNT(*) FROM TBAluno AS A INNER JOIN TBMatricula AS M ON A.Id = M.Aluno_Id INNER JOIN TBCurso AS C ON M.Curso_Id = C.Id GROUP BY C.Nome
 
	--6) Desenvolva um comando SQL que retorne o nome de todos os alunos maiores que 18 anos. 

--select A.Nome FROM TBAluno as A where DataNascimento <= '01/01/1996'

	--7) Faça um comando SQL que retorne o nome de todas as mulheres. 

--SELECT A.Nome FROM TBAluno AS A WHERE Sexo LIKE 'F'

	--8) Faça um comando SQL que retorne o nome de todas as mulheres matriculadas no curso de Medicina. 

--SELECT A.Nome FROM TBAluno AS A INNER JOIN TBMatricula AS M ON A.Id = M.Aluno_Id INNER JOIN TBCurso AS C ON M.Curso_Id = C.Id WHERE A.Sexo = 'F' AND C.Nome = 'Medicina'

	--9) Faça um comando SQL que retorne os nomes dos cursos ordenados por ordem alfabética. 

--SELECT C.Nome FROM TBCurso AS C ORDER BY C.Nome

	--10) Crie o enunciado de uma consulta SQL que utilize “junção” (com resposta). 

	--Faça um comando em SQL que retorne o nome dos integrantes do cursos ordenados pelo nome do curso e do aluno

--SELECT A.Nome as Alunos, C.Nome AS CURSO FROM TBAluno AS A INNER JOIN TBMatricula AS M ON A.Id = M.Aluno_Id INNER JOIN TBCurso AS C ON M.Curso_Id = C.Id GROUP BY C.Nome, A.Nome






