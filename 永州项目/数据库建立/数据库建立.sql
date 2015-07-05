USE [master]
GO

/****** Object:  Database [car_delivery]    Script Date: 07/04/2015 10:31:34 ******/
CREATE DATABASE [car_delivery] ON  PRIMARY 
( NAME = N'car_delivery', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\car_delivery.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'car_delivery_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\car_delivery_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [car_delivery] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [car_delivery].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [car_delivery] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [car_delivery] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [car_delivery] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [car_delivery] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [car_delivery] SET ARITHABORT OFF 
GO

ALTER DATABASE [car_delivery] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [car_delivery] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [car_delivery] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [car_delivery] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [car_delivery] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [car_delivery] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [car_delivery] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [car_delivery] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [car_delivery] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [car_delivery] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [car_delivery] SET  DISABLE_BROKER 
GO

ALTER DATABASE [car_delivery] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [car_delivery] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [car_delivery] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [car_delivery] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [car_delivery] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [car_delivery] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [car_delivery] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [car_delivery] SET  READ_WRITE 
GO

ALTER DATABASE [car_delivery] SET RECOVERY FULL 
GO

ALTER DATABASE [car_delivery] SET  MULTI_USER 
GO

ALTER DATABASE [car_delivery] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [car_delivery] SET DB_CHAINING OFF 
GO


