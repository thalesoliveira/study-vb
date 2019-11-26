Imports System.Data.OleDb
Imports System.IO
Public Class Form7
    Private Sub btnXML_Click(sender As Object, e As EventArgs) Handles btnXML.Click
        Dim xml As String = "d:\database\plant_catalog.xml"

        Try
            Dim dataSet As New DataSet
            dataSet.ReadXml(xml)
            DataGridView1.DataSource = dataSet.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnTxt_Click(sender As Object, e As EventArgs) Handles btnTxt.Click

        Dim txt As String = "d:\database\plant_catalog.txt"

        DataGridView1.AutoGenerateColumns = False

        Dim common As New DataGridViewTextBoxColumn()
        common.DataPropertyName = "common"
        common.HeaderText = "common"

        Dim botanical As New DataGridViewTextBoxColumn()
        botanical.DataPropertyName = "botanical"
        botanical.HeaderText = "botanical"

        Dim zone As New DataGridViewTextBoxColumn()
        zone.DataPropertyName = "zone"
        zone.HeaderText = "zone"

        Dim light As New DataGridViewTextBoxColumn()
        light.DataPropertyName = "light"
        light.HeaderText = "light"

        Dim price As New DataGridViewTextBoxColumn()
        price.DataPropertyName = "price"
        price.HeaderText = "price"

        Dim availability As New DataGridViewTextBoxColumn()
        availability.DataPropertyName = "availability"
        availability.HeaderText = "availability"

        DataGridView1.Columns.Add(common)
        DataGridView1.Columns.Add(botanical)
        DataGridView1.Columns.Add(zone)
        DataGridView1.Columns.Add(light)
        DataGridView1.Columns.Add(price)
        DataGridView1.Columns.Add(availability)

        For Each row As String In File.ReadAllLines(txt)
            DataGridView1.Rows.Add(row.Split(","))
        Next

        'Dim diretorio As String = "d:\database"
        'Dim dataTable As New DataTable

        'Using conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" &
        '                                    "Data Source=" & diretorio & ";" &
        '                                    "Extended Properties=""Text;HDR=Yes;FMT=Delimited""")

        '    conn.Open()
        '    Using da As New OleDbDataAdapter("SELECT * FROM " & txt, conn)
        '        dataTable = New DataTable("plantas")
        '        da.Fill(dataTable)
        '    End Using
        'End Using

        'DataGridView1.DataSource = dataTable

    End Sub

    Private Sub btnObjetos_Click(sender As Object, e As EventArgs) Handles btnObjetos.Click
        'Array de objetos
        Dim arrPlantas As Plantas() = New Plantas(3) {}

        arrPlantas(0) = New Plantas() With {.common = "Bloodroot", .botanical = "Sanguinaria canadensis", .zone = "2", .light = "Mostly Shady", .price = "$2.44", .availability = "31599"}
        arrPlantas(1) = New Plantas() With {.common = "Columbine", .botanical = "Aquilegia canadensi", .zone = "3", .light = "Mostly Shady", .price = "$9.37", .availability = "30699"}
        arrPlantas(2) = New Plantas() With {.common = "Marsh Marigold", .botanical = "Caltha palustris", .zone = "4", .light = "Mostly Shady", .price = "$6.81", .availability = "51799"}

        DataGridView1.DataSource = arrPlantas
    End Sub

    Private Sub btnObjetosTipados_Click(sender As Object, e As EventArgs) Handles btnObjetosTipados.Click
        'coleção objetos tipados
        Dim listaPlantas = New List(Of Plantas)

        listaPlantas.Add(New Plantas("Bloodroot", "Sanguinaria canadensis", "2", "Mostly Shady", "$2.44", "31599"))
        listaPlantas.Add(New Plantas("Columbine", "Aquilegia canadensi", "3", "Mostly Shady", "$9.37", "30699"))
        listaPlantas.Add(New Plantas("Marsh Marigold", "Caltha palustris", "4", "Mostly Shady", "$6.81", "51799"))

        DataGridView1.DataSource = listaPlantas

    End Sub
End Class