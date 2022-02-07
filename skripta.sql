USE [master]
GO
/****** Object:  Database [SkladisnaEvidencija]    Script Date: 2/7/2022 1:31:11 PM ******/
CREATE DATABASE [SkladisnaEvidencija]
GO
ALTER DATABASE [SkladisnaEvidencija] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET ARITHABORT OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SkladisnaEvidencija] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SkladisnaEvidencija] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SkladisnaEvidencija] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SkladisnaEvidencija] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SkladisnaEvidencija] SET  MULTI_USER 
GO
ALTER DATABASE [SkladisnaEvidencija] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SkladisnaEvidencija] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SkladisnaEvidencija] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SkladisnaEvidencija] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SkladisnaEvidencija] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SkladisnaEvidencija] SET QUERY_STORE = OFF
GO
USE [SkladisnaEvidencija]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [SkladisnaEvidencija]
GO
/****** Object:  Table [dbo].[FizickoLice]    Script Date: 2/7/2022 1:31:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FizickoLice](
	[PoslovniPartnerId] [int] NOT NULL,
	[Ime] [nvarchar](30) NOT NULL,
	[Prezime] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_FizickoLice] PRIMARY KEY CLUSTERED 
(
	[PoslovniPartnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JedinicaMere]    Script Date: 2/7/2022 1:31:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JedinicaMere](
	[JedinicaMereId] [int] IDENTITY(1,1) NOT NULL,
	[NazivJediniceMere] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_JedinicaMere] PRIMARY KEY CLUSTERED 
(
	[JedinicaMereId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MagacinskiDokument]    Script Date: 2/7/2022 1:31:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MagacinskiDokument](
	[MagacinskiDokumentId] [int] IDENTITY(1,1) NOT NULL,
	[NazivMagacinskogDokumenta] [int] NOT NULL,
	[Datum] [datetime] NOT NULL,
	[UkupanIznos] [float] NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[PoslovniPartnerId] [int] NOT NULL,
 CONSTRAINT [PK_MagacinskiDokument] PRIMARY KEY CLUSTERED 
(
	[MagacinskiDokumentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PoslovniPartner]    Script Date: 2/7/2022 1:31:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PoslovniPartner](
	[PoslovniPartnerId] [int] IDENTITY(1,1) NOT NULL,
	[Adresa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PoslovniPartner] PRIMARY KEY CLUSTERED 
(
	[PoslovniPartnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PravnoLice]    Script Date: 2/7/2022 1:31:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PravnoLice](
	[PoslovniPartnerId] [int] NOT NULL,
	[NazivFirme] [nvarchar](30) NOT NULL,
	[PIB] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_PravnoLice] PRIMARY KEY CLUSTERED 
(
	[PoslovniPartnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proizvod]    Script Date: 2/7/2022 1:31:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvod](
	[ProizvodId] [int] IDENTITY(1,1) NOT NULL,
	[NazivProizvoda] [nvarchar](30) NOT NULL,
	[UkupnaKolicina] [int] NOT NULL,
	[Opis] [nvarchar](200) NULL,
	[JedinicaMereId] [int] NOT NULL,
 CONSTRAINT [PK_Proizvod] PRIMARY KEY CLUSTERED 
(
	[ProizvodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaMagacinskogDokumenta]    Script Date: 2/7/2022 1:31:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaMagacinskogDokumenta](
	[MagacinskiDokumentId] [int] NOT NULL,
	[RBStavke] [int] NOT NULL,
	[Kolicina] [int] NOT NULL,
	[Cena] [float] NOT NULL,
	[Iznos] [float] NOT NULL,
	[ProizvodId] [int] NOT NULL,
 CONSTRAINT [PK_StavkaMagacinskogDokumenta] PRIMARY KEY CLUSTERED 
(
	[MagacinskiDokumentId] ASC,
	[RBStavke] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FizickoLice]  WITH CHECK ADD  CONSTRAINT [FK_FizickoLice_PoslovniPartner] FOREIGN KEY([PoslovniPartnerId])
REFERENCES [dbo].[PoslovniPartner] ([PoslovniPartnerId])
GO
ALTER TABLE [dbo].[FizickoLice] CHECK CONSTRAINT [FK_FizickoLice_PoslovniPartner]
GO
ALTER TABLE [dbo].[MagacinskiDokument]  WITH CHECK ADD  CONSTRAINT [FK_MagacinskiDokument_PoslovniPartner] FOREIGN KEY([PoslovniPartnerId])
REFERENCES [dbo].[PoslovniPartner] ([PoslovniPartnerId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MagacinskiDokument] CHECK CONSTRAINT [FK_MagacinskiDokument_PoslovniPartner]
GO
ALTER TABLE [dbo].[PravnoLice]  WITH CHECK ADD  CONSTRAINT [FK_PravnoLice_PoslovniPartner] FOREIGN KEY([PoslovniPartnerId])
REFERENCES [dbo].[PoslovniPartner] ([PoslovniPartnerId])
GO
ALTER TABLE [dbo].[PravnoLice] CHECK CONSTRAINT [FK_PravnoLice_PoslovniPartner]
GO
ALTER TABLE [dbo].[Proizvod]  WITH CHECK ADD  CONSTRAINT [FK_Proizvod_JedinicaMere] FOREIGN KEY([JedinicaMereId])
REFERENCES [dbo].[JedinicaMere] ([JedinicaMereId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Proizvod] CHECK CONSTRAINT [FK_Proizvod_JedinicaMere]
GO
ALTER TABLE [dbo].[StavkaMagacinskogDokumenta]  WITH CHECK ADD  CONSTRAINT [FK_StavkaMagacinskogDokumenta_MagacinskiDokument] FOREIGN KEY([MagacinskiDokumentId])
REFERENCES [dbo].[MagacinskiDokument] ([MagacinskiDokumentId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StavkaMagacinskogDokumenta] CHECK CONSTRAINT [FK_StavkaMagacinskogDokumenta_MagacinskiDokument]
GO
ALTER TABLE [dbo].[StavkaMagacinskogDokumenta]  WITH CHECK ADD  CONSTRAINT [FK_StavkaMagacinskogDokumenta_Proizvod] FOREIGN KEY([ProizvodId])
REFERENCES [dbo].[Proizvod] ([ProizvodId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StavkaMagacinskogDokumenta] CHECK CONSTRAINT [FK_StavkaMagacinskogDokumenta_Proizvod]
GO
USE [master]
GO
ALTER DATABASE [SkladisnaEvidencija] SET  READ_WRITE 
GO
