USE [master]
GO
/****** Object:  Database [employment_office]    Script Date: 09/21/2017 13:16:42 ******/
CREATE DATABASE [employment_office] ON  PRIMARY 
( NAME = N'employment_office', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\employment_office.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'employment_office_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\employment_office_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [employment_office] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [employment_office].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [employment_office] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [employment_office] SET ANSI_NULLS OFF
GO
ALTER DATABASE [employment_office] SET ANSI_PADDING OFF
GO
ALTER DATABASE [employment_office] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [employment_office] SET ARITHABORT OFF
GO
ALTER DATABASE [employment_office] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [employment_office] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [employment_office] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [employment_office] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [employment_office] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [employment_office] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [employment_office] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [employment_office] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [employment_office] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [employment_office] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [employment_office] SET  DISABLE_BROKER
GO
ALTER DATABASE [employment_office] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [employment_office] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [employment_office] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [employment_office] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [employment_office] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [employment_office] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [employment_office] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [employment_office] SET  READ_WRITE
GO
ALTER DATABASE [employment_office] SET RECOVERY FULL
GO
ALTER DATABASE [employment_office] SET  MULTI_USER
GO
ALTER DATABASE [employment_office] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [employment_office] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'employment_office', N'ON'
GO
USE [employment_office]
GO
/****** Object:  User [hh]    Script Date: 09/21/2017 13:16:42 ******/
CREATE USER [hh] FOR LOGIN [hh] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[courses]    Script Date: 09/21/2017 13:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[courses](
	[ID] [int] NOT NULL,
	[Course_Name] [varchar](50) NOT NULL,
	[Course_Date] [date] NOT NULL,
	[Num_Of_Days] [varchar](50) NOT NULL,
	[Train_Hours] [int] NOT NULL,
	[As_A_Student] [int] NOT NULL,
	[AS_A_Teacher] [int] NOT NULL,
	[User_ID] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[company]    Script Date: 09/21/2017 13:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[company](
	[ID] [int] NOT NULL,
	[Compnay_name] [varchar](50) NOT NULL,
	[Field_Of_Work] [varchar](50) NOT NULL,
	[Company_Place] [varchar](50) NOT NULL,
 CONSTRAINT [PK_company] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Certificate]    Script Date: 09/21/2017 13:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Certificate](
	[ID] [int] NOT NULL,
	[Certificate_name] [varchar](50) NOT NULL,
	[University_name] [varchar](50) NOT NULL,
	[Graduation] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job_seeker]    Script Date: 09/21/2017 13:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job_seeker](
	[First_name] [varchar](50) NOT NULL,
	[Second_name] [varchar](50) NOT NULL,
	[Father_name] [varchar](50) NOT NULL,
	[Mother_name] [varchar](50) NOT NULL,
	[Place_Of_Birth] [varchar](50) NOT NULL,
	[National_ID] [varchar](50) NOT NULL,
	[PersonalCard_number] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[District] [varchar](50) NOT NULL,
	[Gender] [int] NOT NULL,
	[Face_Color] [varchar](50) NOT NULL,
	[eyes_Color] [varchar](50) NOT NULL,
	[Current_address] [varchar](50) NOT NULL,
	[Previous_address] [varchar](50) NOT NULL,
	[special_Mark] [varchar](50) NOT NULL,
	[Date_Of_Release] [varchar](50) NOT NULL,
	[Military_service] [varchar](50) NOT NULL,
	[Social_status] [varchar](50) NOT NULL,
	[Smoking] [int] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NULL,
	[Cell_phone] [varchar](50) NULL,
	[Handicap] [varchar](50) NULL,
	[Extra_Information] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[National_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[References]    Script Date: 09/21/2017 13:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[References](
	[ID] [int] NOT NULL,
	[Person_Name] [varchar](50) NOT NULL,
	[Place_of_Work] [varchar](50) NOT NULL,
	[Position] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[type] [int] NOT NULL,
	[User_ID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_References] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Language]    Script Date: 09/21/2017 13:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Language](
	[ID] [int] NOT NULL,
	[Language] [varchar](50) NOT NULL,
	[language_level] [varchar](50) NOT NULL,
	[User_ID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hired]    Script Date: 09/21/2017 13:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hired](
	[Company_ID] [int] NOT NULL,
	[User_ID] [varchar](50) NOT NULL,
	[Job_title] [varchar](50) NOT NULL,
	[Hire_date] [varchar](50) NOT NULL,
	[notes] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Hired] PRIMARY KEY CLUSTERED 
(
	[Company_ID] ASC,
	[User_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Work_For]    Script Date: 09/21/2017 13:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Work_For](
	[ID] [int] NOT NULL,
	[Company_Name] [varchar](50) NOT NULL,
	[Field_Of_Work] [varchar](50) NOT NULL,
	[Job_Title] [varchar](50) NOT NULL,
	[Hire_date] [date] NOT NULL,
	[Quti_date] [date] NULL,
	[Reason] [varchar](50) NULL,
	[User_ID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Work_For] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vacancy]    Script Date: 09/21/2017 13:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vacancy](
	[id] [int] NOT NULL,
	[Company_ID] [int] NOT NULL,
	[Age] [date] NOT NULL,
	[Job_Title] [varchar](50) NOT NULL,
	[Expired] [date] NOT NULL,
	[Job_require] [varchar](50) NULL,
 CONSTRAINT [PK_Vacancy] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_Job]    Script Date: 09/21/2017 13:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_Job](
	[ID] [int] NOT NULL,
	[Last_Salary] [int] NOT NULL,
	[Excpected_Salary] [int] NOT NULL,
	[Job_Type] [varchar](50) NOT NULL,
	[Job] [varchar](50) NOT NULL,
	[User_ID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User_Job] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Skills]    Script Date: 09/21/2017 13:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Skills](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[User_ID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Skills] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[References_Opinion]    Script Date: 09/21/2017 13:16:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[References_Opinion](
	[Reference_ID] [int] NOT NULL,
	[Opinion] [varchar](50) NOT NULL,
	[User_ID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_References_Opinion] PRIMARY KEY CLUSTERED 
(
	[Reference_ID] ASC,
	[User_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_References_Userss]    Script Date: 09/21/2017 13:16:42 ******/
ALTER TABLE [dbo].[References]  WITH CHECK ADD  CONSTRAINT [FK_References_Userss] FOREIGN KEY([User_ID])
REFERENCES [dbo].[Job_seeker] ([National_ID])
GO
ALTER TABLE [dbo].[References] CHECK CONSTRAINT [FK_References_Userss]
GO
/****** Object:  ForeignKey [FK_Language_Userss]    Script Date: 09/21/2017 13:16:42 ******/
ALTER TABLE [dbo].[Language]  WITH CHECK ADD  CONSTRAINT [FK_Language_Userss] FOREIGN KEY([User_ID])
REFERENCES [dbo].[Job_seeker] ([National_ID])
GO
ALTER TABLE [dbo].[Language] CHECK CONSTRAINT [FK_Language_Userss]
GO
/****** Object:  ForeignKey [FK_Hired_company]    Script Date: 09/21/2017 13:16:42 ******/
ALTER TABLE [dbo].[Hired]  WITH CHECK ADD  CONSTRAINT [FK_Hired_company] FOREIGN KEY([Company_ID])
REFERENCES [dbo].[company] ([ID])
GO
ALTER TABLE [dbo].[Hired] CHECK CONSTRAINT [FK_Hired_company]
GO
/****** Object:  ForeignKey [FK_Hired_Job_seeker]    Script Date: 09/21/2017 13:16:42 ******/
ALTER TABLE [dbo].[Hired]  WITH CHECK ADD  CONSTRAINT [FK_Hired_Job_seeker] FOREIGN KEY([User_ID])
REFERENCES [dbo].[Job_seeker] ([National_ID])
GO
ALTER TABLE [dbo].[Hired] CHECK CONSTRAINT [FK_Hired_Job_seeker]
GO
/****** Object:  ForeignKey [FK_Work_For_Userss]    Script Date: 09/21/2017 13:16:42 ******/
ALTER TABLE [dbo].[Work_For]  WITH CHECK ADD  CONSTRAINT [FK_Work_For_Userss] FOREIGN KEY([User_ID])
REFERENCES [dbo].[Job_seeker] ([National_ID])
GO
ALTER TABLE [dbo].[Work_For] CHECK CONSTRAINT [FK_Work_For_Userss]
GO
/****** Object:  ForeignKey [FK_Vacancy_company]    Script Date: 09/21/2017 13:16:42 ******/
ALTER TABLE [dbo].[Vacancy]  WITH CHECK ADD  CONSTRAINT [FK_Vacancy_company] FOREIGN KEY([Company_ID])
REFERENCES [dbo].[company] ([ID])
GO
ALTER TABLE [dbo].[Vacancy] CHECK CONSTRAINT [FK_Vacancy_company]
GO
/****** Object:  ForeignKey [FK_User_Job_Userss]    Script Date: 09/21/2017 13:16:42 ******/
ALTER TABLE [dbo].[User_Job]  WITH CHECK ADD  CONSTRAINT [FK_User_Job_Userss] FOREIGN KEY([User_ID])
REFERENCES [dbo].[Job_seeker] ([National_ID])
GO
ALTER TABLE [dbo].[User_Job] CHECK CONSTRAINT [FK_User_Job_Userss]
GO
/****** Object:  ForeignKey [FK_Skills_Userss]    Script Date: 09/21/2017 13:16:42 ******/
ALTER TABLE [dbo].[Skills]  WITH CHECK ADD  CONSTRAINT [FK_Skills_Userss] FOREIGN KEY([User_ID])
REFERENCES [dbo].[Job_seeker] ([National_ID])
GO
ALTER TABLE [dbo].[Skills] CHECK CONSTRAINT [FK_Skills_Userss]
GO
/****** Object:  ForeignKey [FK_References_Opinion_References]    Script Date: 09/21/2017 13:16:42 ******/
ALTER TABLE [dbo].[References_Opinion]  WITH CHECK ADD  CONSTRAINT [FK_References_Opinion_References] FOREIGN KEY([Reference_ID])
REFERENCES [dbo].[References] ([ID])
GO
ALTER TABLE [dbo].[References_Opinion] CHECK CONSTRAINT [FK_References_Opinion_References]
GO
/****** Object:  ForeignKey [FK_References_Opinion_Userss]    Script Date: 09/21/2017 13:16:42 ******/
ALTER TABLE [dbo].[References_Opinion]  WITH CHECK ADD  CONSTRAINT [FK_References_Opinion_Userss] FOREIGN KEY([User_ID])
REFERENCES [dbo].[Job_seeker] ([National_ID])
GO
ALTER TABLE [dbo].[References_Opinion] CHECK CONSTRAINT [FK_References_Opinion_Userss]
GO
