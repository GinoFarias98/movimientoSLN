using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movimiento
{
    public partial class Form1 : Form
    {
        int velocidad = 10;
        int pasoH = 10;
        int pasoV = 5;
        int posicionH = 0;
        int posicionV = 0;
        int velocidad2 = 5;
        int pasoH2 = 5;
        int pasoV2 = 2;
        int posicionH2 = 0;
        int posicionV2 = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private async void btInicio_Click(object sender, EventArgs e)
        {
            btInicio.Visible = false;
            Label figura2 = new Label();
            Label figura = new Label();
            figura.BackColor = Color.Red;
            figura.Text = "";
            figura.Top = posicionV;
            figura.Left = posicionH;
            figura.Width = 50;
            figura.Height = 50;
            Controls.Add(figura);

            figura2.BackColor = Color.Blue;
            figura.Text = "";
            figura.Top = posicionV2;
            figura.Left = posicionH2;
            figura.Width = 50;
            figura.Height = 50;
            Controls.Add(figura2);

            for (int i = 0; i < this.Width; i++)
            {
                posicionH2 = posicionH2 + pasoH2;
                figura2.Left = posicionH2;
                posicionV2 = posicionV2 + pasoV2;
                figura2.Top = posicionV2;
                if ((posicionH2 + figura2.Width) > this.Width)
                {
                    pasoH2 = -1 * pasoH2;
                }
                else if (posicionH2 < 0)
                {
                    pasoH2 = -1 * pasoH2;
                }
                if ((posicionV2 + figura2.Height) > this.Height)
                {
                    pasoV2 = -1 * pasoV2;
                }
                else if (posicionV2 < 0)
                {
                    pasoV2 = -1 * pasoV2;
                }

                this.Refresh();
                figura2.Top = figura2.Top + pasoV2;
                figura2.Left = figura2.Left + pasoH2;
                await Task.Delay(velocidad2);


                for (int j = 0; j < this.Width; j++)
                {
                    posicionH = posicionH + pasoH;
                    figura.Left = posicionH;
                    posicionV = posicionV + pasoV;
                    figura.Top = posicionV;
                    if ((posicionH + figura.Width) > this.Width)
                    {
                        pasoH = -1 * pasoH;
                    }
                    else if (posicionH < 0)
                    {
                        pasoH = -1 * pasoH;
                    }
                    if ((posicionV + figura.Height) > this.Height)
                    {
                        pasoV = -1 * pasoV;
                    }
                    else if (posicionV < 0)
                    {
                        pasoV = -1 * pasoV;
                    }

                    this.Refresh();
                    figura.Top = figura.Top + pasoV;
                    figura.Left = figura.Left + pasoH;
                    await Task.Delay(velocidad);
                }

            }
        }
    }
}
