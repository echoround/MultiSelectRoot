USE [master]
GO

CREATE DATABASE [SelectBoxDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SelectBoxDB', FILENAME = N'C:\Users\Admin\SelectBoxDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SelectBoxDB_log', FILENAME = N'C:\Users\Admin\SelectBoxDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SelectBoxDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SelectBoxDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SelectBoxDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SelectBoxDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SelectBoxDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SelectBoxDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SelectBoxDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SelectBoxDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SelectBoxDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SelectBoxDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SelectBoxDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SelectBoxDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SelectBoxDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SelectBoxDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SelectBoxDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SelectBoxDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SelectBoxDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SelectBoxDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SelectBoxDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SelectBoxDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SelectBoxDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SelectBoxDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SelectBoxDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SelectBoxDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SelectBoxDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SelectBoxDB] SET  MULTI_USER 
GO
ALTER DATABASE [SelectBoxDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SelectBoxDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SelectBoxDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SelectBoxDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SelectBoxDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SelectBoxDB] SET QUERY_STORE = OFF
GO
USE [SelectBoxDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [SelectBoxDB]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerAuth] [varchar](40) NULL,
	[CustomerName] [varchar](100) NOT NULL,
	[Agreed] [bit] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sectors](
	[SectorId] [int] IDENTITY(1,1) NOT NULL,
	[SectorName] [varchar](100) NOT NULL,
	[CustomerId] [int] NULL,
 CONSTRAINT [PK_Sectors] PRIMARY KEY CLUSTERED 
(
	[SectorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211223033441_1', N'5.0.13')
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [CustomerAuth], [CustomerName], [Agreed]) VALUES (1, N'fbc1604707', N'Bob Odenkirk', 1)
INSERT [dbo].[Customers] ([CustomerId], [CustomerAuth], [CustomerName], [Agreed]) VALUES (2, N'f025266bc9', N'Steve', 1)
INSERT [dbo].[Customers] ([CustomerId], [CustomerAuth], [CustomerName], [Agreed]) VALUES (3, N'3ff5a6ea74', N'Liam Neeson', 0)
INSERT [dbo].[Customers] ([CustomerId], [CustomerAuth], [CustomerName], [Agreed]) VALUES (4, N'c501ee9b51', N'Peter Jackson', 1)
INSERT [dbo].[Customers] ([CustomerId], [CustomerAuth], [CustomerName], [Agreed]) VALUES (5, N'6be2a17272', N'Alice', 1)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Sectors] ON 

INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (1, N'Manufacturing', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (2, N'Wood', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (3, N'Textile', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (4, N'Clothing', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (5, N'Textile and Clothing', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (6, N'Labelling and packaging printing', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (7, N'Book/Periodicals printing', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (8, N'Advertising', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (9, N'Other (Wood)', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (10, N'Printing', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (11, N'Plastics welding and processing', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (12, N'Moulding', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (13, N'Blowing', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (14, N'Plastic processing technology', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (15, N'Plastic goods', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (16, N'Packaging', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (17, N'Plastic and Rubber', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (18, N'Plastic profiles', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (19, N'MIG, TIG, Aluminum welding', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (20, N'Wooden building materials', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (21, N'Other', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (22, N'Rail', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (23, N'Air', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (24, N'Transport and Logistics', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (25, N'Translation services', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (26, N'Tourism', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (27, N'Telecommunications', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (28, N'Software, Hardware', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (29, N'Wooden houses', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (30, N'Programming, Consultancy', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (31, N'Information Technology and Telecommunications', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (32, N'Engineering', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (33, N'Business services', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (34, N'Service', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (35, N'Environment', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (36, N'Energy technology', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (37, N'Creative industries', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (38, N'Data processing, Web portals, E-marketing', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (39, N'Road', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (40, N'Gas, Plasma, Laser cutting', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (41, N'CNC-machining', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (42, N'Living room', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (43, N'Kitchen', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (44, N'Children''s room', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (45, N'Bedroom', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (46, N'Bathroom/sauna', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (47, N'Furniture', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (48, N'Sweets & snack food', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (49, N'Office', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (50, N'Other', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (51, N'Meat & meat products', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (52, N'Fish & fish products', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (53, N'Beverages', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (54, N'Bakery & confectionery products', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (55, N'Food and Beverage', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (56, N'Electronics and Optics', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (57, N'Construction materials', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (58, N'Milk & dairy products', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (59, N'Forgings, Fasteners', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (60, N'Other (Furniture)', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (61, N'Project furniture', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (62, N'Metal works', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (63, N'Metal products', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (64, N'Houses and buildings', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (65, N'Construction of metal structures', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (66, N'Metalworking', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (67, N'Repair and maintenance service', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (68, N'Other', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (69, N'Outdoor', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (70, N'Metal structures', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (71, N'Boat/Yacht building', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (72, N'Aluminium and steel workboats', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (73, N'Maritime', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (74, N'Manufacture of machinery', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (75, N'Machinery equipment/tools', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (76, N'Machinery components', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (77, N'Machinery', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (78, N'Ship repair and conversion', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (79, N'Water', NULL)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (80, N'Textile', 1)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (81, N'Packaging', 1)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (82, N'Plastic goods', 1)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (83, N'Rail', 2)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (84, N'Engineering', 2)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (85, N'Air', 3)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (86, N'Rail', 3)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (87, N'Office', 3)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (88, N'Sweets & snack food', 3)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (89, N'Living room', 4)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (90, N'Kitchen', 4)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (91, N'Furniture', 5)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (92, N'Bathroom/sauna', 5)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (93, N'Bedroom', 5)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (94, N'Sweets & snack food', 5)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (95, N'Construction of metal structures', 5)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (96, N'Houses and buildings', 5)
INSERT [dbo].[Sectors] ([SectorId], [SectorName], [CustomerId]) VALUES (97, N'Metal products', 5)
SET IDENTITY_INSERT [dbo].[Sectors] OFF
GO

CREATE NONCLUSTERED INDEX [IX_Sectors_CustomerId] ON [dbo].[Sectors]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Sectors]  WITH CHECK ADD  CONSTRAINT [FK_Sectors_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Sectors] CHECK CONSTRAINT [FK_Sectors_Customers_CustomerId]
GO
USE [master]
GO
ALTER DATABASE [SelectBoxDB] SET  READ_WRITE 
GO
