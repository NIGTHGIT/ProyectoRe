using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace INICIO
{
    public partial class VIdeo : Form
    {
        public VIdeo()
        {
            InitializeComponent();
            trackBar2.Maximum = 300;


            // Agrega un controlador de eventos para el cambio de estado de reproducción del control axWindowsMediaPlayer
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
        }

        private void VIdeo_Load(object sender, EventArgs e)
        {

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Obtener el valor actual del TrackBar
            // Obtener el valor actual del TrackBar
            int volumeValue = trackBar1.Value;

            // Establecer el volumen del reproductor multimedia
            axWindowsMediaPlayer1.settings.volume = volumeValue;
            // Obtener el valor actual del TrackBar


            // Establecer el texto del control Label con el valor actual del TrackBar
            label1.Text = volumeValue.ToString() + "%";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar2.Value;

        }

        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {


        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            double nuevaPosicion = axWindowsMediaPlayer1.Ctlcontrols.currentPosition + 10;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = nuevaPosicion;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            double nuevaPosicion = axWindowsMediaPlayer1.Ctlcontrols.currentPosition - 10;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = nuevaPosicion;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Obtiene el tiempo transcurrido de reproducción del video como una cadena de texto
            string tiempoTranscurrido = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;

            // Actualiza el control Label con el tiempo transcurrido de reproducción
            label3.Text = tiempoTranscurrido;

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Obtiene la posición actual de reproducción en segundos
                double posicionActual = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                // Convierte la posición actual en segundos a una posición en el control TrackBar
                int posicionTrackBar = (int)(posicionActual - trackBar2.Maximum / axWindowsMediaPlayer1.currentMedia.duration);

                // Actualiza el valor del control TrackBar con la posición actual de reproducción
                trackBar2.Value = posicionTrackBar;
            }

        }

        int x = 0;
        int y = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;

            }
            else
            {

                Top = Top + (e.X - x);
                Left = Left + (e.X - y);
            }

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            double nuevaPosicion = axWindowsMediaPlayer1.Ctlcontrols.currentPosition + 10;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = nuevaPosicion;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Obtiene el tiempo transcurrido de reproducción del video como una cadena de texto
            string tiempoTranscurrido = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;

            // Actualiza el control Label con el tiempo transcurrido de reproducción
            label3.Text = tiempoTranscurrido;

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Obtiene la posición actual de reproducción en segundos
                double posicionActual = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                // Convierte la posición actual en segundos a una posición en el control TrackBar
                int posicionTrackBar = (int)(posicionActual + trackBar2.Maximum / axWindowsMediaPlayer1.currentMedia.duration);

                // Actualiza el valor del control TrackBar con la posición actual de reproducción
                trackBar2.Value = posicionTrackBar;
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            double nuevaPosicion = axWindowsMediaPlayer1.Ctlcontrols.currentPosition - 10;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = nuevaPosicion;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                trackBar2.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Obtiene la duración del video como una cadena de texto
                string duracion = axWindowsMediaPlayer1.currentMedia.durationString;

                // Actualiza el control Label con la duración del video
                label2.Text = duracion;
            }

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Obtiene la duración del video como una cadena de texto
                string duracion = axWindowsMediaPlayer1.currentMedia.durationString;

                // Actualiza el control Label con la duración del video
                label2.Text = duracion;
            }




            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Inicia el control Timer
                timer1.Start();
            }
            else
            {
                // Detiene el control Timer
                timer1.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
