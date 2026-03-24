/*Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 08 / 04 / 2026
 * Autores do Projeto: Heitor Pinheiro de Souza
 *                     Mateus Todeschini Monteiro
 *
 * Turma: 3I
 * O Decágono Estocástico via Amostragem de Pontos.
 * Observação: < colocar se houver>
 * 
 * 
 * ******************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoICG1BI
{
    public partial class Form1 : Form
    {
        int r = 0, g = 0, b = 0;
        int bntapertado = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Color cores(int r, int g, int b)
        {
            Color cor = new Color();
            cor = Color.FromArgb(r, g, b);
            return cor;
        }
        public Pen caneta(Color cor)
        {
            Pen caneta = new Pen(cor);
            return caneta;
        }


        public void pintaP(Pen caneta, int x, int y, PaintEventArgs e)
        {
            e.Graphics.DrawLine(caneta, x, y, x + 1, y);
        }
        public float Modulo(float a, float b)
        {
            return (a % b + b) % b;
        }
        public void decagono(PaintEventArgs e, int r, int g, int b)
        {
            int n = 10; // Lados
            int R = 150; // Raio externo
            int tentativas = 80000;
            int largura = 800;
            int altura = 800;
            int centroX = largura / 2;
            int centroY = altura / 2;
            Random rnd = new Random();
            for (int i = 0; i < tentativas; i++)
            {

                // 1. Gera ponto aleatório no "bounding box" do decágono
                int px = rnd.Next(centroX - R, centroX + R);
                int py = rnd.Next(centroY - R, centroY + R);
                int x = px - centroX;
                int y = py - centroY;
                double d = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y, 2));
                double angulo = Math.Atan2(y, x);
                double seccao = (2 * Math.PI)/n;
                float a = Modulo((float)angulo, (float)seccao) - ((float)seccao/2);
                double d_max = R * Math.Cos(Math.PI/n) / Math.Cos(a);
                if (d < d_max)
                {
                    pintaP(caneta(cores(r, g, b)), px, py, e);
                }

            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (bntapertado == 1)
            {
                decagono(e, r, g, b);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string CorSelecionada = comboBox1.SelectedItem.ToString();

            switch (CorSelecionada)
            {
                case "Vermelho":
                    r = 255; g = 0; b = 0;
                    break;
                case "Verde":
                    r = 0; g = 255; b = 0;
                    break;
                case "Azul":
                    r = 0; g = 0; b = 255;
                    break;
                case "Amarelo":
                    r = 255; g = 255; b = 0;
                    break;
                case "Ciano":
                    r = 0; g = 255; b = 255;
                    break;
                case "Magenta":
                    r = 255; g = 0; b = 255;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma cor antes de desenhar o decágono.");
                return;
            }

            bntapertado = 1;
            this.Invalidate();

        }
    }
}
