USE [master]
GO
/****** Object:  Database [MuhtarlikTebligatDB]    Script Date: 12.03.2025 14:12:49 ******/
CREATE DATABASE [MuhtarlikTebligatDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MuhtarlikTebligatDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MuhtarlikTebligatDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MuhtarlikTebligatDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MuhtarlikTebligatDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 COLLATE SQL_Latin1_General_CP1_CI_AS
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MuhtarlikTebligatDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET  MULTI_USER 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MuhtarlikTebligatDB', N'ON'
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MuhtarlikTebligatDB]
GO
/****** Object:  Table [dbo].[Document]    Script Date: 12.03.2025 14:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Document](
	[Document_Id] [int] IDENTITY(1,1) NOT NULL,
	[Document_Name] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Document_Type] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Document_Color] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
PRIMARY KEY CLUSTERED 
(
	[Document_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Document] ON 

INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (1, N'Buttons', N'D', N'White')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (2, N'Coda', N'Cat', N'Multicolor')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (3, N'Merlin', N'P', N'Green-Yellow')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (4, N'Nina', N'T', N'Dark Gray')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (5, N'Domino', N'R', N'White')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (6, N'Luna', N'H', N'Orange')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (7, N'Lucy', N'M', N'Brown')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (8, N'Daysi', N'H', N'White')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (9, N'Zoe', N'S', N'Yellow white')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (10, N'Max', N'B', N'Yellow')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (11, N'Charlie', N'M', N'White')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (12, N'Rocky', N'S', N'Brown-Orange')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (13, N'Leo', N'D', N'White-Black')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (14, N'Loki', N'C', N'Black')
INSERT [dbo].[Document] ([Document_Id], [Document_Name], [Document_Type], [Document_Color]) VALUES (15, N'Jasper', N'D', N'Silver')
SET IDENTITY_INSERT [dbo].[Document] OFF
GO
USE [master]
GO
ALTER DATABASE [MuhtarlikTebligatDB] SET  READ_WRITE 
GO
