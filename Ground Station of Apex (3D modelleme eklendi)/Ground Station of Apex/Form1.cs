using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Windows.Forms;

namespace Ground_Station_of_Apex
{
        public partial class Form1 : Form
        {
            float x = 0, y = 0, z = 0;
            
            public Form1()
            {
                InitializeComponent();
            }
            private void Form1_Load(object sender, EventArgs e)
            {
                GL.ClearColor(Color.FromArgb(93, 240, 167)); //gl arka plan rengi
                
                string[] portlar = SerialPort.GetPortNames();
            foreach (string portAdi in portlar)
                {
                    cmbSerialPort.Items.Add(portAdi);
                }

            }
           private void glControl1_Paint(object sender, PaintEventArgs e)
            {
                float step = 1.0f;
                float topla = step;
                float radius = 3.0f;
                float dikey1 = radius, dikey2 = -radius;
                GL.Clear(ClearBufferMask.ColorBufferBit);
                GL.Clear(ClearBufferMask.DepthBufferBit);

                Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(1.04f, 4 / 3, 1, 10000);
                Matrix4 lookat = Matrix4.LookAt(25, 0, 0, 0, 0, 0, 0, 1, 0);
                GL.MatrixMode(MatrixMode.Projection);
                GL.LoadIdentity();
                GL.LoadMatrix(ref perspective);
                GL.MatrixMode(MatrixMode.Modelview);
                GL.LoadIdentity();
                GL.LoadMatrix(ref lookat);
                GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
                GL.Enable(EnableCap.DepthTest);
                GL.DepthFunc(DepthFunction.Less);

                GL.Rotate(z, 1.0, 0.0, 0.0);//ÖNEMLİ
                GL.Rotate(y, 0.0, 1.0, 0.0);
                GL.Rotate(x, 0.0, 0.0, 1.0);

                silindir(step, topla, radius, 6, -6); //CİZİM
               
                //GL.Begin(BeginMode.Lines);

                //GL.Color3(Color.FromArgb(250, 0, 0)); // z ekseni rengi kırmızı
                //GL.Vertex3(-50.0, 0.0, 0.0);
                //GL.Vertex3(50.0, 0.0, 0.0);


                //GL.Color3(Color.FromArgb(0, 0, 0)); // y ekseni rengi siyah
                //GL.Vertex3(0.0, 50.0, 0.0);
                //GL.Vertex3(0.0, -50.0, 0.0);

                //GL.Color3(Color.FromArgb(0, 0, 250)); // x ekseni rengi mavi
                //GL.Vertex3(0.0, 0.0, 50.0);
                //GL.Vertex3(0.0, 0.0, -50.0);

                //GL.End();
                //GraphicsContext.CurrentContext.VSync = true;
                glControl1.SwapBuffers();
            }
        private void btnStart_Click(object sender, EventArgs e) //port açma 
        {
            try
            {
                serialPort1.BaudRate = Convert.ToInt32(txtBoundRate.Text);
                serialPort1.PortName = cmbSerialPort.Text; //port adı
                if (!serialPort1.IsOpen)
                {
                    timerForBoundRate.Start();
                    serialPort1.Open();  
                    //Message.Show("Port Açıldı");
                    btnEnd.Enabled = true;
                    btnStart.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Kurulamadı");
                btnEnd.Enabled = true;
                //btnStart.Enabled = false;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e) //port kapatma
        {
            serialPort1.Close();
            timerForBoundRate.Stop();
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
        }

        private void timerForBoundRate_Tick(object sender, EventArgs e) //timer ile  veri alma
        {
            try
            {
                string[] paket;
                string sonuc = serialPort1.ReadLine();
                paket = sonuc.Split('/'); // (/) ile ayır
                lblAx.Text = paket[0];
                lblAy.Text = paket[1];
                lblAz.Text = paket[2];
                x = Convert.ToInt32(paket[0]);
                y = Convert.ToInt32(paket[1]);
                z = Convert.ToInt32(paket[2]);
                glControl1.Invalidate();
                serialPort1.DiscardInBuffer();
            }
            catch
            {
                MessageBox.Show("Veri Alınamadı");
            }
        }
      
            private void glControl1_Load(object sender, EventArgs e)
            {
                GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
                GL.Enable(EnableCap.DepthTest);
            }
        private void glControl1_Resize(object sender, EventArgs e)
            {
                GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
                GL.MatrixMode(MatrixMode.Projection);
                GL.LoadIdentity();
                Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(1.04f, 4 / 3, 1, 10000);
                GL.LoadMatrix(ref perspective);
                GL.MatrixMode(MatrixMode.Modelview);
            }
        /// ////////////////SİLİNDİR ÇİZİMİ////////////////////////
      
            private void silindir(float step, float topla, float radius, float dikey1, float dikey2)
            {
                float eski_step = 0.1f;
               GL.Begin(BeginMode.Quads); //Yükseklik CIZIM DAİRENİN
                while (step <= 360)
                {
                   
                    if (step < 90)
                        GL.Color3(Color.FromArgb(219, 115, 50)); //turuncu
                    else if (step < 180)
                        GL.Color3(Color.FromArgb(201, 44, 44)); //kırmızı
                    else if (step < 270)
                        GL.Color3(Color.FromArgb(219, 115, 50));
                    else if (step < 360)
                        GL.Color3(Color.FromArgb(201, 44, 44));


                    float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                    float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                    GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                    float ciz2_x = (float)(radius * Math.Cos((step + 2) * Math.PI / 180F));
                    float ciz2_y = (float)(radius * Math.Sin((step + 2) * Math.PI / 180F));
                    GL.Vertex3(ciz2_x, dikey1, ciz2_y);
                    GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                    GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                    step += topla;
                }
                GL.End();
                GL.Begin(BeginMode.Lines);
                step = eski_step;
                topla = step;
                while (step <= 180)// UST KAPAK
                {
                if (step < 90)
                    GL.Color3(Color.FromArgb(219, 115, 50)); //turuncu
                else if (step < 180)
                    GL.Color3(Color.FromArgb(201, 44, 44)); //kırmızı
                else if (step < 270)
                  GL.Color3(Color.FromArgb(219, 115, 50));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(201, 44, 44));

                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                    float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                    GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                    float ciz2_x = (float)(radius * Math.Cos((step + 180) * Math.PI / 180F));
                    float ciz2_y = (float)(radius * Math.Sin((step + 180) * Math.PI / 180F));
                    GL.Vertex3(ciz2_x, dikey1, ciz2_y);

                    GL.Vertex3(ciz1_x, dikey1, ciz1_y);
                    GL.Vertex3(ciz2_x, dikey1, ciz2_y);
                    step += topla;
                }
                step = eski_step;
                topla = step;
                while (step <= 180)//ALT KAPAK
                {
                if (step < 90)
                    GL.Color3(Color.FromArgb(219, 115, 50)); //turuncu
                else if (step < 180)
                    GL.Color3(Color.FromArgb(201, 44, 44)); //kırmızı
                else if (step < 270)
                    GL.Color3(Color.FromArgb(219, 115, 50));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(201, 44, 44));

                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                    float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                    GL.Vertex3(ciz1_x, dikey2, ciz1_y);

                    float ciz2_x = (float)(radius * Math.Cos((step + 180) * Math.PI / 180F));
                    float ciz2_y = (float)(radius * Math.Sin((step + 180) * Math.PI / 180F));
                    GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                    GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                    GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                    step += topla;
                }
                GL.End();
            }
           
          
        }
    

}
