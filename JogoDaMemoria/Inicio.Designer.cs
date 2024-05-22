namespace JogoDaMemoria
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            btnIniciar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(263, 425);
            btnIniciar.Margin = new Padding(3, 2, 3, 2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(125, 44);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(91, 45);
            label1.Name = "label1";
            label1.Size = new Size(413, 26);
            label1.TabIndex = 1;
            label1.Text = "Bem Vindo ao Jogo da memória da Disney.\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(67, 88);
            label2.Name = "label2";
            label2.Size = new Size(470, 85);
            label2.TabIndex = 2;
            label2.Text = "Você vai passar por 3 fases onde cada uma tem um nivel de difculdade\r\nSendo elas\r\nFase 1 - Fácil\r\nfase 2 - Médio\r\nFase 3 - Difícil\r\n";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img5e292badf2be66_84050594;
            ClientSize = new Size(584, 480);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIniciar);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Label label1;
        private Label label2;
    }
}