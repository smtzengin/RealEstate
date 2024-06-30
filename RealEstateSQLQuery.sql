use DbDapperRealEstate

--Create Table Category(
--CategoryID int primary key identity(1,1),
--CategoryName nvarchar(50),
--CategoryStatus bit
--)

--Create Table Product(
--ProductID int primary key identity(1,1),
--Title nvarchar(100),
--Price decimal(18,2),
--CoverImage nvarchar(250),
--City nvarchar(100),
--District nvarchar(100),
--Address nvarchar(500),
--Description nvarchar(max),
--ProductCategory int
--)

--Create Table ProductDetails(
--ProductDetailID int primary key identity(1,1),
--ProductSize int,
--BedRoomCount tinyint,
--BathCount tinyint,
--RoomCount tinyint,
--GarageSize tinyint,
--BuildYear char(4),
--Price decimal(18,2),
--Location nvarchar(500),
--VideoUrl nvarchar(500),
--ProductID int,
--)

--Create table Client(
--ClientID int primary key identity(1,1),
--Name nvarchar(100),
--Title nvarchar(100),
--Comment nvarchar(2000)
--)

--Create table Employee(
--EmployeeID int identity(1,1) primary key,
--Name nvarchar(100),
--Title nvarchar(100),
--Mail nvarchar(100),
--PhoneNumber nvarchar(100),
--ImageUrl nvarchar(100),
--Status bit
--)

--create table WhoWeAreDetail(
--WhoWeAreDetailID int identity(1,1) primary key,
--Title nvarchar(100),
--Subtitle nvarchar(100),
--Description1 nvarchar(500),
--Description2 nvarchar(500)
--)

--create table Service(
--ServiceID int identity(1,1) primary key,
--ServiceName nvarchar(100),
--ServiceStatus Bit
--)

--create table BottomGrid(
--BottomGridID int identity(1,1) primary key,
--Icon nvarchar(100),
--Title nvarchar(100),
--Description nvarchar(250)
--)

--create table PopularLocation(
--LocationID int primary key identity(1,1),
--CityName nvarchar(50),
--ImageUrl nvarchar(500)
--)

--create table Testimonial(
--TestimonialID int identity(1,1) primary key,
--NameSurname nvarchar(50),
--Title nvarchar(50),
--Comment nvarchar(500),
--Status bit
--)

--create table SubFeature(
--SubFeatureID int identity(1,1) primary key,
--Icon nvarchar(100),
--TopTitle nvarchar(100),
--MainTitle nvarchar(150),
--Description nvarchar(100),
--SubTitle nvarchar(100)
--)

--create table MailSubscribe(
--MailID int identity(1,1) primary key,
--EMail nvarchar(100)
--)

--create table SocialMedia(
--SocialMediaID int identity(1,1) primary key,
--Name nvarchar(100),
--Icon nvarchar(100),
--SocialMediaUrl nvarchar(250)
--)

--create table Contact(
--ContactID int identity(1,1) primary key,
--Name nvarchar(100),
--Subject nvarchar(100),
--Email nvarchar(100),
--Message nvarchar(Max)
--)

--create table Address(
--AddressID int identity(1,1) primary key,
--AddressTitle1 nvarchar(100),
--Description nvarchar(200),
--AddressTitle2 nvarchar(100),
--Phone1 nvarchar(50),
--Phone2 nvarchar(50),
--Email nvarchar(50),
--Location nvarchar(500)
--)

--create table SubFeature
--(
--SubFeatureID int identity(1,1) primary key,
--Icon nvarchar(100),
--TopTitle nvarchar(100),
--MainTitle nvarchar(100),
--Description nvarchar(100),
--SubTitle nvarchar(100)
--)