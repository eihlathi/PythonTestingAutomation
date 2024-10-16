﻿USE [master]
GO
/****** Object:  Database [ContactManager]    Script Date: 10.9.2024 11.32.22 ******/
CREATE DATABASE [ContactManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ContactManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ContactManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ContactManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ContactManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ContactManager] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ContactManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ContactManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ContactManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ContactManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ContactManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ContactManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [ContactManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ContactManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ContactManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ContactManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ContactManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ContactManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ContactManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ContactManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ContactManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ContactManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ContactManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ContactManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ContactManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ContactManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ContactManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ContactManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ContactManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ContactManager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ContactManager] SET  MULTI_USER 
GO
ALTER DATABASE [ContactManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ContactManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ContactManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ContactManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ContactManager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ContactManager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ContactManager] SET QUERY_STORE = OFF
GO
USE [ContactManager]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 10.9.2024 11.32.23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[ContactName] [nvarchar](100) NULL,
	[ContactEmail] [nvarchar](100) NULL,
	[ContactComments] [nvarchar](500) NULL,
	[Active] [bit] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedAt] [datetime] NULL,
	[DeletedAt] [datetime] NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ContactManager] SET  READ_WRITE 
GO