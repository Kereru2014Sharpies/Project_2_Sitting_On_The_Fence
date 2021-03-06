USE [master]
GO

/****** Object:  Database [SittingOnTheFence]    Script Date: 22/08/2014 1:00:21 p.m. ******/
CREATE DATABASE [SittingOnTheFence]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SittingOnTheFence', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SittingOnTheFence.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SittingOnTheFence_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SittingOnTheFence_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [SittingOnTheFence] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SittingOnTheFence].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [SittingOnTheFence] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET ARITHABORT OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [SittingOnTheFence] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [SittingOnTheFence] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [SittingOnTheFence] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET  DISABLE_BROKER 
GO

ALTER DATABASE [SittingOnTheFence] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [SittingOnTheFence] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [SittingOnTheFence] SET  MULTI_USER 
GO

ALTER DATABASE [SittingOnTheFence] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [SittingOnTheFence] SET DB_CHAINING OFF 
GO

ALTER DATABASE [SittingOnTheFence] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [SittingOnTheFence] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [SittingOnTheFence] SET  READ_WRITE 
GO


