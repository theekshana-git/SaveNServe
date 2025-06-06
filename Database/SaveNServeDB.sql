USE [master]
GO
/****** Object:  Database [SaveNServeDB]    Script Date: 6/1/2025 10:09:46 PM ******/
CREATE DATABASE [SaveNServeDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SaveNServeDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SaveNServeDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SaveNServeDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SaveNServeDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SaveNServeDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SaveNServeDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SaveNServeDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SaveNServeDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SaveNServeDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SaveNServeDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SaveNServeDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SaveNServeDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SaveNServeDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SaveNServeDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SaveNServeDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SaveNServeDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SaveNServeDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SaveNServeDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SaveNServeDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SaveNServeDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SaveNServeDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SaveNServeDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SaveNServeDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SaveNServeDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SaveNServeDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SaveNServeDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SaveNServeDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SaveNServeDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SaveNServeDB] SET RECOVERY FULL 
GO
ALTER DATABASE [SaveNServeDB] SET  MULTI_USER 
GO
ALTER DATABASE [SaveNServeDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SaveNServeDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SaveNServeDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SaveNServeDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SaveNServeDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SaveNServeDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SaveNServeDB', N'ON'
GO
ALTER DATABASE [SaveNServeDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [SaveNServeDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SaveNServeDB]
GO
/****** Object:  Table [dbo].[Ingredients]    Script Date: 6/1/2025 10:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredients](
	[IngredientID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Availability] [varchar](20) NULL,
	[NutritionalInfo] [varchar](50) NULL,
	[Taste] [varchar](20) NULL,
	[Texture] [varchar](20) NULL,
	[DateCreated] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IngredientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 6/1/2025 10:09:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[InventoryID] [int] IDENTITY(1,1) NOT NULL,
	[IngredientID] [int] NULL,
	[Quantity] [decimal](6, 2) NULL,
	[Unit] [varchar](10) NULL,
	[ExpiryDate] [date] NULL,
	[LastUpdated] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[InventoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Substitutions]    Script Date: 6/1/2025 10:09:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Substitutions](
	[SubstitutionID] [int] IDENTITY(1,1) NOT NULL,
	[IngredientID] [int] NULL,
	[SubstituteID] [int] NULL,
	[SimilarityScore] [decimal](3, 1) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SubstitutionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/1/2025 10:09:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Username] [varchar](50) NOT NULL,
	[Role] [varchar](10) NULL,
	[Status] [varchar](10) NULL,
	[Password] [varchar](64) NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ingredients] ADD  CONSTRAINT [DF_Ingredients_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_LastUpdated]  DEFAULT (getdate()) FOR [LastUpdated]
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD FOREIGN KEY([IngredientID])
REFERENCES [dbo].[Ingredients] ([IngredientID])
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD FOREIGN KEY([IngredientID])
REFERENCES [dbo].[Ingredients] ([IngredientID])
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD FOREIGN KEY([IngredientID])
REFERENCES [dbo].[Ingredients] ([IngredientID])
GO
ALTER TABLE [dbo].[Substitutions]  WITH CHECK ADD  CONSTRAINT [FK__Substitut__Creat__403A8C7D] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([Username])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Substitutions] CHECK CONSTRAINT [FK__Substitut__Creat__403A8C7D]
GO
ALTER TABLE [dbo].[Substitutions]  WITH CHECK ADD FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([Username])
GO
ALTER TABLE [dbo].[Substitutions]  WITH CHECK ADD FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([Username])
GO
ALTER TABLE [dbo].[Substitutions]  WITH CHECK ADD FOREIGN KEY([IngredientID])
REFERENCES [dbo].[Ingredients] ([IngredientID])
GO
ALTER TABLE [dbo].[Substitutions]  WITH CHECK ADD FOREIGN KEY([IngredientID])
REFERENCES [dbo].[Ingredients] ([IngredientID])
GO
ALTER TABLE [dbo].[Substitutions]  WITH CHECK ADD FOREIGN KEY([IngredientID])
REFERENCES [dbo].[Ingredients] ([IngredientID])
GO
ALTER TABLE [dbo].[Substitutions]  WITH CHECK ADD FOREIGN KEY([SubstituteID])
REFERENCES [dbo].[Ingredients] ([IngredientID])
GO
ALTER TABLE [dbo].[Substitutions]  WITH CHECK ADD FOREIGN KEY([SubstituteID])
REFERENCES [dbo].[Ingredients] ([IngredientID])
GO
ALTER TABLE [dbo].[Substitutions]  WITH CHECK ADD FOREIGN KEY([SubstituteID])
REFERENCES [dbo].[Ingredients] ([IngredientID])
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD CHECK  (([Availability]='Out Of Stock' OR [Availability]='Available'))
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD CHECK  (([Availability]='Out Of Stock' OR [Availability]='Available'))
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD CHECK  (([Availability]='Out Of Stock' OR [Availability]='Available'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([Role]='Admin' OR [Role]='User'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([Role]='Admin' OR [Role]='User'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([Role]='Admin' OR [Role]='User'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([Status]='Inactive' OR [Status]='Active'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([Status]='Inactive' OR [Status]='Active'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([Status]='Inactive' OR [Status]='Active'))
GO
USE [master]
GO
ALTER DATABASE [SaveNServeDB] SET  READ_WRITE 
GO
