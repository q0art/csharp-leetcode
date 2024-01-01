SELECT MAX(num) AS num
FROM (
    SELECT num
    FROM MyNumbers AS n
    GROUP BY n.num
    HAVING COUNT(n.num) = 1 ) AS unique_memebers;