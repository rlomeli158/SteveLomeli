GRANT INSERT ON Student TO Student;
GRANT DELETE ON Course TO Student;
GRANT SELECT ON CompletedRegistration TO Student;
GRANT UPDATE ON ActiveRegistration TO Student;

CREATE ROLE Students IDENTIFIED BY "Student123!" ;

GRANT Students TO srl2629;
--
CREATE ROLE Students IDENTIFIED BY "Password";
CREATE ROLE Faculty IDENTIFIED BY "Password";
CREATE ROLE Administrators IDENTIFIED BY "Password";

GRANT SELECT, UPDATE ON Student TO Students;
GRANT SELECT ON Course TO Students;
GRANT SELECT ON CompletedRegistration TO Students;
GRANT SELECT ON ActiveRegistraation TO Students;
-- Students

GRANT SELECT, UPDATE ON Course TO Faculty;
GRANT SELECT, UPDATE ON ActiveRegistration to Faculty;
-- Faculty

REVOKE SELECT, UPDATE ON Course FROM Faculty;

------------------------------------------- CREATE Roles

CREATE ROLE Customer IDENTIFIED BY "Customer123!";
CREATE ROLE Employee IDENTIFIED BY "Employee123!";
CREATE ROLE SalesEmployee IDENTIFIED BY "SalesEmployee123!";
CREATE ROLE HREmployee IDENTIFIED BY "HREmployee123!";
CREATE ROLE MarketingEmployee IDENTIFIED BY "MarketingEmployee123!";

------------------------------------------- GRANT

GRANT SELECT ON Sale TO Customer;
GRANT SELECT ON SaleInformation TO Customer;
GRANT SELECT, UPDATE ON Customer TO Customer;
-- Customers

GRANT SELECT, UPDATE ON Employee TO Employee;
GRANT SELECT ON Department TO Employee;
-- Employee

GRANT SELECT ON Product TO SalesEmployee;
GRANT SELECT, UPDATE, INSERT ON Sale TO SalesEmployee;
GRANT SELECT, UPDATE, INSERT ON SaleInformation TO SalesEmployee;
GRANT SELECT, UPDATE, INSERT ON Customer TO SalesEmployee;
GRANT SELECT, UPDATE ON Employee TO SalesEmployee;
GRANT SELECT ON Department TO SalesEmployee;
-- SalesEmployee

GRANT SELECT, UPDATE, INSERT, DELETE ON Employee TO HREmployee;
GRANT SELECT, UPDATE, INSERT, DELETE ON Department TO HREmployee;
-- HR Employee

GRANT SELECT, UPDATE ON Employee TO MarketingEmployee;
GRANT SELECT ON Department TO MarketingEmployee;
-- Marketing Employee

--#4
----------------------------------------------- REVOKE

REVOKE ALL ON Sale FROM Customers;
REVOKE ALL ON SaleInformation FROM Customers;
REVOKE ALL ON Customer FROM Customer;

-- Customers

REVOKE ALL ON Employee FROM Employee;
REVOKE ALL ON Department FROM Employee;

-- Employee

REVOKE ALL ON Product FROM SalesEmployee;
REVOKE ALL ON Sale FROM SalesEmployee;
REVOKE ALL ON SaleInformation FROM SalesEmployee;
REVOKE ALL ON Customer FROM SalesEmployee;
REVOKE ALL ON Employee FROM SalesEmployee;
REVOKE ALL ON Department FROM SalesEmployee;

-- SalesEmployee

REVOKE ALL ON Employee FROM HREmployee;
REVOKE ALL ON Department FROM HREmployee;

-- HR Employee

REVOKE ALL ON Employee FROM MarketingEmployee;
REVOKE ALL ON Department FROM MarketingEmployee;
-- Marketing Employee






