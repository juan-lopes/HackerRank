SET NOCOUNT ON;

SELECT CONCAT(CM.customer_id, ' ', CM.name, ' ', '+', CC.country_code, CM.phone_number)
FROM customers CM
INNER JOIN country_codes CC
ON CM.country = CC.country
ORDER BY customer_id ASC
GO
