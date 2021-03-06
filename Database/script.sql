USE [master]
GO
/****** Object:  Database [LamData]    Script Date: 07.05.2020 14:12:47 ******/
CREATE DATABASE [LamData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'qia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\qia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'qia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\qia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LamData] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LamData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LamData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LamData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LamData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LamData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LamData] SET ARITHABORT OFF 
GO
ALTER DATABASE [LamData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LamData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LamData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LamData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LamData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LamData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LamData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LamData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LamData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LamData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LamData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LamData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LamData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LamData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LamData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LamData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LamData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LamData] SET RECOVERY FULL 
GO
ALTER DATABASE [LamData] SET  MULTI_USER 
GO
ALTER DATABASE [LamData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LamData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LamData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LamData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LamData] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LamData', N'ON'
GO
ALTER DATABASE [LamData] SET QUERY_STORE = OFF
GO
USE [LamData]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 07.05.2020 14:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[Id] [int] NOT NULL,
	[Question] [nvarchar](100) NOT NULL,
	[Answer1] [nvarchar](100) NOT NULL,
	[Answer2] [nvarchar](100) NOT NULL,
	[Answer3] [nvarchar](100) NULL,
	[Answer4] [nvarchar](100) NULL,
	[Correct] [int] NOT NULL,
	[NumOfAns] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Questions] ([Id], [Question], [Answer1], [Answer2], [Answer3], [Answer4], [Correct], [NumOfAns]) VALUES (1, N'Jak nazywa się najszybszy człowiek na świecie', N'SpeedMan', N'Usain Bolt', N'Adam Kszczot', N'', 2, 3)
INSERT [dbo].[Questions] ([Id], [Question], [Answer1], [Answer2], [Answer3], [Answer4], [Correct], [NumOfAns]) VALUES (2, N'Jak nazywa się pierwszy król Polski', N'Mieszko I', N'Bolesław I Chrobry', N'Andrzej Duda', N'Kazimierz Wielki', 2, 4)
INSERT [dbo].[Questions] ([Id], [Question], [Answer1], [Answer2], [Answer3], [Answer4], [Correct], [NumOfAns]) VALUES (3, N'Stolica Francji to', N'Paryż', N'Francja', N'Warszawa', N'Gniezno', 1, 4)
INSERT [dbo].[Questions] ([Id], [Question], [Answer1], [Answer2], [Answer3], [Answer4], [Correct], [NumOfAns]) VALUES (4, N'Kto zdobył więcej bramek dla reprezentacji Polski', N'Lewandowski', N'Lato', NULL, NULL, 1, 2)
INSERT [dbo].[Questions] ([Id], [Question], [Answer1], [Answer2], [Answer3], [Answer4], [Correct], [NumOfAns]) VALUES (5, N'Jaki jest najlepszy język programowania?', N'C#', N'Java', NULL, NULL, 1, 2)
INSERT [dbo].[Questions] ([Id], [Question], [Answer1], [Answer2], [Answer3], [Answer4], [Correct], [NumOfAns]) VALUES (6, N'Skąd pochodzi Conan Barbarzyńca', N'z Oz', N'z Mordoru', N'z Cimmerii', N'z Bielska', 3, 4)
INSERT [dbo].[Questions] ([Id], [Question], [Answer1], [Answer2], [Answer3], [Answer4], [Correct], [NumOfAns]) VALUES (7, N'Rybą nie jest', N'Kraska', N'Rozpiór', N'Świnka', N'Krasnopiórka', 1, 4)
INSERT [dbo].[Questions] ([Id], [Question], [Answer1], [Answer2], [Answer3], [Answer4], [Correct], [NumOfAns]) VALUES (8, N'Z gry na jakim intrumencie słynie Czesław Mozil?', N'na nerwach', N'na akordeonie', N'na gitarze', NULL, 2, 3)
INSERT [dbo].[Questions] ([Id], [Question], [Answer1], [Answer2], [Answer3], [Answer4], [Correct], [NumOfAns]) VALUES (9, N'Który utwór Słowackiego napisany jest prozą?', N'"Anhelli"', N'"Arab"', N'"Pan Tadeusz"', N'"W Szwajcarii"', 1, 4)
INSERT [dbo].[Questions] ([Id], [Question], [Answer1], [Answer2], [Answer3], [Answer4], [Correct], [NumOfAns]) VALUES (10, N'Wynik działania 2+2*2 to', N'6', N'8', N'4', NULL, 1, 3)
USE [master]
GO
ALTER DATABASE [LamData] SET  READ_WRITE 
GO
