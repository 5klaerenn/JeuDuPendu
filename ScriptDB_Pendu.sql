
CREATE DATABASE [pendu]
go

USE [pendu]
GO
/****** Object:  Table [dbo].[DictionnaireTable]    Script Date: 2023-11-28 10:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DictionnaireTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mot] [nchar](25) NULL,
	[idLangue] [int] NULL,
	[idNiveau] [int] NULL,
 CONSTRAINT [PK_Mot] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoriqueTable]    Script Date: 2023-11-28 10:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoriqueTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mot] [nchar](25) NULL,
	[score] [int] NULL,
	[erreurs] [int] NULL,
	[temps] [int] NULL,
	[date] [datetime] NULL,
	[reussi] [nchar](10) NULL,
 CONSTRAINT [PK_Partie] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Langue]    Script Date: 2023-11-28 10:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Langue](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[langue] [nchar](15) NULL,
 CONSTRAINT [PK_Langue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Niveau]    Script Date: 2023-11-28 10:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Niveau](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[niveau] [nchar](15) NULL,
 CONSTRAINT [PK_Niveau] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parametres]    Script Date: 2023-11-28 10:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parametres](
	[id] [int] NOT NULL,
	[idLangue] [int] NOT NULL,
	[idNiveau] [int] NOT NULL,
 CONSTRAINT [PK_Parametres] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DictionnaireTable] ON 
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (1, N'Chat                     ', 1, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (2, N'Chien                    ', 1, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (3, N'Fraise                   ', 1, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (4, N'Ventre                   ', 1, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (5, N'Fille                    ', 1, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (6, N'Porte                    ', 1, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (7, N'Lit                      ', 1, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (8, N'Maison                   ', 1, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (9, N'Sport                    ', 1, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (10, N'Robe                     ', 1, 1)

INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (11, N'Pyramide                 ', 1, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (12, N'Rhum                     ', 1, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (13, N'Bateau                   ', 1, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (14, N'Tricot                   ', 1, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (15, N'Chapeau                  ', 1, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (16, N'Printemps                ', 1, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (17, N'Assiette                 ', 1, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (18, N'Clair                    ', 1, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (19, N'Gauche                   ', 1, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (20, N'Partisan                 ', 1, 2)

INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (21, N'Anticonstitutionnelle    ', 1, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (22, N'Lynx                     ', 1, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (23, N'Rock                     ', 1, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (24, N'Thym                     ', 1, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (25, N'Azimut                   ', 1, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (26, N'Basson                   ', 1, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (27, N'Wagon                    ', 1, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (28, N'Tricycle                 ', 1, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (29, N'Poney                    ', 1, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (30, N'Rhinoceros               ', 1, 3)

INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (31, N'Dog                      ', 2, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (32, N'Cat                      ', 2, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (33, N'bird                     ', 2, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (34, N'oat                      ', 2, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (35, N'code                     ', 2, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (36, N'snow                     ', 2, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (37, N'lost                     ', 2, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (38, N'bike                     ', 2, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (39, N'Bed                      ', 2, 1)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (40, N'hat                      ', 2, 1)


INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (41, N'island                   ', 2, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (42, N'mountain                 ', 2, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (43, N'window                   ', 2, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (44, N'penguin                  ', 2, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (45, N'aquatic                  ', 2, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (46, N'trivia                   ', 2, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (47, N'small                    ', 2, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (48, N'thesis                   ', 2, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (49, N'party                    ', 2, 2)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (50, N'cocktail                 ', 2, 2)

INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (51, N'Unbelievable             ', 2, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (52, N'Irregardless             ', 2, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (53, N'Nonplussed               ', 2, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (54, N'Disinterested            ', 2, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (55, N'Enormity                 ', 2, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (56, N'Whom                     ', 2, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (57, N'Hyphen                   ', 2, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (58, N'Pajama                   ', 2, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (59, N'Witchcraft               ', 2, 3)
INSERT [dbo].[DictionnaireTable] ([id], [mot], [idLangue], [idNiveau]) VALUES (60, N'Kazoo                    ', 2, 3)

SET IDENTITY_INSERT [dbo].[DictionnaireTable] OFF


GO
SET IDENTITY_INSERT [dbo].[HistoriqueTable] ON 
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (9, N'UNBELIEVABLE             ', 12, 1, 27, CAST(N'2023-08-07T14:44:18.717' AS DateTime), N'SUCCES    ')
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (10, N'UNABASHED                ', 9, 4, 23, CAST(N'2023-08-07T17:12:52.790' AS DateTime), N'SUCCES    ')
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (11, N'BIRD                     ', 4, 1, 18, CAST(N'2023-08-08T17:56:53.383' AS DateTime), N'SUCCES    ')
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (12, N'FOOD                     ', 4, 2, 48, CAST(N'2023-08-08T17:58:25.493' AS DateTime), N'SUCCES    ')
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (13, N'SNOW                     ', 0, 7, 12, CAST(N'2023-08-08T18:01:33.330' AS DateTime), N'ECHEC     ')
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (14, N'FOOD                     ', 4, 4, 55, CAST(N'2023-08-08T18:02:18.820' AS DateTime), N'SUCCES    ')
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (15, N'CAT                      ', 3, 0, 60, CAST(N'2023-08-08T18:02:29.400' AS DateTime), N'SUCCES    ')
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (16, N'CAT                      ', 3, 0, 3, CAST(N'2023-08-08T18:07:40.113' AS DateTime), N'SUCCES    ')
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (17, N'CAT                      ', 3, 0, 3, CAST(N'2023-08-08T18:07:57.903' AS DateTime), N'SUCCES    ')
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (18, N'BIRD                     ', 4, 2, 14, CAST(N'2023-08-08T18:08:17.080' AS DateTime), N'SUCCES    ')
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (1011, N'FOOD                     ', 4, 4, 8, CAST(N'2023-11-28T10:24:35.757' AS DateTime), N'SUCCES    ')
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (1012, N'ENORMITY                 ', 1, 7, 17, CAST(N'2023-11-28T10:45:48.243' AS DateTime), N'ECHEC     ')
INSERT [dbo].[HistoriqueTable] ([id], [mot], [score], [erreurs], [temps], [date], [reussi]) VALUES (1013, N'ENORMITY                 ', 4, 7, 11, CAST(N'2023-11-28T10:46:58.473' AS DateTime), N'ECHEC     ')

SET IDENTITY_INSERT [dbo].[HistoriqueTable] OFF


GO
SET IDENTITY_INSERT [dbo].[Langue] ON 
INSERT [dbo].[Langue] ([id], [langue]) VALUES (1, N'Français       ')
INSERT [dbo].[Langue] ([id], [langue]) VALUES (2, N'Anglais        ')
SET IDENTITY_INSERT [dbo].[Langue] OFF


GO
SET IDENTITY_INSERT [dbo].[Niveau] ON 

INSERT [dbo].[Niveau] ([id], [niveau]) VALUES (1, N'Facile         ')
INSERT [dbo].[Niveau] ([id], [niveau]) VALUES (2, N'Moyen          ')
INSERT [dbo].[Niveau] ([id], [niveau]) VALUES (3, N'Difficile      ')
SET IDENTITY_INSERT [dbo].[Niveau] OFF

go
INSERT [dbo].[Parametres] ([id], [idLangue], [idNiveau]) VALUES (1, 2, 3)

GO
ALTER TABLE [dbo].[DictionnaireTable]  WITH CHECK ADD  CONSTRAINT [FK_Mot_Langue] FOREIGN KEY([idLangue])
REFERENCES [dbo].[Langue] ([id])
GO
ALTER TABLE [dbo].[DictionnaireTable] CHECK CONSTRAINT [FK_Mot_Langue]
GO
ALTER TABLE [dbo].[DictionnaireTable]  WITH CHECK ADD  CONSTRAINT [FK_Mot_Niveau] FOREIGN KEY([idNiveau])
REFERENCES [dbo].[Niveau] ([id])
GO
ALTER TABLE [dbo].[DictionnaireTable] CHECK CONSTRAINT [FK_Mot_Niveau]
GO
USE [master]
GO
ALTER DATABASE [pendu] SET  READ_WRITE 
GO
