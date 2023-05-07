using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace INICIO
{
    public partial class IA : Form
    {
        public IA()
        {
            InitializeComponent();
           
        }

        private void IA_Load(object sender, EventArgs e)
        {


        }
     



        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el texto ingresado por el usuario
            string userInput = userInputTextBox.Text;

            // Verificar si el usuario saludó
            if (userInput.ToLower().Contains("hola") || userInput.ToLower().Contains("buenas") || userInput.ToLower().Contains("hello"))
            {
                chatbotOutputLabel.Text = "¡Hola! ¿En qué puedo ayudarte?";
            }  
            // Verificar si el usuario preguntó cómo está el chatbot
            else if (userInput.ToLower().Contains("cómo estás") || userInput.ToLower().Contains("cómo te sientes"))
            {
                chatbotOutputLabel.Text = "Estoy funcionando correctamente, ¡gracias por preguntar!";
            }
            // Verificar si el usuario preguntó el nombre del chatbot
            else if (userInput.ToLower().Contains("como te llamas") || userInput.ToLower().Contains("cuál es tu nombre")  || userInput.ToLower().Contains("tu nombre")  || userInput.ToLowerInvariant().Contains("hola como te llamas") )
            {
                chatbotOutputLabel.Text = "Me llamo Chatbot";
            }
            // Verificar si el usuario pidió abrir un formulario
            else if (userInput.ToLower().Contains("abrir formulario"))
            {
                timer.Start();
                // Aquí puedes agregar la lógica para abrir el formulario correspondiente

                chatbotOutputLabel.Text = "Abriendo formulario...";
                Empleado form2 = new Empleado();
                form2.Show();
            }
            // Si el usuario no hizo ninguna pregunta reconocida, pedirle que repita su pregunta
            else
            {
                chatbotOutputLabel.Text = "Lo siento, no entendí tu pregunta. ¿Podrías repetirla de otra forma?";
            }

            // Limpiar el campo de entrada
            userInputTextBox.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar el campo de entrada
            userInputTextBox.Text = "";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Detener el temporizador para que no se active repetidamente
            timer.Stop();

            // Aquí puedes agregar la lógica para abrir el formulario correspondiente
           
        }
    }
}
