SET NOCOUNT ON;

SELECT C.customer_name, CAST(I.total_price AS NUMERIC(15,6))
FROM customer C
INNER JOIN invoice I
ON C.id = I.customer_id
WHERE I.total_price < ((SELECT AVG(total_price) FROM invoice) * 0.25)
ORDER BY I.total_price DESC
GO
