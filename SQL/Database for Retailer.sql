DROP TABLE SaleInformation;
DROP TABLE ManagementInformation;
DROP TABLE Sale;
DROP TABLE Product;
DROP TABLE Supplier; 
DROP TABLE Customer;
DROP TABLE Manager;
DROP TABLE Employee;
DROP TABLE Department;

CREATE TABLE Supplier
(
SupplierID VARCHAR2(10) PRIMARY KEY NOT NULL, 
SupplierName VARCHAR2(20),
SupplierStreetAddress VARCHAR2(15),
SupplierCity VARCHAR2(15),
SupplierState VARCHAR2(2),
SupplierZipCode NUMBER
);

CREATE TABLE Product
(
ProductID VARCHAR2(10) PRIMARY KEY NOT NULL,
SupplierID VARCHAR2(10) REFERENCES Supplier(SupplierID),
ProductName VARCHAR2(15),
ProductPrice VARCHAR2(5),
ProductDescription VARCHAR2(100)
);

CREATE TABLE Customer
(
CustomerID VARCHAR2(10) PRIMARY KEY NOT NULL,
CustomerName VARCHAR2(20),
CustomerStreetAddress VARCHAR2(15),
CustomerCity VARCHAR2(15),
CustomerState VARCHAR2(2),
CustomerZipCode NUMBER
);

CREATE TABLE Department
(
DepartmentID VARCHAR2(7) PRIMARY KEY NOT NULL,
DepartmentName VARCHAR2(10)
);

CREATE TABLE Employee
(
EmployeeID VARCHAR2(10) PRIMARY KEY NOT NULL,
DepartmentID VARCHAR2(10) REFERENCES Department(DepartmentID),
EmployeeName VARCHAR2(20)
);

CREATE TABLE Manager
(
ManagerID VARCHAR2(10) PRIMARY KEY NOT NULL,
EmployeeID VARCHAR2(10) REFERENCES Employee(EmployeeID)
);

CREATE TABLE ManagementInformation
(
ManagementInteractionID VARCHAR2(10) PRIMARY KEY NOT NULL,
ManagerID VARCHAR2(10) REFERENCES Manager(ManagerID),
EmployeeID VARCHAR2(10) REFERENCES Employee(EmployeeID)
);

CREATE TABLE Sale
(
SaleID VARCHAR2(10) PRIMARY KEY NOT NULL,
EmployeeID VARCHAR2(10),
CONSTRAINT 
EmployeeID_FK FOREIGN KEY (EmployeeID)
REFERENCES Employee(EmployeeID),
CustomerID VARCHAR2(10),
CONSTRAINT 
CustomerID_FK FOREIGN KEY (CustomerID) 
REFERENCES Customer(CustomerID),
SaleTotal VARCHAR2(12),
SaleDate DATE
);

CREATE TABLE SaleInformation
(
SaleSequenceNumber NUMBER(5,0) PRIMARY KEY NOT NULL,
ProductID VARCHAR2(10),
CONSTRAINT 
SaleInformation_FK FOREIGN KEY (ProductID)
REFERENCES Product(ProductID), 
SaleID VARCHAR2(10),
CONSTRAINT 
SaleID_FK FOREIGN KEY (SaleID)
REFERENCES Sale(SaleID),
SaleProductQuantity NUMBER(5,0)
)