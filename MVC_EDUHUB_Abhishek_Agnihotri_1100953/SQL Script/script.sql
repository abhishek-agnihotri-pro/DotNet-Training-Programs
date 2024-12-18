USE [master]
GO
/****** Object:  Database [EDUHUBBB]    Script Date: 10/20/2024 5:29:15 PM ******/
CREATE DATABASE [EDUHUBBB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EDUHUBBB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\EDUHUBBB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EDUHUBBB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\EDUHUBBB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [EDUHUBBB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EDUHUBBB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EDUHUBBB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EDUHUBBB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EDUHUBBB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EDUHUBBB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EDUHUBBB] SET ARITHABORT OFF 
GO
ALTER DATABASE [EDUHUBBB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EDUHUBBB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EDUHUBBB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EDUHUBBB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EDUHUBBB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EDUHUBBB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EDUHUBBB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EDUHUBBB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EDUHUBBB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EDUHUBBB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EDUHUBBB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EDUHUBBB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EDUHUBBB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EDUHUBBB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EDUHUBBB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EDUHUBBB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EDUHUBBB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EDUHUBBB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EDUHUBBB] SET  MULTI_USER 
GO
ALTER DATABASE [EDUHUBBB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EDUHUBBB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EDUHUBBB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EDUHUBBB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EDUHUBBB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EDUHUBBB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [EDUHUBBB] SET QUERY_STORE = ON
GO
ALTER DATABASE [EDUHUBBB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [EDUHUBBB]
GO
/****** Object:  Table [dbo].[courses]    Script Date: 10/20/2024 5:29:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[courses](
	[courseId] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[description] [varchar](250) NULL,
	[courseStartDate] [datetime] NULL,
	[courseEndDate] [datetime] NULL,
	[userId] [int] NULL,
	[category] [varchar](50) NULL,
	[level] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[courseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enquiries]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enquiries](
	[enquiryId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NULL,
	[courseId] [int] NULL,
	[subject] [varchar](255) NULL,
	[message] [varchar](200) NULL,
	[enquiryDate] [datetime] NULL,
	[status] [varchar](50) NULL,
	[response] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[enquiryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[enrollments]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[enrollments](
	[enrollmentId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NULL,
	[courseId] [int] NULL,
	[enrollmentDate] [datetime] NULL,
	[status] [varchar](70) NULL,
PRIMARY KEY CLUSTERED 
(
	[enrollmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedbacks]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedbacks](
	[feedbackId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NULL,
	[feedback] [text] NULL,
	[date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[feedbackId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materials]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materials](
	[materialId] [int] IDENTITY(1,1) NOT NULL,
	[courseId] [int] NULL,
	[title] [varchar](255) NULL,
	[description] [varchar](100) NULL,
	[URL] [varchar](255) NULL,
	[uploadDate] [date] NULL,
	[contentType] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[materialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[quantity] [int] NULL,
	[price] [decimal](10, 2) NULL,
	[active] [bit] NULL,
	[expire] [date] NULL,
	[description] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[students]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[students](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [varchar](70) NULL,
	[lastname] [varchar](60) NULL,
	[doa] [date] NULL,
	[dob] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[role] [varchar](20) NOT NULL,
	[email] [varchar](100) NULL,
	[mobile_number] [varchar](20) NULL,
	[profileImage] [varchar](255) NULL,
	[FullName] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[courses] ON 

INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (1, N'Introduction to Python', N'Learn Python basics', CAST(N'2024-09-01T00:00:00.000' AS DateTime), CAST(N'2024-12-15T00:00:00.000' AS DateTime), 19, N'Programming', N'Beginner')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (2, N'Advanced Machine Learning', N'Deep dive into ML', CAST(N'2024-09-15T00:00:00.000' AS DateTime), CAST(N'2025-01-30T00:00:00.000' AS DateTime), 4, N'Data Science', N'Advanced')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (3, N'Web Development Fundamentals', N'HTML, CSS, and JavaScript', CAST(N'2024-10-01T00:00:00.000' AS DateTime), CAST(N'2024-12-31T00:00:00.000' AS DateTime), 2, N'Web Development', N'Beginner')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (4, N'Data Structures and Algorithms', N'Core CS concept', CAST(N'2024-09-15T00:00:00.000' AS DateTime), CAST(N'2025-02-28T00:00:00.000' AS DateTime), 19, N'Computer Science', N'Intermediate')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (5, N'Digital Marketing Basics', N'Introduction to digital marketing', CAST(N'2024-09-01T00:00:00.000' AS DateTime), CAST(N'2024-11-30T00:00:00.000' AS DateTime), 6, N'Marketing', N'Beginner')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (6, N'Artificial Intelligence Ethics', N'Ethical considerations in AI', CAST(N'2024-10-15T00:00:00.000' AS DateTime), CAST(N'2025-01-15T00:00:00.000' AS DateTime), 19, N'Ethics', N'Intermediate')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (7, N'Mobile App Development', N'Build apps for iOS and Android', CAST(N'2024-11-01T00:00:00.000' AS DateTime), CAST(N'2025-03-31T00:00:00.000' AS DateTime), 10, N'Mobile Development', N'Intermediate')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (8, N'Cybersecurity Fundamentals', N'Basic principles of information security', CAST(N'2024-09-15T00:00:00.000' AS DateTime), CAST(N'2024-12-15T00:00:00.000' AS DateTime), 19, N'Cybersecurity', N'Beginner')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (9, N'Cloud Computing Essentials', N'Introduction to cloud technologies', CAST(N'2024-10-01T00:00:00.000' AS DateTime), CAST(N'2025-01-31T00:00:00.000' AS DateTime), 8, N'Cloud Computing', N'Intermediate')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (10, N'Blockchain Technology', N'Understanding blockchain and cryptocurrencies', CAST(N'2024-11-15T00:00:00.000' AS DateTime), CAST(N'2025-03-15T00:00:00.000' AS DateTime), 19, N'Blockchain', N'Advanced')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (11, N'HEY', N'HEY', CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2024-01-01T00:00:00.000' AS DateTime), 5, N'HEY', N'HEY')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (12, N'hello', N'hello', CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2024-01-01T00:00:00.000' AS DateTime), 3, N'hello', N'hello')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (13, N'Hello', N'Hello', CAST(N'2024-02-02T00:00:00.000' AS DateTime), CAST(N'2024-02-02T00:00:00.000' AS DateTime), 10, N'Hello', N'easy')
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (15, N'sdf', N'sdf', CAST(N'2024-10-21T12:09:00.000' AS DateTime), CAST(N'2024-10-06T12:09:00.000' AS DateTime), 19, NULL, NULL)
INSERT [dbo].[courses] ([courseId], [title], [description], [courseStartDate], [courseEndDate], [userId], [category], [level]) VALUES (17, N'17Oct 2024', N'17Oct 2024', CAST(N'2024-10-14T18:10:00.000' AS DateTime), CAST(N'2024-10-22T18:10:00.000' AS DateTime), 19, NULL, N'Advanced')
SET IDENTITY_INSERT [dbo].[courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Enquiries] ON 

INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (1, 1, 1, N'SQL Course Question', N'Is prior programming experience needed?', CAST(N'2024-01-16T10:30:00.000' AS DateTime), N'Answered', N'No prior experience needed.')
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (2, 2, 2, N'Python Course Difficulty', N'How challenging is the Python course?', CAST(N'2024-02-05T14:45:00.000' AS DateTime), N'Pending', NULL)
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (3, 3, 3, N'ML Prerequisites', N'What math knowledge is required for ML?', CAST(N'2024-03-10T09:15:00.000' AS DateTime), N'Answered', N'Basic calculus and linear algebra recommended.')
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (4, 4, 4, N'Web Dev Tools', N'Which IDE do you recommend for web development?', CAST(N'2024-04-05T16:20:00.000' AS DateTime), N'In Progress', N'We recommend Visual Studio Code.')
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (5, 5, 5, N'Data Viz Software', N'Do we need to purchase any software?', CAST(N'2024-05-05T11:00:00.000' AS DateTime), N'Pending', NULL)
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (6, 6, NULL, N'Course Recommendations', N'Which course is best for a beginner?', CAST(N'2024-06-01T13:30:00.000' AS DateTime), N'Answered', N'We suggest starting with Python Basics.')
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (7, 7, 1, N'SQL Course Duration', N'How long does it take to complete the SQL course?', CAST(N'2024-06-15T10:00:00.000' AS DateTime), N'Pending', NULL)
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (8, 8, 2, N'Python Project Help', N'Can I get help with my Python project?', CAST(N'2024-07-01T15:45:00.000' AS DateTime), N'Answered', N'Yes, we offer project support.')
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (9, 9, 3, N'Machine Learning Job Prospects', N'What are the job opportunities after this course?', CAST(N'2024-07-10T09:30:00.000' AS DateTime), N'Pending', N'Not Null')
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (10, 10, 4, N'Web Dev Course Update', N'When will the course content be updated?', CAST(N'2024-08-01T14:00:00.000' AS DateTime), N'Answere', N'The course will be updated next month.')
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (11, 1, 1, N'fsd', N'1', CAST(N'2024-09-09T14:25:35.210' AS DateTime), N'sdf', N'sdfsd')
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (12, 22, 1, N'hkj', N'fasfdss', CAST(N'2024-10-14T16:22:51.430' AS DateTime), N'Open', NULL)
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (13, 22, 7, N'fdfd', N'fdsafd', CAST(N'2024-10-14T16:26:24.197' AS DateTime), N'Open', NULL)
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (14, 22, 10, N'eeeeee', N'fffff', CAST(N'2024-10-14T16:30:00.597' AS DateTime), N'Open', NULL)
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (15, 22, 5, N'fddsfds', N'fsdfdsf', CAST(N'2024-10-14T16:31:49.687' AS DateTime), N'Open', NULL)
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (16, 22, 12, N'aaaaaaaa', N'bbbbbb', CAST(N'2024-10-14T16:32:02.020' AS DateTime), N'Open', NULL)
INSERT [dbo].[Enquiries] ([enquiryId], [userId], [courseId], [subject], [message], [enquiryDate], [status], [response]) VALUES (17, 22, 1, N'Coding', N'Is it cover graph topics?', CAST(N'2024-10-16T11:32:57.143' AS DateTime), N'Open', NULL)
SET IDENTITY_INSERT [dbo].[Enquiries] OFF
GO
SET IDENTITY_INSERT [dbo].[enrollments] ON 

INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (1, 19, 6, CAST(N'2024-01-15T09:30:00.000' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (2, 22, 2, CAST(N'2024-01-20T14:45:00.000' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (3, 19, 8, CAST(N'2024-02-01T10:00:00.000' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (4, 19, 4, CAST(N'2024-02-10T16:30:00.000' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (5, 19, 10, CAST(N'2024-03-01T11:15:00.000' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (6, 6, 1, CAST(N'2024-03-15T13:00:00.000' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (7, 7, 2, CAST(N'2024-04-01T09:45:00.000' AS DateTime), N'Rejected')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (8, 8, 3, CAST(N'2024-04-10T15:30:00.000' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (9, 9, 4, CAST(N'2024-05-01T10:30:00.000' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (10, 22, 5, CAST(N'2024-05-15T14:00:00.000' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (11, 19, 15, CAST(N'2021-01-01T00:00:00.000' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (12, 22, 11, CAST(N'2024-10-14T15:44:29.273' AS DateTime), N'Pending')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (13, 22, 1, CAST(N'2024-10-14T15:58:06.250' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (14, 22, 10, CAST(N'2024-10-14T15:59:53.853' AS DateTime), N'Rejected')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (15, 22, 6, CAST(N'2024-10-14T16:00:10.320' AS DateTime), N'Pending')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (16, 22, 10, CAST(N'2024-10-16T16:55:32.737' AS DateTime), N'Pending')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (17, 22, 1, CAST(N'2024-10-16T17:04:19.190' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (18, 22, 8, CAST(N'2024-10-16T17:04:28.383' AS DateTime), N'Accepted')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (19, 22, 6, CAST(N'2024-10-16T17:04:45.873' AS DateTime), N'Pending')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (20, 19, 8, CAST(N'2024-10-16T17:07:27.243' AS DateTime), N'Pending')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (21, 19, 1, CAST(N'2024-10-16T17:10:52.650' AS DateTime), N'Pending')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (22, 19, 8, CAST(N'2024-10-16T17:11:08.147' AS DateTime), N'Pending')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (23, 19, 4, CAST(N'2024-10-16T17:11:18.173' AS DateTime), N'Pending')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (24, 19, 6, CAST(N'2024-10-16T17:11:39.177' AS DateTime), N'Pending')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (25, 19, 12, CAST(N'2024-10-16T17:11:48.323' AS DateTime), N'Pending')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (26, 22, 4, CAST(N'2024-10-17T10:54:58.107' AS DateTime), N'Pending')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (27, 29, 10, CAST(N'2024-10-17T17:29:44.653' AS DateTime), N'Pending')
INSERT [dbo].[enrollments] ([enrollmentId], [userId], [courseId], [enrollmentDate], [status]) VALUES (28, 22, 8, CAST(N'2024-10-20T13:06:00.473' AS DateTime), N'Pending')
SET IDENTITY_INSERT [dbo].[enrollments] OFF
GO
SET IDENTITY_INSERT [dbo].[Feedbacks] ON 

INSERT [dbo].[Feedbacks] ([feedbackId], [userId], [feedback], [date]) VALUES (1, 1, N'The SQL course was very informative and well-structured.', CAST(N'2024-02-01' AS Date))
INSERT [dbo].[Feedbacks] ([feedbackId], [userId], [feedback], [date]) VALUES (2, 2, N'I found the Python basics easy to follow. Great for beginners!', CAST(N'2024-03-15' AS Date))
INSERT [dbo].[Feedbacks] ([feedbackId], [userId], [feedback], [date]) VALUES (3, 3, N'The Machine Learning course was challenging but rewarding.', CAST(N'2024-04-20' AS Date))
INSERT [dbo].[Feedbacks] ([feedbackId], [userId], [feedback], [date]) VALUES (4, 4, N'Web Development basics helped me kickstart my project.', CAST(N'2024-05-10' AS Date))
INSERT [dbo].[Feedbacks] ([feedbackId], [userId], [feedback], [date]) VALUES (5, 5, N'Data Visualization techniques were eye-opening. Loved the course!', CAST(N'2024-06-05' AS Date))
INSERT [dbo].[Feedbacks] ([feedbackId], [userId], [feedback], [date]) VALUES (6, 6, N'The SQL advanced queries section could use more examples.', CAST(N'2024-06-20' AS Date))
INSERT [dbo].[Feedbacks] ([feedbackId], [userId], [feedback], [date]) VALUES (7, 7, N'Python Data Structures course was comprehensive. Highly recommend!', CAST(N'2024-07-15' AS Date))
INSERT [dbo].[Feedbacks] ([feedbackId], [userId], [feedback], [date]) VALUES (8, 8, N'Neural Networks module was a bit too fast-paced for me.', CAST(N'2024-08-01' AS Date))
INSERT [dbo].[Feedbacks] ([feedbackId], [userId], [feedback], [date]) VALUES (9, 9, N'Responsive Design course gave me skills I use daily now.', CAST(N'2024-08-15' AS Date))
INSERT [dbo].[Feedbacks] ([feedbackId], [userId], [feedback], [date]) VALUES (10, 10, N'Dashboard Design course was practical and immediately useful.', CAST(N'2024-09-01' AS Date))
INSERT [dbo].[Feedbacks] ([feedbackId], [userId], [feedback], [date]) VALUES (11, 1, N'sdfdsf', CAST(N'2024-09-09' AS Date))
SET IDENTITY_INSERT [dbo].[Feedbacks] OFF
GO
SET IDENTITY_INSERT [dbo].[Materials] ON 

INSERT [dbo].[Materials] ([materialId], [courseId], [title], [description], [URL], [uploadDate], [contentType]) VALUES (1, 1, N'Introduction to SQL', N'Basic SQL concepts', N'https://example.com/sql-intro', CAST(N'2024-01-15' AS Date), N'Video')
INSERT [dbo].[Materials] ([materialId], [courseId], [title], [description], [URL], [uploadDate], [contentType]) VALUES (2, 1, N'Advanced SQL Queries', N'Complex SQL queries explained', N'https://example.com/advanced-sql', CAST(N'2024-01-20' AS Date), N'PDF')
INSERT [dbo].[Materials] ([materialId], [courseId], [title], [description], [URL], [uploadDate], [contentType]) VALUES (3, 2, N'Python Basics', N'Getting started with Python', N'https://example.com/python-basics', CAST(N'2024-02-01' AS Date), N'Interactive')
INSERT [dbo].[Materials] ([materialId], [courseId], [title], [description], [URL], [uploadDate], [contentType]) VALUES (4, 2, N'Python Data Structures', N'Lists, tuples, and dictionaries', N'https://example.com/python-data-structures', CAST(N'2024-02-10' AS Date), N'Video')
INSERT [dbo].[Materials] ([materialId], [courseId], [title], [description], [URL], [uploadDate], [contentType]) VALUES (5, 3, N'Machine Learning Fundamentals', N'Introduction to ML concepts', N'https://example.com/ml-fundamentals', CAST(N'2024-03-01' AS Date), N'PDF')
INSERT [dbo].[Materials] ([materialId], [courseId], [title], [description], [URL], [uploadDate], [contentType]) VALUES (6, 3, N'Neural Networks', N'Deep dive into neural networks', N'https://example.com/neural-networks', CAST(N'2024-03-15' AS Date), N'Interactive')
INSERT [dbo].[Materials] ([materialId], [courseId], [title], [description], [URL], [uploadDate], [contentType]) VALUES (7, 4, N'Web Development Basics', N'HTML, CSS, and JavaScript', N'https://example.com/web-dev-basics', CAST(N'2024-04-01' AS Date), N'Video')
INSERT [dbo].[Materials] ([materialId], [courseId], [title], [description], [URL], [uploadDate], [contentType]) VALUES (8, 4, N'Responsive Design', N'Creating responsive websites', N'https://example.com/responsive-design', CAST(N'2024-04-10' AS Date), N'PDF')
INSERT [dbo].[Materials] ([materialId], [courseId], [title], [description], [URL], [uploadDate], [contentType]) VALUES (9, 5, N'Data Visualization', N'Techniques for effective data viz', N'https://example.com/data-viz', CAST(N'2024-05-01' AS Date), N'Interactive')
INSERT [dbo].[Materials] ([materialId], [courseId], [title], [description], [URL], [uploadDate], [contentType]) VALUES (10, 5, N'Dashboard Design', N'Creating impactful dashboards', N'https://example.com/dashboard-design', CAST(N'2024-05-15' AS Date), N'Video')
INSERT [dbo].[Materials] ([materialId], [courseId], [title], [description], [URL], [uploadDate], [contentType]) VALUES (11, 1, N'hello', N'hello', N'hello.com', CAST(N'2024-09-09' AS Date), N'hellopdf')
SET IDENTITY_INSERT [dbo].[Materials] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (2, N'Smartphone', 100, CAST(599.99 AS Decimal(10, 2)), 0, CAST(N'2025-06-30' AS Date), N'Latest model with 5G capability')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (3, N'Wireless Earbuds', 200, CAST(129.99 AS Decimal(10, 2)), 0, CAST(N'2026-03-15' AS Date), N'Noise-cancelling bluetooth earbuds')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (4, N'Smart Watch', 75, CAST(249.99 AS Decimal(10, 2)), 1, CAST(N'2025-09-30' AS Date), N'Fitness tracker with heart rate monitor')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (5, N'4K TV', 30, CAST(799.99 AS Decimal(10, 2)), 1, CAST(N'2026-01-31' AS Date), N'55-inch 4K Smart TV')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (6, N'Gaming Console', 40, CAST(499.99 AS Decimal(10, 2)), 1, CAST(N'2025-11-30' AS Date), N'Next-gen gaming console')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (7, N'Tablet', 60, CAST(349.99 AS Decimal(10, 2)), 1, CAST(N'2025-08-31' AS Date), N'10-inch tablet with stylus support')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (8, N'Bluetooth Speaker', 150, CAST(79.99 AS Decimal(10, 2)), 1, CAST(N'2026-02-28' AS Date), N'Waterproof portable speaker')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (9, N'Digital Camera', 25, CAST(699.99 AS Decimal(10, 2)), 1, CAST(N'2025-10-31' AS Date), N'Mirrorless camera with 4K video')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (10, N'Electric Toothbrush', 100, CAST(59.99 AS Decimal(10, 2)), 1, CAST(N'2026-04-30' AS Date), N'Rechargeable with multiple modes')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (11, N'Coffee Maker', 80, CAST(89.99 AS Decimal(10, 2)), 1, CAST(N'2025-07-31' AS Date), N'Programmable drip coffee maker')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (12, N'Fitness Tracker', 120, CAST(49.99 AS Decimal(10, 2)), 1, CAST(N'2026-05-31' AS Date), N'Basic fitness and sleep tracker')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (13, N'Wireless Mouse', 200, CAST(29.99 AS Decimal(10, 2)), 1, CAST(N'2026-06-30' AS Date), N'Ergonomic wireless mouse')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (14, N'External Hard Drive', 70, CAST(119.99 AS Decimal(10, 2)), 1, CAST(N'2025-12-15' AS Date), N'2TB portable hard drive')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (15, N'Robot Vacuum', 40, CAST(299.99 AS Decimal(10, 2)), 1, CAST(N'2025-11-15' AS Date), N'Smart robot vacuum with mapping')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (16, N'Air Purifier', 60, CAST(179.99 AS Decimal(10, 2)), 1, CAST(N'2026-01-15' AS Date), N'HEPA air purifier for large rooms')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (17, N'Gaming Keyboard', 90, CAST(149.99 AS Decimal(10, 2)), 1, CAST(N'2026-03-31' AS Date), N'Mechanical gaming keyboard with RGB')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (18, N'Wireless Charger', 150, CAST(39.99 AS Decimal(10, 2)), 1, CAST(N'2026-04-15' AS Date), N'Fast wireless charging pad')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (19, N'Smart Thermostat', 50, CAST(199.99 AS Decimal(10, 2)), 1, CAST(N'2025-10-15' AS Date), N'Wi-Fi enabled smart thermostat')
INSERT [dbo].[products] ([id], [name], [quantity], [price], [active], [expire], [description]) VALUES (20, N'Portable Projector', 30, CAST(399.99 AS Decimal(10, 2)), 1, CAST(N'2025-09-15' AS Date), N'Mini HD projector with built-in speaker')
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[students] ON 

INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (1, N'John', N'Doe', CAST(N'2023-09-15' AS Date), CAST(N'2000-05-10' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (2, N'Jane', N'Smith', CAST(N'2023-08-22' AS Date), CAST(N'2001-03-18' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (3, N'Michael', N'Johnson', CAST(N'2023-07-30' AS Date), CAST(N'1999-11-25' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (5, N'David', N'Wilson', CAST(N'2023-08-05' AS Date), CAST(N'2000-09-30' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (6, N'Sarah', N'Taylor', CAST(N'2023-09-10' AS Date), CAST(N'2001-06-14' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (7, N'Christopher', N'Anderson', CAST(N'2023-07-18' AS Date), CAST(N'1999-04-22' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (8, N'Jessica', N'Thomas', CAST(N'2023-08-28' AS Date), CAST(N'2002-02-11' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (9, N'Matthew', N'Jackson', CAST(N'2023-09-05' AS Date), CAST(N'2000-12-03' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (10, N'Olivia', N'White', CAST(N'2023-07-25' AS Date), CAST(N'2001-08-19' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (11, N'Daniel', N'Harris', CAST(N'2023-08-12' AS Date), CAST(N'1999-10-08' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (12, N'Sophia', N'Martin', CAST(N'2023-09-18' AS Date), CAST(N'2002-03-27' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (13, N'Andrew', N'Thompson', CAST(N'2023-07-22' AS Date), CAST(N'2000-07-15' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (14, N'Emma', N'Garcia', CAST(N'2023-08-30' AS Date), CAST(N'2001-01-29' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (15, N'William', N'Martinez', CAST(N'2023-09-08' AS Date), CAST(N'1999-06-05' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (16, N'Ava', N'Robinson', CAST(N'2023-07-28' AS Date), CAST(N'2002-04-12' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (17, N'James', N'Clark', CAST(N'2023-08-17' AS Date), CAST(N'2000-11-20' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (18, N'Isabella', N'Rodriguez', CAST(N'2023-09-03' AS Date), CAST(N'2001-09-02' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (19, N'Benjamin', N'Lewis', CAST(N'2023-07-20' AS Date), CAST(N'1999-12-16' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (20, N'Mia', N'Lee', CAST(N'2023-08-25' AS Date), CAST(N'2002-05-23' AS Date))
INSERT [dbo].[students] ([id], [firstname], [lastname], [doa], [dob]) VALUES (22, N'Abhishek', N'string', CAST(N'2024-10-09' AS Date), CAST(N'2024-10-09' AS Date))
SET IDENTITY_INSERT [dbo].[students] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (1, N'abhi_agni', N'xyz', N'admin', N'abhishek2@gmail.com', N'9098080785', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (2, N'utkar23', N'u', N'Educator', N'u@gmail.com', N'9098080785', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (3, N'abih123', N'xyz', N'user', N'abhihek@gmail.com', N'9098080785', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (4, N'atuuul', N'xyz', N'user', N'abhi12ek@gmail.com', N'9098080785', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (5, N'atul23', N'xyz', N'user', N'ab12hiek@gmail.com', N'9098080785', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (6, N'atuuuul00', N'xyz', N'user', N'abhis213k@gmail.com', N'9098080785', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (7, N'atuuuuuul', N'xyz', N'user', N'abhi123@gmail.com', N'9098080785', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (8, N'adsfbhi', N'xyz', N'user', N'abhishek323@gmail.com', N'9098080785', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (9, N'989abhi', N'xyz', N'user', N'abh345ik@gmail.com', N'9098080785', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (10, N'babycoder', N'xyz', N'user', N'ramramramram', N'ramramramram', N'ramramramram', NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (11, N'codercoding', N'xyz', N'user', N'a4ishe6k@gmail.com', N'9098080785', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (12, N'dsfsd', N'sadfs', N'sadf', N'sadf', NULL, NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (14, N'werew', N'erwer', N'rwerwer', N'werwer', NULL, NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (15, N'Abhishek Agni', N'1234', N'AdminOfAdmin', N'yash.com', N'everyone knows', N'understood', NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (16, N'adf', N'daf', N'adsf', N'adsf', N'asdf', N'adsf', NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (17, N'fasdfdserw', N'fsadf', N'Student', N'rwefsdsfge', N'234234234', N'sdfsdf', NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (19, N'Abhishek_Agnihotri', N'asdf', N'Educator', N'dsf@gmail.com', N'1234567890', N'dsfa.com', NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (20, N'helllo', N'xyz', N'Student', N'hello@gmail.com', N'1234567890', N'dabc.com', NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (22, N'abhi_student', N'a', N'Student', N'as@gmail.com', N'1234567890', N'', NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (23, N'abhisheknewuser', N'a', N'Student', N'b@gmail.com', N'9098080785', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (24, N'CheckRegister', N'a', N'Student', N'aa@gmail.com', N'1234566778', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (25, N'aa', N'a', N'Student', N'q@gmail.com', N'1234567890', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (26, N'a', N'a', N'Student', N'a@gmail.com', N'1234567890', NULL, NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (29, N'abc', N'a', N'Student', N'abb@gmail.com', N'1234567890', N'5b553e8b-860b-4c57-870d-0ec987119a39_20240724_201343new.jpg', NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (30, N'Abhishek_Educator', N'a', N'Educator', N'abhisheka@gmail.com', N'1234567890', N'f0dda773-ac06-4b57-938d-7ecc69a6e728_WIN_20240617_15_35_38_Pro.jpg', NULL)
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (31, N'new20', N'a', N'Student', N'new20@gmail.com', N'1234567890', N'6cab2fc2-f926-487c-81fb-e59177da4e9b_image.png', N'new20')
INSERT [dbo].[users] ([userId], [username], [password], [role], [email], [mobile_number], [profileImage], [FullName]) VALUES (33, N'neew20', N'a', N'Student', N'n20@gmail.com', N'1234567890', N'abc967f5-15b0-42ec-b60c-88a724bf56b4_20240724_201343new.jpg', N'nfullname')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__users__F3DBC572AC27B4B2]    Script Date: 10/20/2024 5:29:16 PM ******/
ALTER TABLE [dbo].[users] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetAcceptedEnrollmentByName]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAcceptedEnrollmentByName]
(@id int)
AS
BEGIN
  SELECT 
    e.EnrollmentId as EnrollmentId,
    e.UserId as UserId,
    e.CourseId as CourseId,
    e.EnrollmentDate as EnrollmentDate,
    e.Status as Status,
    u.UserName as UserName,
    c.title AS CourseName
FROM 
    Enrollments e
INNER JOIN 
    [Users] u ON e.UserId = u.UserId
INNER JOIN 
    Courses c ON e.CourseId = c.courseId
	where c.userId = @id and e.status='Accepted';
END
GO
/****** Object:  StoredProcedure [dbo].[GetCoursesByUserId]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCoursesByUserId] 
(@id int)
AS
BEGIN
	select * from courses where courseId = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AddCourse]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_AddCourse]
(
@title varchar(50),
@description varchar(250),
@courseStartDate datetime,
@courseEndDate datetime,
@userId int,
@category varchar(50),
@level varchar(40)
)
AS
BEGIN
	insert into courses(title,description,courseStartDate,courseEndDate,userId,category,level)
	values(@title,@description,@courseStartDate,@courseEndDate,@userId,@category,@level)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllCourses]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetAllCourses] 
AS
BEGIN
	SELECT * from Courses;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetCoursesByUserId]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetCoursesByUserId] 
(@id int)
AS
BEGIN
	select * from courses where userId = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetEnquiryByCourseNameStudent]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetEnquiryByCourseNameStudent]
(@id int)
AS
BEGIN
SELECT 
    e.EnquiryId,
    e.CourseId,
    e.UserId,
    e.EnquiryDate,
    e.Subject,
    e.Message,
    e.Status,
    e.Response,
    u.UserName,
    c.title AS CourseName
FROM 
    Enquiries e
INNER JOIN 
    Users u ON e.UserId = u.UserId
INNER JOIN 
    Courses c ON e.CourseId = c.courseId
	where u.userId = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetEnquiryByNamesEducator]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetEnquiryByNamesEducator]
(@id int)
AS
BEGIN
SELECT 
    e.EnquiryId,
    e.CourseId,
    e.UserId,
    e.EnquiryDate,
    e.Subject,
    e.Message,
    e.Status,
    e.Response,
    u.UserName,
    c.title AS CourseName
FROM 
    Enquiries e
INNER JOIN 
    Users u ON e.UserId = u.UserId
INNER JOIN 
    Courses c ON e.CourseId = c.courseId
	where c.courseId = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetEnrollmentByName]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetEnrollmentByName]
(@id int)
AS
BEGIN
  SELECT 
    e.EnrollmentId as EnrollmentId,
    e.UserId as UserId,
    e.CourseId as CourseId,
    e.EnrollmentDate as EnrollmentDate,
    e.Status as Status,
    u.UserName as UserName,
    c.title AS CourseName
FROM 
    Enrollments e
INNER JOIN 
    [Users] u ON e.UserId = u.UserId
INNER JOIN 
    Courses c ON e.CourseId = c.courseId
	where c.userId = @id and e.status='Pending';
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetFeedbackByName]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetFeedbackByName] 
AS
BEGIN
	SELECT 
    f.FeedbackId as FeedbackId,
    f.UserId as UserId,
    f.Date as Date,
    f.feedback as feedback,
    u.UserName as UserName
FROM 
    Feedbacks f
INNER JOIN 
    Users u ON f.UserId = u.UserId;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetMaterialByCourseId]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetMaterialByCourseId] 
	(@id int)
AS
BEGIN
	select m.materialId as MaterialId, m.description as description, m.contentType as ContentType, m.title as Title, m.URL as URL, m.uploadDate as UploadDate, c.title as CourseTitle from Materials m inner join courses c on m.courseId = c.courseId where c.courseId = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetStudentEnrollmentById]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetStudentEnrollmentById]
(@id int)
AS
BEGIN
	SELECT e.EnrollmentId,c.CourseId, c.title as CourseName,e.EnrollmentDate,e.Status from Enrollments e join Courses c on c.courseId=e.courseId
	where e.userId=@id;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MyCourseViewModel]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_MyCourseViewModel]
(@id int)
AS
BEGIN
SELECT 
    c.courseId,
    c.title,
    c.description,
    c.courseStartDate,
    c.courseEndDate,
    c.userId,
    c.category,
    c.level,
    u.UserName,
    c.title AS CourseName
FROM 
    Courses c
INNER JOIN 
    Users u ON c.userId = u.UserId
	where u.UserId = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateCourse]    Script Date: 10/20/2024 5:29:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_UpdateCourse] 
(
@title varchar(50),
@description varchar(250),
@courseStartDate datetime,
@courseEndDate datetime,
@userId int,
@category varchar(50),
@level varchar(40),
@courseId int
)
AS
BEGIN
Update courses set title=@title,description=@description,courseStartDate=@courseStartDate,courseEndDate=@courseEndDate,
userId=@userId,category=@category,level=@level where courseId=@courseId
END
GO
USE [master]
GO
ALTER DATABASE [EDUHUBBB] SET  READ_WRITE 
GO
