CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(100),
    password VARCHAR(100),
    role VARCHAR(50),
    status VARCHAR(50),
    date_created DATE
);
GO

SELECT * FROM users;
INSERT INTO users (username, password, role, status, date_created) VALUES('admin', '123', 'admin', 'active', '2025 - 11 - 01');