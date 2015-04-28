SELECT 
	Employees.id,
	Employees.name,
	CAST((Salaries.annual_amount / Currencies.conversion_factor) AS DECIMAL(10, 2)) AS salary
FROM Salaries
JOIN Employees ON Salaries.employee_id = Employees.id
JOIN Currencies ON Salaries.currency = Currencies.id