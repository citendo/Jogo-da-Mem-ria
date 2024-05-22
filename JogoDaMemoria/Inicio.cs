using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        //Evento do botão iniciar para chamar a outra tela e fechar essa
        public void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t1 = new Thread(() => { Application.Run(new FaseUm()); });
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            this.Close();
        }
    }
}
