Module ConexionPapeleria
    Public conexion As New SqlClient.SqlConnection("data source= LENOVO20\SQLEXPRESS ; initial catalog =papeleria; integrated security=SSPI; persist security info = false; trusted_connection = yes;")
    'Nos permite ejecutar los comandos que tiene almacenados de sql
    Public cmd As SqlClient.SqlCommand
    'Permite leer los datos
    Public sqlread As SqlClient.SqlDataReader
    Public Query As String
    Public i As Integer
End Module
