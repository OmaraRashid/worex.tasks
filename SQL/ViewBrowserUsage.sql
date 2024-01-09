CREATE VIEW [dbo].[ViewBrowserUsage]
AS 
SELECT ProcessName, SUM(DurationInSec) AS TotalDuration
FROM ActiveProcessDetails
WHERE ProcessName IN ('Brave', 'Google Chrome', 'Microsoft Edge', 'Firefox')
AND TimeStamp BETWEEN '2022-08-08' AND '2022-10-08'
GROUP BY ProcessName;
