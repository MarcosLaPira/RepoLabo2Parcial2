USE [master]
GO
/****** Object:  Database [Cartas]    Script Date: 7/12/2022 07:14:39 ******/
CREATE DATABASE [Cartas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cartas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Cartas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cartas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Cartas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Cartas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cartas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cartas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cartas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cartas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cartas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cartas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cartas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Cartas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cartas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cartas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cartas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cartas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cartas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cartas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cartas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cartas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Cartas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cartas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cartas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cartas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cartas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cartas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cartas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cartas] SET RECOVERY FULL 
GO
ALTER DATABASE [Cartas] SET  MULTI_USER 
GO
ALTER DATABASE [Cartas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cartas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cartas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cartas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Cartas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Cartas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Cartas', N'ON'
GO
ALTER DATABASE [Cartas] SET QUERY_STORE = OFF
GO
USE [Cartas]
GO
/****** Object:  Table [dbo].[TablaCartas]    Script Date: 7/12/2022 07:14:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaCartas](
	[numeroCarta] [int] NOT NULL,
	[palo] [int] NOT NULL,
	[indiceCarta] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (1, 1, 1)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (1, 3, 7)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (1, 2, 2)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (1, 4, 7)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (2, 1, 6)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (2, 3, 6)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (2, 2, 6)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (2, 4, 6)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (3, 1, 5)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (3, 3, 5)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (3, 2, 5)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (3, 4, 5)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (4, 1, 14)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (4, 3, 14)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (4, 2, 14)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (4, 4, 14)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (5, 1, 13)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (5, 3, 13)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (5, 2, 13)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (5, 4, 13)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (6, 1, 12)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (6, 3, 12)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (6, 2, 12)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (6, 4, 12)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (7, 1, 3)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (7, 3, 4)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (7, 2, 11)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (7, 4, 11)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (10, 1, 10)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (10, 3, 10)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (10, 2, 10)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (10, 4, 10)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (11, 1, 9)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (11, 3, 9)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (11, 2, 9)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (11, 4, 9)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (12, 1, 8)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (12, 3, 8)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (12, 2, 8)
INSERT [dbo].[TablaCartas] ([numeroCarta], [palo], [indiceCarta]) VALUES (12, 4, 8)
GO
USE [master]
GO
ALTER DATABASE [Cartas] SET  READ_WRITE 
GO
