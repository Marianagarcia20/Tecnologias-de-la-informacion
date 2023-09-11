Public Class Form1
    Private Sub PbxExcel_Click(sender As Object, e As EventArgs) Handles PbxExcel.Click
        Dim diaI, mesI, anioI, diaF, mesF, anioF, FechaI, FechaF As String
        diaI = Mid(DtpFechaI.Text, 1, 2)
        mesI = Mid(DtpFechaI.Text, 4, 2)
        anioI = Mid(DtpFechaI.Text, 7, 4)
        diaF = Mid(DtpFechaF.Text, 1, 2)
        mesF = Mid(DtpFechaF.Text, 4, 2)
        anioF = Mid(DtpFechaF.Text, 7, 4)
        FechaI = diaI + "/" + mesI + "/" + anioI
        FechaF = diaF + "/" + mesF + "/" + anioF
        Dim m_Excel As Microsoft.Office.Interop.Excel.Application
        Dim aPath As String = My.Application.Info.DirectoryPath
        Dim ruta As String = "C:\Users\mg520\OneDrive\Documentos\Reporte de ventas.xlsx"
        m_Excel = New Microsoft.Office.Interop.Excel.Application
        m_Excel.Visible = True
        Dim objLibroExcel As Microsoft.Office.Interop.Excel.Workbook
        Dim objHojaExcel As Microsoft.Office.Interop.Excel.Worksheet
        objLibroExcel = m_Excel.Workbooks.Open(ruta)
        Dim objSQLconect As New System.Data.OleDb.OleDbConnection("Provider= SQLOLEdb; data source 
            = LENOVO20\SQLEXPRESS; initial catalog = papeleria; integrated security = SSPI; persist security
            info = false; trusted connection = yes;")

        Query = " select Pr.Id_Venta as Venta, P.Id_Producto as Consecutivo , P.NombreP as Nombreproducto, P.EspecifP as Especificaciones, Pr.PrecioVender as Precio, Pr.Cantidad as Cantidad from Producto as P, Produce as Pr, Venta as V where (P.Id_Producto= Pr.Id_Producto) and (V.Id_Venta = Pr.Id_Venta) AND V.FechaV BETWEEN '" + FechaI +
            "' and '" + FechaF + "'"

        Dim objSQLAdapter As New OleDb.OleDbDataAdapter(Query, objSQLconect)
        Dim objDataSet As New DataSet("ExcelTest")
        objSQLAdapter.Fill(objDataSet, "ReporteVentas")
        '' Creamos una variable para guardar la cultura actujal 
        Dim Oldcultureinfo As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        '' Crear una cultura standar (en-US) ingles estados unidos 
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        '' Creamos una instancia de la primera hoja de trabajo de Excel
        objHojaExcel = objLibroExcel.Worksheets(1)
        objHojaExcel.Visible = Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Cells(, "H") = ""
        i = 7
        For Each objrow As DataRow In objDataSet.Tables(0).Rows
            '' Asignar los valores de los registros a las celdas
            objHojaExcel.Cells(i, "B") = objrow.Item("Venta")
            objHojaExcel.Cells(i, "C") = objrow.Item("Consecutivo")
            objHojaExcel.Cells(i, "D") = objrow.Item("Nombreproducto")
            objHojaExcel.Cells(i, "E") = objrow.Item("Especificaciones")
            objHojaExcel.Cells(i, "F") = objrow.Item("Precio")
            objHojaExcel.Cells(i, "G") = objrow.Item("Cantidad")

            '' Avanzamos una fila
            i += 1
        Next
        MsgBox("Reporte realizado correctamente")
    End Sub


End Class
