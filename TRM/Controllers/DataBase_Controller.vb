Imports System.Data.SqlClient

Module DataBase_Controller
    Public Sub WhatsNew()

        'AddPermission("Prices", 10)               '/  AddPermission(permission_name as String,permision_index as Integer)
        'DropTableFromDataBase("test")             '/  DropTableFromDataBase(table_name as String)


        'AddColumnToTable("test", "test_price")     '/  AddColumnToTable(table_name As String, column_name As String)


        'CreateTables()
        'EditActionsPrice()
    End Sub


    Public Sub AddColumnToTable(table_name As String, column_name As String)
        Dim Que As String
        Que = "IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS
               WHERE TABLE_NAME = '" & table_name & "'
               AND COLUMN_NAME = 'total_price')
               BEGIN
               ALTER TABLE dbo." & table_name & "
               ADD " & column_name & " decimal(18, 2)
               CONSTRAINT [DF_" & table_name & "_Column_" & column_name & "] 
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
    Public Sub DropTableFromDataBase(table_name As String)
        Dim Que As String
        Que = "IF EXISTS(SELECT * FROM sys.objects 
               WHERE object_id = OBJECT_ID(N'" & table_name & "') AND type in (N'U'))
               BEGIN
               DROP TABLE " & table_name & "
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
            MsgBox("The Table " & table_name & " Has been Droped")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub AddPermission(permission_name As String, permission_index As Integer)
        Try
            Dim que As String
            Dim isFound As Boolean = False
            que = "select * from permissions"
            FillList(que)
            For i = 0 To MyTab.Rows.Count - 1
                If MyTab.Rows(i).Item(1) = permission_name Then
                    isFound = True
                End If
            Next
            If isFound = False Then
                cmd = New SqlCommand
                With cmd
                    .CommandType = CommandType.Text
                    .CommandText = "insert into permissions (permission_name)values(@permission_name)"
                    .Connection = dbcon
                End With
                cmd.Parameters.AddWithValue("@permission_name", permission_name)

                dbcon.Open()
                cmd.ExecuteNonQuery()
                dbcon.Close()
                MsgBox("The Permission called " & permission_name & " has been added successfully ")
            Else
                MsgBox("The Permission called " & permission_name & " is already found ")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Private Sub AddPermission2(permission_name As String, permission_index As Integer)
        Try
            'Dim que As String
            'Dim isFound As Boolean = False
            'que = "select * from permissions"
            'FillList(que)
            'For i = 0 To MyTab.Rows.Count - 1
            '    If MyTab.Rows(i).Item(1) = permission_name Then
            '        isFound = True
            '    End If
            'Next
            If PermissionCounter() = permission_index Then
                MsgBox("index found")
            Else
                MsgBox("not found")
            End If
            'MsgBox(PermissionCounter())
            'If isFound = False Then
            '    cmd = New SqlCommand
            '    With cmd
            '        .CommandType = CommandType.Text
            '        .CommandText = "insert into permissions (permission_name)values(@permission_name)"
            '        .Connection = dbcon
            '    End With
            '    cmd.Parameters.AddWithValue("@permission_name", permission_name)

            '    dbcon.Open()
            '    cmd.ExecuteNonQuery()
            '    dbcon.Close()
            '    MsgBox(permission_name & " isthe new Permission has been added ")
            'Else
            '    MsgBox("The Permission called " & permission_name & " is already found ")

            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

    Public Function PermissionCounter() As Integer
        Dim CountCMD As New SqlCommand
        Dim Counter As Integer = 0
        With CountCMD
            .CommandType = CommandType.Text
            .CommandText = "select count(*) from permissions"
            .Connection = dbcon
        End With
        Try
            dbcon.Open()
            Counter = CountCMD.ExecuteScalar
            dbcon.Close()
            cmd = Nothing
        Catch ex As Exception
            Return Counter
        Finally
            dbcon.Close()
        End Try
        Return Counter
    End Function

    '//************************* Functions FOR ONCE ONLY ******************************

    Public Sub EditActionsPrice()
        Try
            cmd = New SqlCommand
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "update actions set total_price=@total_price"
                .Connection = dbcon
            End With
            cmd.Parameters.AddWithValue("@total_price", 0)

            dbcon.Open()
            cmd.ExecuteNonQuery()
            dbcon.Close()
            MsgBox("All Actions Prices have been edited to 0 successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbcon.Close()
        End Try
    End Sub

End Module
