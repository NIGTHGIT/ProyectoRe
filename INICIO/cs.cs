using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace INICIO
{
    public partial class cs : Form
    {
        public cs()
        {
            InitializeComponent();
           
            btnGenerarPDF.Click += new EventHandler(Imprimir_Click);
        }
    


        private void cs_Load(object sender, EventArgs e)
        {

        }
        int contador = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            Boletos formularioPrincipal = Owner as Boletos;
            if (formularioPrincipal != null)
            {
                formularioPrincipal.InformacionEnviada = label1.Text;
                formularioPrincipal.ShowDialog();
            }
            else
            {
                
                formularioPrincipal.InformacionEnviada = label1.Text;
                formularioPrincipal.ShowDialog();
            }




        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // Crear el documento PDF
            Document document = new Document();
            string nombreArchivo = "nuevoArchivo.pdf";




            // Crea un objeto SaveFileDialog
            SaveFileDialog sfd = new SaveFileDialog();

            // Establece las opciones del cuadro de diálogo
            sfd.Filter = "Archivos PDF (*.pdf)|*.pdf";
            sfd.Title = "Guardar archivo PDF";
            sfd.ShowDialog();

            // Si el usuario ha seleccionado un archivo
            if (sfd.FileName != "")
            {
                // Crea el archivo PDF en la ubicación seleccionada
                PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));

                // Abre el documento PDF
                document.Open();

                // Agrega el texto "hola" al documento
                Paragraph paragraph = new Paragraph("Numero de Boletos");
                paragraph.Alignment = Element.ALIGN_CENTER;

                document.Add(paragraph);


                // Crear un segundo párrafo con el texto "Número"
                Paragraph paragraph2 = new Paragraph($"{label1.Text}");


                // Establecer la alineación del segundo párrafo en el centro
                paragraph2.Alignment = Element.ALIGN_CENTER;

                // Añadir un espacio antes del segundo párrafo
                paragraph2.SpacingBefore = 10f;

                // Añadir el segundo párrafo al documento
                document.Add(paragraph2);
                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("dd/MM/yyyy hh:mm:ss");
                Paragraph paragraph3 = new Paragraph(formattedDateTime);


                // Establecer la alineación del segundo párrafo en el centro
                paragraph3.Alignment = Element.ALIGN_CENTER;

                // Añadir un espacio antes del segundo párrafo
                paragraph3.SpacingBefore = 15f;

                // Añadir el segundo párrafo al documento
                document.Add(paragraph3);







                document.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
        }
        int x = 0;
        int y = 0;

        private void cs_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else {


                Top = Top + (e.Y - y);
                Left = Left + (e.Y - y);

            
            }


        }
    }
}
