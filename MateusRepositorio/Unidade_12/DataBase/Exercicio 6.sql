select sum(altura) as Soma_Das_Alturas from Aluno;
select sum(altura) as Altura_dos_Reprovados from Aluno where Aprovado = 0;
select count(*) as Quantidade from Aluno;
select max(altura) as Maior_Altura from Aluno;
select min(altura) as Menor_Altura from Aluno;
select count(*) as Aprovados from Aluno where Aprovado =1;