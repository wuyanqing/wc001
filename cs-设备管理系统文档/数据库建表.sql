USE [sbgl ]
GO

/****** Object:  Table [dbo].[Bus_MaintainInfo]    Script Date: 06/30/2015 08:57:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Bus_MaintainInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[EquipmentCode] [nvarchar](20) NOT NULL,
	[Status] [char](1) NOT NULL,
	[MaintainCycle] [int] NOT NULL,
	[Maintaindate] [datetime] NOT NULL,
 CONSTRAINT [PK_Bus_MaintainInfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [sbgl ]
GO

/****** Object:  Table [dbo].[Bus_SpareInfo]    Script Date: 06/30/2015 08:58:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Bus_SpareInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Modelcode] [nvarchar](20) NOT NULL,
	[ModelNum] [int] NOT NULL,
	[Warningnum] [int] NOT NULL,
	[IsWarning] [char](1) NOT NULL,
	[Warninginterval] [int] NOT NULL,
 CONSTRAINT [PK_Bus_SpareInfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [sbgl ]
GO

/****** Object:  Table [dbo].[Bus_WarrantyInfo]    Script Date: 06/30/2015 08:58:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Bus_WarrantyInfo](
	[WarrantyId] [int] NOT NULL,
	[EquipmentCode] [nvarchar](30) NOT NULL,
	[Wstarttime] [datetime] NOT NULL,
	[WEndtime] [datetime] NOT NULL,
	[IsWarning] [char](1) NOT NULL,
 CONSTRAINT [PK_Bus_WarrantyInfo] PRIMARY KEY CLUSTERED 
(
	[WarrantyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Sys_EquipmentInfo]    Script Date: 06/30/2015 08:58:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sys_EquipmentInfo](
	[EquipmentCode] [nvarchar](30) NOT NULL,
	[Modelcode] [nvarchar](30) NULL,
	[Specifications] [nvarchar](30) NOT NULL,
	[Functions] [nvarchar](30) NOT NULL,
	[SuppliersCode] [nvarchar](30) NOT NULL,
	[Position] [nvarchar](30) NOT NULL,
	[Effect] [nvarchar](30) NULL,
	[IsWarranty] [char](1) NOT NULL,
	[IsUsed] [char](1) NOT NULL,
	[EquipmentBuyTime] [datetime] NOT NULL,
	[EquipmentUseTime] [datetime] NULL,
	[EquipmentLevel] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Sys_EquipmentInfo] PRIMARY KEY CLUSTERED 
(
	[EquipmentCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Sys_FaultInfo]    Script Date: 06/30/2015 09:00:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sys_FaultInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[Display] [nvarchar](50) NULL,
	[State] [char](1) NOT NULL,
	[Fstarttime] [datetime] NOT NULL,
	[FEndtime] [datetime] NOT NULL,
	[Summary] [nvarchar](50) NULL,
	[EquipmentCode] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Sys_FaultInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Sys_Fuction]    Script Date: 06/30/2015 09:01:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sys_Fuction](
	[FunctionID] [int] IDENTITY(1,1) NOT NULL,
	[FunctionName] [nvarchar](50) NOT NULL,
	[ControlName] [nvarchar](50) NOT NULL,
	[IndicateImage] [nvarchar](100) NULL,
	[Module_ModuleID] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Sys_Fuction] PRIMARY KEY CLUSTERED 
(
	[FunctionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Sys_Module]    Script Date: 06/30/2015 09:01:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sys_Module](
	[ModuleID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleName] [nvarchar](20) NOT NULL,
	[ShowOrder] [int] NOT NULL,
	[ModuleURL] [nvarchar](100) NOT NULL,
	[IndicateImage] [nvarchar](100) NULL,
	[DeskTopImage] [nvarchar](100) NULL,
	[ParentModule_ModuleID] [int] NOT NULL,
 CONSTRAINT [PK_Sys_Module] PRIMARY KEY CLUSTERED 
(
	[ModuleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Sys_Role]    Script Date: 06/30/2015 09:01:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sys_Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](20) NOT NULL,
	[IsLock] [char](1) NOT NULL,
	[Memo] [nvarchar](100) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Sys_RoleFunction]    Script Date: 06/30/2015 09:01:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sys_RoleFunction](
	[RoleFunctionID] [int] IDENTITY(1,1) NOT NULL,
	[IsActive] [char](1) NOT NULL,
	[Function_FunctionID] [int] NOT NULL,
 CONSTRAINT [PK_Sys_RoleFunction] PRIMARY KEY CLUSTERED 
(
	[RoleFunctionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Sys_RoleModule]    Script Date: 06/30/2015 09:02:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sys_RoleModule](
	[RoleModuleID] [int] IDENTITY(1,1) NOT NULL,
	[IsActive] [char](1) NULL,
	[Module_ModuleID] [int] NULL,
 CONSTRAINT [PK_Sys_RoleModule] PRIMARY KEY CLUSTERED 
(
	[RoleModuleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Sys_UserFunction]    Script Date: 06/30/2015 09:02:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sys_UserFunction](
	[UserFunctionID] [int] IDENTITY(1,1) NOT NULL,
	[IsActive] [char](1) NOT NULL,
	[Function_FunctionID] [int] NOT NULL,
 CONSTRAINT [PK_Sys_UserFunction] PRIMARY KEY CLUSTERED 
(
	[UserFunctionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Sys_UserInfo]    Script Date: 06/30/2015 09:02:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sys_UserInfo](
	[Usercode] [nvarchar](20) NOT NULL,
	[Loginname] [nvarchar](10) NOT NULL,
	[Username] [nvarchar](30) NOT NULL,
	[Userpwd] [nvarchar](30) NULL,
	[Telphone] [nvarchar](20) NULL,
	[Post] [nvarchar](50) NULL,
 CONSTRAINT [PK_数据表名称	Sys_UserInfo] PRIMARY KEY CLUSTERED 
(
	[Usercode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Sys_UserModule]    Script Date: 06/30/2015 09:03:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sys_UserModule](
	[UserModuleID] [int] IDENTITY(1,1) NOT NULL,
	[IsActive] [char](1) NOT NULL,
	[Module_ModuleID] [int] NOT NULL,
 CONSTRAINT [PK_Sys_UserModule] PRIMARY KEY CLUSTERED 
(
	[UserModuleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Sys_UserRole]    Script Date: 06/30/2015 09:03:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sys_UserRole](
	[UserRoleID] [int] IDENTITY(1,1) NOT NULL,
	[Role_RoleID] [int] NOT NULL,
	[User_UserID] [int] NOT NULL,
 CONSTRAINT [PK_Sys_UserRole] PRIMARY KEY CLUSTERED 
(
	[UserRoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Sys_WarningInfo]    Script Date: 06/30/2015 09:03:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sys_WarningInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[WarningWays] [nvarchar](20) NOT NULL,
	[Warningnum] [int] NOT NULL,
	[EquipmentCode] [nvarchar](30) NOT NULL,
	[Warningdate] [datetime] NOT NULL,
	[Warninginterval] [int] NOT NULL,
 CONSTRAINT [PK_Sys_WarningInfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [sbgl ]
GO

/****** Object:  Table [dbo].[Bus_RegistrationInfo]    Script Date: 07/03/2015 20:06:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Bus_RegistrationInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[billno] [varchar](50) NOT NULL,
	[carcode] [varchar](50) NULL,
	[phone] [varchar](50) NOT NULL,
	[daytime] [datetime] NOT NULL,
	[state] [varchar](10) NOT NULL,
	[memo] [varchar](50) NULL,
	[port] [varchar](10) NULL,
	[address] [varchar](50) NOT NULL,
	[isSubmit] [char](1) NOT NULL,
	[iswork] [char](1) NOT NULL,
 CONSTRAINT [PK_RegistrationInfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [sbgl ]
GO

/****** Object:  Table [dbo].[Bus_productAddress]    Script Date: 07/03/2015 20:07:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Bus_productAddress](
	[product_address_code] [varchar](50) NOT NULL,
	[product_address_name] [nchar](10) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO









