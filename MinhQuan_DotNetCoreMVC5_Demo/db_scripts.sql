USE [master]
GO
/****** Object:  Database [Demo_DotNetCore5.0MVC]    Script Date: 5/13/2022 1:04:37 AM ******/
CREATE DATABASE [Demo_DotNetCore5.0MVC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Demo_DotNetCore5.0MVC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.NPMINHQUAN\MSSQL\DATA\Demo_DotNetCore5.0MVC.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Demo_DotNetCore5.0MVC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.NPMINHQUAN\MSSQL\DATA\Demo_DotNetCore5.0MVC_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Demo_DotNetCore5.0MVC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET ARITHABORT OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET RECOVERY FULL 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET  MULTI_USER 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Demo_DotNetCore5.0MVC', N'ON'
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET QUERY_STORE = OFF
GO
USE [Demo_DotNetCore5.0MVC]
GO
/****** Object:  Table [dbo].[DemoUser]    Script Date: 5/13/2022 1:04:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DemoUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Email] [nchar](100) NULL,
	[Phone] [nchar](14) NULL,
	[Address] [nvarchar](200) NULL,
 CONSTRAINT [PK_DemoUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DemoUser] ON 

INSERT [dbo].[DemoUser] ([Id], [Name], [Email], [Phone], [Address]) VALUES (1, N'Quan', N'teo@gmail.com                                                                                       ', N'0909222333    ', N'abc đường D Khu B, Tp ABC')
INSERT [dbo].[DemoUser] ([Id], [Name], [Email], [Phone], [Address]) VALUES (2, N'Nguyet', N'tao@gmail.com                                                                                       ', N'0909111222    ', N'haha đường hihi, Tp Alabasta')
INSERT [dbo].[DemoUser] ([Id], [Name], [Email], [Phone], [Address]) VALUES (4, N'Teo Nguyen', N'teo@gmail.com                                                                                       ', N'0457754754745 ', N'acs')
INSERT [dbo].[DemoUser] ([Id], [Name], [Email], [Phone], [Address]) VALUES (5, N'Teofsafasfas Nguyen', N'teofasfsafsa@gmail.com                                                                              ', N'04577346426423', N'acshgsedbnsedbes')
SET IDENTITY_INSERT [dbo].[DemoUser] OFF
GO
USE [master]
GO
ALTER DATABASE [Demo_DotNetCore5.0MVC] SET  READ_WRITE 
GO
