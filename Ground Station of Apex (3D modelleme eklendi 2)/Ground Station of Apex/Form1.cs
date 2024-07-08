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
            float totalAngelx = 0, totalAngely = 0, totalAngelz = 0;
            
            

        public Form1()
            {
                InitializeComponent();
            }
            private void Form1_Load(object sender, EventArgs e)
            {
                GL.ClearColor(Color.FromArgb(93, 240, 167)); //gl arka plan rengi


            //portları comboboxa ekleme//
            string[] portlar = SerialPort.GetPortNames();
                foreach (string portAdi in portlar)
                {
                    cmbSerialPort.Items.Add(portAdi);
                }

                cmbBaudRate.Items.Add("2400");
                cmbBaudRate.Items.Add("4800");
                cmbBaudRate.Items.Add("9600");
                cmbBaudRate.Items.Add("19200");
                ////////////////////////////
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

                    GL.Rotate(totalAngelz, 1.0, 0.0, 0.0);//ÖNEMLİ
                    GL.Rotate(totalAngely, 0.0, 1.0, 0.0);
                    GL.Rotate(totalAngelx, 0.0, 0.0, 1.0);

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
                if (cmbSerialPort.Text == "" || cmbBaudRate.Text == "") //port ve baudrate seçilmediyse
                {
                    MessageBox.Show("Port ve Baud Rate Seçiniz");
                    return;
                }
                else
                {
                    serialPort1.BaudRate = Convert.ToInt32(cmbBaudRate.SelectedItem.ToString());
                    serialPort1.PortName = cmbSerialPort.Text; //port adı
                    

                }

                if (!serialPort1.IsOpen)
                {
                    timerForBoundRate.Start();
                    serialPort1.Open();
                    //Message.Show("Port Açıldı");
                    picStart2.Enabled = false;
                    picEnd2.Enabled = true;
                    picKalibre.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Kurulamadı");
                timerForBoundRate.Stop();
                picEnd2.Enabled = true;
                picStart2.Enabled = false;
               
            }
        }

        private void picStart_MouseHover(object sender, EventArgs e)
        {
            picStart.Visible = false;
            picStart2.Visible = true;
        }

        private void picStart_MouseLeave(object sender, EventArgs e)
        {
            picStart.Visible = true;
            picStart2.Visible = false;
        }

        private void btnEnd_Click(object sender, EventArgs e) //port kapatma
        {
            serialPort1.Close();
            timerForBoundRate.Stop();
            picStart2.Enabled = true;
            picEnd.Visible = true;
            picEnd2.Visible = false;
            picEnd2.Enabled = true;
        }

        private void picEnd_MouseHover(object sender, EventArgs e)
        {
            picEnd.Visible = false;
            picEnd2.Visible = true;
        }

        private void picEnd2_MouseLeave(object sender, EventArgs e)
        {
            picEnd.Visible = true;
            picEnd2.Visible = false;
        }

        private void timerForBoundRate_Tick(object sender, EventArgs e) //timer ile  veri alma
        {
            try
            {
                
                string[] paket;
                string sonuc = serialPort1.ReadLine();
                paket = sonuc.Split('/'); // (/) ile ayır
                lblAx.Text = Convert.ToString(totalAngelx);
                lblAy.Text = Convert.ToString(totalAngely);
                lblAz.Text = Convert.ToString(totalAngelz);
                


                x = Convert.ToSingle(paket[0]);
                y = Convert.ToSingle(paket[1]);
                z = Convert.ToSingle(paket[2]);

                totalAngelx += x/10;
                totalAngely += y/10;
                totalAngelz += z/10;
                
                
                glControl1.Invalidate();
                serialPort1.DiscardInBuffer();
            }
            catch
            {
                MessageBox.Show("Veri Alınamadı");
            }
        }

       
        //Form aksiyonları//


        private void picExit_MouseHover(object sender, EventArgs e) //çıkış butonu üzerine gelince rengi değiştir
        {
            picExit.Visible = false;
            picExit2.Visible = true;
        }

        private void picExit_MouseLeave(object sender, EventArgs e) //çıkış butonundan ayrılınca rengi eski haline döndür
        {
            picExit.Visible = true;
            picExit2.Visible = false;
        }

        private void picExit_Click(object sender, EventArgs e) //formu kapat
        {
            
            Application.Exit();

        }


        private void picDown_Click(object sender, EventArgs e) //formu aşağı indir
        {   
            this.WindowState = FormWindowState.Minimized;

        }

        private void picDown_MouseHover(object sender, EventArgs e) //aşağı indir butonu üzerine gelince rengi değiştir
        {
            picDown.Visible = false;
            picDown2.Visible = true;
        }

        private void picDown_MouseLeave(object sender, EventArgs e) //aşağı indir butonundan ayrılınca rengi eski haline döndür
        {
            picDown.Visible = true;
            picDown2.Visible = false;
        }


        private void picFullScreen_Click(object sender, EventArgs e) //formu tam ekran yap
        {
            if (Form1.ActiveForm.WindowState== FormWindowState.Maximized)
            {
                Form1.ActiveForm.WindowState = FormWindowState.Normal;
                picFullScreen.Visible = true;
            }
            else
            {
                Form1.ActiveForm.WindowState = FormWindowState.Maximized;
                picFullScreen.Visible = false;
                picFullScreen2.Visible = false;
            }
        }

        private void picFullScreen_MouseHover(object sender, EventArgs e) //tam ekran butonu üzerine gelince rengi değiştir
        {
            picFullScreen.Visible = false;
            picFullScreen2.Visible = true;
        }

        private void picFullScreen_MouseLeave(object sender, EventArgs e) //tam ekran butonundan ayrılınca rengi eski haline döndür
        {
            picFullScreen.Visible = true;
            picFullScreen2.Visible = false;

        }
        //Form aksiyonları sonu//


        private void glControl1_Load(object sender, EventArgs e)
            {
                GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
                GL.Enable(EnableCap.DepthTest);
            }

        private void btnKalibre_Click(object sender, EventArgs e)   //kalibrasyon
        {
            timerForBoundRate.Stop();
            totalAngelx = 0;
            totalAngely = 0;
            totalAngelz = 0;

            lblAx.Text = "0";
            lblAy.Text = "0";
            lblAz.Text = "0";

            picEnd2.Enabled = true;
            picStart.Enabled = true;

            glControl1.Invalidate();

        }

        private void picKalibre_MouseHover(object sender, EventArgs e) //kalibrasyon butonu üzerine gelince rengi değiştir
        {
            picKalibre.Visible = false;
            picKalibre2.Visible = true;
        }

        private void picKalibre_MouseLeave(object sender, EventArgs e) //kalibrasyon butonundan ayrılınca rengi eski haline döndür
        {
            picKalibre.Visible = true;
            picKalibre2.Visible = false;
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
