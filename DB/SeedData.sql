INSERT INTO Roles (RoleName) VALUES ('Admin'), ('User'), ('Manager'), ('Guest');

INSERT INTO ShipmentStatus (StatusName, Description) VALUES
('Pending', 'The shipment is pending and not yet processed.'),
('In Transit', 'The shipment is currently in transit.'),
('Delivered', 'The shipment has been delivered to the destination.'),
('Cancelled', 'The shipment has been cancelled.'),
('Exception', 'There is an exception with the shipment.');