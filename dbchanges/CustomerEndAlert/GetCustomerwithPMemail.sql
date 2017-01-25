USE [V2Intranet]
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerwithPMemail]    Script Date: 1/10/2017 5:22:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mahesh Farad
-- Create date: 10th jan 2017 
-- Description:	To Get Project Maneger Email for CustomerEndAlert
-- =============================================
ALTER PROCEDURE [dbo].[GetCustomerwithPMemail]
	-- Add the parameters for the stored procedure here
	@customerId int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	select r.EmployeeID,he.EmployeeCode,he.EmailID,ds.DesignationName,he.EmployeeName from tbl_PM_ProjectEmployeeRole r 
join tbl_pm_employee te on (r.EmployeeID=te.EmployeeID)
join tbl_PM_Project pr on (r.ProjectID=pr.ProjectID)
join HRMS_tbl_PM_Employee he on (he.EmployeeCode=te.EmployeeCode)
join HRMS_tbl_PM_DesignationMaster ds on (he.DesignationID=ds.DesignationID)
where 
r.ProjectID in (select p.ProjectID from tbl_PM_Customer c
join  tbl_pm_project p on (c.Customer=p.CustomerID)
where c.Customer=@customerId) and ds.DesignationID in (20) and he.Status=0 and he.EmployeeStatusMasterID=1
END
