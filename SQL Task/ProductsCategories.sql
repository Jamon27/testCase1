--В базе данных MS SQL Server есть продукты и категории.
--Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
--Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
--Если у продукта нет категорий, то его имя все равно должно выводиться.

CREATE TABLE [dbo].[Product](
	 [Id] [int] PRIMARY KEY
	,[Name] [nvarchar](255) NOT NULL
);

INSERT INTO [dbo].[Product] (Id, Name)
	VALUES 
		 (1, N'Конфеты')
		,(2, N'Шоколад')
		,(3, N'Ель живая')
		,(4, N'Салат с тунцом');


CREATE TABLE [dbo].[Category](
	 [Id] [int] PRIMARY KEY
	,[Name] [nvarchar](255) NOT NULL
);

INSERT INTO [dbo].[Category] (Id, Name)
	VALUES 
		  (1, N'Кондитерские изделия')
		 ,(2, N'Товары для дома и сада')
		 ,(3, N'Новый год')
		 ,(4, N'Книги');

CREATE TABLE [dbo].[ProductsCategories]
(
	 ProductId INT FOREIGN KEY REFERENCES [dbo].[Product](Id)
	,CategoryId INT FOREIGN KEY REFERENCES [dbo].[Category](Id)
	,PRIMARY KEY(ProductId, CategoryId)
);

INSERT INTO [dbo].[ProductsCategories] (ProductId, CategoryId)
	VALUES 
	  (1, 1)
	 ,(2, 1)
	 ,(3, 2)
	 ,(3, 3);


SELECT p.Name, c.Name
FROM [dbo].[Product] p
LEFT JOIN [dbo].[ProductsCategories] pc ON p.Id = pc.ProductId
LEFT JOIN [dbo].[Category] c ON pc.CategoryId = c.Id;