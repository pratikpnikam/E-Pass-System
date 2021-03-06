USE [master]
GO
/****** Object:  Database [epass_system]    Script Date: 05-04-2021 03:24:25 PM ******/
CREATE DATABASE [epass_system]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'epass_system', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\epass_system.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'epass_system_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\epass_system_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [epass_system] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [epass_system].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [epass_system] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [epass_system] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [epass_system] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [epass_system] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [epass_system] SET ARITHABORT OFF 
GO
ALTER DATABASE [epass_system] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [epass_system] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [epass_system] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [epass_system] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [epass_system] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [epass_system] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [epass_system] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [epass_system] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [epass_system] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [epass_system] SET  DISABLE_BROKER 
GO
ALTER DATABASE [epass_system] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [epass_system] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [epass_system] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [epass_system] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [epass_system] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [epass_system] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [epass_system] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [epass_system] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [epass_system] SET  MULTI_USER 
GO
ALTER DATABASE [epass_system] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [epass_system] SET DB_CHAINING OFF 
GO
ALTER DATABASE [epass_system] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [epass_system] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [epass_system] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [epass_system] SET QUERY_STORE = OFF
GO
USE [epass_system]
GO
/****** Object:  Table [dbo].[register]    Script Date: 05-04-2021 03:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[register](
	[register_no] [int] IDENTITY(1,1) NOT NULL,
	[register_name] [varchar](50) NULL,
	[register_mobile] [bigint] NULL,
	[register_address] [varchar](50) NULL,
	[register_address_code] [int] NULL,
	[register_adhar] [varchar](50) NULL,
	[register_age] [int] NULL,
	[register_dob] [date] NULL,
	[register_city] [varchar](50) NULL,
 CONSTRAINT [PK_register] PRIMARY KEY CLUSTERED 
(
	[register_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[travel_info]    Script Date: 05-04-2021 03:24:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[travel_info](
	[form_id] [int] IDENTITY(1,1) NOT NULL,
	[register_no] [int] NULL,
	[journey_date] [date] NULL,
	[city_from] [varchar](50) NULL,
	[city_to] [varchar](50) NULL,
	[number_of_passanger] [int] NULL,
	[district_from] [varchar](50) NULL,
	[district_to] [varchar](50) NULL,
	[vehical_no] [varchar](50) NULL,
	[driving_licence] [varchar](50) NULL,
	[vehicle_model] [varchar](50) NULL,
 CONSTRAINT [PK_travel_info] PRIMARY KEY CLUSTERED 
(
	[form_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[travel_info]  WITH CHECK ADD FOREIGN KEY([register_no])
REFERENCES [dbo].[register] ([register_no])
GO
/****** Object:  StoredProcedure [dbo].[pr_print]    Script Date: 05-04-2021 03:24:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[pr_print]
@register_no int 
as

begin

select top 1
register.register_no,
register.register_name,
register.register_mobile,
register.register_address, 
register.register_adhar, 
register.register_age,
register.register_dob,
register.register_city,
travel_info.form_id,
travel_info.journey_date, 
travel_info.city_from,
travel_info.city_to,
travel_info.district_from,
travel_info.district_to,
travel_info.number_of_passanger,
travel_info.vehical_no,
travel_info.driving_licence,
travel_info.vehicle_model
  from register
    inner join
       travel_info 
	   on register.register_no= travel_info.register_no

where register.register_no=@register_no
order by travel_info.form_id desc 

end
GO
/****** Object:  StoredProcedure [dbo].[sp_register]    Script Date: 05-04-2021 03:24:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_register]

@register_no int =0,
@register_name	varchar(50)='',	
@register_mobile	bigint	=0,
@register_address	varchar(50)='',	
@register_address_code	int	=0,
@register_adhar	varchar(50)	='',
@register_age	int	=0,
@register_dob	date='',	
@register_city	varchar(50)='',	
@Flag varchar(20)=''

as
select @register_no=count(register_no)+1 from register;
if(@Flag='insert')
begin
set identity_insert register on;
insert into register(
register_no,
register_name,
register_mobile,
register_address,
register_address_code,
register_adhar,
register_age,
register_dob,
register_city
) values(
@register_no,
@register_name,
@register_mobile,
@register_address,
@register_address_code,
@register_adhar,
@register_age,
@register_dob,
@register_city
);
end

if(@Flag='login')
begin
select count(*) from register where (register_name=@register_name and register_adhar=@register_adhar)
end

if(@Flag='viewOne')
begin
select *from register where register_name=@register_name and register_adhar=@register_adhar
end
GO
/****** Object:  StoredProcedure [dbo].[sp_travel_info]    Script Date: 05-04-2021 03:24:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_travel_info]

@form_id	int=0,
@register_no	int	=0,
@journey_date	date='',	
@city_from	nvarchar(50)='',	
@city_to	nvarchar(50)='',
@number_of_passanger	int=0,	
@district_from	nvarchar(50)='',
@district_to	nvarchar(50)='',
@vehical_no	varchar(50)='',
@driving_licence	varchar(50)='',	
@vehicle_model	varchar(50)='',
@Flag varchar(20)=''

as

select @form_id=count(form_id)+1 from travel_info;

if(@Flag='insert')
begin
--set identity_insert travel_info on;

insert into travel_info (
register_no,
journey_date,
city_from,
city_to,
number_of_passanger,
district_from,
district_to,
vehical_no,
driving_licence,
vehicle_model
)values(
@register_no,
@journey_date,
@city_from,
@city_to,
@number_of_passanger,
@district_from,
@district_to,
@vehical_no,
@driving_licence,
@vehicle_model
);
end


GO
USE [master]
GO
ALTER DATABASE [epass_system] SET  READ_WRITE 
GO
