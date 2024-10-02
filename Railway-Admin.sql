create database Railway_Assing02;

create table Admins (
    AdminID int primary key identity(1,1),
    Username NVARCHAR(30) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Email NVARCHAR(50) NOT NULL
);

create table Trains (
    TrainID int primary key identity(1,1),
    TrainName VARCHAR(20) NOT NULL,
    Source VARCHAR(30) NOT NULL,
    Destination NVARCHAR(30) NOT NULL,
    DepartureTime DATETIME NOT NULL,
    ArrivalTime DATETIME NOT NULL
);

create table Bookings (
    BookingID int primary key identity(1,1),
    TrainID int,
	PassengerName varchar(50) not null,
    SeatNumber int not null,
	MonileNo int not null,
	Departure varchar(50) not null,
	Arrival varchar(50) not null,
	DateTravel date not null,
	NumberofSeats int not null,
	Class varchar(10) not null,
	TicketType varchar(20) not null,
    AdminID int,
    foreign key (TrainID) references Trains(TrainID),
    foreign key (AdminID) references Admins(AdminID)
);

insert into Admins(Username,Password,Email) values 
('admin1','admin1','admin1@mail.com'),
('admin2','admin2','admin1@mail.com'),
('admin3','admin3','admin3@mail.com')

select * from Admins