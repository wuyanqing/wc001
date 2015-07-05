USE [car_delivery ]
GO

/****** Object:  Table [dbo].[Bus_productAddress]    Script Date: 07/04/2015 10:27:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Bus_productAddress](
	[address_code] [varchar](50) NOT NULL,
	[address_name] [varchar](50) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

GO

/****** Object:  Table [dbo].[Sys_parameter]    Script Date: 07/04/2015 10:28:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sys_parameter](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[parameter_name] [varchar](50) NOT NULL,
	[parameter_value] [varchar](50) NOT NULL,
	[memo] [varchar](50) NULL,
 CONSTRAINT [PK_auth_system_parameter] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

GO

/****** Object:  Table [dbo].[Bus_RegistrationInfo]    Script Date: 07/04/2015 10:28:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Bus_RegistrationInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[billno] [varchar](50) NOT NULL,
	[carcode] [varchar](50) NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[daytime] [datetime] NOT NULL,
	[state] [varchar](10) NULL,
	[memo] [varchar](50) NULL,
	[port] [varchar](10) NULL,
	[address_code] [varchar](50) NOT NULL,
	[workstate] [char](1) NOT NULL,
 CONSTRAINT [PK_RegistrationInfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO