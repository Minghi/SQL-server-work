USE [master]
GO
/****** Object:  Database [productjxc]    Script Date: 12/18/2015 15:23:29 ******/
CREATE DATABASE [productjxc] ON  PRIMARY 
( NAME = N'productjxc', FILENAME = N'C:\Demo_Productjxc\DB\productjxc.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'productjxc_log', FILENAME = N'C:\Demo_Productjxc\DB\productjxc_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [productjxc] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [productjxc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [productjxc] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [productjxc] SET ANSI_NULLS OFF
GO
ALTER DATABASE [productjxc] SET ANSI_PADDING OFF
GO
ALTER DATABASE [productjxc] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [productjxc] SET ARITHABORT OFF
GO
ALTER DATABASE [productjxc] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [productjxc] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [productjxc] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [productjxc] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [productjxc] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [productjxc] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [productjxc] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [productjxc] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [productjxc] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [productjxc] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [productjxc] SET  DISABLE_BROKER
GO
ALTER DATABASE [productjxc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [productjxc] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [productjxc] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [productjxc] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [productjxc] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [productjxc] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [productjxc] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [productjxc] SET  READ_WRITE
GO
ALTER DATABASE [productjxc] SET RECOVERY SIMPLE
GO
ALTER DATABASE [productjxc] SET  MULTI_USER
GO
ALTER DATABASE [productjxc] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [productjxc] SET DB_CHAINING OFF
GO
USE [productjxc]
GO
/****** Object:  Table [dbo].[P_CUS]    Script Date: 12/18/2015 15:23:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[P_CUS](
	[ProNO] [varchar](50) NOT NULL,
	[CusNO] [varchar](50) NOT NULL,
	[SaleCount] [int] NULL,
	[StaffName] [varchar](50) NOT NULL,
	[SalePrice] [float] NULL,
 CONSTRAINT [pk_PCUS] PRIMARY KEY CLUSTERED 
(
	[ProNO] ASC,
	[CusNO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[P_CON]    Script Date: 12/18/2015 15:23:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[P_CON](
	[ProNO] [varchar](50) NOT NULL,
	[ConNO] [varchar](50) NOT NULL,
	[ImportCount] [int] NULL,
 CONSTRAINT [pk_PCON] PRIMARY KEY CLUSTERED 
(
	[ProNO] ASC,
	[ConNO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/18/2015 15:23:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CusNO] [varchar](50) NOT NULL,
	[CusName] [varchar](50) NOT NULL,
	[CusTel] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CusNO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Customer] ([CusNO], [CusName], [CusTel]) VALUES (N'000', N'Bob', N'12200111100')
INSERT [dbo].[Customer] ([CusNO], [CusName], [CusTel]) VALUES (N'001', N'Lucy', N'13122110022')
/****** Object:  Table [dbo].[Contractor]    Script Date: 12/18/2015 15:23:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contractor](
	[ConNO] [varchar](50) NOT NULL,
	[ConName] [varchar](50) NOT NULL,
	[ConAddress] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ConNO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Contractor] ([ConNO], [ConName], [ConAddress]) VALUES (N'00', N'peter', N'San')
INSERT [dbo].[Contractor] ([ConNO], [ConName], [ConAddress]) VALUES (N'01', N'kate', N'New')
/****** Object:  Table [dbo].[Store]    Script Date: 12/18/2015 15:23:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Store](
	[StoNO] [varchar](50) NOT NULL,
	[AdminName] [varchar](50) NOT NULL,
	[AdminPwd] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[StoNO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Store] ([StoNO], [AdminName], [AdminPwd]) VALUES (N'0', N'Tom', N'123')
INSERT [dbo].[Store] ([StoNO], [AdminName], [AdminPwd]) VALUES (N'1', N'Merry', N'456')
INSERT [dbo].[Store] ([StoNO], [AdminName], [AdminPwd]) VALUES (N'2', N'Tony', N'123')
INSERT [dbo].[Store] ([StoNO], [AdminName], [AdminPwd]) VALUES (N'3', N'Jack', N'abc')
/****** Object:  Table [dbo].[Product]    Script Date: 12/18/2015 15:23:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProNO] [varchar](50) NOT NULL,
	[ProName] [varchar](50) NOT NULL,
	[ProPrice] [float] NULL,
	[StoNO] [varchar](50) NULL,
	[StoCount] [int] NULL,
 CONSTRAINT [pk_Product] PRIMARY KEY CLUSTERED 
(
	[ProNO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Product] ([ProNO], [ProName], [ProPrice], [StoNO], [StoCount]) VALUES (N'0000', N'衣架', 2, N'0', 20)
INSERT [dbo].[Product] ([ProNO], [ProName], [ProPrice], [StoNO], [StoCount]) VALUES (N'0001', N'洗衣粉', 4, N'0', 120)
INSERT [dbo].[Product] ([ProNO], [ProName], [ProPrice], [StoNO], [StoCount]) VALUES (N'0002', N'雨伞', 7, N'0', 20)
INSERT [dbo].[Product] ([ProNO], [ProName], [ProPrice], [StoNO], [StoCount]) VALUES (N'0003', N'橘子', 5, N'1', 200)
INSERT [dbo].[Product] ([ProNO], [ProName], [ProPrice], [StoNO], [StoCount]) VALUES (N'0004', N'铅笔', 2, N'2', 300)
INSERT [dbo].[Product] ([ProNO], [ProName], [ProPrice], [StoNO], [StoCount]) VALUES (N'0005', N'梨', 6, N'1', 100)
INSERT [dbo].[Product] ([ProNO], [ProName], [ProPrice], [StoNO], [StoCount]) VALUES (N'0006', N'羽毛球拍', 10, N'3', 20)
INSERT [dbo].[Product] ([ProNO], [ProName], [ProPrice], [StoNO], [StoCount]) VALUES (N'0007', N'篮球', 20, N'3', 22)
INSERT [dbo].[Product] ([ProNO], [ProName], [ProPrice], [StoNO], [StoCount]) VALUES (N'0008', N'葡萄', 6, N'1', 50)
INSERT [dbo].[Product] ([ProNO], [ProName], [ProPrice], [StoNO], [StoCount]) VALUES (N'0009', N'足球', 50, N'3', 6)
INSERT [dbo].[Product] ([ProNO], [ProName], [ProPrice], [StoNO], [StoCount]) VALUES (N'0010', N'橡皮', 1, N'2', 20)
INSERT [dbo].[Product] ([ProNO], [ProName], [ProPrice], [StoNO], [StoCount]) VALUES (N'0011', N'尺子', 2, N'2', 16)
/****** Object:  Default [DF__P_CUS__SalePrice__108B795B]    Script Date: 12/18/2015 15:23:29 ******/
ALTER TABLE [dbo].[P_CUS] ADD  DEFAULT ((2)) FOR [SalePrice]
GO
/****** Object:  Default [DF__Product__ProPric__03317E3D]    Script Date: 12/18/2015 15:23:29 ******/
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((2)) FOR [ProPrice]
GO
/****** Object:  ForeignKey [fk_Product_Store]    Script Date: 12/18/2015 15:23:29 ******/
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [fk_Product_Store] FOREIGN KEY([StoNO])
REFERENCES [dbo].[Store] ([StoNO])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [fk_Product_Store]
GO
