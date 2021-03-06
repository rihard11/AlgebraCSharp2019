USE [master]
GO
/****** Object:  Database [skladiste]    Script Date: 3/20/2019 1:46:22 PM ******/
CREATE DATABASE [skladiste]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'skladiste', FILENAME = N'C:\Users\Rihard\skladiste.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'skladiste_log', FILENAME = N'C:\Users\Rihard\skladiste_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [skladiste] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [skladiste].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [skladiste] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [skladiste] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [skladiste] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [skladiste] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [skladiste] SET ARITHABORT OFF 
GO
ALTER DATABASE [skladiste] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [skladiste] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [skladiste] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [skladiste] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [skladiste] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [skladiste] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [skladiste] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [skladiste] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [skladiste] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [skladiste] SET  DISABLE_BROKER 
GO
ALTER DATABASE [skladiste] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [skladiste] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [skladiste] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [skladiste] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [skladiste] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [skladiste] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [skladiste] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [skladiste] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [skladiste] SET  MULTI_USER 
GO
ALTER DATABASE [skladiste] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [skladiste] SET DB_CHAINING OFF 
GO
ALTER DATABASE [skladiste] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [skladiste] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [skladiste] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [skladiste] SET QUERY_STORE = OFF
GO
USE [skladiste]
GO
/****** Object:  Table [dbo].[proizvod]    Script Date: 3/20/2019 1:46:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proizvod](
	[id] [bigint] NOT NULL,
	[naziv] [nchar](30) NULL,
	[id_skladista] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[radnik]    Script Date: 3/20/2019 1:46:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[radnik](
	[id] [bigint] NOT NULL,
	[ime] [nchar](30) NULL,
	[prezime] [nchar](30) NULL,
	[id_skladista] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[skladisno_mjesto]    Script Date: 3/20/2019 1:46:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[skladisno_mjesto](
	[id] [bigint] NOT NULL,
	[naziv] [nchar](50) NULL,
	[mjesto] [nchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[voditelji]    Script Date: 3/20/2019 1:46:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[voditelji](
	[id_radnika] [bigint] NOT NULL,
	[id_skladista] [bigint] NOT NULL,
 CONSTRAINT [PK_sifre] PRIMARY KEY CLUSTERED 
(
	[id_radnika] ASC,
	[id_skladista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[proizvod]  WITH CHECK ADD FOREIGN KEY([id_skladista])
REFERENCES [dbo].[skladisno_mjesto] ([id])
GO
ALTER TABLE [dbo].[radnik]  WITH CHECK ADD FOREIGN KEY([id_skladista])
REFERENCES [dbo].[skladisno_mjesto] ([id])
GO
ALTER TABLE [dbo].[voditelji]  WITH CHECK ADD FOREIGN KEY([id_radnika])
REFERENCES [dbo].[radnik] ([id])
GO
ALTER TABLE [dbo].[voditelji]  WITH CHECK ADD FOREIGN KEY([id_skladista])
REFERENCES [dbo].[skladisno_mjesto] ([id])
GO
ALTER TABLE [dbo].[skladisno_mjesto]  WITH CHECK ADD  CONSTRAINT [ck_provjera] CHECK  (([mjesto]='SISAK' OR [mjesto]='RIJEKA' OR [mjesto]='ZAGREB'))
GO
ALTER TABLE [dbo].[skladisno_mjesto] CHECK CONSTRAINT [ck_provjera]
GO
USE [master]
GO
ALTER DATABASE [skladiste] SET  READ_WRITE 
GO
