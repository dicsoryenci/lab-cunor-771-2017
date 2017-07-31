-- Se consulta el último proveedor insertado.
SELECT *
FROM dbo.proveedor AS p
WHERE p.cod_proveedor = (SELECT MAX(p1.cod_proveedor) FROM dbo.proveedor AS p1)

--- Consultar el máximo
SELECT p.nom_proveedor, max(p.cod_proveedor)
FROM dbo.proveedor AS p
GROUP BY p.nom_proveedor

-- Cantidad de productos por proveedor

SELECT p.nom_proveedor, COUNT(pro.nom_producto) AS cantidad
FROM dbo.proveedor AS p INNER join dbo.producto AS pro ON p.cod_proveedor = pro.cod_proveedor
GROUP BY p.nom_proveedor

-- Consulta de exclusión

SELECT p.nom_proveedor
FROM dbo.proveedor AS p LEFT JOIN dbo.producto AS pro ON p.cod_proveedor = pro.cod_proveedor
WHERE pro.cod_proveedor IS NULL

-- Producto cartesiano

SELECT p.nom_proveedor, COUNT(pro.nom_producto)
FROM dbo.proveedor AS p FULL OUTER JOIN dbo.producto AS pro ON p.cod_proveedor = pro.cod_proveedor
GROUP BY p.nom_proveedor

-- Función de agregación MIN

SELECT MIN(p.cod_proveedor)
FROM dbo.proveedor AS p

SELECT p.nom_proveedor, COUNT(pro.nom_producto)
FROM dbo.proveedor AS p FULL OUTER JOIN dbo.producto AS pro ON p.cod_proveedor = pro.cod_proveedor
WHERE p.cod_proveedor = (SELECT MIN(p1.cod_proveedor) FROM dbo.proveedor AS p1)
GROUP BY p.nom_proveedor

-- Función de agregción SUM

SELECT SUM(p.precio_compra)
FROM dbo.producto AS p

-- Función de agregción AVG

SELECT AVG(p.precio_compra)
FROM dbo.producto AS p

-- Uso de AGE y Extract

SELECT age(timestamp '2050-06-13');

SELECT extract(day from age(timestamp '1957-06-13'));

