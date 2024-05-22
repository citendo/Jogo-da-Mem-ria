using JogoDaMemoria.Properties;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;

namespace JogoDaMemoria
{
    public partial class FaseTres : Form
    {

        int[] x = { 12, 158, 304, 450, 596, 742, 888, 1034 };
        int[] y = { 12, 118, 224, 330, 436, 542, 648, 754 };
        int tagIndex, cliques, cartasEncontradas;

        int[] tags = new int[2];
        List<string> lista = new List<string>();
        Image[] img = new Image[32];

        Random rdn = new Random();
        public FaseTres()
        {
            InitializeComponent();

            //passa por todas Picture box e muda a imagem para o verso, alem de pegar o elemento tag para validar os pares posteriormente.
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                tagIndex = int.Parse(String.Format("{0}", item.Tag));
                img[tagIndex] = item.Image;
                item.Image = Resources.Verso;
                item.Enabled = true;
            }

            Embaralhar();
        }

        //Aqui ele embaralha aleatoriamente, usando o vetor de posições instaciado no começo da tela.
        private void Embaralhar()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                (int, int) tupla = VerificaPosicao();
                item.Location = new Point(tupla.Item1, tupla.Item2);
            }
        }

        //Evento do Click, onde a pessoa clica no Picture box e a carta vira.
        private void ImagensClick_Click(object sender, EventArgs e)
        {
            bool parEncontrado = false;
            PictureBox pic = (PictureBox)sender;
            cliques++;
            tagIndex = int.Parse(string.Format("{0}", pic.Tag));
            pic.Image = img[tagIndex];
            pic.Refresh();

            if (cliques == 1)
            {
                tags[0] = int.Parse(string.Format("{0}", pic.Tag));
            }

            if (cliques == 2)
            {
                tags[1] = int.Parse(string.Format("{0}", pic.Tag));
                parEncontrado = tags[0] == tags[1];
                Desvirar(parEncontrado);
                cliques = 0;
            }
            Thread.Sleep(100);
        }

        //Sistema de recursivade, feita para checar a posição, se já tiver sido usada, ele tenta novamente chamando o metodo novamente.
        private (int, int) VerificaPosicao()
        {
            int posicaox = x[rdn.Next(0, x.Length)];
            int posicaoy = y[rdn.Next(0, y.Length)];

            string verificacao = posicaox.ToString() + posicaoy.ToString();

            if (lista.Contains(verificacao))
            {
                return VerificaPosicao();
            }

            lista.Add(verificacao);
            return (posicaox, posicaoy);
        }

        //Metodo para validar se encontrou o par, é meio anti-performatico... ter que percorrer todo o array de picture box, mas como precisamos desabilitar a picture box, vamos precisar achar ela e desabilitar.
        private void Desvirar(bool check)
        {
            Thread.Sleep(900);

            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                if (int.Parse(String.Format("{0}", item.Tag)) == tags[0] || int.Parse(String.Format("{0}", item.Tag)) == tags[1])
                {
                    if (!check)
                    {
                        item.Image = Resources.Verso;
                        item.Refresh();
                        continue;
                    }

                    item.Enabled = false;
                    cartasEncontradas++;
                }
            }

            FinalJogo();
        }

        //Aqui valida o final do jogo, e faz o sistema de threads para fechar a tela e abrir outra.
        private void FinalJogo()
        {
            if (cartasEncontradas == (img.Length * 2))
            {
                DialogResult resultado = MessageBox.Show("Parabens você Finalizou o jogo, Deseja jogar novamente?", "", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                    Thread t1 = new Thread(() => { Application.Run(new FaseDois()); });
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                    this.Close();

                    return;
                }

                this.Close();
            }
        }
    }
}
