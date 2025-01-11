Imports System.Data.SqlClient

Module DataBase_Controller
    Public Sub WhatsNew()

        DropTableFromDataBase()
        CreateTables()
        AddColumnToTable()
    End Sub

    Public Sub DropTableFromDataBase()
        Dim Que As String
        Que = "IF EXISTS(SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'material_prices') AND type in (N'U'))
               BEGIN
               DROP TABLE material_prices
               End

               IF EXISTS(SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'material_pricies') AND type in (N'U'))
               BEGIN
               DROP TABLE material_pricies
               End

               "
        cmd = New SqlCommand
        MyTab = New DataTable
        Try
            MyTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = Que
                .Connection = dbcon
            End With
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MyTab)
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub AddColumnToTable()
        Dim Que As String
        Que = "IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS
               WHERE TABLE_NAME = 'actions'
               AND COLUMN_NAME = 'total_price')
               BEGIN
               ALTER TABLE dbo.actions
               ADD total_price decimal(18, 2)
               CONSTRAINT [DF_actions_Column_total_price] 
               Default(0)  
               END

               "
        cmd = New SqlCommand
        MyTab = New DataTable
        Try
            MyTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = Que
                .Connection = dbcon
            End With
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MyTab)
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CreateTables()
        Dim Que As String
        Que = "IF NOT EXISTS (SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'users') AND type in (N'U'))
               BEGIN
               CREATE TABLE users(
               id BIGINT IDENTITY (0, 1) NOT NULL PRIMARY KEY,
               user_name nvarchar (50) NOT NULL,
               user_pass nvarchar (50) NOT NULL,
               user_lvl INT NOT NULL,
               user_phone nvarchar (50) NOT NULL,
	           isactive bit NOT NULL DEFAULT (1),
               ) 
               INSERT INTO users (user_name,user_pass) values ('admin','0')
               END

               IF NOT EXISTS (SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'action_types') AND type in (N'U'))
               BEGIN
               CREATE TABLE action_types(
               id BIGINT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
               action_type_name nvarchar (50) NOT NULL,
	           isincrease bit NOT NULL,
               ) 
               END

               IF NOT EXISTS (SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'permissions') AND type in (N'U'))
               BEGIN
               CREATE TABLE permissions(
               id BIGINT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
               permission_name nvarchar (50) NOT NULL,
	           lvl1 bit NOT NULL Default(1),
	           lvl2 bit NOT NULL Default(0),
	           lvl3 bit NOT NULL Default(0),
	           lvl4 bit NOT NULL Default(0),
	           lvl5 bit NOT NULL Default(0),
	           lvl6 bit NOT NULL Default(0),
	           lvl7 bit NOT NULL Default(0),
	           lvl8 bit NOT NULL Default(0),
	           lvl9 bit NOT NULL Default(0),
               ) 
               INSERT INTO permissions (permission_name) values ('Users')
               INSERT INTO permissions (permission_name) values ('Increase Actions')
               INSERT INTO permissions (permission_name) values ('Decrease Actions')
               INSERT INTO permissions (permission_name) values ('Edit Action')
               INSERT INTO permissions (permission_name) values ('Delete Action')
               INSERT INTO permissions (permission_name) values ('Permissions')
               INSERT INTO permissions (permission_name) values ('Products')
               INSERT INTO permissions (permission_name) values ('Action Types')
               INSERT INTO permissions (permission_name) values ('Audits')
               INSERT INTO permissions (permission_name) values ('Prices')

               END

               IF NOT EXISTS (SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'material_types') AND type in (N'U'))
               BEGIN
               CREATE TABLE material_types(
               id BIGINT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
               material_id int NOT NULL,
               type_name nvarchar (50) NOT NULL,
               type_quantity decimal(18, 2) NOT NULL Default(0),
               ) 
               END

               IF NOT EXISTS (SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'material_prices') AND type in (N'U'))
               BEGIN
               CREATE TABLE material_prices(
               id BIGINT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
               material_id int NOT NULL,
               price_year int NOT NULL,
               material_main_price decimal(18, 2) NOT NULL Default(0),
               price_discount decimal(18, 2) NOT NULL Default(0),
               material_price decimal(18, 2) NOT NULL Default(0),
               ) 
               END

               IF NOT EXISTS (SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'product_materials') AND type in (N'U'))
               BEGIN
               CREATE TABLE product_materials(
               id BIGINT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
               product_id int NOT NULL,
               material_id int NOT NULL,
               material_name nvarchar (50) NOT NULL,
               material_loc_barcode nvarchar (50) NOT NULL,
               material_quantity decimal(18, 2) NOT NULL Default(0),
               material_unit nvarchar (15) NOT NULL,
               ) 
               END

               IF NOT EXISTS (SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'units') AND type in (N'U'))
               BEGIN
               CREATE TABLE units(
               id BIGINT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
               unit_name nchar (10) NOT NULL,
               ) 
               END

               IF NOT EXISTS (SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'materials') AND type in (N'U'))
               BEGIN
               CREATE TABLE materials(
               id BIGINT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
               material_name nvarchar (50),
               material_barcode nvarchar (50),
               material_loc_barcode nvarchar (50),
               material_quantity  decimal(18, 2) NOT NULL Default(0),
               material_min_quantity decimal(18, 2) NOT NULL Default(0),
               material_unit nchar (10),
               material_weight int,
               material_isactive bit NOT NULL Default(1),
               material_inuse bit NOT NULL Default(0),
               ) 
               END

               IF NOT EXISTS (SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'products') AND type in (N'U'))
               BEGIN
               CREATE TABLE products(
               id BIGINT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
               product_name nvarchar (50),
               product_barcode nvarchar (50),
               product_can int,
               product_box int,              
               product_total int,              
               ) 
               END

               IF NOT EXISTS (SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'actions') AND type in (N'U'))
               BEGIN
               CREATE TABLE actions(
               id BIGINT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
               material_name nvarchar (50),
               material_loc_barcode nvarchar (50),
               material_barcode nvarchar (50),
               block_number nchar (10),
               action_user nvarchar (50),
               material_quantity  decimal(18, 2) NOT NULL Default(0),
               action_date datetime,
               vendor_name nvarchar (50),
               action_order nvarchar (50),
               more_info nvarchar (200),
               action_isincrease int,
               action_type nchar (10),
               total_price decimal(18, 2) Default(0),

               ) 
               END

               IF NOT EXISTS (SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'audits') AND type in (N'U'))
               BEGIN
               CREATE TABLE audits(
               id BIGINT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
               audit_name nvarchar (50),
               audit_start_date datetime,
               audit_end_date datetime,
               alert_days int Default(0),
               audit_alert_date datetime,
               audit_alert_on bit NOT NULL,
               more_info nvarchar (200),
               ) 
               END

       
               "

        cmd = New SqlCommand
        MyTab = New DataTable
        Try
            MyTab.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = Que
                .Connection = dbcon
            End With
            dbaddapter = New SqlDataAdapter(cmd)
            dbaddapter.Fill(MyTab)
            cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
