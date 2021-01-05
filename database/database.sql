USE [master]
GO

/****** Object:  Database [QuanLyTaiKhoanATM]    Script Date: 1/5/2021 10:11:58 PM ******/
CREATE DATABASE [QuanLyTaiKhoanATM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyTaiKhoanATM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DAT\MSSQL\DATA\QuanLyTaiKhoanATM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyTaiKhoanATM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DAT\MSSQL\DATA\QuanLyTaiKhoanATM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyTaiKhoanATM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET ARITHABORT OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET  DISABLE_BROKER 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET  MULTI_USER 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET DB_CHAINING OFF 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET QUERY_STORE = OFF
GO

ALTER DATABASE [QuanLyTaiKhoanATM] SET  READ_WRITE 
GO

