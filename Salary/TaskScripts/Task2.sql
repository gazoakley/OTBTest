SELECT 
	Employees.id,
	Employees.name,
	Salaries.annual_amount AS local_salary,
	CAST((Salaries.annual_amount / Currencies.conversion_factor) AS DECIMAL(10, 2)) AS gbp_salary
FROM Salaries
JOIN Employees ON Salaries.employee_id = Employees.id
JOIN Currencies ON Salaries.currency = Currencies.id
JOIN Roles ON Employees.role_id = Roles.id
WHERE Employees.name LIKE @Name
ORDER BY gbp_salary DESC