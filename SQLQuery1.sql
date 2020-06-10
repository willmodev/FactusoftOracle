USE [master]
GO
/****** Object:  Database [Factusoft]    Script Date: 8/06/2020 11:22:35 a. m. ******/
CREATE DATABASE [Factusoft]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Factusoft', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Factusoft.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Factusoft_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Factusoft_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Factusoft] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Factusoft].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Factusoft] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Factusoft] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Factusoft] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Factusoft] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Factusoft] SET ARITHABORT OFF 
GO
ALTER DATABASE [Factusoft] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Factusoft] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Factusoft] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Factusoft] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Factusoft] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Factusoft] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Factusoft] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Factusoft] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Factusoft] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Factusoft] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Factusoft] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Factusoft] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Factusoft] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Factusoft] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Factusoft] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Factusoft] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Factusoft] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Factusoft] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Factusoft] SET  MULTI_USER 
GO
ALTER DATABASE [Factusoft] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Factusoft] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Factusoft] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Factusoft] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Factusoft] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Factusoft] SET QUERY_STORE = OFF
GO
USE [Factusoft]
GO
USE [Factusoft]
GO
/****** Object:  Sequence [dbo].[sec_address]    Script Date: 8/06/2020 11:22:37 a. m. ******/
CREATE SEQUENCE [dbo].[sec_address] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  UserDefinedFunction [dbo].[returnInvoiceType]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[returnInvoiceType](@InvoiceID INT)
RETURNS NVARCHAR
AS
BEGIN
 DECLARE @invoiceType NVARCHAR(7)
 SET @invoiceType = (SELECT InvoiceType FROM Invoice WHERE Invoice_ID  = @InvoiceID)

RETURN @invoiceType
END;
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[userName] [nvarchar](15) NULL,
	[passwordName] [nvarchar](15) NULL,
	[Email] [nvarchar](30) NULL,
	[passwordEmail] [nvarchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[FirstName] [nvarchar](15) NOT NULL,
	[secondName] [nvarchar](15) NOT NULL,
	[LastName] [nvarchar](15) NOT NULL,
	[SecondLastName] [nvarchar](15) NOT NULL,
	[Cedula] [nvarchar](11) NOT NULL,
	[Sex] [char](1) NOT NULL,
	[DateOfBorn] [date] NOT NULL,
	[Age] [int] NOT NULL,
	[Telephone] [nvarchar](11) NOT NULL,
	[E_mail] [nvarchar](30) NOT NULL,
	[AddressHome] [nvarchar](20) NOT NULL,
	[Neighborhood] [nvarchar](15) NOT NULL,
	[City] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Client_cedula] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[Invoice_ID] [int] NOT NULL,
	[SaleDate] [date] NOT NULL,
	[DueDate] [date] NOT NULL,
	[InvoiceType] [nvarchar](7) NULL,
	[Cedula] [nvarchar](11) NOT NULL,
	[SubTotal] [decimal](18, 0) NULL,
	[Total_IVA] [decimal](18, 0) NULL,
	[Total] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetail](
	[Quantity] [float] NOT NULL,
	[Discount] [float] NULL,
	[IVA] [decimal](18, 0) NULL,
	[product_ID] [nvarchar](3) NOT NULL,
	[Invoice_ID] [int] NOT NULL,
	[TolalDetail] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [nvarchar](3) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[UnitValue] [decimal](10, 2) NOT NULL,
	[UnitMeasure] [nvarchar](3) NOT NULL,
	[Quantity] [float] NOT NULL,
	[IVA] [decimal](4, 1) NOT NULL,
 CONSTRAINT [PK_Productos_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT ((0)) FOR [SubTotal]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT ((0)) FOR [Total_IVA]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[InvoiceDetail] ADD  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[InvoiceDetail] ADD  DEFAULT ((0)) FOR [IVA]
GO
ALTER TABLE [dbo].[InvoiceDetail] ADD  DEFAULT ((0)) FOR [TolalDetail]
GO
/****** Object:  StoredProcedure [dbo].[insert_client]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insert_client]

	@FirstName NVARCHAR(15),
	@secondName NVARCHAR(15),
	@LastName NVARCHAR(15) ,
	@SecondLastName NVARCHAR(15),
	@Cedula NVARCHAR(11),
	@Sex CHAR(1),
	@DateOfBorn DATE ,
	@Age INT ,
	@Telephone NVARCHAR(11) ,
	@E_mail NVARCHAR(30),
	@AddressHome NVARCHAR(10), 
	@Neighborhood NVARCHAR(15), 
	@City NVARCHAR(15)
AS
  INSERT INTO Clients VALUES(@FirstName,@secondName, @LastName, @SecondLastName,@Cedula, 
			     @Sex, @DateOfBorn,@Age,@Telephone, @E_mail,@AddressHome,@Neighborhood,@City)
GO
/****** Object:  StoredProcedure [dbo].[insert_invoice]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insert_invoice]

	@Invoice_ID INT,
	@SaleDate DATE, 
	@DueDate DATE,
	@InvoiceType NVARCHAR(7),
	@Cedula NVARCHAR(11),
	@SubTotal DECIMAL,
	@Total_IVA DECIMAL, 
	@Total DECIMAL
	
AS
	INSERT INTO Invoice(Invoice_ID, SaleDate, DueDate,InvoiceType, Cedula, SubTotal, Total_IVA, Total) 
				VALUES (@Invoice_ID, @SaleDate, @DueDate,@InvoiceType, @Cedula, @SubTotal, @Total_IVA, @Total);
GO
/****** Object:  StoredProcedure [dbo].[insert_InvoiceDetail]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insert_InvoiceDetail]

	@Quantity FLOAT,
	@Discount FLOAT,
	@IVA DECIMAL,
	@product_ID NVARCHAR(3),
	@Invoice_ID INT,
	@TolalDetail DECIMAL

	
AS

 DECLARE @InvoiceType NVARCHAR(7)

	INSERT INTO InvoiceDetail(Quantity,Discount,IVA,product_ID,Invoice_ID,TolalDetail)
				  VALUES(@Quantity, @Discount, @IVA, @product_ID, @Invoice_ID, @TolalDetail);

  EXEC @InvoiceType = returnInvoiceType @Invoice_ID

  EXEC modify_warehouse_quantity @Quantity,@InvoiceType,@product_ID
    
GO
/****** Object:  StoredProcedure [dbo].[modify_warehouse_quantity]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[modify_warehouse_quantity]
@Quantity FLOAT,
@InvoiceType NVARCHAR,
@product_ID	 NVARCHAR(3)
AS
  IF  @InvoiceType = 'C' 
	UPDATE Products SET Quantity = (Quantity + @Quantity) WHERE ID = @product_ID
	
 ELSE IF @InvoiceType = 'V'
	UPDATE Products SET Quantity = (Quantity -  @Quantity) WHERE ID = @product_ID
 
GO
/****** Object:  StoredProcedure [dbo].[selectInvoiceAndClients]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[selectInvoiceAndClients]
AS
SELECT 
iv.SaleDate,iv.DueDate,iv.InvoiceType,iv.Invoice_ID,iv.SubTotal,iv.Total_IVA,iv.Total,
cl.Cedula,cl.FirstName,cl.secondName,cl.LastName,cl.SecondLastName,cl.Sex,cl.DateOfBorn,
cl.Age,cl.Telephone,cl.E_mail,cl.AddressHome,cl.Neighborhood,cl.Cedula
FROM  Invoice iv JOIN Clients cl
ON(iv.Cedula = cl.Cedula) 
WHERE iv.Invoice_ID = (SELECT MAX(Invoice_ID) FROM Invoice);	
GO
/****** Object:  StoredProcedure [dbo].[selectInvoiceDetailAndProducts]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[selectInvoiceDetailAndProducts]
@Invoice_ID INT
As

SELECT 
	di.Quantity,di.Discount,di.TolalDetail,
	pr.ID,pr.Name,pr.UnitValue,pr.UnitMeasure,pr.IVA,pr.Quantity
FROM InvoiceDetail di JOIN Products pr ON(di.product_ID = pr.ID)
WHERE di.Invoice_ID = @Invoice_ID;

GO
/****** Object:  StoredProcedure [dbo].[validate_user]    Script Date: 8/06/2020 11:22:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[validate_user]

@userName NVARCHAR(15),
@passwordName NVARCHAR(15)

AS
		SELECT * FROM Administrator WHERE userName = @userName AND passwordName = @passwordName;
GO
USE [master]
GO
ALTER DATABASE [Factusoft] SET  READ_WRITE 
GO
