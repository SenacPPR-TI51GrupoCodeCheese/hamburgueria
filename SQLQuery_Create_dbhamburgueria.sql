USE [master]
GO
/****** Object:  Database [dbhamburgueria]    Script Date: 17/10/2024 16:33:39 ******/
CREATE DATABASE [dbhamburgueria]
 CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'dbhamburgueria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbhamburgueria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'dbhamburgueria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbhamburgueria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
-- WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbhamburgueria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbhamburgueria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbhamburgueria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbhamburgueria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbhamburgueria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbhamburgueria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbhamburgueria] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbhamburgueria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbhamburgueria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbhamburgueria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbhamburgueria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbhamburgueria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbhamburgueria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbhamburgueria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbhamburgueria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbhamburgueria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbhamburgueria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbhamburgueria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbhamburgueria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbhamburgueria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbhamburgueria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbhamburgueria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbhamburgueria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbhamburgueria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbhamburgueria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbhamburgueria] SET  MULTI_USER 
GO
ALTER DATABASE [dbhamburgueria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbhamburgueria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbhamburgueria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbhamburgueria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbhamburgueria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbhamburgueria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbhamburgueria] SET QUERY_STORE = OFF
GO
USE [dbhamburgueria]
GO
CREATE LOGIN [Aluno] WITH PASSWORD = 'Senac111'
GO
/****** Object:  User [Aluno]    Script Date: 22/10/2024 10:46:17 ******/
CREATE USER [Aluno] FOR LOGIN [Aluno] WITH DEFAULT_SCHEMA=[public]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Aluno]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Aluno]
GO
/****** Object:  Table [dbo].[Administrador]    Script Date: 17/10/2024 16:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrador](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NULL,
	[Cpf] [varchar](11) NULL,
	[Login] [varchar](12) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Administrador] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
INSERT INTO Administrador([Login], [Senha]) VALUES ('admin', 'admin')
GO
/****** Object:  Table [dbo].[ItensPedido]    Script Date: 17/10/2024 16:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItensPedido](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPedido] [int] NOT NULL,
	[NomeProduto] [varchar](50) NOT NULL,
	[PrecoProduto] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_ItensPedido] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItensSacola]    Script Date: 17/10/2024 16:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItensSacola](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdSacola] [int] NOT NULL,
	[NomeProduto] [varchar](50) NOT NULL,
	[PrecoProduto] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_Itens] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 17/10/2024 16:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CpfUsuario] [varchar](11) NOT NULL,
	[MetPag] [char](1) NOT NULL,
	[Status] [char](1) NOT NULL,
	[Total] [decimal](10, 2) NOT NULL,
	[DataPedido] [datetime] NOT NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 17/10/2024 16:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Preco] [decimal](5, 2) NOT NULL,
	[Descricao] [varchar](431) NULL,
	[Ingredientes] [varchar](150) NULL,
	[Foto] [image] NULL,
	[Tipo] [char](1) NOT NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sacola]    Script Date: 17/10/2024 16:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sacola](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CpfUsuario] [varchar](11) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Sacola] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CpfUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 17/10/2024 16:33:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeCompleto] [varchar](255) NULL,
	[NomeUsuario] [varchar](12) NULL,
	[Email] [varchar](256) NULL,
	[Cpf] [varchar](11) NOT NULL,
	[Telefone] [varchar](11) NULL,
	[Nascimento] [datetime] NULL,
	[Genero] [char](1) NULL,
	[Endereco] [varchar](150) NULL,
	[Pontos] [int] NULL,
	[Senha] [varchar](50) NULL,
	[Convidado] [bit] NOT NULL,
	[NomeHost] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Cpf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UQConvidado_NomeHost]    Script Date: 17/10/2024 16:33:39 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_UQConvidado_NomeHost] ON [dbo].[Usuario]
(
	[NomeHost] ASC
)
WHERE ([Convidado]=(1))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pedido] ADD  CONSTRAINT [DF_Pedido_DataPedido]  DEFAULT (sysdatetime()) FOR [DataPedido]
GO
ALTER TABLE [dbo].[Pedido] ADD  CONSTRAINT [DF_Pedido_Status]  DEFAULT ('A') FOR [Status]
GO
ALTER TABLE [dbo].[Produto] ADD  CONSTRAINT [DF_Produto_Tipo]  DEFAULT ('L') FOR [Tipo]
GO
ALTER TABLE [dbo].[Sacola] ADD  CONSTRAINT [DF_Sacola_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_NomeHost]  DEFAULT (host_name()) FOR [NomeHost]
GO
ALTER TABLE [dbo].[ItensPedido]  WITH CHECK ADD  CONSTRAINT [FK_ItensPedido_Pedido] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedido] ([Id])
GO
ALTER TABLE [dbo].[ItensPedido] CHECK CONSTRAINT [FK_ItensPedido_Pedido]
GO
ALTER TABLE [dbo].[ItensSacola]  WITH CHECK ADD  CONSTRAINT [FK_ItensSacola_Sacola] FOREIGN KEY([IdSacola])
REFERENCES [dbo].[Sacola] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ItensSacola] CHECK CONSTRAINT [FK_ItensSacola_Sacola]
GO
ALTER TABLE [dbo].[Sacola]  WITH CHECK ADD  CONSTRAINT [FK_Sacola_Usuario] FOREIGN KEY([CpfUsuario])
REFERENCES [dbo].[Usuario] ([Cpf])
GO
ALTER TABLE [dbo].[Sacola] CHECK CONSTRAINT [FK_Sacola_Usuario]
GO
ALTER TABLE [dbo].[Sacola]  WITH CHECK ADD CHECK  (([Status]=(0) OR [Status]=(1)))
GO
USE [master]
GO
ALTER DATABASE [dbhamburgueria] SET  READ_WRITE 
GO
