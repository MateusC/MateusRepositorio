select*from Aluno where Altura <1.9; --mostra altura menor que 1,90;
select*from Aluno where Aprovado < 1; --mostra quem esta reprovado;
select*from Aluno where Nome is not null; --mostra nome preenchido, nome não vazio;
select*from Aluno where Altura between 1.5 and 1.9; --mostra altura entre 1,50 e 1,90;
select*from Aluno where Nome like 'Maria'; --mostra nome igual a MARIA;
select*from Aluno where Altura < 1.8 or Nome like 'Rodrigo'; --mostra altura menor que 1,80 OU nome igual a RODRIGO;