SELECT E.name AS Employee FROM Employee E
JOIN Employee M ON M.id = E.managerId
WHERE M.salary < E.salary;