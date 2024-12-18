-- UNION

-- O OPERADOR UNION COMBINA DOIS OU MAIS RESULTADOS DE UM SELECT EM UM RESULTADO APENAS.

SELECT coluna1, coluna2
FROM tabela1
UNION
SELECT coluna1, coluna 2
FROM tabela2

-- AS COLUNAS RESPECTIVAS DEVEM CONTER DADOS DO MESMO TIPO

-- O UNION NÃO MOSTRA DADOS DUPLUCADOS
-- USANDO UNION ALL, SERÁ PUXADO TODOS OS DADOS INCLUSIVE OS DUPLICADOS


-- EXEMPLO 1
SELECT [ProductID], [Name], [ProductNumber]
FROM Production.Product
WHERE Name LIKE '%Chain%'
UNION
SELECT [ProductID], [Name], [ProductNumber]
FROM Production.Product
WHERE Name LIKE '%Decal%'
ORDER BY Name desc

-- EXEMPLO 2
SELECT FirstName, Title
FROM Person.Person
WHERE Title = 'Mr.'
UNION
SELECT FirstName, Title
FROM Person.Person
WHERE MiddleName = 'A'