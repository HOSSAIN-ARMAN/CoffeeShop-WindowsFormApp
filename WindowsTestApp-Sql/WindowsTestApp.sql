USE [TestApp]
GO
/****** Object:  Table [dbo].[TestItem]    Script Date: 10/2/2019 1:26:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](50) NULL,
	[ItemPrice] [float] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TestItem] ON 

INSERT [dbo].[TestItem] ([Id], [ItemName], [ItemPrice]) VALUES (1, N'ads', 12)
SET IDENTITY_INSERT [dbo].[TestItem] OFF
