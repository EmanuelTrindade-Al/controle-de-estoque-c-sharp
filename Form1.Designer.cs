namespace ControleEstoqueWin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQtd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Text = "ID:";
            this.lblId.Location = new System.Drawing.Point(20, 20);
            this.lblId.AutoSize = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(80, 20);
            this.txtId.Width = 100;
            // 
            // lblNome
            // 
            this.lblNome.Text = "Nome:";
            this.lblNome.Location = new System.Drawing.Point(20, 60);
            this.lblNome.AutoSize = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 60);
            this.txtNome.Width = 200;
            // 
            // lblQtd
            // 
            this.lblQtd.Text = "Quantidade:";
            this.lblQtd.Location = new System.Drawing.Point(20, 100);
            this.lblQtd.AutoSize = true;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(110, 100);
            this.txtQtd.Width = 80;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Location = new System.Drawing.Point(20, 150);
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.Location = new System.Drawing.Point(120, 150);
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Text = "Saída";
            this.btnSaida.Location = new System.Drawing.Point(220, 150);
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(20, 200);
            this.listBox1.Size = new System.Drawing.Size(360, 200);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.listBox1);
            this.Text = "Controle de Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
