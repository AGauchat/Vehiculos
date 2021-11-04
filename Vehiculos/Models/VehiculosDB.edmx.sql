
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/04/2021 10:04:47
-- Generated from EDMX file: C:\Users\agus1\source\repos\Vehiculos\Vehiculos\Models\VehiculosDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Vehiculos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Vehiculos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehiculos];
GO
IF OBJECT_ID(N'[dbo].[Marcas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Marcas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Vehiculos'
CREATE TABLE [dbo].[Vehiculos] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Patente] nchar(8)  NOT NULL,
    [IDMarca] bigint  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Dueño] nvarchar(max)  NOT NULL,
    [Puertas] int  NOT NULL
);
GO

-- Creating table 'Marcas'
CREATE TABLE [dbo].[Marcas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Marca] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [PK_Vehiculos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Marcas'
ALTER TABLE [dbo].[Marcas]
ADD CONSTRAINT [PK_Marcas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------