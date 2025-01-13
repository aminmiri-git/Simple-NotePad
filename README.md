# Simple-NotePad
A simple notepad made by visual studio (windows form) , with features like : open,save,exit,cut,paste,select all, and zoom.



Feel free to make it better.

The application it self is in   SimpleNotepad/bin/release/SimpleNotepad.exe





CREATE TABLE customers (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Address VARCHAR(255)
);


CREATE TABLE menu (
    MenuID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL
);


CREATE TABLE orders (
    OrderID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATETIME NOT NULL DEFAULT NOW(),
    TotalAmount DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID) ON DELETE CASCADE
);


CREATE TABLE orderdetails (
    OrderDetailID INT AUTO_INCREMENT PRIMARY KEY,
    OrderID INT NOT NULL,
    MenuID INT NOT NULL,
    Quantity INT NOT NULL,
    Subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES orders(OrderID) ON DELETE CASCADE,
    FOREIGN KEY (MenuID) REFERENCES menu(MenuID) ON DELETE CASCADE
);








-- Insert into customers
INSERT INTO customers (Name, Phone, Email, Address) VALUES
('John Doe', '1234567890', 'john@example.com', '123 Elm St'),
('Jane Smith', '0987654321', 'jane@example.com', '456 Oak St');

-- Insert into menu
INSERT INTO menu (Name, Price) VALUES
('Pizza', 10.50),
('Burger', 8.75),
('Pasta', 12.00);

-- Insert into orders
INSERT INTO orders (CustomerID, TotalAmount) VALUES
(1, 50.00),
(2, 30.00);

-- Insert into orderdetails
INSERT INTO orderdetails (OrderID, MenuID, Quantity, Subtotal) VALUES
(1, 1, 2, 21.00),
(1, 2, 3, 26.25),
(2, 3, 2, 24.00);
