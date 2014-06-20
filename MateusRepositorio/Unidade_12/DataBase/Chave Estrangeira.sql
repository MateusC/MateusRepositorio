SELECT L.Titulo, L.Ano_De_Publicacao, A.Nome from Livro as L, Autor as A
where A.Id = L.Autor_ID