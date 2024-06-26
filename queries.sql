CREATE TABLE Users (
    ID int PRIMARY KEY IDENTITY,
    Email nvarchar(50) UNIQUE NOT NULL,
    Password nvarchar(50) NOT NULL,
    Role nvarchar(50) NOT NULL
);

CREATE TABLE Customers (
    ID int PRIMARY KEY IDENTITY,
    Username nvarchar(50) UNIQUE NOT NULL,
    Contact nvarchar(50),
    Cart nvarchar(255),
    "Status" nvarchar(50) NOT NULL,
	Gender nvarchar(50) NOT NULL,
    UserID int NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(ID) ON DELETE CASCADE
);

CREATE TABLE Employees(
	ID INT Primary KEY IDENTITY,
	Username nvarchar(50) UNIQUE NOT NULL, 
	Contact nvarchar(50),
	Salary decimal(10, 2) NOT NULL,
	JoinDate datetime,
	Gender nvarchar(50) NOT NULL,
	UserID int NOT NULL,
	FOREIGN KEY (UserID) REFERENCES Users(ID) ON DELETE CASCADE
);


CREATE TABLE Regular(
	ID int PRIMARY KEY IDENTITY,
	LoyaltyPoints int,
	CustomerID int NOT NULL,
	FOREIGN KEY (CustomerID) REFERENCES Customers(ID) ON DELETE CASCADE
);

CREATE TABLE Admins(
	ID int PRIMARY KEY IDENTITY,
	ToolsUsed nvarchar(255),
	Permissions nvarchar(255),
	EmployeeID int,
	FOREIGN KEY (EmployeeID) References Employees(ID) ON DELETE CASCADE
)

CREATE TABLE VIP(
	ID int PRIMARY KEY IDENTITY,
	MembershipLevel nvarchar(50) NOT NULL,
	CustomerID int,
	FOREIGN KEY (CustomerID) REFERENCES Customers(ID) ON DELETE CASCADE
);

CREATE TABLE Vouchers(
	ID int PRIMARY KEY IDENTITY,
	ExpirationDate datetime NOT NULL,
	"Value" decimal(10,2) NOT NULL
);

CREATE TABLE "Table"(
	ID int PRIMARY KEY IDENTITY,
	Capacity int NOT NULL,
	"Status" nvarchar(50) NOT NULL
);

CREATE TABLE Reservation(
	ID int PRIMARY KEY IDENTITY,
	ReservationDate Datetime NOT NULL,
	TotalPersons int NOT NULL,
	CustomerID int,
	FOREIGN KEY (CustomerID) REFERENCES Customers(ID) ON DELETE CASCADE,
	TableID int NOT NULL,
	FOREIGN KEY (TableID) REFERENCES "Table"(ID) ON DELETE CASCADE,
);

CREATE TABLE Feedback(
	ID int PRIMARY KEY IDENTITY,
	Reviews nvarchar(50),
	CustomerID int,
	FOREIGN KEY (CustomerID) REFERENCES Customers(ID) ON DELETE CASCADE
);

CREATE TABLE Orders(
	ID int PRIMARY KEY IDENTITY,
	ProductsOrdered nvarchar(255) NOT NULL,
	TotalPrice decimal(10,2) NOT NULL,
	OrderDate DateTime,
	"Status" nvarchar(50) NOT NULL,
	CustomerComments nvarchar(255),
	PaymentMethod nvarchar(50) NOT NULL,
	CustomerID int,
	FOREIGN KEY (CustomerID) REFERENCES Customers(ID) ON DELETE CASCADE
);

CREATE TABLE Deals(
	ID int PRIMARY KEY IDENTITY,
	DealName nvarchar(50) NOT NULL,
	TotalPrice decimal(10,2) NOT NULL,
	Items TEXT NOT NULL
);

CREATE TABLE Products(
	ID int PRIMARY KEY IDENTITY,
	ProductName nvarchar(50) NOT NULL Unique,
	Category nvarchar(50) NOT NULL,
	"Description" nvarchar(255) NOT NULL,
	IsAvailable int NOT NULL
	);

CREATE TABLE ProductVariants(
	ID int PRIMARY KEY IDENTITY,
	Quantity nvarchar(50) NOT NULL,
	Price decimal (10,2) NOT NULL,
	ProductID int NOT NULL,
	Foreign Key (ProductID) References Products(ID) ON DELETE CASCADE
);


CREATE TABLE Chefs(
	ID INT Primary KEY IDENTITY,
	"Shift" nvarchar(50),
	Specialization nvarchar(50),
	Experience nvarchar(50),
	EmployeeID int NOT NULL,
	FOREIGN KEY (EmployeeID) REFERENCES Employees(ID) ON DELETE CASCADE
);

CREATE TABLE Waiters(
	ID INT PRIMARY KEY IDENTITY,
	"Shift" nvarchar(50),
	Area nvarchar(50) NOT NULL,
	"Language" nvarchar(50),
	EmployeeID int NOT NULL,
	FOREIGN KEY (EmployeeID) REFERENCES Employees(ID) ON DELETE CASCADE
);

CREATE TABLE Notifications(
	ID INT PRIMARY KEY IDENTITY,
	"Notification" Text
);

CREATE TABLE ViewNotification(
	ID INT PRIMARY KEY IDENTITY,
	NotificationID int,
	CustomerID int,
	HasSeen int,
	FOREIGN KEY (NotificationID) REFERENCES Notifications(ID) ON DELETE CASCADE,
	FOREIGN KEY (CustomerID) REFERENCES Customers(ID) ON DELETE CASCADE
);

CREATE TABLE UserPictures(
	ID INT PRIMARY KEY IDENTITY,
	"Image" image,
	UserID int NOT NULL,
	FOREIGN KEY(UserID) REFERENCES Users(ID) ON DELETE CASCADE
);

CREATE TABLE "Messages" (
    MessageID INT PRIMARY KEY IDENTITY,
    SenderID INT,
    ReceiverID INT,
    MessageText VARCHAR(MAX),
    "Timestamp" DATETIME
);