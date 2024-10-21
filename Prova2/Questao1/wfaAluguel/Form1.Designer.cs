namespace wfaAluguel;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pbVeiculo = new PictureBox();
        rbOnibus = new RadioButton();
        rbCaminhao = new RadioButton();
        lbPlaca = new Label();
        lbAno = new Label();
        mtbPlaca = new MaskedTextBox();
        tbAno = new TextBox();
        btCadastrar = new Button();
        btLimpar = new Button();
        lvTelinha = new ListView();
        Placa = new ColumnHeader();
        Ano = new ColumnHeader();
        Assentos = new ColumnHeader();
        Eixos = new ColumnHeader();
        Diaria = new ColumnHeader();
        pnlOnibus = new Panel();
        pnlCaminhao = new Panel();
        tbQtdEixos = new TextBox();
        lbQtdEixos = new Label();
        tbQtdAssentos = new TextBox();
        lbQtdAssentos = new Label();
        ((System.ComponentModel.ISupportInitialize)pbVeiculo).BeginInit();
        pnlOnibus.SuspendLayout();
        pnlCaminhao.SuspendLayout();
        SuspendLayout();
        // 
        // pbVeiculo
        // 
        pbVeiculo.Image = Properties.Resources.imagem0;
        pbVeiculo.InitialImage = null;
        pbVeiculo.Location = new Point(428, 21);
        pbVeiculo.Name = "pbVeiculo";
        pbVeiculo.Size = new Size(287, 196);
        pbVeiculo.SizeMode = PictureBoxSizeMode.StretchImage;
        pbVeiculo.TabIndex = 0;
        pbVeiculo.TabStop = false;
        // 
        // rbOnibus
        // 
        rbOnibus.AutoSize = true;
        rbOnibus.Location = new Point(46, 33);
        rbOnibus.Name = "rbOnibus";
        rbOnibus.Size = new Size(63, 19);
        rbOnibus.TabIndex = 1;
        rbOnibus.Text = "Ônibus";
        rbOnibus.UseVisualStyleBackColor = true;
        rbOnibus.CheckedChanged += rbOnibus_CheckedChanged;
        // 
        // rbCaminhao
        // 
        rbCaminhao.AutoSize = true;
        rbCaminhao.Location = new Point(228, 33);
        rbCaminhao.Name = "rbCaminhao";
        rbCaminhao.Size = new Size(80, 19);
        rbCaminhao.TabIndex = 2;
        rbCaminhao.Text = "Caminhão";
        rbCaminhao.UseVisualStyleBackColor = true;
        rbCaminhao.CheckedChanged += rbCaminhao_CheckedChanged;
        // 
        // lbPlaca
        // 
        lbPlaca.AutoSize = true;
        lbPlaca.Location = new Point(116, 111);
        lbPlaca.Name = "lbPlaca";
        lbPlaca.Size = new Size(35, 15);
        lbPlaca.TabIndex = 3;
        lbPlaca.Text = "Placa";
        // 
        // lbAno
        // 
        lbAno.AutoSize = true;
        lbAno.Location = new Point(116, 149);
        lbAno.Name = "lbAno";
        lbAno.Size = new Size(29, 15);
        lbAno.TabIndex = 4;
        lbAno.Text = "Ano";
        // 
        // mtbPlaca
        // 
        mtbPlaca.Location = new Point(208, 111);
        mtbPlaca.Mask = "AAA-0000";
        mtbPlaca.Name = "mtbPlaca";
        mtbPlaca.Size = new Size(156, 23);
        mtbPlaca.TabIndex = 6;
        // 
        // tbAno
        // 
        tbAno.Location = new Point(208, 149);
        tbAno.Name = "tbAno";
        tbAno.Size = new Size(156, 23);
        tbAno.TabIndex = 7;
        // 
        // btCadastrar
        // 
        btCadastrar.Location = new Point(176, 224);
        btCadastrar.Name = "btCadastrar";
        btCadastrar.Size = new Size(161, 44);
        btCadastrar.TabIndex = 9;
        btCadastrar.Text = "CADASTRAR";
        btCadastrar.UseVisualStyleBackColor = true;
        btCadastrar.Click += btCadastrar_Click;
        // 
        // btLimpar
        // 
        btLimpar.Location = new Point(384, 224);
        btLimpar.Name = "btLimpar";
        btLimpar.Size = new Size(161, 44);
        btLimpar.TabIndex = 10;
        btLimpar.Text = "LIMPAR";
        btLimpar.UseVisualStyleBackColor = true;
        btLimpar.Click += btLimpar_Click;
        // 
        // lvTelinha
        // 
        lvTelinha.Columns.AddRange(new ColumnHeader[] { Placa, Ano, Assentos, Eixos, Diaria });
        lvTelinha.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        lvTelinha.Location = new Point(46, 274);
        lvTelinha.Name = "lvTelinha";
        lvTelinha.Size = new Size(669, 131);
        lvTelinha.TabIndex = 11;
        lvTelinha.UseCompatibleStateImageBehavior = false;
        lvTelinha.SelectedIndexChanged += lvTelinha_SelectedIndexChanged;
        // 
        // pnlOnibus
        // 
        pnlOnibus.Controls.Add(pnlCaminhao);
        pnlOnibus.Controls.Add(tbQtdAssentos);
        pnlOnibus.Controls.Add(lbQtdAssentos);
        pnlOnibus.Location = new Point(103, 178);
        pnlOnibus.Name = "pnlOnibus";
        pnlOnibus.Size = new Size(273, 39);
        pnlOnibus.TabIndex = 12;
        // 
        // pnlCaminhao
        // 
        pnlCaminhao.Controls.Add(tbQtdEixos);
        pnlCaminhao.Controls.Add(lbQtdEixos);
        pnlCaminhao.Location = new Point(0, 1);
        pnlCaminhao.Name = "pnlCaminhao";
        pnlCaminhao.Size = new Size(273, 39);
        pnlCaminhao.TabIndex = 13;
        // 
        // tbQtdEixos
        // 
        tbQtdEixos.Location = new Point(105, 10);
        tbQtdEixos.Name = "tbQtdEixos";
        tbQtdEixos.Size = new Size(156, 23);
        tbQtdEixos.TabIndex = 8;
        // 
        // lbQtdEixos
        // 
        lbQtdEixos.AutoSize = true;
        lbQtdEixos.Location = new Point(8, 13);
        lbQtdEixos.Name = "lbQtdEixos";
        lbQtdEixos.Size = new Size(57, 15);
        lbQtdEixos.TabIndex = 5;
        lbQtdEixos.Text = "Qtd Eixos";
        // 
        // tbQtdAssentos
        // 
        tbQtdAssentos.Location = new Point(105, 10);
        tbQtdAssentos.Name = "tbQtdAssentos";
        tbQtdAssentos.Size = new Size(156, 23);
        tbQtdAssentos.TabIndex = 8;
        // 
        // lbQtdAssentos
        // 
        lbQtdAssentos.AutoSize = true;
        lbQtdAssentos.Location = new Point(8, 13);
        lbQtdAssentos.Name = "lbQtdAssentos";
        lbQtdAssentos.Size = new Size(77, 15);
        lbQtdAssentos.TabIndex = 5;
        lbQtdAssentos.Text = "Qtd Assentos";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(pnlOnibus);
        Controls.Add(lvTelinha);
        Controls.Add(btLimpar);
        Controls.Add(btCadastrar);
        Controls.Add(tbAno);
        Controls.Add(mtbPlaca);
        Controls.Add(lbAno);
        Controls.Add(lbPlaca);
        Controls.Add(rbCaminhao);
        Controls.Add(rbOnibus);
        Controls.Add(pbVeiculo);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pbVeiculo).EndInit();
        pnlOnibus.ResumeLayout(false);
        pnlOnibus.PerformLayout();
        pnlCaminhao.ResumeLayout(false);
        pnlCaminhao.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pbVeiculo;
    private RadioButton rbOnibus;
    private RadioButton rbCaminhao;
    private Label lbPlaca;
    private Label lbAno;
    private MaskedTextBox mtbPlaca;
    private TextBox tbAno;
    private Button btCadastrar;
    private Button btLimpar;
    private ListView lvTelinha;
    private Panel pnlOnibus;
    private Panel pnlCaminhao;
    private TextBox tbQtdEixos;
    private Label lbQtdEixos;
    private TextBox tbQtdAssentos;
    private Label lbQtdAssentos;
    private ColumnHeader Placa;
    private ColumnHeader Ano;
    private ColumnHeader Assentos;
    private ColumnHeader Eixos;
    private ColumnHeader Diaria;
}
