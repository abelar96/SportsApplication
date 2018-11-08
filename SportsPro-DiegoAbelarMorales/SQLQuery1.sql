Select ProductCode, DateOpened,Customers.Name,Technicians.Name AS Technician,Title 
FROM (( Incidents left outer join Technicians on Incidents.TechID = Technicians.TechID)
inner JOIN Customers on Incidents.CustomerID = Customers.CustomerID)
WHERE DateClosed is NULL