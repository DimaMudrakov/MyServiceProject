USE SiteCountries;

IF OBJECT_ID('[dbo].[Countries]', 'U') IS NOT NULL
    DROP TABLE dbo.Countries
GO

CREATE TABLE [dbo].[Countries] 
(
    [Id] INT IDENTITY(1,1) NOT NULL,
    [CountryName] VARCHAR(25) NOT NULL,
	PRIMARY KEY ([Id])
)

IF OBJECT_ID('[dbo].[Cities]', 'U') IS NOT NULL
    DROP TABLE dbo.Cities
GO

CREATE TABLE [dbo].[Cities] 
(
    [Id] INT IDENTITY(1,1) NOT NULL,
    [CityName] VARCHAR(25) NOT NULL,
    [CountryId] INT NOT NULL,
    PRIMARY KEY ([Id]),
	FOREIGN KEY ([CountryId]) REFERENCES [Countries]([Id])
)