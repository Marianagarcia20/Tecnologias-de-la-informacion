using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace EditorDocumentosDeOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PbxWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string ruta = dialogo.FileName;
            Object obj = System.Reflection.Missing.Value;
            Word.Application objWord = new Word.Application();
            Word.Document objDoc = objWord.Documents.Add(ref obj);
            objDoc.Activate();
            objWord.Selection.TypeText(TxtDato.Text);
            objWord.ActiveDocument.SaveAs2(ruta);
            objWord.Visible = true;
        }

        private void PbxExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;

            }
            string ruta = dialogo.FileName;
            Object obj = System.Reflection.Missing.Value;
            Excel.Application objExcel = new Excel.Application();
            Excel.Workbook objDoc = objExcel.Workbooks.Add(obj);
            objDoc.Activate();
            Excel.Worksheet sheet = objDoc.Worksheets.Add();
            sheet.Cells[1, 1].value = TxtDato.Text;
            objDoc.SaveAs(dialogo.FileName);
            objExcel.Visible = true;
        }
    }
}
