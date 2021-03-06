USE [master]
GO
/****** Object:  Database [videoteka]    Script Date: 3/20/2019 1:52:52 PM ******/
CREATE DATABASE [videoteka]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'videoteka', FILENAME = N'C:\Users\Rihard\videoteka.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'videoteka_log', FILENAME = N'C:\Users\Rihard\videoteka_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [videoteka] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [videoteka].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [videoteka] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [videoteka] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [videoteka] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [videoteka] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [videoteka] SET ARITHABORT OFF 
GO
ALTER DATABASE [videoteka] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [videoteka] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [videoteka] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [videoteka] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [videoteka] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [videoteka] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [videoteka] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [videoteka] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [videoteka] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [videoteka] SET  DISABLE_BROKER 
GO
ALTER DATABASE [videoteka] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [videoteka] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [videoteka] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [videoteka] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [videoteka] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [videoteka] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [videoteka] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [videoteka] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [videoteka] SET  MULTI_USER 
GO
ALTER DATABASE [videoteka] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [videoteka] SET DB_CHAINING OFF 
GO
ALTER DATABASE [videoteka] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [videoteka] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [videoteka] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [videoteka] SET QUERY_STORE = OFF
GO
USE [videoteka]
GO
/****** Object:  Table [dbo].[cjenik]    Script Date: 3/20/2019 1:52:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cjenik](
	[id] [int] NOT NULL,
	[kategorija] [nchar](30) NULL,
	[cijena] [smallmoney] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clanovi]    Script Date: 3/20/2019 1:52:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clanovi](
	[id] [int] NOT NULL,
	[ime] [nchar](30) NULL,
	[prezime] [nchar](30) NULL,
	[adresa] [nchar](30) NULL,
	[telefon] [nchar](30) NULL,
	[datum_uclanjenja] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[filmovi]    Script Date: 3/20/2019 1:52:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[filmovi](
	[id] [int] NOT NULL,
	[naziv] [nchar](30) NULL,
	[reziser] [nchar](30) NULL,
	[glavni_glumci] [nchar](30) NULL,
	[godina_izdanja] [int] NULL,
	[kolicina_DVD] [int] NULL,
	[kolicina_VHS] [int] NULL,
	[slika_naslovnice] [image] NULL,
	[sifra_zanra] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[posudba]    Script Date: 3/20/2019 1:52:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[posudba](
	[id_clan] [int] NOT NULL,
	[id_filma] [int] NOT NULL,
	[datum_posudbe] [datetime] NOT NULL,
	[datum_povratka] [datetime] NULL,
	[id_cjenika] [int] NOT NULL,
 CONSTRAINT [PK_sifre] PRIMARY KEY CLUSTERED 
(
	[id_clan] ASC,
	[id_filma] ASC,
	[datum_posudbe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[zanr]    Script Date: 3/20/2019 1:52:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zanr](
	[id] [int] NOT NULL,
	[naziv] [nchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[filmovi]  WITH CHECK ADD FOREIGN KEY([sifra_zanra])
REFERENCES [dbo].[zanr] ([id])
GO
ALTER TABLE [dbo].[posudba]  WITH CHECK ADD FOREIGN KEY([id_cjenika])
REFERENCES [dbo].[cjenik] ([id])
GO
ALTER TABLE [dbo].[posudba]  WITH CHECK ADD FOREIGN KEY([id_clan])
REFERENCES [dbo].[clanovi] ([id])
GO
ALTER TABLE [dbo].[posudba]  WITH CHECK ADD FOREIGN KEY([id_filma])
REFERENCES [dbo].[filmovi] ([id])
GO
USE [master]
GO
ALTER DATABASE [videoteka] SET  READ_WRITE 
GO
