# ShapesArea
ShapesArea


Ответ на второй вопрос: 


SELECT p.Title as ProductTitle, c.TItle as CategoryTitle FROM
CategoriesProducts as cp RIGHT JOIN
Products as p ON p.Id = cp.ProductId LEFT JOIN
Categories as c ON c.Id = cp.CategoryId
