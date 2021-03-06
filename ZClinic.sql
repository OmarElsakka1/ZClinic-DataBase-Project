USE [master]
GO
/****** Object:  Database [ZClinic]    Script Date: 6/14/2021 1:08:55 AM ******/
CREATE DATABASE [ZClinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ZClinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ZClinic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ZClinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ZClinic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ZClinic] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZClinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ZClinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ZClinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ZClinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ZClinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ZClinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [ZClinic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ZClinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ZClinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ZClinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ZClinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ZClinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ZClinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ZClinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ZClinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ZClinic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ZClinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ZClinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ZClinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ZClinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ZClinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ZClinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ZClinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ZClinic] SET RECOVERY FULL 
GO
ALTER DATABASE [ZClinic] SET  MULTI_USER 
GO
ALTER DATABASE [ZClinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ZClinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ZClinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ZClinic] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ZClinic] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ZClinic] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ZClinic', N'ON'
GO
ALTER DATABASE [ZClinic] SET QUERY_STORE = OFF
GO
USE [ZClinic]
GO
/****** Object:  Table [dbo].[Chronic_diseases]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chronic_diseases](
	[disease] [varchar](50) NOT NULL,
	[National_ID] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[disease] ASC,
	[National_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DName] [varchar](50) NOT NULL,
	[Building_Name] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[National_ID] [varchar](25) NOT NULL,
	[Specialization] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[National_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drugs_Medical_supplies]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drugs_Medical_supplies](
	[Names] [varchar](50) NOT NULL,
	[Price] [numeric](5, 2) NOT NULL,
	[Available] [int] NOT NULL,
	[Needed] [int] NOT NULL,
	[ImageLocation] [varchar](30) NOT NULL,
	[Descriptions] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Names] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drugs_Requests]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drugs_Requests](
	[National_ID] [varchar](25) NOT NULL,
	[Names] [varchar](50) NOT NULL,
	[NUMBER] [int] NOT NULL,
	[dates] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[National_ID] ASC,
	[Names] ASC,
	[dates] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emergency]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emergency](
	[Location] [varchar](50) NOT NULL,
	[NID] [varchar](25) NOT NULL,
	[Time] [datetime] NOT NULL,
	[State] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Time] ASC,
	[NID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hospital]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital](
	[HName] [varchar](100) NOT NULL,
	[Addresss] [varchar](100) NOT NULL,
	[LinkMap] [varchar](300) NOT NULL,
	[Phonenumber] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medical_excuses]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medical_excuses](
	[Starting_date] [date] NOT NULL,
	[Ending_date] [date] NOT NULL,
	[Symptom1] [varchar](30) NOT NULL,
	[Symptom2] [varchar](30) NULL,
	[Symptom3] [varchar](30) NULL,
	[Symptom4] [varchar](30) NULL,
	[FileDrive] [varchar](300) NULL,
	[Comment] [varchar](300) NULL,
	[Approval_state] [bit] NULL,
	[National_ID_Users] [varchar](25) NOT NULL,
	[TANID] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Starting_date] ASC,
	[National_ID_Users] ASC,
	[TANID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicals_Info]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicals_Info](
	[Blood_type] [varchar](3) NOT NULL,
	[Bdate] [date] NOT NULL,
	[Height] [decimal](5, 2) NOT NULL,
	[Weights] [decimal](5, 2) NOT NULL,
	[National_ID] [varchar](25) NOT NULL,
	[Notes] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[National_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [varchar](9) NOT NULL,
	[DName] [varchar](50) NOT NULL,
	[National_ID] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[National_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SNID] [varchar](25) NOT NULL,
	[TNID] [varchar](25) NOT NULL,
	[Subjec] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SNID] ASC,
	[TNID] ASC,
	[Subjec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUPPORT]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUPPORT](
	[National_ID] [varchar](25) NOT NULL,
	[STARTDATE] [datetime] NOT NULL,
	[Comment] [varchar](300) NOT NULL,
	[Approval_state] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[National_ID] ASC,
	[STARTDATE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/14/2021 1:08:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[National_ID] [varchar](25) NOT NULL,
	[Phone_number] [varchar](15) NOT NULL,
	[Type_] [varchar](25) NOT NULL,
	[passwords] [varchar](40) NOT NULL,
	[E_mail] [varchar](50) NOT NULL,
	[Name_] [varchar](50) NOT NULL,
	[Sex] [char](1) NOT NULL,
	[Answer1] [varchar](50) NOT NULL,
	[Answer2] [varchar](50) NOT NULL,
	[Balance] [decimal](5, 2) NULL,
	[ImageLocation] [varchar](20) NOT NULL,
	[Rating] [int] NULL,
	[UserState] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[National_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Chronic_diseases] ([disease], [National_ID]) VALUES (N'Diabetes', N'3020304242019')
INSERT [dbo].[Chronic_diseases] ([disease], [National_ID]) VALUES (N'Diabetes', N'3027389534837')
INSERT [dbo].[Chronic_diseases] ([disease], [National_ID]) VALUES (N's;m;ms', N'123')
GO
INSERT [dbo].[Department] ([DName], [Building_Name]) VALUES (N'Aerospace Engineering', N'Service Building')
INSERT [dbo].[Department] ([DName], [Building_Name]) VALUES (N'Biomedical Science', N'Helmy Building')
INSERT [dbo].[Department] ([DName], [Building_Name]) VALUES (N'Communication and Information Engineering', N'Nano Building')
INSERT [dbo].[Department] ([DName], [Building_Name]) VALUES (N'Enviromental Engineering', N'Helmy Building')
INSERT [dbo].[Department] ([DName], [Building_Name]) VALUES (N'Material Science', N'Nano Building')
INSERT [dbo].[Department] ([DName], [Building_Name]) VALUES (N'Nano Science', N'Nano Building')
INSERT [dbo].[Department] ([DName], [Building_Name]) VALUES (N'Nanotechonology Engineering', N'Nano Building')
INSERT [dbo].[Department] ([DName], [Building_Name]) VALUES (N'Physics of Earth and universe Science', N'Service Building')
INSERT [dbo].[Department] ([DName], [Building_Name]) VALUES (N'Renewable energy Engineering', N'Service Building')
GO
INSERT [dbo].[Doctors] ([National_ID], [Specialization]) VALUES (N'3020304538992', N'Cardiology')
GO
INSERT [dbo].[Drugs_Medical_supplies] ([Names], [Price], [Available], [Needed], [ImageLocation], [Descriptions]) VALUES (N'Asprin', CAST(20.80 AS Numeric(5, 2)), 3, 5, N'Asprin.jpg', N'Asprinazolzin')
INSERT [dbo].[Drugs_Medical_supplies] ([Names], [Price], [Available], [Needed], [ImageLocation], [Descriptions]) VALUES (N'Augmentin', CAST(80.00 AS Numeric(5, 2)), 27, 50, N'Augmentin.jpg', N'Augmentinol')
INSERT [dbo].[Drugs_Medical_supplies] ([Names], [Price], [Available], [Needed], [ImageLocation], [Descriptions]) VALUES (N'Betaidne', CAST(19.80 AS Numeric(5, 2)), 12, 13, N'Betaidne.jpg', N'Purpline')
INSERT [dbo].[Drugs_Medical_supplies] ([Names], [Price], [Available], [Needed], [ImageLocation], [Descriptions]) VALUES (N'Nasonex', CAST(70.80 AS Numeric(5, 2)), 2, 4, N'Nasonex.jpg', N'Cortizon')
INSERT [dbo].[Drugs_Medical_supplies] ([Names], [Price], [Available], [Needed], [ImageLocation], [Descriptions]) VALUES (N'Panadol', CAST(15.00 AS Numeric(5, 2)), 12, 27, N'Panadol.png', N'Paracetamol')
INSERT [dbo].[Drugs_Medical_supplies] ([Names], [Price], [Available], [Needed], [ImageLocation], [Descriptions]) VALUES (N'Symbicort', CAST(100.80 AS Numeric(5, 2)), 7, 6, N'Symbicort.jpg', N'Cortizon')
INSERT [dbo].[Drugs_Medical_supplies] ([Names], [Price], [Available], [Needed], [ImageLocation], [Descriptions]) VALUES (N'Voltaren', CAST(75.00 AS Numeric(5, 2)), 20, 100, N'Voltaren.jpg', N'Voltarenol')
GO
INSERT [dbo].[Drugs_Requests] ([National_ID], [Names], [NUMBER], [dates]) VALUES (N'30110010212612', N'Asprin', 1, CAST(N'2021-06-03T02:50:50.370' AS DateTime))
INSERT [dbo].[Drugs_Requests] ([National_ID], [Names], [NUMBER], [dates]) VALUES (N'30110010212612', N'Asprin', 2, CAST(N'2021-06-03T02:51:06.677' AS DateTime))
INSERT [dbo].[Drugs_Requests] ([National_ID], [Names], [NUMBER], [dates]) VALUES (N'30110010212612', N'Asprin', 7, CAST(N'2021-06-06T09:52:12.180' AS DateTime))
INSERT [dbo].[Drugs_Requests] ([National_ID], [Names], [NUMBER], [dates]) VALUES (N'30110010212612', N'Betaidne', 1, CAST(N'2021-06-02T15:43:09.537' AS DateTime))
INSERT [dbo].[Drugs_Requests] ([National_ID], [Names], [NUMBER], [dates]) VALUES (N'3020301475768', N'Panadol', 4, CAST(N'2021-05-04T10:12:14.000' AS DateTime))
INSERT [dbo].[Drugs_Requests] ([National_ID], [Names], [NUMBER], [dates]) VALUES (N'3020301989745', N'Betaidne', 2, CAST(N'2021-03-21T00:00:00.000' AS DateTime))
INSERT [dbo].[Drugs_Requests] ([National_ID], [Names], [NUMBER], [dates]) VALUES (N'3020301989745', N'Nasonex', 1, CAST(N'2021-04-12T09:00:07.000' AS DateTime))
GO
INSERT [dbo].[Emergency] ([Location], [NID], [Time], [State]) VALUES (N'Nano Building 3rd floor', N'30110010212612', CAST(N'2021-06-13T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Emergency] ([Location], [NID], [Time], [State]) VALUES (N'ljkjhfgjklbm', N'30110010212612', CAST(N'2021-06-13T23:33:39.980' AS DateTime), 0)
INSERT [dbo].[Emergency] ([Location], [NID], [Time], [State]) VALUES (N'lkjhugyft', N'30110010212612', CAST(N'2021-06-13T23:56:38.240' AS DateTime), 0)
INSERT [dbo].[Emergency] ([Location], [NID], [Time], [State]) VALUES (N'Helmy Building 3rd floor', N'30110010212612', CAST(N'2021-06-14T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Hospital] ([HName], [Addresss], [LinkMap], [Phonenumber]) VALUES (N'Al-Salama', N'Hamdan Bin Mohammed St - Al ZahiyahE13 - Abu Dhabi - United Arab Emirates', N'https://www.google.com/maps/dir//location+of+alsalamahospital+on+google+maps/data=!4m6!4m5!1m1!4e2!1m2!1m1!1s0x3e5e66591c343109:0xbbea6547335a678a?sa=X&ved=2ahUKEwjh2t3rlPzwAhUzg_0HHcWWAV8Q9RcwFHoECDgQAw', N'0238500922')
INSERT [dbo].[Hospital] ([HName], [Addresss], [LinkMap], [Phonenumber]) VALUES (N'Dar Al Fouad', N'26th of July Corridor, First 6th of October, Giza Governorate 12568', N'https://www.google.com/maps/dir//location+of+dar+el+fouad+hospital+on+google+maps/data=!4m6!4m5!1m1!4e2!1m2!1m1!1s0x1458573f853da531:0x631bbb875edebfed?sa=X&ved=2ahUKEwiiwK2NlfzwAhVX_rsIHTX0BcwQ9RcwHHoECEwQBA', N'02 38247248')
GO
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2021-06-06' AS Date), CAST(N'2021-06-08' AS Date), N'Headache', N'Fever', NULL, NULL, N'https://drive.google.com/drive/w/1/folders/16_3juPp8oCHsRTKNXQInuxWxiWuqKEqc', NULL, 1, N'30110010212612', N'3020304242019')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2021-06-09' AS Date), CAST(N'2021-06-10' AS Date), N'Headache', N'Fever', NULL, NULL, N'https://drive.google.com/drive/w/1/folders/16_3juPp8oCHsRTKNXQInuxWxiWuqKEqc', NULL, 1, N'30110010212612', N'3020304242019')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2021-06-13' AS Date), CAST(N'2021-06-14' AS Date), N'jnfjkjf jfjn', N'kmfsmkdkm', N'klscakvdkm', N'vdnnkv,k', N'lmmlfml', N'jvnfvnmf', NULL, N'30110010212612', N'3020304242019')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2021-06-13' AS Date), CAST(N'2021-06-14' AS Date), N'vdkk.vdk', N'nsdnkvn', N'lsdvnlvdn', N'dmsvlmsvdl', N';vdsm;dvsm', N'vdkmdvmldsvm', NULL, N'30110010212612', N'3253684531928')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2021-06-19' AS Date), CAST(N'2021-06-25' AS Date), N'lskklmkl', N'wkmdmkwqk', N'qw', N'qd', N'dqdw', N'kdmmmmmmmmmmmmm', NULL, N'30110010212612', N'3020304242019')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2021-06-26' AS Date), CAST(N'2021-06-28' AS Date), N'dalwij', N'dwna', N'kjdwa', N'andw', N'kjwda', N'dmlwak', NULL, N'30110010212612', N'3020304242019')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2021-06-26' AS Date), CAST(N'2021-06-28' AS Date), N'dalwij', N'dwna', N'kjdwa', N'andw', N'kjwda', N'dmlwak', NULL, N'30110010212612', N'3253684531928')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2021-08-06' AS Date), CAST(N'2021-09-08' AS Date), N'Meow', NULL, NULL, NULL, NULL, N'kdd', 1, N'30110010212612', N'3020304242019')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2021-08-12' AS Date), CAST(N'2021-08-26' AS Date), N'Headache', N'Mara', NULL, NULL, N'jflwnklsk', NULL, 1, N'30110010212612', N'3253684531928')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2022-03-10' AS Date), CAST(N'2022-03-25' AS Date), N'dkldkl', N'dlkkdld', N'slkkdlkds', N'kdslkdlklsd', N'skldksdklsd', N'sksklkdlskldsk', NULL, N'30110010212612', N'3020304242019')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2022-03-10' AS Date), CAST(N'2022-03-25' AS Date), N'dkldkl', N'dlkkdld', N'slkkdlkds', N'kdslkdlklsd', N'skldksdklsd', N'sksklkdlskldsk', NULL, N'30110010212612', N'3253684531928')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2022-06-09' AS Date), CAST(N'2022-06-10' AS Date), N'Headache', N'Fever', NULL, NULL, N'https://drive.google.com/drive/w/1/folders/16_3juPp8oCHsRTKNXQInuxWxiWuqKEqc', NULL, NULL, N'30110010212612', N'3020304242019')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2051-03-02' AS Date), CAST(N'2060-01-28' AS Date), N'klmlml', NULL, NULL, NULL, N'lkmlml', NULL, 1, N'30110010212612', N'3020304242019')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2099-12-03' AS Date), CAST(N'2100-01-01' AS Date), N'xhgxxm', N'nsrysnyn', N'fffddf', N'fgdd', N'lkjnbv', N'lkjhgfd', NULL, N'30110010212612', N'3020304242019')
INSERT [dbo].[Medical_excuses] ([Starting_date], [Ending_date], [Symptom1], [Symptom2], [Symptom3], [Symptom4], [FileDrive], [Comment], [Approval_state], [National_ID_Users], [TANID]) VALUES (CAST(N'2099-12-03' AS Date), CAST(N'2100-01-01' AS Date), N'xhgxxm', N'nsrysnyn', N'fffddf', N'fgdd', N'lkjnbv', N'lkjhgfd', NULL, N'30110010212612', N'3253684531928')
GO
INSERT [dbo].[Medicals_Info] ([Blood_type], [Bdate], [Height], [Weights], [National_ID], [Notes]) VALUES (N'A+', CAST(N'2021-06-03' AS Date), CAST(170.00 AS Decimal(5, 2)), CAST(50.00 AS Decimal(5, 2)), N'123', N'vjhbklml')
INSERT [dbo].[Medicals_Info] ([Blood_type], [Bdate], [Height], [Weights], [National_ID], [Notes]) VALUES (N'A+', CAST(N'2001-10-10' AS Date), CAST(170.00 AS Decimal(5, 2)), CAST(47.00 AS Decimal(5, 2)), N'30110010212612', NULL)
INSERT [dbo].[Medicals_Info] ([Blood_type], [Bdate], [Height], [Weights], [National_ID], [Notes]) VALUES (N'A+', CAST(N'1959-10-24' AS Date), CAST(175.00 AS Decimal(5, 2)), CAST(65.00 AS Decimal(5, 2)), N'3020301989745', N'okfjjb')
INSERT [dbo].[Medicals_Info] ([Blood_type], [Bdate], [Height], [Weights], [National_ID], [Notes]) VALUES (N'O+', CAST(N'2001-08-26' AS Date), CAST(181.00 AS Decimal(5, 2)), CAST(79.00 AS Decimal(5, 2)), N'3020304242019', NULL)
INSERT [dbo].[Medicals_Info] ([Blood_type], [Bdate], [Height], [Weights], [National_ID], [Notes]) VALUES (N'O-', CAST(N'2002-05-09' AS Date), CAST(165.00 AS Decimal(5, 2)), CAST(50.00 AS Decimal(5, 2)), N'3020304538992', NULL)
INSERT [dbo].[Medicals_Info] ([Blood_type], [Bdate], [Height], [Weights], [National_ID], [Notes]) VALUES (N'AB-', CAST(N'1970-07-15' AS Date), CAST(170.00 AS Decimal(5, 2)), CAST(88.00 AS Decimal(5, 2)), N'3253684531928', NULL)
GO
INSERT [dbo].[Student] ([ID], [DName], [National_ID]) VALUES (N'201900321', N'Aerospace Engineering', N'123')
INSERT [dbo].[Student] ([ID], [DName], [National_ID]) VALUES (N'201900311', N'Communication and Information Engineering', N'30110010212612')
INSERT [dbo].[Student] ([ID], [DName], [National_ID]) VALUES (N'201900928', N'Communication and Information Engineering', N'30202098700456')
INSERT [dbo].[Student] ([ID], [DName], [National_ID]) VALUES (N'201700178', N'Biomedical Science', N'3020301475768')
INSERT [dbo].[Student] ([ID], [DName], [National_ID]) VALUES (N'201801978', N'Nanotechonology Engineering', N'3020301989745')
INSERT [dbo].[Student] ([ID], [DName], [National_ID]) VALUES (N'201500897', N'Aerospace Engineering', N'3020304242019')
INSERT [dbo].[Student] ([ID], [DName], [National_ID]) VALUES (N'201600198', N'Physics of Earth and universe Science', N'3020304538992')
INSERT [dbo].[Student] ([ID], [DName], [National_ID]) VALUES (N'201900176', N'Material Science', N'3020984532899')
INSERT [dbo].[Student] ([ID], [DName], [National_ID]) VALUES (N'201300576', N'Renewable energy Engineering', N'3027389534837')
INSERT [dbo].[Student] ([ID], [DName], [National_ID]) VALUES (N'201400987', N'Enviromental Engineering', N'3045984538070')
INSERT [dbo].[Student] ([ID], [DName], [National_ID]) VALUES (N'201900887', N'Nano Science', N'3253684531928')
GO
INSERT [dbo].[Subjects] ([SNID], [TNID], [Subjec]) VALUES (N'30110010212612', N'3020304242019', N'Math')
GO
INSERT [dbo].[Users] ([National_ID], [Phone_number], [Type_], [passwords], [E_mail], [Name_], [Sex], [Answer1], [Answer2], [Balance], [ImageLocation], [Rating], [UserState]) VALUES (N'123', N'900', N'Student', N'123', N'angmail.com', N'a', N'M', N'1', N'1', NULL, N'Nour.jpg', NULL, 1)
INSERT [dbo].[Users] ([National_ID], [Phone_number], [Type_], [passwords], [E_mail], [Name_], [Sex], [Answer1], [Answer2], [Balance], [ImageLocation], [Rating], [UserState]) VALUES (N'30110010212612', N'01119775054', N'Student', N'noor', N's-noureldin.hamedo@zewailcity.edu.eg', N'Noureldin Mohamed', N'M', N'no', N'noo', CAST(0.00 AS Decimal(5, 2)), N'Nour.jpg', 0, 1)
INSERT [dbo].[Users] ([National_ID], [Phone_number], [Type_], [passwords], [E_mail], [Name_], [Sex], [Answer1], [Answer2], [Balance], [ImageLocation], [Rating], [UserState]) VALUES (N'30202098700456', N'01013153610', N'Admin', N'12342345', N'Admin@zewailcity.edu.eg', N'Mohamed Mahours', N'M', N'g', N'h', CAST(0.00 AS Decimal(5, 2)), N'Mohamed.jpg', 2, 1)
INSERT [dbo].[Users] ([National_ID], [Phone_number], [Type_], [passwords], [E_mail], [Name_], [Sex], [Answer1], [Answer2], [Balance], [ImageLocation], [Rating], [UserState]) VALUES (N'3020301475768', N'01029182390', N'Student', N'wertyu', N'Mohsennour@zewailcity.edu.eg', N'Mohsen Nour El-Din', N'M', N'hgdvbf', N'jhtec', CAST(60.00 AS Decimal(5, 2)), N'Mohsen.jpg', 3, 1)
INSERT [dbo].[Users] ([National_ID], [Phone_number], [Type_], [passwords], [E_mail], [Name_], [Sex], [Answer1], [Answer2], [Balance], [ImageLocation], [Rating], [UserState]) VALUES (N'3020301989745', N'01029183425', N'Student', N'qwerty', N'Omarail@zewailcity.edu.eg', N'Omar ail Elderany', N'M', N'kkjhf', N'rjhgdf', CAST(0.00 AS Decimal(5, 2)), N'Omar.jpg', 3, 1)
INSERT [dbo].[Users] ([National_ID], [Phone_number], [Type_], [passwords], [E_mail], [Name_], [Sex], [Answer1], [Answer2], [Balance], [ImageLocation], [Rating], [UserState]) VALUES (N'3020304242019', N'01123574431', N'Teaching Stuff', N'123456789', N'Ateamostafa@zewailcity.edu.eg', N'Atia Mostafa', N'M', N'plmihj', N'o', CAST(20.00 AS Decimal(5, 2)), N'Atia.jpg', 2, 1)
INSERT [dbo].[Users] ([National_ID], [Phone_number], [Type_], [passwords], [E_mail], [Name_], [Sex], [Answer1], [Answer2], [Balance], [ImageLocation], [Rating], [UserState]) VALUES (N'3020304538992', N'01223453959', N'Doctor', N'ertyui', N'KhaledAhmed@zewailcity.edu.eg', N'Khaled Ahmed Arafa', N'M', N'butrty', N'ikmuhkj', CAST(90.00 AS Decimal(5, 2)), N'Khaled.jpg', 4, 1)
INSERT [dbo].[Users] ([National_ID], [Phone_number], [Type_], [passwords], [E_mail], [Name_], [Sex], [Answer1], [Answer2], [Balance], [ImageLocation], [Rating], [UserState]) VALUES (N'3020984532899', N'01276583432', N'Nurse', N'rtyuio', N'Nourelhoda@zewailcity.edu.eg', N'Nour Elhoda Mohsen', N'F', N'poimuy', N'trvbjy', CAST(120.00 AS Decimal(5, 2)), N'Nour.jpg', 4, NULL)
INSERT [dbo].[Users] ([National_ID], [Phone_number], [Type_], [passwords], [E_mail], [Name_], [Sex], [Answer1], [Answer2], [Balance], [ImageLocation], [Rating], [UserState]) VALUES (N'3027389534837', N'01276865948', N'Student', N'1234567890', N'mariam@zewailcity.edu.eg', N'Mariam Seedawy', N'F', N'omiu', N'm', CAST(90.00 AS Decimal(5, 2)), N'Mariam.jpeg', 4, NULL)
INSERT [dbo].[Users] ([National_ID], [Phone_number], [Type_], [passwords], [E_mail], [Name_], [Sex], [Answer1], [Answer2], [Balance], [ImageLocation], [Rating], [UserState]) VALUES (N'3045984538070', N'01276864411', N'Nurse', N'tyuiop', N'Ahmedmohamed@zewailcity.edu.eg', N'Ahmed Mohamed Ail', N'M', N'jbtbtg', N'intyhghj', CAST(-120.00 AS Decimal(5, 2)), N'Ahmed.jpg', 1, 1)
INSERT [dbo].[Users] ([National_ID], [Phone_number], [Type_], [passwords], [E_mail], [Name_], [Sex], [Answer1], [Answer2], [Balance], [ImageLocation], [Rating], [UserState]) VALUES (N'3253684531928', N'01295483432', N'Teaching Stuff', N'1234567', N'MostafaAil@zewailcity.edu.eg', N'Mostafa Ail Mohamed', N'M', N'omiu', N'm', CAST(20.00 AS Decimal(5, 2)), N'Mostafa.jpg', 3, 1)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Drugs_Me__3F174F237EEB4F8C]    Script Date: 6/14/2021 1:08:59 AM ******/
ALTER TABLE [dbo].[Drugs_Medical_supplies] ADD UNIQUE NONCLUSTERED 
(
	[ImageLocation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Drugs_Me__44C0348641781708]    Script Date: 6/14/2021 1:08:59 AM ******/
ALTER TABLE [dbo].[Drugs_Medical_supplies] ADD UNIQUE NONCLUSTERED 
(
	[Names] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__31660442B8725397]    Script Date: 6/14/2021 1:08:59 AM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[E_mail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__7E87EC67652B751E]    Script Date: 6/14/2021 1:08:59 AM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[Phone_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Chronic_diseases]  WITH CHECK ADD FOREIGN KEY([National_ID])
REFERENCES [dbo].[Users] ([National_ID])
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD FOREIGN KEY([National_ID])
REFERENCES [dbo].[Users] ([National_ID])
GO
ALTER TABLE [dbo].[Drugs_Requests]  WITH CHECK ADD FOREIGN KEY([Names])
REFERENCES [dbo].[Drugs_Medical_supplies] ([Names])
GO
ALTER TABLE [dbo].[Drugs_Requests]  WITH CHECK ADD FOREIGN KEY([National_ID])
REFERENCES [dbo].[Users] ([National_ID])
GO
ALTER TABLE [dbo].[Emergency]  WITH CHECK ADD FOREIGN KEY([NID])
REFERENCES [dbo].[Users] ([National_ID])
GO
ALTER TABLE [dbo].[Medicals_Info]  WITH CHECK ADD FOREIGN KEY([National_ID])
REFERENCES [dbo].[Users] ([National_ID])
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([DName])
REFERENCES [dbo].[Department] ([DName])
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD FOREIGN KEY([SNID])
REFERENCES [dbo].[Users] ([National_ID])
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD FOREIGN KEY([TNID])
REFERENCES [dbo].[Users] ([National_ID])
GO
/****** Object:  StoredProcedure [dbo].[CheckMSuppliesImage]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CheckMSuppliesImage] @Image VARCHAR(30)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT COUNT(*)
	FROM Drugs_Medical_supplies WHERE ImageLocation = @Image
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END
GO
/****** Object:  StoredProcedure [dbo].[CheckUsersImage]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CheckUsersImage] @Image VARCHAR(20)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT COUNT(*)
	FROM Users WHERE ImageLocation = @Image
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteSupportIT]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteSupportIT] @NID varchar(25),@Comment varchar(300)
AS
BEGIN
Delete From SUPPORT
where National_ID=@NID and Comment=@Comment
SET NOCOUNT ON;

  
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserNotInDoctor]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteUserNotInDoctor] @NID Varchar(25)
AS
BEGIN
	Delete
	from Users 
	where National_ID=@NID and (National_ID Not in ((select D.National_ID from  Doctors as D where D.National_ID=National_ID)))
	SET NOCOUNT ON;

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserNotInStudent]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteUserNotInStudent] @NID varchar(25)
AS
BEGIN
	Delete
	from Users 
	where National_ID=@NID and (National_ID Not in ((select S.National_ID from  Student as S where S.National_ID=National_ID)))
	SET NOCOUNT ON;
END
GO
/****** Object:  StoredProcedure [dbo].[Drugs_Statistics_3Month]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Drugs_Statistics_3Month]
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN

    SELECT COUNT(*) as 'Count',Names
	From Drugs_Requests
	WHERE dates >= DATEADD(MONTH, -3, GETDATE()) 
	Group by Names

	SET NOCOUNT ON;
    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Drugs_Statistics_3Month_Major]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Drugs_Statistics_3Month_Major]
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN

    SELECT SUM(NUMBER) as 'Count',DName
	From Drugs_Requests  D,Student S 
	WHERE dates >= DATEADD(MONTH, -3, GETDATE()) AND D.National_ID=S.National_ID 
	Group by DName

	SET NOCOUNT ON;
    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Edit_Profile]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Edit_Profile] @NID VARCHAR(25),@Names VARCHAR(50),@Email VARCHAR(50),@Pnumber VARCHAR(15)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	UPDATE Users SET  Name_ = @Names, Phone_number = @Pnumber,E_mail = @Email 
	WHERE National_ID = @NID
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[ExcuseUpdate]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ExcuseUpdate] @NID VARCHAR(25),@state Bit ,@Date VARCHAR(20) 
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	UPDATE Medical_excuses 
	SET Approval_state = @state
	WHERE National_ID_Users = @NID and Starting_date=CAST(@date as Date);
	SET NOCOUNT ON;
	
    -- TODO: Insert statements for procedure here
	--SELECT..
END
GO
/****** Object:  StoredProcedure [dbo].[FillAdmin]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[FillAdmin] 
AS
BEGIN
Select U.Name_,U.E_mail,U.ImageLocation
From Users as U
where  U.UserState is NULL
SET NOCOUNT ON;

  
END
GO
/****** Object:  StoredProcedure [dbo].[FillRevisedSupportIT]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FillRevisedSupportIT]
AS
BEGIN
	Select U.ImageLocation,U.Name_,U.E_mail, S.Comment
	from Users as U,SUPPORT as S
	where U.National_ID=S.National_ID and S.Approval_state=1
	SET NOCOUNT ON;

  
END
GO
/****** Object:  StoredProcedure [dbo].[FillSupportIT]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FillSupportIT]
AS
BEGIN
	Select U.ImageLocation,U.Name_,U.E_mail, S.Comment
	from Users as U,SUPPORT as S
	where U.National_ID=S.National_ID and S.Approval_state is Null
	SET NOCOUNT ON;

  
END
GO
/****** Object:  StoredProcedure [dbo].[Get_All_MyIssues]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_All_MyIssues] @NID Varchar(25)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT Comment
	FROM SUPPORT S
	WHERE S.National_ID = @NID
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Get_Email_From_NationalID]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_Email_From_NationalID] @NID Varchar(25)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT E_mail FROM Users WHERE National_ID = @NID
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Get_Issues]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_Issues] 
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT Name_, E_mail, Comment, ImageLocation
	FROM Users U, SUPPORT S
	WHERE U.National_ID = S.National_ID
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Get_Month]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_Month]
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT MONTH(GETDATE())
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Get_NationalID]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_NationalID] @Email Varchar(50)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT National_ID FROM Users WHERE E_mail = @Email
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Get_NationalIDFromPhone]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[Get_NationalIDFromPhone] @phone varchar(15)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT National_ID FROM Users as U WHERE U.Phone_number = @phone
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Get_Password]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_Password] @Email VARCHAR(50)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT passwords
	FROM Users WHERE LOWER(E_mail) = @Email
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END
GO
/****** Object:  StoredProcedure [dbo].[Get_Type]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_Type] @Email Varchar(50)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT Type_ FROM Users WHERE E_mail = @Email
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[GetAllAcceptedMedicalExcusesPerUSer]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllAcceptedMedicalExcusesPerUSer]
AS
BEGIN
	SELECT Name_ , CAST (datediff(DD,Bdate,getdate())/365.25 AS INT) as AGE, DName, CONVERT(NVARCHAR,Starting_date,106) ,CONVERT(NVARCHAR,Ending_date,106), ImageLocation, Symptom1, Symptom2, Symptom3, Symptom4 
	FROM Users U, Medicals_Info Me, Student S, Medical_excuses M 
	WHERE U.National_ID = M.National_ID_Users AND U.National_ID = S.National_ID AND Me.National_ID = U.National_ID AND Approval_state=1
	SET NOCOUNT ON;

END
GO
/****** Object:  StoredProcedure [dbo].[GetAllDeclinedMedicalExcusesPerUSer]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllDeclinedMedicalExcusesPerUSer]
AS
BEGIN
	SELECT Name_ , CAST (datediff(DD,Bdate,getdate())/365.25 AS INT) as AGE, DName, CONVERT(NVARCHAR,Starting_date,106) ,CONVERT(NVARCHAR,Ending_date,106), ImageLocation, Symptom1, Symptom2, Symptom3, Symptom4 
	FROM Users U, Medicals_Info Me, Student S, Medical_excuses M 
	WHERE U.National_ID = M.National_ID_Users AND U.National_ID = S.National_ID AND Me.National_ID = U.National_ID AND Approval_state=0
	SET NOCOUNT ON;

END
GO
/****** Object:  StoredProcedure [dbo].[GetAllDrugs]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllDrugs]
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	Select DISTINCT Names FROM Drugs_Medical_supplies;
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[GetAllMedicalExcuses]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllMedicalExcuses]
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT Name_ , CAST (datediff(DD,Bdate,getdate())/365.25 AS INT) as AGE, DName, CONVERT(NVARCHAR,Starting_date,106) ,CONVERT(NVARCHAR,Ending_date,106), ImageLocation, Symptom1, Symptom2, Symptom3, Symptom4 
	FROM Users U, Medicals_Info Me, Student S, Medical_excuses M 
	WHERE U.National_ID = M.National_ID_Users AND U.National_ID = S.National_ID AND Me.National_ID = U.National_ID
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[GetAllNullMedicalExcuses]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllNullMedicalExcuses]
AS
BEGIN
	-- interfering with SELECT statements.
	SELECT Name_ , CAST (datediff(DD,Bdate,getdate())/365.25 AS INT) as AGE, DName, CONVERT(NVARCHAR,Starting_date,106) ,CONVERT(NVARCHAR,Ending_date,106), ImageLocation, Symptom1, Symptom2, Symptom3, Symptom4, U.National_ID
	FROM Users U, Medicals_Info Me, Student S, Medical_excuses M 
	WHERE U.National_ID = M.National_ID_Users AND U.National_ID = S.National_ID AND Me.National_ID = U.National_ID and M.Approval_state is NULL
	SET NOCOUNT ON;

END
GO
/****** Object:  StoredProcedure [dbo].[GetAllPendingMedicalExcusesPerUSer]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllPendingMedicalExcusesPerUSer]
AS
BEGIN
	SELECT Name_ , CAST (datediff(DD,Bdate,getdate())/365.25 AS INT) as AGE, DName, CONVERT(NVARCHAR,Starting_date,106) ,CONVERT(NVARCHAR,Ending_date,106), ImageLocation, Symptom1, Symptom2, Symptom3, Symptom4 
	FROM Users U, Medicals_Info Me, Student S, Medical_excuses M 
	WHERE U.National_ID = M.National_ID_Users AND U.National_ID = S.National_ID AND Me.National_ID = U.National_ID AND Approval_state is NULL
	SET NOCOUNT ON;

END
GO
/****** Object:  StoredProcedure [dbo].[GetAnswers]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAnswers] @Email Varchar(50)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT Answer1, Answer2
	FROM Users
	WHERE LOWER(E_mail) = @Email
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[GetEmergencyStateZero]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetEmergencyStateZero]

AS
BEGIN
Select U.Name_,U.Phone_number, E.Location,U.ImageLocation ,E.Time
from Users as U, Emergency as E
where E.state=0 and U.National_ID=E.NID
	SET NOCOUNT ON;

END
GO
/****** Object:  StoredProcedure [dbo].[GetIDUsingPhotoName]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetIDUsingPhotoName] @ImageName VarChar(20)
AS
BEGIN
	Select National_ID
	From Users as U
	where U.ImageLocation= @ImageName
	SET NOCOUNT ON;

END
GO
/****** Object:  StoredProcedure [dbo].[GetNumPerSex_Branch]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetNumPerSex_Branch] @num INT, @Sex CHAR(1)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT COUNT(*) FROM Student S,Users U,Medical_excuses M WHERE (YEAR(GETDATE()) - CAST(SUBSTRING(S.ID, 1, 4) AS INT)) = @num AND U.Sex = @Sex AND U.National_ID = S.National_ID AND M.National_ID_Users = U.National_ID AND CAST(SUBSTRING((CAST (M.Starting_date AS VARCHAR)), 1, 4) AS INT)=YEAR(GETDATE());
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Hosptials_Data]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Hosptials_Data]
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT *
	FROM Hospital 
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Insert_Chronic_Disease]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_Chronic_Disease] @Disease VARCHAR(50),@NID VARCHAR(25)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO Chronic_diseases VALUES(@Disease, @NID)
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Insert_Doctor]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_Doctor] @NID VARCHAR(25),@Specialization VARCHAR(30)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO Doctors VALUES (@NID,@Specialization)
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Insert_Drug_Data]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_Drug_Data] @DrugName VARCHAR(50),@Price NUMERIC(5,2),@Available INT,@Needed INT,@ImageLocation VARCHAR(30),@Descriptions VARCHAR(30)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO Drugs_Medical_supplies
	VALUES(@DrugName,@Price,@Available,@Needed,@ImageLocation,@Descriptions)
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Insert_Emergency]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_Emergency] @location VARCHAR(50),@NID VARCHAR(25)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO Emergency
	VALUES(@location,@NID,GETDATE(),0)
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Insert_Medical_info]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_Medical_info] @BloodType VARCHAR(3),@Bdate DATE,@Height DECIMAL(5,2),@Weights DECIMAL(5,2),@NID VARCHAR(25),@Notes VARCHAR(100)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO Medicals_Info
	VALUES(@BloodType,@Bdate,@Height,@Weights,@NID,@Notes)
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Insert_Medical_infoNULL]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Insert_Medical_infoNULL] @BloodType VARCHAR(3),@Bdate DATE,@Height DECIMAL(5,2),@Weights DECIMAL(5,2),@NID VARCHAR(25)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO Medicals_Info
	VALUES(@BloodType,@Bdate,@Height,@Weights,@NID,NULL)
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[InsertExcuse]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertExcuse] @SD VARCHAR(20),@ED VARCHAR(20),@S1 Varchar(30),@S2 Varchar(30),@S3 Varchar(30),@S4 Varchar(30),@DL Varchar(300),@Com Varchar(30) ,@NID varchar(25)
AS
BEGIN
Insert Into Medical_excuses
values(CAST(@SD as Date),CAST(@ED as Date),@S1,NULLIF(@S2, ''),NULLIF(@S3, ''),NULLIF(@S4, ''),NULLIF(@DL, ''),NULLIF(@Com, ''),NULL,@NID,@NID)
	SET NOCOUNT ON;

END
GO
/****** Object:  StoredProcedure [dbo].[InsertStudentExcuse]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertStudentExcuse] @SD VARCHAR(20),@ED VARCHAR(20),@S1 Varchar(30),@S2 Varchar(30),@S3 Varchar(30),@S4 Varchar(30),@DL Varchar(300),@Com Varchar(30) ,@NID varchar(25),@TANID varchar(25)
AS
BEGIN
Insert Into Medical_excuses
values(CAST(@SD as Date),CAST(@ED as Date),@S1,NULLIF(@S2, ''),NULLIF(@S3, ''),NULLIF(@S4, ''),NULLIF(@DL, ''),NULLIF(@Com, ''),NULL,@NID,@TANID)
	SET NOCOUNT ON;

END
GO
/****** Object:  StoredProcedure [dbo].[InsertSupport]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertSupport]  @NID Varchar(25), @SD Varchar(25), @Comment Varchar(300)
As
BEGIN

Insert INTO [dbo].[SUPPORT]
Values( @NID,Cast(@SD as DateTime),@Comment)
	SET NOCOUNT ON;

END
GO
/****** Object:  StoredProcedure [dbo].[InsertUser]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertUser] @NID VARCHAR(25),@Pnumber VARCHAR(15),@Type VARCHAR(25),@Password VARCHAR(40),@Email VARCHAR(50),@Name VARCHAR(50),@Sex CHAR(1),@A1 VARCHAR(50),@A2 VARCHAR(50),@Image VARCHAR(20)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO Users VALUES (@NID,@Pnumber,@Type,@Password,@Email,@Name,@Sex,@A1,@A2,0.00,@Image,NULL,NULL)
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[IsUserExist]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[IsUserExist] @Email VARCHAR(40)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT COUNT(*)
	FROM Users WHERE LOWER(E_mail) = @Email
	SET NOCOUNT ON;
	
    -- TODO: Insert statements for procedure here
	--SELECT...

END
GO
/****** Object:  StoredProcedure [dbo].[MaleFemaleStat]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[MaleFemaleStat]
AS
BEGIN
	SELECT COUNT(*)
	From Medical_excuses as M, Users as U
	Where M.National_ID_Users=U.National_ID
	--Where M.National_ID_Users=U.National_ID
	Group by Sex
	SET NOCOUNT ON;
END
GO
/****** Object:  StoredProcedure [dbo].[Medical_Excuses_3Month]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Medical_Excuses_3Month]
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN

    SELECT COUNT(*) as 'Count',Sex
	From Medical_excuses as M, Users as U
	Where M.National_ID_Users=U.National_ID AND  Starting_date >= DATEADD(MONTH, -3, GETDATE()) 
	Group by Sex

	SET NOCOUNT ON;
    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Medical_Excuses_3Month_Major]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Medical_Excuses_3Month_Major]
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN

    SELECT COUNT(*) as 'Count',DName
	From Medical_excuses as M, Users as U,Student S
	Where M.National_ID_Users=U.National_ID AND  Starting_date >= DATEADD(MONTH, -3, GETDATE())  AND M.National_ID_Users=S.National_ID 
	Group by DName

	SET NOCOUNT ON;
    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Request_Drugs]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Request_Drugs] @NID VARCHAR(25),@Names VARCHAR(50),@NUMBER INT
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO Drugs_Requests VAlUES(@NID,@Names,@NUMBER,GETDATE());
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[SelectDrugsData]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SelectDrugsData]
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT Names, Price, ImageLocation, Descriptions
	FROM Drugs_Medical_supplies 
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[Set_Rating]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Set_Rating] @NID VARCHAR(25),@rating INT
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	UPDATE Users SET Rating = @rating WHERE National_ID = @NID;
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END
GO
/****** Object:  StoredProcedure [dbo].[SET_STUDENT]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SET_STUDENT] @ID VARCHAR(9),@DName VARCHAR(50),@National_ID VARCHAR(25)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO Student VALUES(@ID,@DName,@National_ID)
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[SetEmergencyStateToOne]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SetEmergencyStateToOne] @NID varchar(25),@Time DateTime
AS
BEGIN
	UPDATE Emergency Set State=1
where NID=@NID and State=0 and Time=CAST(@Time as Datetime)
	SET NOCOUNT ON;

END

GO
/****** Object:  StoredProcedure [dbo].[SetRevisedSupportIT]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SetRevisedSupportIT] @NID varchar(25),@Comment varchar(300)
AS
BEGIN
UPDATE SUPPORT Set Approval_state=1
where National_ID=@NID and Approval_state is NULL and Comment=@Comment
SET NOCOUNT ON;

  
END
GO
/****** Object:  StoredProcedure [dbo].[SetUNRevisedSupportIT]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SetUNRevisedSupportIT] @NID varchar(25),@Comment varchar(300)
AS
BEGIN
UPDATE SUPPORT Set Approval_state=NULL
where National_ID=@NID and Approval_state=1 and Comment=@Comment
SET NOCOUNT ON;

  
END
GO
/****** Object:  StoredProcedure [dbo].[SexStat]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SexStat]
AS
BEGIN
	SELECT COUNT(*) as 'Count',Sex
	From Medical_excuses as M, Users as U
	Where M.National_ID_Users=U.National_ID
	--Where M.National_ID_Users=U.National_ID
	Group by Sex
	SET NOCOUNT ON;
END
GO
/****** Object:  StoredProcedure [dbo].[StudentTA]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[StudentTA]
AS
BEGIN
	SELECT COUNT(*) as 'CountR',Type_ as 'Position'
	From Medical_excuses as M, Users as U
	Where M.National_ID_Users=U.National_ID and (U.Type_='Student' or U.Type_='Teaching Stuff')
	--Where M.National_ID_Users=U.National_ID
	Group by Type_
	SET NOCOUNT ON;
END
GO
/****** Object:  StoredProcedure [dbo].[TeachingMedicalEcxcuses]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TeachingMedicalEcxcuses] @NID Varchar(25) 
AS
BEGIN
Select M.Starting_date,M.Ending_date,M.Symptom1,M.Symptom2,M.Symptom3,M.Symptom4,S.ID,S.DName,M.Approval_state,U.Name_ ,U.ImageLocation
From Medical_excuses as M, Student as S,Users as U
where M.National_ID_Users=S.National_ID and M.TANID=@NID and M.Approval_state  is not null and U.National_ID=S.National_ID
	
	SET NOCOUNT ON;

END
GO
/****** Object:  StoredProcedure [dbo].[UpdatePassword]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdatePassword] @NID VARCHAR(25),@password VARCHAR(50)
	-- TODO: Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	UPDATE Users SET passwords = @password WHERE National_ID = @NID
	SET NOCOUNT ON;

    -- TODO: Insert statements for procedure here
	--SELECT...

END

GO
/****** Object:  StoredProcedure [dbo].[UpdateUserState]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[UpdateUserState]  @Email varchar(40)
AS
BEGIN
UPDATE Users Set UserState=1
where E_mail=@Email and UserState is NULL
SET NOCOUNT ON;

  
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateUserStateDec]    Script Date: 6/14/2021 1:08:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[UpdateUserStateDec]  @Email varchar(40)
AS
BEGIN
UPDATE Users Set UserState=0
where E_mail=@Email and UserState is NULL
SET NOCOUNT ON;

  
END
GO
USE [master]
GO
ALTER DATABASE [ZClinic] SET  READ_WRITE 
GO
