Imports Word = Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1

    Private Sub PbxWord_Click(sender As Object, e As EventArgs) Handles PbxWord.Click
        Dim dialogo As SaveFileDialog = New SaveFileDialog()
        If dialogo.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim ruta As String = dialogo.FileName
        Dim obj As Object = System.Reflection.Missing.Value
        Dim objWord As Word.Application = New Word.Application()
        Dim objDoc As Word.Document = objWord.Documents.Add(obj)
        objDoc.Activate()
        objWord.Selection.TypeText(TxtDato.Text)
        objWord.ActiveDocument.SaveAs2(ruta)
        objWord.Visible = True
    End Sub

    Private Sub PbxExcel_Click(sender As Object, e As EventArgs) Handles PbxExcel.Click
        Dim dialogo As SaveFileDialog = New SaveFileDialog()

        If dialogo.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim ruta As String = dialogo.FileName
        Dim obj As Object = System.Reflection.Missing.Value
        Dim objExcel As Excel.Application = New Excel.Application()
        Dim objDoc As Excel.Workbook = objExcel.Workbooks.Add(obj)
        objDoc.Activate()
        Dim sheet As Excel.Worksheet = objDoc.Worksheets.Add()
        sheet.Cells(1, 1).value = TxtDato.Text
        objDoc.SaveAs(ruta)
        objExcel.Visible = True
    End Sub
End Class
