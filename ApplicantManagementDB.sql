USE [master]
GO
/****** Object:  Database [Education]    Script Date: 08.11.2021 16:56:03 ******/
CREATE DATABASE [Education]
GO
USE [Education]
GO
/****** Object:  Table [dbo].[Application]    Script Date: 08.11.2021 16:56:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Application](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SpecialityID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[AverageScore] [decimal](3, 2) NOT NULL,
 CONSTRAINT [PK_Application] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormOfEducation]    Script Date: 08.11.2021 16:56:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormOfEducation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_FormOfEducation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 08.11.2021 16:56:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 08.11.2021 16:56:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Speciality]    Script Date: 08.11.2021 16:56:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Speciality](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IsBudgetForm] [bit] NOT NULL,
	[PlaceNumber] [int] NOT NULL,
	[FormOfEducationID] [int] NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Image] [image] NULL,
	[Exams] [nvarchar](500) NULL,
 CONSTRAINT [PK_Speciality] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 08.11.2021 16:56:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[GenderID] [int] NOT NULL,
	[Image] [image] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Application] ON 

INSERT [dbo].[Application] ([ID], [UserID], [SpecialityID], [Date], [AverageScore]) VALUES (2, 2, 1, CAST(N'2021-08-10' AS Date), CAST(5.00 AS Decimal(3, 2)))
INSERT [dbo].[Application] ([ID], [UserID], [SpecialityID], [Date], [AverageScore]) VALUES (3, 3, 2, CAST(N'2020-01-01' AS Date), CAST(5.00 AS Decimal(3, 2)))
INSERT [dbo].[Application] ([ID], [UserID], [SpecialityID], [Date], [AverageScore]) VALUES (4, 3, 3, CAST(N'2020-01-01' AS Date), CAST(5.00 AS Decimal(3, 2)))
INSERT [dbo].[Application] ([ID], [UserID], [SpecialityID], [Date], [AverageScore]) VALUES (6, 3, 4, CAST(N'2020-01-01' AS Date), CAST(5.00 AS Decimal(3, 2)))
INSERT [dbo].[Application] ([ID], [UserID], [SpecialityID], [Date], [AverageScore]) VALUES (7, 4, 2, CAST(N'2020-01-01' AS Date), CAST(5.00 AS Decimal(3, 2)))
INSERT [dbo].[Application] ([ID], [UserID], [SpecialityID], [Date], [AverageScore]) VALUES (8, 5, 2, CAST(N'2020-01-01' AS Date), CAST(5.00 AS Decimal(3, 2)))
INSERT [dbo].[Application] ([ID], [UserID], [SpecialityID], [Date], [AverageScore]) VALUES (9, 5, 5, CAST(N'2020-01-01' AS Date), CAST(5.00 AS Decimal(3, 2)))
INSERT [dbo].[Application] ([ID], [UserID], [SpecialityID], [Date], [AverageScore]) VALUES (11, 2, 2, CAST(N'2021-10-12' AS Date), CAST(5.00 AS Decimal(3, 2)))
INSERT [dbo].[Application] ([ID], [UserID], [SpecialityID], [Date], [AverageScore]) VALUES (13, 8, 2, CAST(N'2021-10-12' AS Date), CAST(3.00 AS Decimal(3, 2)))
SET IDENTITY_INSERT [dbo].[Application] OFF
GO
SET IDENTITY_INSERT [dbo].[FormOfEducation] ON 

INSERT [dbo].[FormOfEducation] ([ID], [Name]) VALUES (1, N'Очная')
INSERT [dbo].[FormOfEducation] ([ID], [Name]) VALUES (2, N'Заочная')
SET IDENTITY_INSERT [dbo].[FormOfEducation] OFF
GO
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([ID], [Name]) VALUES (1, N'Мужской')
INSERT [dbo].[Gender] ([ID], [Name]) VALUES (2, N'Женский')
SET IDENTITY_INSERT [dbo].[Gender] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([ID], [Name]) VALUES (2, N'Applicant')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Speciality] ON 

INSERT [dbo].[Speciality] ([ID], [Name], [IsBudgetForm], [PlaceNumber], [FormOfEducationID], [Description], [Image], [Exams]) VALUES (1, N'Программист', 1, 25, 1, NULL, NULL, N'Математика, Информатика')
INSERT [dbo].[Speciality] ([ID], [Name], [IsBudgetForm], [PlaceNumber], [FormOfEducationID], [Description], [Image], [Exams]) VALUES (2, N'Программист', 0, 25, 2, NULL, NULL, N'Математика, Информатика')
INSERT [dbo].[Speciality] ([ID], [Name], [IsBudgetForm], [PlaceNumber], [FormOfEducationID], [Description], [Image], [Exams]) VALUES (3, N'Почта', 1, 25, 1, NULL, NULL, N'Математика, Информатика')
INSERT [dbo].[Speciality] ([ID], [Name], [IsBudgetForm], [PlaceNumber], [FormOfEducationID], [Description], [Image], [Exams]) VALUES (4, N'Почта', 1, 25, 2, NULL, NULL, N'Математика, Информатика')
INSERT [dbo].[Speciality] ([ID], [Name], [IsBudgetForm], [PlaceNumber], [FormOfEducationID], [Description], [Image], [Exams]) VALUES (5, N'Почта', 0, 25, 1, NULL, NULL, N'Математика, Информатика')
INSERT [dbo].[Speciality] ([ID], [Name], [IsBudgetForm], [PlaceNumber], [FormOfEducationID], [Description], [Image], [Exams]) VALUES (6, N'Почта', 0, 25, 2, NULL, NULL, N'Математика, Информатика')
INSERT [dbo].[Speciality] ([ID], [Name], [IsBudgetForm], [PlaceNumber], [FormOfEducationID], [Description], [Image], [Exams]) VALUES (7, N'КСК', 1, 25, 2, NULL, NULL, N'Информатика')
INSERT [dbo].[Speciality] ([ID], [Name], [IsBudgetForm], [PlaceNumber], [FormOfEducationID], [Description], [Image], [Exams]) VALUES (8, N'КСК', 1, 25, 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Speciality] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Surname], [Name], [Patronymic], [RoleID], [Login], [Password], [GenderID], [Image]) VALUES (1, N'Admin', N'Admin', N'Admin', 1, N'1', N'1', 1, NULL)
INSERT [dbo].[User] ([ID], [Surname], [Name], [Patronymic], [RoleID], [Login], [Password], [GenderID], [Image]) VALUES (2, N'Григорьев', N'Захар ', N'Антонинович', 2, N'2', N'2', 1, NULL)
INSERT [dbo].[User] ([ID], [Surname], [Name], [Patronymic], [RoleID], [Login], [Password], [GenderID], [Image]) VALUES (3, N'Комарова ', N'Эльза ', N'Федосеевна', 2, N'3', N'3', 2, NULL)
INSERT [dbo].[User] ([ID], [Surname], [Name], [Patronymic], [RoleID], [Login], [Password], [GenderID], [Image]) VALUES (4, N'Ситников ', N'Ермак ', N'Владимирович', 2, N'4', N'4', 1, NULL)
INSERT [dbo].[User] ([ID], [Surname], [Name], [Patronymic], [RoleID], [Login], [Password], [GenderID], [Image]) VALUES (5, N'Мышкина ', N'Дебора ', N'Пантелеймоновна', 2, N'5', N'5', 2, NULL)
INSERT [dbo].[User] ([ID], [Surname], [Name], [Patronymic], [RoleID], [Login], [Password], [GenderID], [Image]) VALUES (6, N'Тимофеев ', N'Игнатий ', N'Улебович', 2, N'6', N'6', 1, NULL)
INSERT [dbo].[User] ([ID], [Surname], [Name], [Patronymic], [RoleID], [Login], [Password], [GenderID], [Image]) VALUES (7, N'Тимофеева ', N'Валентина ', N'Адольфовна', 2, N'7', N'7', 2, NULL)
INSERT [dbo].[User] ([ID], [Surname], [Name], [Patronymic], [RoleID], [Login], [Password], [GenderID], [Image]) VALUES (8, N'Колобков', N'Арсений', N'Альбертович', 2, N'ar', N'ari', 1, NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Application]  WITH CHECK ADD  CONSTRAINT [FK_Application_Speciality] FOREIGN KEY([SpecialityID])
REFERENCES [dbo].[Speciality] ([ID])
GO
ALTER TABLE [dbo].[Application] CHECK CONSTRAINT [FK_Application_Speciality]
GO
ALTER TABLE [dbo].[Application]  WITH CHECK ADD  CONSTRAINT [FK_Application_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Application] CHECK CONSTRAINT [FK_Application_User]
GO
ALTER TABLE [dbo].[Speciality]  WITH CHECK ADD  CONSTRAINT [FK_Speciality_FormOfEducation] FOREIGN KEY([FormOfEducationID])
REFERENCES [dbo].[FormOfEducation] ([ID])
GO
ALTER TABLE [dbo].[Speciality] CHECK CONSTRAINT [FK_Speciality_FormOfEducation]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Gender] FOREIGN KEY([GenderID])
REFERENCES [dbo].[Gender] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Gender]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
