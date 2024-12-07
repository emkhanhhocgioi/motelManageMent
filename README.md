Hướng dẫn install project:

chạy 2 query dưới đây trong sql server:

CREATE TABLE MotelManagement.dbo.accounts (
    AccountID INT IDENTITY(1,1) PRIMARY KEY,  -- Auto-incremented primary key
    Username NVARCHAR(255) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Phone int NOT NULL
);

Chưa nghĩ ra tiếp
