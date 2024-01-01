SELECT name FROM SalesPerson AS S 
WHERE S.sales_id NOT IN (
    SELECT sales_id FROM Orders AS O 
        JOIN Company AS C ON O.com_id = C.com_id AND C.name = 'RED');