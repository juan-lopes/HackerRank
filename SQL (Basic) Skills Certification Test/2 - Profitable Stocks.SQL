SET NOCOUNT ON;

SELECT PT.stock_code
FROM price_today PT
INNER JOIN price_tomorrow PTM
ON PT.stock_code = PTM.stock_code
WHERE PT.price < PTM.price
ORDER BY PT.stock_code ASC
GO
