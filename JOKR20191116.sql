USE [aspnet-JOKRStore]
GO
/****** Object:  Table [dbo].[SysReq]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysReq](
	[Id] [uniqueidentifier] NOT NULL,
	[ram] [bigint] NOT NULL,
	[storage] [bigint] NOT NULL,
	[directx] [real] NOT NULL,
	[opengl] [real] NOT NULL,
	[vulkan] [real] NOT NULL,
 CONSTRAINT [PK_SysReq] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SysReq] ([Id], [ram], [storage], [directx], [opengl], [vulkan]) VALUES (N'b14db6e3-8a03-4460-8702-e42a019a19f2', 2048, 0, 10, 0, 0)
INSERT [dbo].[SysReq] ([Id], [ram], [storage], [directx], [opengl], [vulkan]) VALUES (N'9bffef14-63ff-4680-883f-f63c4ad0b99a', 1024, 12288, 9, 0, 0)
/****** Object:  Table [dbo].[Properties]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Properties](
	[Id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NULL,
	[type] [int] NOT NULL,
 CONSTRAINT [PK_Properties] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'b39d35ab-18d2-41c9-a8f9-514ffad80274', N'Logical/Puzzle', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'7522adc8-aed8-4103-9556-57a966d614e6', N'RPG', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'19124832-c571-4b5c-bf84-5846eb5b380f', N'MOBA', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'4f39c93d-7d78-47dc-825d-6965d4859124', N'Coop', 1)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'a8cdaeb0-a4f6-4d36-97a9-72fe5803b304', N'Singleplayer', 1)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'ecf777b7-ae61-4f8b-abdf-8a0b3dddde72', N'Platform (3D)', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'24c091c7-1ec8-4387-9b19-8ca312e03fba', N'Multiplayer', 1)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'45fbeda7-6a13-497e-b414-95a2aeb03bc4', N'Adventure', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'ab29f141-55e1-461a-b6a8-9dfe1114461f', N'Sandbox', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'cc71be49-598e-4254-96f9-a6b63a73d21c', N'Racing (Simulator)', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'0c12c99d-55d8-4ac7-ba4a-a8768b6a0694', N'Local/SplitScreen', 1)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'904ac35b-a43d-4ccc-89f5-ad7a5fda64f0', N'FPS', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'6f3d7fb0-a76e-4d5a-9ed3-b33c5ce74167', N'Strategy', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'49d0b2fe-ac90-466c-abab-bc57f6cbb515', N'Point & Click', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'a8e5b7b7-217b-4460-a770-c54285eff4e3', N'Racing (Arcade)', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'2a046500-1dea-422e-a2d0-d8805c256f2b', N'Platform (2D)', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'62d1ff2d-1056-4269-a44f-e67addb09216', N'MMO', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'10239528-214a-4c21-b8d8-e722469f1230', N'TPS', 0)
INSERT [dbo].[Properties] ([Id], [name], [type]) VALUES (N'cfdb12a8-5512-43eb-a7c9-f6987d5155f2', N'Action', 0)
/****** Object:  Table [dbo].[OSes]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OSes](
	[Id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NULL,
	[group] [int] NOT NULL,
	[major_ver] [int] NOT NULL,
	[minor_ver] [int] NOT NULL,
 CONSTRAINT [PK_OSes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[OSes] ([Id], [name], [group], [major_ver], [minor_ver]) VALUES (N'121d9b92-f2e0-49e9-a17b-2271aca93eb9', N'Windows 8', 0, 6, 2)
INSERT [dbo].[OSes] ([Id], [name], [group], [major_ver], [minor_ver]) VALUES (N'808edf76-c0af-4db1-ab62-5e58c1e5e53b', N'Windows 10', 0, 10, 0)
INSERT [dbo].[OSes] ([Id], [name], [group], [major_ver], [minor_ver]) VALUES (N'2a552ab7-208e-4f5b-9fd1-6127de9d9aa4', N'Windows 8.1', 0, 6, 3)
INSERT [dbo].[OSes] ([Id], [name], [group], [major_ver], [minor_ver]) VALUES (N'6f7fc978-9c10-46c1-8f52-61c912807eba', N'Windows 2000', 0, 5, 0)
INSERT [dbo].[OSes] ([Id], [name], [group], [major_ver], [minor_ver]) VALUES (N'8b8a1d13-3912-459a-9510-6c2a090728d7', N'Windows XP', 0, 5, 1)
INSERT [dbo].[OSes] ([Id], [name], [group], [major_ver], [minor_ver]) VALUES (N'17555874-e618-4f14-b297-9d30487b73ca', N'Windows 7', 0, 6, 1)
INSERT [dbo].[OSes] ([Id], [name], [group], [major_ver], [minor_ver]) VALUES (N'b511fd17-c9e1-4106-accc-f448f19067d9', N'Windows VISTA', 0, 6, 0)
/****** Object:  Table [dbo].[GPUs]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GPUs](
	[Id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NULL,
	[architect] [nvarchar](max) NULL,
	[release] [datetime2](7) NOT NULL,
	[memory_size] [bigint] NOT NULL,
	[shader_model] [real] NOT NULL,
	[directx] [real] NOT NULL,
	[opengl] [real] NOT NULL,
	[vulkan] [real] NOT NULL,
	[memory_freqency] [bigint] NOT NULL,
	[core_frequency] [bigint] NOT NULL,
	[shaders] [bigint] NOT NULL,
	[buswidth] [bigint] NOT NULL,
	[bandwidth] [bigint] NOT NULL,
	[pixel_fillrate] [bigint] NOT NULL,
	[texture_fillrate] [bigint] NOT NULL,
	[manufacturer] [int] NOT NULL,
 CONSTRAINT [PK_GPUs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[GPUs] ([Id], [name], [architect], [release], [memory_size], [shader_model], [directx], [opengl], [vulkan], [memory_freqency], [core_frequency], [shaders], [buswidth], [bandwidth], [pixel_fillrate], [texture_fillrate], [manufacturer]) VALUES (N'a800e3c9-2e8d-4cce-b97e-81a2fcc60b05', N'Geforce 6800', N'NV40', CAST(0x070000000000242A0B AS DateTime2), 256, 3, 9, 2.1, 0, 350, 325, 0, 256, 32400, 3900, 3900, 0)
INSERT [dbo].[GPUs] ([Id], [name], [architect], [release], [memory_size], [shader_model], [directx], [opengl], [vulkan], [memory_freqency], [core_frequency], [shaders], [buswidth], [bandwidth], [pixel_fillrate], [texture_fillrate], [manufacturer]) VALUES (N'82259d49-2362-41b7-894f-85400d8b61f4', N'Geforce 8600 GTS', N'NV40', CAST(0x0700000000006E2E0B AS DateTime2), 256, 4, 10, 3.3, 0, 1000, 675, 1450, 128, 32000, 5400, 10800, 0)
INSERT [dbo].[GPUs] ([Id], [name], [architect], [release], [memory_size], [shader_model], [directx], [opengl], [vulkan], [memory_freqency], [core_frequency], [shaders], [buswidth], [bandwidth], [pixel_fillrate], [texture_fillrate], [manufacturer]) VALUES (N'86e10eec-6a55-4050-b547-85a2496cd185', N'Radeon X1900 GT', N'R580', CAST(0x070000000000132D0B AS DateTime2), 256, 3, 9, 2.1, 0, 575, 600, 0, 256, 38400, 6144, 6144, 1)
INSERT [dbo].[GPUs] ([Id], [name], [architect], [release], [memory_size], [shader_model], [directx], [opengl], [vulkan], [memory_freqency], [core_frequency], [shaders], [buswidth], [bandwidth], [pixel_fillrate], [texture_fillrate], [manufacturer]) VALUES (N'5e7bb8c5-c7c7-41cb-a647-cb16c421d95f', N'Radeon X1650', N'NV40', CAST(0x070000000000232E0B AS DateTime2), 256, 3, 9, 2.1, 0, 400, 635, 0, 128, 12800, 2000, 2000, 1)
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190723180331_Initial', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190724192514_Migration2', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190817111459_SysReqMigration', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190907124528_config_mig', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190908192414_ForumMigration', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190915090305_ConfigEdit_mig', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190915175346_ConfigEdit2_mig', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190917193807_Config3Mig', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190921201543_ManufactMig', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190921203633_ManufactMig2', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190922183207_PropertyMig', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190926192350_GameEditMig', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190929170212_GameEditMig2', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191006185745_MediaMig', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191108185339_GameModification', N'2.2.4-servicing-10062')
/****** Object:  Table [dbo].[ForumCategories]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ForumCategories](
	[Id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_ForumCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ForumCategories] ([Id], [name]) VALUES (N'e9a176b3-3730-4f6f-b078-148041c6440b', N'Softwares')
INSERT [dbo].[ForumCategories] ([Id], [name]) VALUES (N'776c2318-5aa2-4d6b-9d25-88e9df1d8e02', N'Computers, hardwares')
INSERT [dbo].[ForumCategories] ([Id], [name]) VALUES (N'041dd7a2-d3fa-4c40-b7f1-9db41c921e3f', N'Games')
INSERT [dbo].[ForumCategories] ([Id], [name]) VALUES (N'450b45af-d462-4473-b870-b77fec0f8dbd', N'Consoles')
INSERT [dbo].[ForumCategories] ([Id], [name]) VALUES (N'abcfc551-fa81-4c5a-b3db-d2ad0a9ed4f2', N'Other (for everything else)')
INSERT [dbo].[ForumCategories] ([Id], [name]) VALUES (N'863214cb-dfc7-4c81-9aa4-e477a1acb446', N'JOKR')
/****** Object:  Table [dbo].[Description]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Description](
	[Id] [uniqueidentifier] NOT NULL,
	[Content] [nvarchar](max) NULL,
	[Language] [int] NOT NULL,
 CONSTRAINT [PK_Description] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CPUs]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CPUs](
	[Id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NULL,
	[architect] [nvarchar](max) NULL,
	[release] [datetime2](7) NOT NULL,
	[freqency] [bigint] NOT NULL,
	[cores] [bigint] NOT NULL,
	[cache] [bigint] NOT NULL,
	[manufacturer] [int] NOT NULL,
 CONSTRAINT [PK_CPUs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[CPUs] ([Id], [name], [architect], [release], [freqency], [cores], [cache], [manufacturer]) VALUES (N'1c1f421e-37d0-4a8e-9f48-244398c1e013', N'Core 2 Duo E4200', N'Conroe', CAST(0x070000000000042E0B AS DateTime2), 1600, 2, 2, 0)
INSERT [dbo].[CPUs] ([Id], [name], [architect], [release], [freqency], [cores], [cache], [manufacturer]) VALUES (N'26f86e2d-5497-44db-aa98-2a824cf7b605', N'Core 2 Duo E4300', N'Conroe', CAST(0x0700000000005E2E0B AS DateTime2), 1800, 2, 2, 0)
INSERT [dbo].[CPUs] ([Id], [name], [architect], [release], [freqency], [cores], [cache], [manufacturer]) VALUES (N'232a0734-e7b5-4b41-be7d-385312abc20e', N'Core 2 Duo E4700', N'Conroe', CAST(0x070000000000AD2F0B AS DateTime2), 2600, 2, 2, 0)
INSERT [dbo].[CPUs] ([Id], [name], [architect], [release], [freqency], [cores], [cache], [manufacturer]) VALUES (N'4b0452a2-14e7-4374-a78c-3f288ae9b113', N'Pentium D 805', N'Smithfield', CAST(0x070000000000782C0B AS DateTime2), 2660, 2, 2, 0)
INSERT [dbo].[CPUs] ([Id], [name], [architect], [release], [freqency], [cores], [cache], [manufacturer]) VALUES (N'bf871c36-cf7f-402b-940c-3f33dc8b5a3c', N'Core 2 Duo E4600', N'Conroe', CAST(0x070000000000152F0B AS DateTime2), 2400, 2, 2, 0)
INSERT [dbo].[CPUs] ([Id], [name], [architect], [release], [freqency], [cores], [cache], [manufacturer]) VALUES (N'02f11db1-93bd-4bbd-8b72-9def0cd3faf6', N'Pentium 4 HT 540', N'Prescott', CAST(0x070000000000CE2A0B AS DateTime2), 3200, 1, 1, 0)
INSERT [dbo].[CPUs] ([Id], [name], [architect], [release], [freqency], [cores], [cache], [manufacturer]) VALUES (N'77bc81e7-e295-46e7-bda5-e808154b1f34', N'Core 2 Duo E4400', N'Conroe', CAST(0x0700000000005E2E0B AS DateTime2), 2000, 2, 2, 0)
INSERT [dbo].[CPUs] ([Id], [name], [architect], [release], [freqency], [cores], [cache], [manufacturer]) VALUES (N'633d5951-58c5-499f-afac-fec93a952951', N'Core 2 Duo E4500', N'Conroe', CAST(0x070000000000B92E0B AS DateTime2), 2200, 2, 2, 0)
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Registration] [datetime2](7) NOT NULL,
	[BankAccount] [nvarchar](max) NULL,
	[IsAdmin] [bit] NOT NULL,
	[LastLogin] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Registration], [BankAccount], [IsAdmin], [LastLogin]) VALUES (N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'Alonso93', N'ALONSO93', N'szabo.joakim@gmail.com', N'SZABO.JOAKIM@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEK37/z/nbO7BPaJ5diiVcTS6o9mSd2ZGpXga280iqxF9F7cfWBsVC/LQCP4YziReHg==', N'AQERTSFENORCWCJOG5BOLLAKQOMMSWQL', N'fdd474d4-7695-4c5f-9b3a-a730e3331ecf', NULL, 0, 0, NULL, 1, 0, CAST(0x070000000000000000 AS DateTime2), NULL, 0, CAST(0x076B798003A85A400B AS DateTime2))
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Registration], [BankAccount], [IsAdmin], [LastLogin]) VALUES (N'f28f7ebc-7742-424a-947f-65d571cc699d', N'Alonso94', N'ALONSO94', N'test@gmail.com', N'TEST@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEPvsphpdUeiJb9VfVclI0j6NQUkxIUyBXRoVDfw/dIG9emv1gZuliplbT8nPThQbmA==', N'7TF4NTRF4SMHZMOPUNIZ3TTGCBQCTL7E', N'cd9a89bb-778b-4dfa-8417-987cea74b7f2', NULL, 0, 0, NULL, 1, 0, CAST(0x070000000000000000 AS DateTime2), NULL, 0, CAST(0x07842DB28AA83E400B AS DateTime2))
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Registration], [BankAccount], [IsAdmin], [LastLogin]) VALUES (N'e1552ef8-cd4b-4aa1-9202-985ddd1f27a0', N'Alonso92', N'ALONSO92', N'test@testmail.hu', N'TEST@TESTMAIL.HU', 0, N'AQAAAAEAACcQAAAAEBnTfT8HULfbd4rfhF6+J6vLQieVJ0y9fD8TPKVBmf9HOLOEqvexKYqINWTThD9e5Q==', N'7G5PTJRAO5NCPMXHGB5NBQVMIXTSKWOF', N'483fdca7-71c8-49eb-a15d-f456803fb223', NULL, 0, 0, NULL, 1, 0, CAST(0x07E7145DB96EFA3F0B AS DateTime2), NULL, 0, CAST(0x070000000000000000 AS DateTime2))
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Registration], [BankAccount], [IsAdmin], [LastLogin]) VALUES (N'06f7514b-55ae-4a6c-8a7b-f80cdb5930a8', N'Alonso', N'ALONSO', N'szabo.joakim@gmail.com', N'SZABO.JOAKIM@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAELNOTT9U2bGFNu1h4v+J5SoFqm7sEeAVp2U/IymWcBwHeaKdVW7Yad9jHKCvR0DlXw==', N'6QMZRZCNMON2DQOHTL3QKJIFFPKXUCTJ', N'2db75978-2374-4b19-a7cf-6e249c193f88', NULL, 0, 0, NULL, 1, 0, CAST(0x070000000000000000 AS DateTime2), NULL, 0, CAST(0x070000000000000000 AS DateTime2))
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Registration], [BankAccount], [IsAdmin], [LastLogin]) VALUES (N'4be75580-8368-48fd-b5ad-fc2f03956b4e', N'szabo.joakim@gmail.com', N'SZABO.JOAKIM@GMAIL.COM', N'szabo.joakim@gmail.com', N'SZABO.JOAKIM@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEIta9tBwooX+rTTY380YYzWV41INnkS4JmDsNeyBchqNa1HqQyNB6/+7VaQYh+PxmA==', N'4ICQ2HZQDC45RFQZ6QYQYLIITNOQWPSK', N'17fc0c53-76dd-4ecb-90c9-4d8c2b01fa5c', NULL, 0, 0, NULL, 1, 0, CAST(0x070000000000000000 AS DateTime2), NULL, 0, CAST(0x070000000000000000 AS DateTime2))
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Configs]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configs](
	[Id] [uniqueidentifier] NOT NULL,
	[CPUId] [uniqueidentifier] NOT NULL,
	[RAM] [int] NOT NULL,
	[GPUId] [uniqueidentifier] NOT NULL,
	[GPU_size] [int] NOT NULL,
	[OSId] [uniqueidentifier] NOT NULL,
	[others] [nvarchar](max) NULL,
	[UserId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Configs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Configs] ([Id], [CPUId], [RAM], [GPUId], [GPU_size], [OSId], [others], [UserId]) VALUES (N'8f13b84d-8dc4-4132-744c-08d73ba474fa', N'1c1f421e-37d0-4a8e-9f48-244398c1e013', 2048, N'5e7bb8c5-c7c7-41cb-a647-cb16c421d95f', 0, N'17555874-e618-4f14-b297-9d30487b73ca', NULL, N'00000000-0000-0000-0000-000000000000')
INSERT [dbo].[Configs] ([Id], [CPUId], [RAM], [GPUId], [GPU_size], [OSId], [others], [UserId]) VALUES (N'3df51d01-5c3d-41bb-a73d-08d73ba7e4f0', N'1c1f421e-37d0-4a8e-9f48-244398c1e013', 2048, N'5e7bb8c5-c7c7-41cb-a647-cb16c421d95f', 0, N'17555874-e618-4f14-b297-9d30487b73ca', NULL, N'f28f7ebc-7742-424a-947f-65d571cc699d')
INSERT [dbo].[Configs] ([Id], [CPUId], [RAM], [GPUId], [GPU_size], [OSId], [others], [UserId]) VALUES (N'498f1118-2b0f-46b6-2f5c-08d73c5ba0b7', N'1c1f421e-37d0-4a8e-9f48-244398c1e013', 2048, N'a800e3c9-2e8d-4cce-b97e-81a2fcc60b05', 0, N'2a552ab7-208e-4f5b-9fd1-6127de9d9aa4', NULL, N'00000000-0000-0000-0000-000000000000')
INSERT [dbo].[Configs] ([Id], [CPUId], [RAM], [GPUId], [GPU_size], [OSId], [others], [UserId]) VALUES (N'186e479a-4012-4bf0-faf8-08d73d29a72d', N'1c1f421e-37d0-4a8e-9f48-244398c1e013', 2048, N'86e10eec-6a55-4050-b547-85a2496cd185', 0, N'17555874-e618-4f14-b297-9d30487b73ca', NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c')
INSERT [dbo].[Configs] ([Id], [CPUId], [RAM], [GPUId], [GPU_size], [OSId], [others], [UserId]) VALUES (N'2a3efce9-e8e4-432f-9478-0951d250f3f2', N'1c1f421e-37d0-4a8e-9f48-244398c1e013', 2048, N'82259d49-2362-41b7-894f-85400d8b61f4', 0, N'b511fd17-c9e1-4106-accc-f448f19067d9', NULL, N'00000000-0000-0000-0000-000000000000')
/****** Object:  Table [dbo].[ForumTopics]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ForumTopics](
	[Id] [uniqueidentifier] NOT NULL,
	[title] [nvarchar](max) NULL,
	[content] [nvarchar](max) NULL,
	[date] [datetime2](7) NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[ForumCategoryId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_ForumTopics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'34e3b764-b704-4e74-0aa4-08d7355ce95b', NULL, NULL, CAST(0x0760D55704B51E400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'e9a176b3-3730-4f6f-b078-148041c6440b')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'27d3a971-fdc9-4c01-0aa5-08d7355ce95b', NULL, NULL, CAST(0x07A1405A7FB51E400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'e9a176b3-3730-4f6f-b078-148041c6440b')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'91b31c6e-fb2b-4a1c-0aa6-08d7355ce95b', N'asd', N'sdfgsfdsd', CAST(0x0740B3E285B61E400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'e9a176b3-3730-4f6f-b078-148041c6440b')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'aab7cd2c-4ad3-4fa0-0aa7-08d7355ce95b', N'adfad', N'sertsdrrsd', CAST(0x0726559E06B71E400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'e9a176b3-3730-4f6f-b078-148041c6440b')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'b3d11cb9-9416-4e77-1db0-08d7356129b5', N'Great topic', N'sfgsfgsgsgf
sgfsygfsag
sagsgyfd', CAST(0x0745FEAC44B91E400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'e9a176b3-3730-4f6f-b078-148041c6440b')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'1c47b979-eacc-4cb1-eab7-08d735c4d672', N'adfad', N'dgfhdrgsfgsef
sfgsfkln
llskfdejnlksjf', CAST(0x07DDDAFFC6531F400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'e9a176b3-3730-4f6f-b078-148041c6440b')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'5d81537c-8265-411f-63af-08d735c5ca21', N'asf', N' fhcxfgxfg
xfgxdgxf', CAST(0x079FB1AEBA541F400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'e9a176b3-3730-4f6f-b078-148041c6440b')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'2d080a1c-7acd-43f6-1c15-08d735c5f30d', N'asd', N'vhgjfghcv', CAST(0x07A7679DE3541F400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'e9a176b3-3730-4f6f-b078-148041c6440b')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'd13a1d40-4f96-440e-4eed-08d735c6b882', N'cxfgdxgf', N'cxfhgdxgxsdf', CAST(0x079B6BDAA8551F400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'e9a176b3-3730-4f6f-b078-148041c6440b')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'a069c2fe-74b6-478f-bdf3-08d735c85e0e', N'Great topic', N'xfgxgdxfg
segsgsxg
shgsdftgs
sgdsgfsdg', CAST(0x07FBE8994E571F400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'776c2318-5aa2-4d6b-9d25-88e9df1d8e02')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'01d92e91-1576-4a0e-9ad3-08d735c8b754', N'Awesome topic', N'sgsdfsdfsa
sdhsdgf
sdgfsgfsggsfsg
sgsgf', CAST(0x071DCDABA7571F400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'776c2318-5aa2-4d6b-9d25-88e9df1d8e02')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'251fb25b-4ce9-4b4a-4dfb-08d735d1f8ab', N'adfad', N'dxfgsdfgdsf', CAST(0x0707BD39E9601F400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'776c2318-5aa2-4d6b-9d25-88e9df1d8e02')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'579ed858-63d1-4f0e-4dfc-08d735d1f8ab', N'Awesome topic', N'xfdgsxdfd', CAST(0x079946F1F3601F400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'776c2318-5aa2-4d6b-9d25-88e9df1d8e02')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'8e59f39c-9fd2-4aee-c6fc-08d736955bd4', N'Alonsotopic', N'fmh,ndxklfjghsyihgfsioéhfn
ysdpigjasoéifjdoéasijfgéos
ésloyidgjsoijfgsoijsí
spdeogjsopiejfgoséiejfosiehfjspiohífpioushe
íofkspofejpoj', CAST(0x078938F1215B20400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'e9a176b3-3730-4f6f-b078-148041c6440b')
INSERT [dbo].[ForumTopics] ([Id], [title], [content], [date], [UserId], [ForumCategoryId]) VALUES (N'1609b497-14fd-4484-f6f6-08d7369b46eb', N'Alonsotopic', N'l.évgmhnélc mbX
xgfkléxglxkjmdgálx
xfxéopgkjáxpogkjf', CAST(0x070E5F140D6120400B AS DateTime2), N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'e9a176b3-3730-4f6f-b078-148041c6440b')
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [uniqueidentifier] NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[Id] [uniqueidentifier] NOT NULL,
	[GameName] [nvarchar](max) NULL,
	[CoverArt] [nvarchar](max) NULL,
	[Rate] [float] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Release] [datetime2](7) NOT NULL,
	[DownloadLink] [nvarchar](max) NULL,
	[DemoLink] [nvarchar](max) NULL,
	[NumOfDownloads] [int] NOT NULL,
	[MinSysReqId] [uniqueidentifier] NULL,
	[RecSysReqId] [uniqueidentifier] NULL,
	[SysReqNotes] [nvarchar](max) NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[DescriptionId] [uniqueidentifier] NULL,
	[Publish] [datetime2](7) NOT NULL,
	[ReleaseState] [int] NOT NULL,
	[State] [int] NOT NULL,
 CONSTRAINT [PK_Games] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'f618b055-ac4f-4fff-5f46-08d74369ab25', N'Far Cry 4', NULL, 0, CAST(7500.00 AS Decimal(18, 2)), CAST(0x0700000000008D390B AS DateTime2), NULL, NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'e4277484-f5ae-4963-da77-08d7438bf584', N'Far cry 5', NULL, 0, CAST(8000.00 AS Decimal(18, 2)), CAST(0x0700000000002F3E0B AS DateTime2), NULL, NULL, 0, NULL, NULL, NULL, N'f28f7ebc-7742-424a-947f-65d571cc699d', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'3a9ca826-ceaf-4df0-ca5f-08d743f3c208', N'Crysis 3', NULL, 0, CAST(6000.00 AS Decimal(18, 2)), CAST(0x070000000000DD360B AS DateTime2), NULL, NULL, 0, NULL, NULL, NULL, N'f28f7ebc-7742-424a-947f-65d571cc699d', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'fe5599a2-b27d-436a-8e12-08d743f5e8db', N'Need for Speed II', NULL, 0, CAST(2000.00 AS Decimal(18, 2)), CAST(0x0700000000001A200B AS DateTime2), NULL, NULL, 0, NULL, NULL, NULL, N'f28f7ebc-7742-424a-947f-65d571cc699d', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'fec78cb9-ca14-4ba8-d68a-08d744fef64d', N'Need for Speed II', NULL, 0, CAST(2000.00 AS Decimal(18, 2)), CAST(0x0700000000000A200B AS DateTime2), NULL, NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'94adaa11-cbfc-40bb-39bc-08d74902180b', N'Need for Speed III', NULL, 0, CAST(2500.00 AS Decimal(18, 2)), CAST(0x07000000000088210B AS DateTime2), NULL, NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'08ae1dfb-a88d-49b2-a0ce-08d74dbfcbed', N'Persian Nights', NULL, 0, CAST(4000.00 AS Decimal(18, 2)), CAST(0x07000000000071400B AS DateTime2), NULL, NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'81db361a-1891-464c-22a4-08d74dc087a6', N'Far Cry 4', NULL, 0, CAST(8000.00 AS Decimal(18, 2)), CAST(0x07000000000034390B AS DateTime2), NULL, NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'4b226d8e-9589-4c11-8d02-08d74dc10fb4', N'Crysis 4', NULL, 0, CAST(10000.00 AS Decimal(18, 2)), CAST(0x070000000000DA400B AS DateTime2), NULL, NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'280aa785-f3dd-4079-3231-08d74e76643b', N'Far Cry 6', NULL, 0, CAST(6500.00 AS Decimal(18, 2)), CAST(0x07000000000033410B AS DateTime2), NULL, NULL, 0, NULL, NULL, NULL, N'f28f7ebc-7742-424a-947f-65d571cc699d', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'67ccd344-a37b-44e6-9ddd-10460b0257af', N'Far Cry', N'images/far_cry.jpg', 3.5, CAST(8000.00 AS Decimal(18, 2)), CAST(0x070000000000542A0B AS DateTime2), N'far_fry.exe', NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'65f35af2-1c86-406a-862d-33db6517366f', N'Duke Nukem forever', N'images/far_cry_2.jpg', 3.8, CAST(6500.00 AS Decimal(18, 2)), CAST(0x07000000000059340B AS DateTime2), N'duke_nukem_forever.exe', NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'e8ec09af-de7f-4ecd-9a2d-60ea6da0bfea', N'Doom', N'images/crysis.jpg', 4.7, CAST(0.00 AS Decimal(18, 2)), CAST(0x070000000000251B0B AS DateTime2), N'doom.exe', N'doom_demo.exe', 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'89ec13aa-1995-41be-b67b-63e253ec17fe', N'Crysis', N'images/crysis.jpg', 4.5, CAST(8000.00 AS Decimal(18, 2)), CAST(0x070000000000342F0B AS DateTime2), N'crysis.exe', NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'90f2d718-0fa1-488a-aaa9-7759dd7d0182', N'Doom (2016)', N'images/far_cry_2.jpg', 4.3, CAST(12000.00 AS Decimal(18, 2)), CAST(0x070000000000603B0B AS DateTime2), N'doom2016.exe', NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'cfd41d11-7675-44b3-b5b4-96594b4472ac', N'Duke Nukem 3D', N'images/far_cry.jpg', 3.5, CAST(5000.00 AS Decimal(18, 2)), CAST(0x0700000000006E1E0B AS DateTime2), N'duke_nukem.exe', NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'a084ba8d-d60c-4708-9167-9da9e49abc04', N'Super Mario 3D World', NULL, 0, CAST(5000.00 AS Decimal(18, 2)), CAST(0x07000000000059360B AS DateTime2), NULL, NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'ab0ecbb9-0034-4167-9255-a99caf469bca', N'Far Cry 2', N'images/far_cry_2.jpg', 4, CAST(8000.00 AS Decimal(18, 2)), CAST(0x070000000000A2300B AS DateTime2), N'far_cry2.exe', N'far_cry2_demo.exe', 0, N'9bffef14-63ff-4680-883f-f63c4ad0b99a', N'b14db6e3-8a03-4460-8702-e42a019a19f2', NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'6721e843-065a-4744-a3ac-ab3cc240b775', N'Crysis 2', N'images/far_cry_2.jpg', 3.9, CAST(7500.00 AS Decimal(18, 2)), CAST(0x07000000000009340B AS DateTime2), N'crysis2.exe', NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
INSERT [dbo].[Games] ([Id], [GameName], [CoverArt], [Rate], [Price], [Release], [DownloadLink], [DemoLink], [NumOfDownloads], [MinSysReqId], [RecSysReqId], [SysReqNotes], [UserId], [DescriptionId], [Publish], [ReleaseState], [State]) VALUES (N'169d3f40-1fd0-46e1-adb5-d8d66c87afcc', N'Need for Speed High Stakes', N'images/far_cry_2.jpg', 4.2, CAST(3500.00 AS Decimal(18, 2)), CAST(0x070000000000D7220B AS DateTime2), N'nfs4.exe', NULL, 0, NULL, NULL, NULL, N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL, CAST(0x070000000000000000 AS DateTime2), 0, 0)
/****** Object:  Table [dbo].[SysReqOS]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysReqOS](
	[Id] [uniqueidentifier] NOT NULL,
	[SysReqId] [uniqueidentifier] NOT NULL,
	[OSId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_SysReqOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SysReqOS] ([Id], [SysReqId], [OSId]) VALUES (N'ba3b3d0a-cff4-49cc-8f02-8e29a8bce2a3', N'9bffef14-63ff-4680-883f-f63c4ad0b99a', N'8b8a1d13-3912-459a-9510-6c2a090728d7')
/****** Object:  Table [dbo].[SysReqGPU]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysReqGPU](
	[Id] [uniqueidentifier] NOT NULL,
	[SysReqId] [uniqueidentifier] NOT NULL,
	[GPUId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_SysReqGPU] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SysReqGPU] ([Id], [SysReqId], [GPUId]) VALUES (N'35bba189-360a-4afd-99af-16da5cb2dd79', N'b14db6e3-8a03-4460-8702-e42a019a19f2', N'82259d49-2362-41b7-894f-85400d8b61f4')
INSERT [dbo].[SysReqGPU] ([Id], [SysReqId], [GPUId]) VALUES (N'e44bf526-e814-4df0-8e60-88f6f1ca4490', N'9bffef14-63ff-4680-883f-f63c4ad0b99a', N'a800e3c9-2e8d-4cce-b97e-81a2fcc60b05')
INSERT [dbo].[SysReqGPU] ([Id], [SysReqId], [GPUId]) VALUES (N'ee83ac5a-ba81-4972-afee-944553fbc6e7', N'b14db6e3-8a03-4460-8702-e42a019a19f2', N'86e10eec-6a55-4050-b547-85a2496cd185')
INSERT [dbo].[SysReqGPU] ([Id], [SysReqId], [GPUId]) VALUES (N'9b6a4de3-d991-467a-8129-ef8d136343cb', N'9bffef14-63ff-4680-883f-f63c4ad0b99a', N'5e7bb8c5-c7c7-41cb-a647-cb16c421d95f')
/****** Object:  Table [dbo].[SysReqCPU]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysReqCPU](
	[Id] [uniqueidentifier] NOT NULL,
	[SysReqId] [uniqueidentifier] NOT NULL,
	[CPUId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_SysReqCPU] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SysReqCPU] ([Id], [SysReqId], [CPUId]) VALUES (N'88f02d6f-f6ce-43a1-8247-05640b1786e8', N'b14db6e3-8a03-4460-8702-e42a019a19f2', N'1c1f421e-37d0-4a8e-9f48-244398c1e013')
INSERT [dbo].[SysReqCPU] ([Id], [SysReqId], [CPUId]) VALUES (N'6fe3c3d9-734b-49bd-9da2-4d9a54250fd2', N'9bffef14-63ff-4680-883f-f63c4ad0b99a', N'4b0452a2-14e7-4374-a78c-3f288ae9b113')
INSERT [dbo].[SysReqCPU] ([Id], [SysReqId], [CPUId]) VALUES (N'28ce18f9-2a4c-4c18-8802-7bb787b2185c', N'9bffef14-63ff-4680-883f-f63c4ad0b99a', N'02f11db1-93bd-4bbd-8b72-9def0cd3faf6')
/****** Object:  Table [dbo].[UserGames]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGames](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[GameId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_UserGames] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[UserGames] ([Id], [UserId], [GameId]) VALUES (N'50a4ba2f-2851-4c33-b33d-08d7106e2b4b', N'4be75580-8368-48fd-b5ad-fc2f03956b4e', N'67ccd344-a37b-44e6-9ddd-10460b0257af')
INSERT [dbo].[UserGames] ([Id], [UserId], [GameId]) VALUES (N'3aaa769f-9cb6-4e02-b33e-08d7106e2b4b', N'4be75580-8368-48fd-b5ad-fc2f03956b4e', N'89ec13aa-1995-41be-b67b-63e253ec17fe')
INSERT [dbo].[UserGames] ([Id], [UserId], [GameId]) VALUES (N'dd838e61-bb37-4c61-9f18-08d72b2189bb', N'f28f7ebc-7742-424a-947f-65d571cc699d', N'ab0ecbb9-0034-4167-9255-a99caf469bca')
INSERT [dbo].[UserGames] ([Id], [UserId], [GameId]) VALUES (N'6de1799d-0fd3-4077-359f-08d72b248b5a', N'f28f7ebc-7742-424a-947f-65d571cc699d', N'89ec13aa-1995-41be-b67b-63e253ec17fe')
INSERT [dbo].[UserGames] ([Id], [UserId], [GameId]) VALUES (N'a7ad0e8e-ddf2-4c75-efd9-08d7314e69c1', N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'ab0ecbb9-0034-4167-9255-a99caf469bca')
INSERT [dbo].[UserGames] ([Id], [UserId], [GameId]) VALUES (N'ff9e595e-841c-48ba-efda-08d7314e69c1', N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', N'89ec13aa-1995-41be-b67b-63e253ec17fe')
/****** Object:  Table [dbo].[Medias]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medias](
	[Id] [uniqueidentifier] NOT NULL,
	[GameId] [uniqueidentifier] NOT NULL,
	[type] [int] NOT NULL,
	[contain] [nvarchar](max) NULL,
 CONSTRAINT [PK_Medias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'd12718e5-4a73-450e-e579-08d74dbfcbf9', N'08ae1dfb-a88d-49b2-a0ce-08d74dbfcbed', 0, N'D:\Alonso\Documents\Visual Studio Code\JokrStore\JOKRStore\wwwroot/images/Persian Nights84569edf-3ea1-4357-8dd2-aad46f1426b1.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'4dd9391d-84f0-408b-e57a-08d74dbfcbf9', N'08ae1dfb-a88d-49b2-a0ce-08d74dbfcbed', 0, N'D:\Alonso\Documents\Visual Studio Code\JokrStore\JOKRStore\wwwroot/images/Persian Nightsc3c90cc4-bb5b-459f-a0d1-0a338d211741.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'560b5d25-c84f-4c33-e57b-08d74dbfcbf9', N'08ae1dfb-a88d-49b2-a0ce-08d74dbfcbed', 0, N'D:\Alonso\Documents\Visual Studio Code\JokrStore\JOKRStore\wwwroot/images/Persian Nights5de48e63-fb18-4f79-a7d1-aaff79c0f9b0.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'e585dad1-4005-401c-e57c-08d74dbfcbf9', N'08ae1dfb-a88d-49b2-a0ce-08d74dbfcbed', 0, N'D:\Alonso\Documents\Visual Studio Code\JokrStore\JOKRStore\wwwroot/images/Persian Nightsdc624903-672b-4922-9057-cc0b71119426.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'5ffa762d-8b72-4da2-93ad-08d74dc087a8', N'81db361a-1891-464c-22a4-08d74dc087a6', 0, N'D:\Alonso\Documents\Visual Studio Code\JokrStore\JOKRStore\wwwroot/images/Games/Far Cry 4/69fae514-9a6d-45fe-a323-edd21c384850.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'6e989db5-cdd6-4f0d-93ae-08d74dc087a8', N'81db361a-1891-464c-22a4-08d74dc087a6', 0, N'D:\Alonso\Documents\Visual Studio Code\JokrStore\JOKRStore\wwwroot/images/Games/Far Cry 4/68066858-86b1-4164-a2e4-0f56a59f9c79.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'efada19a-de3e-40d0-93af-08d74dc087a8', N'81db361a-1891-464c-22a4-08d74dc087a6', 0, N'D:\Alonso\Documents\Visual Studio Code\JokrStore\JOKRStore\wwwroot/images/Games/Far Cry 4/0803a4df-33c5-4121-8d35-820129cd986b.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'8c241b50-deb6-4629-93b0-08d74dc087a8', N'81db361a-1891-464c-22a4-08d74dc087a6', 0, N'D:\Alonso\Documents\Visual Studio Code\JokrStore\JOKRStore\wwwroot/images/Games/Far Cry 4/f961ca58-3210-4292-a1ba-82a785d5ef7b.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'083551b9-8990-4231-93b1-08d74dc087a8', N'81db361a-1891-464c-22a4-08d74dc087a6', 0, N'D:\Alonso\Documents\Visual Studio Code\JokrStore\JOKRStore\wwwroot/images/Games/Far Cry 4/b0e26fa0-c3b8-4128-9836-cca74c94ce60.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'479006c2-1c64-49a4-26e7-08d74dc10fb8', N'4b226d8e-9589-4c11-8d02-08d74dc10fb4', 0, N'9247aadc-c538-4366-be5b-5f4290395987.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'bd690557-99f8-44d4-26e8-08d74dc10fb8', N'4b226d8e-9589-4c11-8d02-08d74dc10fb4', 0, N'd2b509fe-af50-459a-b337-f96076546772.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'4520005a-988a-42a1-dffc-08d74e76ef76', N'280aa785-f3dd-4079-3231-08d74e76643b', 0, N'c66fc8ff-8f74-4922-8b75-1e2ef936a302.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'a7990682-1316-4a7a-dffd-08d74e76ef76', N'280aa785-f3dd-4079-3231-08d74e76643b', 0, N'e4d2acd5-f279-413c-be51-214d56606db2.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'e3a00460-0baa-4702-dfff-08d74e76ef76', N'e4277484-f5ae-4963-da77-08d7438bf584', 0, N'8e48d47b-fecd-4830-8551-423046d2f242.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'6b6e07a2-bcc0-4a45-e000-08d74e76ef76', N'e4277484-f5ae-4963-da77-08d7438bf584', 0, N'b0846ed4-c22d-4c48-8080-e4a1f0f3ada6.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'312cfa76-94a1-4c24-e001-08d74e76ef76', N'e4277484-f5ae-4963-da77-08d7438bf584', 0, N'c99120b5-2c5e-448f-a6e3-3c238768fab6.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'9b888841-18af-4056-b76b-08d7647e53af', N'ab0ecbb9-0034-4167-9255-a99caf469bca', 0, N'5c0f5749-3384-4b91-9278-bbe91df2d81b.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'1b249147-2809-4390-b76c-08d7647e53af', N'ab0ecbb9-0034-4167-9255-a99caf469bca', 0, N'c0b25ed1-f536-42c0-a62a-b4c103c10d92.jpg')
INSERT [dbo].[Medias] ([Id], [GameId], [type], [contain]) VALUES (N'570bac6a-1b91-436b-b76d-08d7647e53af', N'ab0ecbb9-0034-4167-9255-a99caf469bca', 0, N'0baae3f5-82ad-433f-8bdf-6ff9d74d5ad8.jpg')
/****** Object:  Table [dbo].[GameProperties]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GameProperties](
	[Id] [uniqueidentifier] NOT NULL,
	[GameId] [uniqueidentifier] NOT NULL,
	[PropertyId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_GameProperties] PRIMARY KEY CLUSTERED 
(
	[GameId] ASC,
	[PropertyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'fec78cb9-ca14-4ba8-d68a-08d744fef64d', N'ecf777b7-ae61-4f8b-abdf-8a0b3dddde72')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'fec78cb9-ca14-4ba8-d68a-08d744fef64d', N'45fbeda7-6a13-497e-b414-95a2aeb03bc4')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'fec78cb9-ca14-4ba8-d68a-08d744fef64d', N'ab29f141-55e1-461a-b6a8-9dfe1114461f')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'fec78cb9-ca14-4ba8-d68a-08d744fef64d', N'cc71be49-598e-4254-96f9-a6b63a73d21c')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'fec78cb9-ca14-4ba8-d68a-08d744fef64d', N'a8e5b7b7-217b-4460-a770-c54285eff4e3')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'94adaa11-cbfc-40bb-39bc-08d74902180b', N'a8e5b7b7-217b-4460-a770-c54285eff4e3')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'08ae1dfb-a88d-49b2-a0ce-08d74dbfcbed', N'45fbeda7-6a13-497e-b414-95a2aeb03bc4')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'08ae1dfb-a88d-49b2-a0ce-08d74dbfcbed', N'10239528-214a-4c21-b8d8-e722469f1230')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'08ae1dfb-a88d-49b2-a0ce-08d74dbfcbed', N'cfdb12a8-5512-43eb-a7c9-f6987d5155f2')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'81db361a-1891-464c-22a4-08d74dc087a6', N'904ac35b-a43d-4ccc-89f5-ad7a5fda64f0')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'81db361a-1891-464c-22a4-08d74dc087a6', N'cfdb12a8-5512-43eb-a7c9-f6987d5155f2')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'4b226d8e-9589-4c11-8d02-08d74dc10fb4', N'904ac35b-a43d-4ccc-89f5-ad7a5fda64f0')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'4b226d8e-9589-4c11-8d02-08d74dc10fb4', N'cfdb12a8-5512-43eb-a7c9-f6987d5155f2')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'280aa785-f3dd-4079-3231-08d74e76643b', N'904ac35b-a43d-4ccc-89f5-ad7a5fda64f0')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'280aa785-f3dd-4079-3231-08d74e76643b', N'cfdb12a8-5512-43eb-a7c9-f6987d5155f2')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'e8ec09af-de7f-4ecd-9a2d-60ea6da0bfea', N'904ac35b-a43d-4ccc-89f5-ad7a5fda64f0')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'11276a8b-5d67-4e44-6ae1-08d74453554c', N'a084ba8d-d60c-4708-9167-9da9e49abc04', N'ecf777b7-ae61-4f8b-abdf-8a0b3dddde72')
INSERT [dbo].[GameProperties] ([Id], [GameId], [PropertyId]) VALUES (N'a67fc6df-ec3c-4904-6ae2-08d74453554c', N'a084ba8d-d60c-4708-9167-9da9e49abc04', N'45fbeda7-6a13-497e-b414-95a2aeb03bc4')
/****** Object:  Table [dbo].[Comments]    Script Date: 11/16/2019 21:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentId] [uniqueidentifier] NOT NULL,
	[CommentDate] [datetime2](7) NOT NULL,
	[Contain] [nvarchar](max) NULL,
	[GameId] [uniqueidentifier] NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[ForumTopicId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[CommentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Comments] ([CommentId], [CommentDate], [Contain], [GameId], [UserId], [ForumTopicId]) VALUES (N'ac8793c3-021b-4cac-81fa-08d736e11504', CAST(0x07009C8F374220400B AS DateTime2), N'kjkjhikhkhiokuhiloéuh', NULL, N'f28f7ebc-7742-424a-947f-65d571cc699d', N'1609b497-14fd-4484-f6f6-08d7369b46eb')
INSERT [dbo].[Comments] ([CommentId], [CommentDate], [Contain], [GameId], [UserId], [ForumTopicId]) VALUES (N'83669af2-e782-4e71-6712-08d736e1d3a2', CAST(0x0700FA5FEA4220400B AS DateTime2), N'ghjfhdhdghdg', NULL, N'f28f7ebc-7742-424a-947f-65d571cc699d', N'1609b497-14fd-4484-f6f6-08d7369b46eb')
INSERT [dbo].[Comments] ([CommentId], [CommentDate], [Contain], [GameId], [UserId], [ForumTopicId]) VALUES (N'07242386-d371-48d5-6713-08d736e1d3a2', CAST(0x070040230E4320400B AS DateTime2), N'awesome game', N'ab0ecbb9-0034-4167-9255-a99caf469bca', N'f28f7ebc-7742-424a-947f-65d571cc699d', NULL)
INSERT [dbo].[Comments] ([CommentId], [CommentDate], [Contain], [GameId], [UserId], [ForumTopicId]) VALUES (N'7cd4c040-b800-490d-6714-08d736e1d3a2', CAST(0x070040230E4320400B AS DateTime2), N'good areas in africa', N'ab0ecbb9-0034-4167-9255-a99caf469bca', N'f4a8e71b-94e5-4bd3-9dac-5ed77e9bb54c', NULL)
/****** Object:  Default [DF__Configs__UserId__7E37BEF6]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Configs] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [UserId]
GO
/****** Object:  Default [DF__CPUs__manufactur__0B91BA14]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[CPUs] ADD  DEFAULT ((0)) FOR [manufacturer]
GO
/****** Object:  Default [DF__Games__SysReqNot__628FA481]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Games] ADD  DEFAULT (NULL) FOR [SysReqNotes]
GO
/****** Object:  Default [DF__Games__UserId__208CD6FA]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Games] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [UserId]
GO
/****** Object:  Default [DF__Games__Publish__2739D489]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Games] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Publish]
GO
/****** Object:  Default [DF__Games__ReleaseSt__282DF8C2]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Games] ADD  DEFAULT ((0)) FOR [ReleaseState]
GO
/****** Object:  Default [DF__Games__State__29221CFB]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Games] ADD  DEFAULT ((0)) FOR [State]
GO
/****** Object:  Default [DF__GPUs__manufactur__0A9D95DB]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[GPUs] ADD  DEFAULT ((0)) FOR [manufacturer]
GO
/****** Object:  ForeignKey [FK_AspNetRoleClaims_AspNetRoles_RoleId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
/****** Object:  ForeignKey [FK_AspNetUserClaims_AspNetUsers_UserId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_AspNetUserLogins_AspNetUsers_UserId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_AspNetUserRoles_AspNetRoles_RoleId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
/****** Object:  ForeignKey [FK_AspNetUserRoles_AspNetUsers_UserId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_AspNetUserTokens_AspNetUsers_UserId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_Comments_AspNetUsers_UserId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_Comments_ForumTopics_ForumTopicId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_ForumTopics_ForumTopicId] FOREIGN KEY([ForumTopicId])
REFERENCES [dbo].[ForumTopics] ([Id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_ForumTopics_ForumTopicId]
GO
/****** Object:  ForeignKey [FK_Comments_Games_GameId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Games_GameId] FOREIGN KEY([GameId])
REFERENCES [dbo].[Games] ([Id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Games_GameId]
GO
/****** Object:  ForeignKey [FK_Configs_CPUs_CPUId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Configs]  WITH CHECK ADD  CONSTRAINT [FK_Configs_CPUs_CPUId] FOREIGN KEY([CPUId])
REFERENCES [dbo].[CPUs] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Configs] CHECK CONSTRAINT [FK_Configs_CPUs_CPUId]
GO
/****** Object:  ForeignKey [FK_Configs_GPUs_GPUId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Configs]  WITH CHECK ADD  CONSTRAINT [FK_Configs_GPUs_GPUId] FOREIGN KEY([GPUId])
REFERENCES [dbo].[GPUs] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Configs] CHECK CONSTRAINT [FK_Configs_GPUs_GPUId]
GO
/****** Object:  ForeignKey [FK_Configs_OSes_OSId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Configs]  WITH CHECK ADD  CONSTRAINT [FK_Configs_OSes_OSId] FOREIGN KEY([OSId])
REFERENCES [dbo].[OSes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Configs] CHECK CONSTRAINT [FK_Configs_OSes_OSId]
GO
/****** Object:  ForeignKey [FK_ForumTopics_AspNetUsers_UserId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[ForumTopics]  WITH CHECK ADD  CONSTRAINT [FK_ForumTopics_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ForumTopics] CHECK CONSTRAINT [FK_ForumTopics_AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_ForumTopics_ForumCategories_ForumCategoryId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[ForumTopics]  WITH CHECK ADD  CONSTRAINT [FK_ForumTopics_ForumCategories_ForumCategoryId] FOREIGN KEY([ForumCategoryId])
REFERENCES [dbo].[ForumCategories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ForumTopics] CHECK CONSTRAINT [FK_ForumTopics_ForumCategories_ForumCategoryId]
GO
/****** Object:  ForeignKey [FK_GameProperties_Games_GameId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[GameProperties]  WITH CHECK ADD  CONSTRAINT [FK_GameProperties_Games_GameId] FOREIGN KEY([GameId])
REFERENCES [dbo].[Games] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GameProperties] CHECK CONSTRAINT [FK_GameProperties_Games_GameId]
GO
/****** Object:  ForeignKey [FK_GameProperties_Properties_PropertyId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[GameProperties]  WITH CHECK ADD  CONSTRAINT [FK_GameProperties_Properties_PropertyId] FOREIGN KEY([PropertyId])
REFERENCES [dbo].[Properties] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GameProperties] CHECK CONSTRAINT [FK_GameProperties_Properties_PropertyId]
GO
/****** Object:  ForeignKey [FK_Games_Description_DescriptionId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Games]  WITH CHECK ADD  CONSTRAINT [FK_Games_Description_DescriptionId] FOREIGN KEY([DescriptionId])
REFERENCES [dbo].[Description] ([Id])
GO
ALTER TABLE [dbo].[Games] CHECK CONSTRAINT [FK_Games_Description_DescriptionId]
GO
/****** Object:  ForeignKey [FK_Medias_Games_GameId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[Medias]  WITH CHECK ADD  CONSTRAINT [FK_Medias_Games_GameId] FOREIGN KEY([GameId])
REFERENCES [dbo].[Games] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Medias] CHECK CONSTRAINT [FK_Medias_Games_GameId]
GO
/****** Object:  ForeignKey [FK_SysReqCPU_CPUs_CPUId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[SysReqCPU]  WITH CHECK ADD  CONSTRAINT [FK_SysReqCPU_CPUs_CPUId] FOREIGN KEY([CPUId])
REFERENCES [dbo].[CPUs] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SysReqCPU] CHECK CONSTRAINT [FK_SysReqCPU_CPUs_CPUId]
GO
/****** Object:  ForeignKey [FK_SysReqCPU_SysReq_SysReqId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[SysReqCPU]  WITH CHECK ADD  CONSTRAINT [FK_SysReqCPU_SysReq_SysReqId] FOREIGN KEY([SysReqId])
REFERENCES [dbo].[SysReq] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SysReqCPU] CHECK CONSTRAINT [FK_SysReqCPU_SysReq_SysReqId]
GO
/****** Object:  ForeignKey [FK_SysReqGPU_GPUs_GPUId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[SysReqGPU]  WITH CHECK ADD  CONSTRAINT [FK_SysReqGPU_GPUs_GPUId] FOREIGN KEY([GPUId])
REFERENCES [dbo].[GPUs] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SysReqGPU] CHECK CONSTRAINT [FK_SysReqGPU_GPUs_GPUId]
GO
/****** Object:  ForeignKey [FK_SysReqGPU_SysReq_SysReqId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[SysReqGPU]  WITH CHECK ADD  CONSTRAINT [FK_SysReqGPU_SysReq_SysReqId] FOREIGN KEY([SysReqId])
REFERENCES [dbo].[SysReq] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SysReqGPU] CHECK CONSTRAINT [FK_SysReqGPU_SysReq_SysReqId]
GO
/****** Object:  ForeignKey [FK_SysReqOS_OSes_OSId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[SysReqOS]  WITH CHECK ADD  CONSTRAINT [FK_SysReqOS_OSes_OSId] FOREIGN KEY([OSId])
REFERENCES [dbo].[OSes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SysReqOS] CHECK CONSTRAINT [FK_SysReqOS_OSes_OSId]
GO
/****** Object:  ForeignKey [FK_SysReqOS_SysReq_SysReqId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[SysReqOS]  WITH CHECK ADD  CONSTRAINT [FK_SysReqOS_SysReq_SysReqId] FOREIGN KEY([SysReqId])
REFERENCES [dbo].[SysReq] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SysReqOS] CHECK CONSTRAINT [FK_SysReqOS_SysReq_SysReqId]
GO
/****** Object:  ForeignKey [FK_UserGames_AspNetUsers_UserId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[UserGames]  WITH CHECK ADD  CONSTRAINT [FK_UserGames_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserGames] CHECK CONSTRAINT [FK_UserGames_AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_UserGames_Games_GameId]    Script Date: 11/16/2019 21:27:05 ******/
ALTER TABLE [dbo].[UserGames]  WITH CHECK ADD  CONSTRAINT [FK_UserGames_Games_GameId] FOREIGN KEY([GameId])
REFERENCES [dbo].[Games] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserGames] CHECK CONSTRAINT [FK_UserGames_Games_GameId]
GO
