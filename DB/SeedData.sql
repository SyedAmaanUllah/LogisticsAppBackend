INSERT INTO Roles (RoleName) VALUES ('Admin'), ('User'), ('Manager'), ('Guest');

INSERT INTO ShipmentStatus (StatusName, Description) VALUES
('Pending', 'The shipment is pending and not yet processed.'),
('In Transit', 'The shipment is currently in transit.'),
('Delivered', 'The shipment has been delivered to the destination.'),
('Cancelled', 'The shipment has been cancelled.'),
('Exception', 'There is an exception with the shipment.');

INSERT INTO Airlines (Name, Code, Country, CreatedDate, ModifiedDate)
VALUES 
('American Airlines', 'AA', 'USA', GETDATE(), GETDATE()),
('Delta Airlines', 'DL', 'USA', GETDATE(), GETDATE());


INSERT INTO Customers (Name, Email, Phone, CreatedDate, ModifiedDate)
VALUES 
('John Doe', 'john.doe@example.com', '123-456-7890', GETDATE(), GETDATE()),
('Jane Smith', 'jane.smith@example.com', '987-654-3210', GETDATE(), GETDATE());


-- Assuming Airlines table data already exists
INSERT INTO Flights (FlightNumber, AirlineCode, AirlineName, DepartureAirportId, ArrivalAirportId, DepartureTime, ArrivalTime, Status, CargoCapacity, CreatedDate, ModifiedDate)
VALUES 
('AA101', 'AA', 'American Airlines', 1, 2, '2024-08-26 08:00:00', '2024-08-26 11:00:00', 'On Time', 2000, GETDATE(), GETDATE()),
('DL202', 'DL', 'Delta Airlines', 2, 1, '2024-08-27 09:30:00', '2024-08-27 12:30:00', 'Delayed', 1800, GETDATE(), GETDATE());
