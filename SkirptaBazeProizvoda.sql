USE [BazaProizvoda]
GO
/****** Object:  Table [dbo].[Proizvodi]    Script Date: 12/9/2020 4:53:19 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proizvodi]') AND type in (N'U'))
DROP TABLE [dbo].[Proizvodi]
GO
/****** Object:  Table [dbo].[Proizvodi]    Script Date: 12/9/2020 4:53:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvodi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[Opis] [nvarchar](100) NOT NULL,
	[Kategorija] [nvarchar](50) NOT NULL,
	[Proizvodjac] [nvarchar](50) NOT NULL,
	[Dobavljac] [nvarchar](50) NOT NULL,
	[Cena] [int] NOT NULL,
 CONSTRAINT [PK_Proizvod] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Proizvodi] ON 

INSERT [dbo].[Proizvodi] ([ID], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Dobavljac], [Cena]) VALUES (1, N'Olovka', N'Olovka za pisanje', N'Hemijska olovka', N'Stabilo', N'Dobavljac d.o.o', 50)
INSERT [dbo].[Proizvodi] ([ID], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Dobavljac], [Cena]) VALUES (2, N'Sveska', N'Sveska u linije', N'Tvrdi povez', N'Zavod', N'Zavod', 100)
INSERT [dbo].[Proizvodi] ([ID], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Dobavljac], [Cena]) VALUES (3, N'Ranac', N'Torba za knjige i sveske', N'Skolski ranac', N'Play', N'Play', 500)
INSERT [dbo].[Proizvodi] ([ID], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Dobavljac], [Cena]) VALUES (4, N'Blok', N'Blok za likovna', N'Blok 5', N'Stabilo', N'Dobavljac d.o.o', 250)
INSERT [dbo].[Proizvodi] ([ID], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Dobavljac], [Cena]) VALUES (5, N'Gumica', N'Gumica za brisanje', N'Gumica za drvenu olovku', N'Stabilo', N'Dobavljac d.o.o', 25)
INSERT [dbo].[Proizvodi] ([ID], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Dobavljac], [Cena]) VALUES (1003, N'Pernica', N'Pernica za osnovce', N'Dvostrana pernica', N'Proizvodjac', N'Dobavljac', 245)
SET IDENTITY_INSERT [dbo].[Proizvodi] OFF
GO
