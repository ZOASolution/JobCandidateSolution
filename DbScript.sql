CREATE DATABASE [JobCandidateDB]
Go

USE [JobCandidateDB]
GO


CREATE TABLE [dbo].[Candidates](
	[ID] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](250) NOT NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[LinkedInProfile] [nvarchar](50) NULL,
	[GithubProfile] [nvarchar](50) NULL,
	[PreferedTime] [time](7) NULL,
	[Comments] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Candidates] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

