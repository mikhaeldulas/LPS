USE [master]
GO

/****** Object:  Database [LPS]    Script Date: 10/5/2023 7:48:01 PM ******/
CREATE DATABASE [LPS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LPS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LPS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LPS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LPS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LPS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [LPS] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [LPS] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [LPS] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [LPS] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [LPS] SET ARITHABORT OFF 
GO

ALTER DATABASE [LPS] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [LPS] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [LPS] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [LPS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [LPS] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [LPS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [LPS] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [LPS] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [LPS] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [LPS] SET  DISABLE_BROKER 
GO

ALTER DATABASE [LPS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [LPS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [LPS] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [LPS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [LPS] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [LPS] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [LPS] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [LPS] SET RECOVERY FULL 
GO

ALTER DATABASE [LPS] SET  MULTI_USER 
GO

ALTER DATABASE [LPS] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [LPS] SET DB_CHAINING OFF 
GO

ALTER DATABASE [LPS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [LPS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [LPS] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [LPS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [LPS] SET QUERY_STORE = OFF
GO

ALTER DATABASE [LPS] SET  READ_WRITE 
GO


