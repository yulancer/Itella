-- запрос, который возвращает все книги, авторы которых не являются соавторами в других книгах
select * from Books 
where Id in (
	select Book_Id from AuthorBooks where Author_Id not in (
		select distinct Author_Id from AuthorBooks
		where Book_Id in (
			select Book_Id from (
				select Book_Id, COUNT(Author_Id) AuthorCount 
				from AuthorBooks
				group by Book_Id
			) a 
			where AuthorCount > 1
		) 
	)
)