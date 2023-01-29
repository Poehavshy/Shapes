CREATE TABLE Products (
    Id INT PRIMARY KEY,
    "Name" TEXT
);

INSERT INTO Products
VALUES
    (1, 'Хлеб'),
    (2, 'Молоко'),
    (3, 'Сок');

CREATE TABLE Categories (
    Id INT PRIMARY KEY,
    "Name" TEXT
);

INSERT INTO Categories
VALUES
    (1, 'Напитки'),
    (2, 'Хлебные изделия'),
    (3, 'Мясные изделия');

CREATE TABLE ProductCategories (
   ProductId INT FOREIGN KEY REFERENCES Products(Id),
   CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
   PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
    (1, 2),
    (2, 1),
    (3, 1);

SELECT P."Name", C."Name"
FROM Products P
    LEFT JOIN ProductCategories PC
        ON P.Id = PC.ProductId
    LEFT JOIN Categories C
        ON PC.CategoryId = C.Id;
