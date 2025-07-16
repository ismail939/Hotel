use hoteldb;
-- Create the staff_tbl
CREATE TABLE staff_tbl (
    staffName NVARCHAR(50) NOT NULL,
    staffPassword VARCHAR(50) NOT NULL
);

-- Create the client_tbl
CREATE TABLE client_tbl (
    clientId INT PRIMARY KEY IDENTITY(1,1),
    clientName NVARCHAR(50) NOT NULL,
    clientCountry NVARCHAR(50),
    clientPhone VARCHAR(20)
);
