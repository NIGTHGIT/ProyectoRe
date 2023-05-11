using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;

using System.Net;
using System.Speech.Synthesis;


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
            string[] saludos = {"hey", "¡qué onda!", "¿qué tal?", "¡buenas tardes!", "¡buenas noches!", "¡buenos días!", "¡hola amigo!", "¡hola a todos!", "¡hola de nuevo!", "¡hola vecino!", "¡hola colega!", "¡hola chicos!", "¡hola chicas!", "¡hola mundo!", "¡hola hermano!", "¡hola hermana!", "¡hola bebé!", "¡hola guapo!", "¡hola preciosa!", "¡hola mi amor!", "¡hola mi vida!", "¡hola cielo!", "¡hola sol!", "¡hola estrella!", "¡hola luna!", "¡hola nube!", "¡hola mar!", "¡hola montaña!", "¡hola río!", "¡hola bosque!", "¡hola playa!", "¡hola ciudad!", "¡hola campo!", "¡hola carretera!", "¡hola tráfico!", "¡hola tecnología!", "¡hola futuro!", "¡hola pasado!", "¡hola presente!", "¡hola realidad!", "¡hola sueño!", "¡hola magia!", "¡hola ciencia!", "¡hola arte!", "¡hola música!", "¡hola deporte!", "¡hola literatura!", "¡hola cine!", "¡hola teatro!", "¡hola televisión!", "¡hola internet!", "¡hola redes sociales!", "¡hola teléfono!", "¡hola computadora!", "¡hola videojuegos!", "¡hola trabajo!", "¡hola vacaciones!", "¡hola familia!", "¡hola amigos!", "¡hola conocidos!", "¡hola desconocidos!", "¡hola extraterrestres!", "¡hola animales!", "¡hola plantas!", "¡hola objetos!", "¡hola comida!", "¡hola bebida!", "¡hola diversión!", "¡hola aprendizaje!", "¡hola desafío!", "¡hola oportunidad!", "¡hola desafío!", "¡hola risa!", "¡hola llanto!", "¡hola emoción!", "¡hola aventura!", "¡hola peligro!", "¡hola seguridad!", "¡hola amor!", "¡hola amistad!", "¡hola paz!", "¡hola libertad!", "¡hola felicidad!", "¡hola alegría!", "¡hola tristeza!", "¡hola sorpresa!", "¡hola éxito!", "¡hola fracaso!", "¡hola futuro!", "¡hola presente!", "¡hola pasado!", "¡hola esperanza!", "¡hola fe!","hola","klk","qlq","buenos dias"
 };
            string[] abrirFormulario = { "abrir formulario", "abrir from1", "from1", "abre", "formulario", "nuevo formulario", "abrir ventana", "ventana nueva", "mostrar formulario", "ver formulario", "iniciar formulario", "abrir cuadro", "cuadro de dialogo", "abrir diálogo", "diálogo nuevo", "lanzar formulario", "abrir pantalla", "nueva pantalla", "abrir interfaz", "interfaz de usuario", "abrir ventana emergente", "ventana flotante", "abrir documento", "ver documento", "abrir archivo", "ver archivo", "abrir página", "nueva página", "abrir pestaña", "nueva pestaña", "abrir página web", "nueva página web", "abrir enlace", "nuevo enlace", "abrir aplicación", "nueva aplicación", "abrir editor", "nuevo editor", "abrir constructor", "nuevo constructor", "abrir diseñador", "nuevo diseñador", "abrir creador", "nuevo creador", "abrir generador", "nuevo generador", "abrir productor", "nuevo productor", "abrir generador de formularios", "nuevo generador de formularios", "abrir creador de formularios", "nuevo creador de formularios", "abrir diseñador de formularios", "nuevo diseñador de formularios", "abrir constructor de formularios", "nuevo constructor de formularios", "abrir generador de ventanas", "nuevo generador de ventanas", "abrir creador de ventanas", "nuevo creador de ventanas", "abrir diseñador de ventanas", "nuevo diseñador de ventanas", "abrir constructor de ventanas", "nuevo constructor de ventanas", "abrir creador de pantallas", "nuevo creador de pantallas", "abrir diseñador de pantallas", "nuevo diseñador de pantallas", "abrir constructor de pantallas", "nuevo constructor de pantallas", "abrir generador de interfaces", "nuevo generador de interfaces", "abrir creador de interfaces", "nuevo creador de interfaces", "abrir diseñador de interfaces", "nuevo diseñador de interfaces", "abrir constructor de interfaces", "nuevo constructor de interfaces", "abrir creador de documentos", "nuevo creador de documentos", "abrir diseñador de documentos", "nuevo diseñador de documentos", "abrir constructor de documentos", "nuevo constructor de documentos", "abrir generador de archivos", "nuevo generador de archivos", "abrir creador de archivos", "nuevo creador de archivos", "abrir diseñador de archivos", "nuevo diseñador de archivos", "abrir constructor de archivos", "nuevo constructor de archivos", "abrir creador de páginas", "nuevo creador de páginas", "abrir diseñador de páginas", "nuevo diseñador de páginas", "abrir constructor de páginas", "nuevo constructor de páginas", "abrir creador de pestañas", "nuevo creador de pestañas", "abrir diseñador de pestañas", "nuevo diseñador de pestañas", "abrir constructor de pestañas", "nuevo constructor de pestañas", "abrir generador de enlaces", "nuevo generador de enlaces", "abrir creador de enlaces" };


            // Convertir la entrada del usuario a minúsculas para compararla más fácilmente
            userInput = userInput.ToLower();

            // Lista de posibles saludos



            // Verificar si el usuario saludó
            if (saludos.Any(saludo => userInput.Contains(saludo)))
            {
                chatbotOutputLabel.Text = "¡Hola! Soy Chatbot, ¿en qué puedo ayudarte soy el chat de la feria de fe y alegria?";
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak(chatbotOutputLabel.Text);

            }
            // Verificar si el usuario preguntó cómo está el chatbot
            else if (userInput.Contains("cómo estás") || userInput.Contains("cómo te sientes"))
            {
                chatbotOutputLabel.Text = "Estoy funcionando correctamente, ¡gracias por preguntar!";
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak(chatbotOutputLabel.Text);

            }

            // Verificar si el usuario preguntó el nombre del chatbot
            else if (userInput.Contains("como te llamas") || userInput.Contains("cuál es tu nombre"))
            {
                chatbotOutputLabel.Text = "Me llamo Chatbot, ¿y tú cómo te llamas?";
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak(chatbotOutputLabel.Text);
            }
            else if (userInput.Contains("mi nombre es") || userInput.Contains("me llamo"))
            {
                string nombre = userInput.Split(' ').Last(); // Obtener el último elemento de la entrada del usuario, que debería ser su nombre
                chatbotOutputLabel.Text = "Hola " + nombre + ", soy Chatbot";
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak(chatbotOutputLabel.Text);
            }

            // Verificar si el usuario pidió abrir un formulario
            // Verificar si el usuario pidió abrir un formulario
            else if (abrirFormulario.Any(s => userInput.ToLower().Contains(s)))
            {
                timer.Start();
                // Aquí puedes agregar la lógica para abrir el formulario correspondiente

                chatbotOutputLabel.Text = "Abriendo formulario...";

                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak(chatbotOutputLabel.Text);
                Empleado form2 = new Empleado();
                form2.Show();
            }
            else if (userInput.Contains("que es fe y alegria"))
            {
                chatbotOutputLabel.Text = "Fe y Alegría es una organización de educación popular y cristiana que trabaja para proporcionar educación asequible y de calidad en comunidades empobrecidas de América Latina y el Caribe. Fue fundada en 1955 en Venezuela por el sacerdote jesuita José María Vélaz, y hoy en día tiene presencia en más de 20 países de la región. Fe y Alegría busca promover la educación como un derecho humano fundamental y como una herramienta para combatir la pobreza y la exclusión social. Sus escuelas y programas educativos buscan formar personas críticas y comprometidas con el desarrollo de sus comunidades.";
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak(chatbotOutputLabel.Text);

            }
            else if (userInput.Contains("feria") )
            {
                chatbotOutputLabel.Visible = false;
                chatbotOutputLabel.Text = " ¡Bienvenidos a la quinta feria de Fe y Alegría del área de informática! En este evento, se presentan los proyectos más innovadores y creativos desarrollados por nuestros estudiantes y profesores. Desde aplicaciones móviles hasta sistemas de información empresarial, hay algo para todos en esta feria. ¡Así que únanse a nosotros para celebrar la tecnología y el conocimiento en Fe y Alegría!";
               
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak(chatbotOutputLabel.Text);

                chatbotOutputLabel.Visible = true;
            }
           



            // Si el usuario no hizo ninguna pregunta reconocida, pedirle que repita su pregunta
            else
            {
                chatbotOutputLabel.Text = "Lo siento, no entendí tu pregunta. ¿Podrías repetirla de otra forma?";
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak(chatbotOutputLabel.Text);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Inicio ss = new Inicio();
            ss.Show();
            this.Close();
        }
    }
    }

