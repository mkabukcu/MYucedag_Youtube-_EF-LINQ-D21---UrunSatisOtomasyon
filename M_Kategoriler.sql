USE [AdventureWorks]
GO

/****** Object:  Table [dbo].[M_Kategoriler]    Script Date: 10.06.2022 12:17:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[M_Kategoriler](
	[KategoriID] [INT] IDENTITY(1,1) NOT NULL,
	[KategoriAd] [NVARCHAR](MAX) NULL,
	[KategoriAciklama] [NVARCHAR](MAX) NULL,
 CONSTRAINT [PK_dbo.M_Kategoriler] PRIMARY KEY CLUSTERED 
(
	[KategoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


