SELECT p.cod_producto AS codprod, p.nom_producto AS producto
FROM dbo.producto AS p 



--WHERE fec_caducidad BETWEEN '2017-07-01' AND '2017-07-30'
WHERE fec_caducidad BETWEEN CURRENT_DATE AND (CURRENT_DATE +10)


SELECT pro.nom_proveedor, p.nom_producto
FROM dbo.producto AS p 
INNER JOIN dbo.proveedor AS pro ON p.cod_proveedor = pro.cod_proveedor
WHERE p.estado_activo = 0 AND p.fec_caducidad BETWEEN CURRENT_DATE AND (CURRENT_DATE +10)

=
>
<
!=
<=
>=
LIKE 
BETWEEN

INNER JOIN