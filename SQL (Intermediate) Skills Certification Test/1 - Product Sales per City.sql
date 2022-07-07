SET NOCOUNT ON;

SELECT C.city_name, P.product_name, II.line_total_price
FROM city C
INNER JOIN customer CT
ON CT.city_id = C.id
INNER JOIN invoice I
ON CT.id = I.customer_id
INNER JOIN invoice_item II
ON I.id = II.invoice_id
INNER JOIN product P
ON II.PRODUCT_ID = P.id
ORDER BY C.city_name, P.product_name ASC
GO
