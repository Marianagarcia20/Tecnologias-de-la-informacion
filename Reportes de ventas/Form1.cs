using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;



namespace Reportes_de_ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PbxExcel_Click(object sender, EventArgs e)
        {
            string diaI, mesI, anioI, diaF, mesF, anioF, FechaI, FechaF;
            diaI = Strings.Mid(DtpFechaI.Text, 1, 2);
            mesI = Strings.Mid(DtpFechaI.Text, 4, 2);
            anioI = Strings.Mid(DtpFechaI.Text, 7, 4);
            diaF = Strings.Mid(DtpFechaF.Text, 1, 2);
            mesF = Strings.Mid(DtpFechaF.Text, 4, 2);
            anioF = Strings.Mid(DtpFechaF.Text, 7, 4);
            FechaI = mesI + "/" + diaI + "/" +  anioI;
            FechaF = mesF + "/" + diaF + "/" + anioF;
            Microsoft.Office.Interop.Excel.Application m_Excel;  
            string ruta = "C:\\Users\\mg520\\OneDrive\\Documentos\\Reporte de ventas.xlsx";
            m_Excel = new Microsoft.Office.Interop.Excel.Application();
            m_Excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook objLibroExcel;
            Microsoft.Office.Interop.Excel.Worksheet objHojaExcel;
            objLibroExcel = m_Excel.Workbooks.Open(ruta);
            System.Data.OleDb.OleDbConnection objSQLconect = new System.Data.OleDb.OleDbConnection(@"Provider= SQLOLEdb; data source 
    = LENOVO20\SQLEXPRESS; initial catalog = papeleria; integrated security = SSPI; persist security
    info = false; trusted connection = yes;");

            string Query;
            Query = " select Pr.Id_Venta as Venta, P.Id_Producto as Consecutivo , P.NombreP as Nombreproducto, P.EspecifP as Especificaciones, Pr.PrecioVender as Precio, Pr.Cantidad as Cantidad from Producto as P, Produce as Pr, Venta as V where (P.Id_Producto= Pr.Id_Producto) and (V.Id_Venta = Pr.Id_Venta) AND V.FechaV BETWEEN '" + FechaI + "' and '" + FechaF + "'";

            System.Data.OleDb.OleDbDataAdapter objSQLAdapter = new System.Data.OleDb.OleDbDataAdapter(Query, objSQLconect);
            DataSet objDataSet = new DataSet("ExcelTest");
            objSQLAdapter.Fill(objDataSet, "ReporteVentas");
            // ' Creamos una variable para guardar la cultura actujal 
            System.Globalization.CultureInfo Oldcultureinfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            // ' Crear una cultura standar (en-US) ingles estados unidos 
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            // ' Creamos una instancia de la primera hoja de trabajo de Excel
            objHojaExcel = objLibroExcel.Worksheets[1];
            objHojaExcel.Visible = Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetVisible;          
            int i; 
            i = 7;
            foreach (DataRow objrow in objDataSet.Tables[0].Rows)
            {
                // ' Asignar los valores de los registros a las celdas
                objHojaExcel.Cells[i, "B"] = objrow["Venta"].ToString();
                objHojaExcel.Cells[i, "C"] = objrow["Consecutivo"].ToString();
                objHojaExcel.Cells[i, "D"] = objrow["Nombreproducto"].ToString();
                objHojaExcel.Cells[i, "E"]= objrow["Especificaciones"].ToString();
                objHojaExcel.Cells[i, "F"] = objrow["Precio"].ToString();
                objHojaExcel.Cells[i, "G"] = objrow["Cantidad"].ToString();

                // ' Avanzamos una fila
                i += 1;
            }
            MessageBox.Show("Reporte realizado correctamente");



        }
    }
    }

