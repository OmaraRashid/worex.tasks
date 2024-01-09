CREATE PROCEDURE GetManagerProjectHours
AS
BEGIN
    SELECT 
        Manager.Name AS ManagerName,
        Project.Name AS ProjectName,
        SUM(TimeLog.MinutesWorked) AS TotalMinutes
    FROM TimeLog
    INNER JOIN Employee ON TimeLog.EmployeeID = Employee.EmployeeID
    INNER JOIN Project ON TimeLog.ProjectID = Project.ProjectID
    INNER JOIN Employee AS Manager ON Employee.ManagerID = Manager.EmployeeID
    GROUP BY Manager.Name, Project.Name
END
