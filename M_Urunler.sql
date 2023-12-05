USE [AdventureWorks]
GO

/****** Object:  Table [dbo].[M_Urunler]    Script Date: 10.06.2022 12:17:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[M_Urunler](
	[UrunID] [INT] IDENTITY(1,1) NOT NULL,
	[UrunAd] [NVARCHAR](MAX) NULL,
	[UrunMarka] [NVARCHAR](MAX) NULL,
	[Aciklama] [NVARCHAR](MAX) NULL,
	[UrunStok] [INT] NOT NULL,
	[Kategori_KategoriID] [INT] NULL,
 CONSTRAINT [PK_dbo.M_Urunler] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[M_Urunler]  WITH CHECK ADD  CONSTRAINT [FK_dbo.M_Urunler_dbo.M_Kategoriler_Kategori_KategoriID] FOREIGN KEY([Kategori_KategoriID])
REFERENCES [dbo].[M_Kategoriler] ([KategoriID])
GO

ALTER TABLE [dbo].[M_Urunler] CHECK CONSTRAINT [FK_dbo.M_Urunler_dbo.M_Kategoriler_Kategori_KategoriID]
GO


