USE [master]
GO
/****** Object:  Database [SkladisnaEvidencija]    Script Date: 2/15/2022 9:56:56 PM ******/
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
/****** Object:  Table [dbo].[FizickoLice]    Script Date: 2/15/2022 9:56:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FizickoLice](
	[PartnerId] [int] NOT NULL,
	[Ime] [nvarchar](30) NOT NULL,
	[Prezime] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_FizickoLice] PRIMARY KEY CLUSTERED 
(
	[PartnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JedinicaMere]    Script Date: 2/15/2022 9:56:57 PM ******/
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
/****** Object:  Table [dbo].[MagacinskiDokument]    Script Date: 2/15/2022 9:56:57 PM ******/
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
	[PartnerId] [int] NOT NULL,
 CONSTRAINT [PK_MagacinskiDokument] PRIMARY KEY CLUSTERED 
(
	[MagacinskiDokumentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PoslovniPartner]    Script Date: 2/15/2022 9:56:57 PM ******/
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
/****** Object:  Table [dbo].[PravnoLice]    Script Date: 2/15/2022 9:56:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PravnoLice](
	[PartnerId] [int] NOT NULL,
	[NazivFirme] [nvarchar](30) NOT NULL,
	[PIB] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_PravnoLice] PRIMARY KEY CLUSTERED 
(
	[PartnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proizvod]    Script Date: 2/15/2022 9:56:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvod](
	[ProizvodId] [int] IDENTITY(1,1) NOT NULL,
	[NazivProizvoda] [nvarchar](30) NOT NULL,
	[UkupnaKolicina] [int] NOT NULL,
	[Opis] [nvarchar](200) NULL,
	[JmId] [int] NOT NULL,
 CONSTRAINT [PK_Proizvod] PRIMARY KEY CLUSTERED 
(
	[ProizvodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaMagacinskogDokumenta]    Script Date: 2/15/2022 9:56:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaMagacinskogDokumenta](
	[DokumentId] [int] NOT NULL,
	[RBStavke] [int] NOT NULL,
	[Kolicina] [int] NOT NULL,
	[Cena] [float] NOT NULL,
	[Iznos] [float] NOT NULL,
	[ProizvodId] [int] NOT NULL,
 CONSTRAINT [PK_StavkaMagacinskogDokumenta] PRIMARY KEY CLUSTERED 
(
	[DokumentId] ASC,
	[RBStavke] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[FizickoLice] ([PartnerId], [Ime], [Prezime]) VALUES (1002, N'Marko', N'Markovic')
INSERT [dbo].[FizickoLice] ([PartnerId], [Ime], [Prezime]) VALUES (1003, N'Petar ', N'Petrovic')
INSERT [dbo].[FizickoLice] ([PartnerId], [Ime], [Prezime]) VALUES (1004, N'Aleksandar', N'Lukic')
INSERT [dbo].[FizickoLice] ([PartnerId], [Ime], [Prezime]) VALUES (1005, N'Ana', N'Trifunovic')
GO
SET IDENTITY_INSERT [dbo].[JedinicaMere] ON 

INSERT [dbo].[JedinicaMere] ([JedinicaMereId], [NazivJediniceMere]) VALUES (1002, N'kom')
INSERT [dbo].[JedinicaMere] ([JedinicaMereId], [NazivJediniceMere]) VALUES (1003, N'm')
INSERT [dbo].[JedinicaMere] ([JedinicaMereId], [NazivJediniceMere]) VALUES (1004, N'm2')
SET IDENTITY_INSERT [dbo].[JedinicaMere] OFF
GO
SET IDENTITY_INSERT [dbo].[PoslovniPartner] ON 

INSERT [dbo].[PoslovniPartner] ([PoslovniPartnerId], [Adresa]) VALUES (1002, N'Ljermontova 17a')
INSERT [dbo].[PoslovniPartner] ([PoslovniPartnerId], [Adresa]) VALUES (1003, N'Dr Huga Klajna 4')
INSERT [dbo].[PoslovniPartner] ([PoslovniPartnerId], [Adresa]) VALUES (1004, N'Brace Ristic 5')
INSERT [dbo].[PoslovniPartner] ([PoslovniPartnerId], [Adresa]) VALUES (1005, N'Obrenovacka bb')
INSERT [dbo].[PoslovniPartner] ([PoslovniPartnerId], [Adresa]) VALUES (1006, N'Nehruova 77')
INSERT [dbo].[PoslovniPartner] ([PoslovniPartnerId], [Adresa]) VALUES (1007, N'Vojvodjanska 313')
INSERT [dbo].[PoslovniPartner] ([PoslovniPartnerId], [Adresa]) VALUES (1008, N'Durmitorska 10')
INSERT [dbo].[PoslovniPartner] ([PoslovniPartnerId], [Adresa]) VALUES (1009, N'Ljubinke Bobic 3')
SET IDENTITY_INSERT [dbo].[PoslovniPartner] OFF
GO
INSERT [dbo].[PravnoLice] ([PartnerId], [NazivFirme], [PIB], [Email]) VALUES (1006, N'NamPro d.o.o.', N'4587213444', N'nam.pro@gmail.com')
INSERT [dbo].[PravnoLice] ([PartnerId], [NazivFirme], [PIB], [Email]) VALUES (1007, N'Rafimeks d.o.o.', N'3698521472', N'rafimeks@yahoo.com')
INSERT [dbo].[PravnoLice] ([PartnerId], [NazivFirme], [PIB], [Email]) VALUES (1008, N'Artinvest a.d.', N'7531598524', N'artinvest@gmail.com')
INSERT [dbo].[PravnoLice] ([PartnerId], [NazivFirme], [PIB], [Email]) VALUES (1009, N'Bodum d.o.o.', N'1166458962', N'bodum@bodum.rs')
GO
SET IDENTITY_INSERT [dbo].[Proizvod] ON 

INSERT [dbo].[Proizvod] ([ProizvodId], [NazivProizvoda], [UkupnaKolicina], [Opis], [JmId]) VALUES (2002, N'Trpezarijski sto Roma', 150, N'Glatka obrada 1740x900x780 mm', 1002)
INSERT [dbo].[Proizvod] ([ProizvodId], [NazivProizvoda], [UkupnaKolicina], [Opis], [JmId]) VALUES (2003, N'Trpezarijska stolica Sark', 330, N'Kozno tapaciranje 450x460x980 mm', 1002)
INSERT [dbo].[Proizvod] ([ProizvodId], [NazivProizvoda], [UkupnaKolicina], [Opis], [JmId]) VALUES (2004, N'Kancelarijska stolica 61B', 280, N'Crna boja 650x710x1120 mm', 1002)
INSERT [dbo].[Proizvod] ([ProizvodId], [NazivProizvoda], [UkupnaKolicina], [Opis], [JmId]) VALUES (2007, N'Komoda Spektar', 100, N'Bela boja 450x750x1400 mm', 1002)
INSERT [dbo].[Proizvod] ([ProizvodId], [NazivProizvoda], [UkupnaKolicina], [Opis], [JmId]) VALUES (2008, N'Ormar Spektar 4V', 150, N'Svetli sonoma hrast 520x1600x2050 mm', 1002)
INSERT [dbo].[Proizvod] ([ProizvodId], [NazivProizvoda], [UkupnaKolicina], [Opis], [JmId]) VALUES (2009, N'Trosed Gold Life', 200, N'Grafitno siva boja 2350x780x950 mm', 1002)
INSERT [dbo].[Proizvod] ([ProizvodId], [NazivProizvoda], [UkupnaKolicina], [Opis], [JmId]) VALUES (2010, N'Fotelja Gold Life', 400, N'Braon boja 900x750x800 mm', 1002)
INSERT [dbo].[Proizvod] ([ProizvodId], [NazivProizvoda], [UkupnaKolicina], [Opis], [JmId]) VALUES (2011, N'Kant traka', 4000, N'22x1 mm', 1003)
INSERT [dbo].[Proizvod] ([ProizvodId], [NazivProizvoda], [UkupnaKolicina], [Opis], [JmId]) VALUES (2012, N'Sarke GTV', 15000, N'Ravna sa usporivacem', 1002)
INSERT [dbo].[Proizvod] ([ProizvodId], [NazivProizvoda], [UkupnaKolicina], [Opis], [JmId]) VALUES (2013, N'OSB ploce', 8000, N'18mm tanke', 1004)
INSERT [dbo].[Proizvod] ([ProizvodId], [NazivProizvoda], [UkupnaKolicina], [Opis], [JmId]) VALUES (2014, N'Sper ploce', 9000, N'18mm tanke', 1004)
SET IDENTITY_INSERT [dbo].[Proizvod] OFF
GO
ALTER TABLE [dbo].[FizickoLice]  WITH CHECK ADD  CONSTRAINT [FK_FizickoLice_PoslovniPartner] FOREIGN KEY([PartnerId])
REFERENCES [dbo].[PoslovniPartner] ([PoslovniPartnerId])
GO
ALTER TABLE [dbo].[FizickoLice] CHECK CONSTRAINT [FK_FizickoLice_PoslovniPartner]
GO
ALTER TABLE [dbo].[MagacinskiDokument]  WITH CHECK ADD  CONSTRAINT [FK_MagacinskiDokument_PoslovniPartner] FOREIGN KEY([PartnerId])
REFERENCES [dbo].[PoslovniPartner] ([PoslovniPartnerId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MagacinskiDokument] CHECK CONSTRAINT [FK_MagacinskiDokument_PoslovniPartner]
GO
ALTER TABLE [dbo].[PravnoLice]  WITH CHECK ADD  CONSTRAINT [FK_PravnoLice_PoslovniPartner] FOREIGN KEY([PartnerId])
REFERENCES [dbo].[PoslovniPartner] ([PoslovniPartnerId])
GO
ALTER TABLE [dbo].[PravnoLice] CHECK CONSTRAINT [FK_PravnoLice_PoslovniPartner]
GO
ALTER TABLE [dbo].[Proizvod]  WITH CHECK ADD  CONSTRAINT [FK_Proizvod_JedinicaMere] FOREIGN KEY([JmId])
REFERENCES [dbo].[JedinicaMere] ([JedinicaMereId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Proizvod] CHECK CONSTRAINT [FK_Proizvod_JedinicaMere]
GO
ALTER TABLE [dbo].[StavkaMagacinskogDokumenta]  WITH CHECK ADD  CONSTRAINT [FK_StavkaMagacinskogDokumenta_MagacinskiDokument] FOREIGN KEY([DokumentId])
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
