namespace wfaAluguel;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    private void rbOnibus_CheckedChanged(object sender, EventArgs e)
    {
        pnlCaminhao.Visible = false;
        pnlOnibus.Visible = true;
        pbVeiculo.Image = Properties.Resources.onibus;

    }

    private void rbCaminhao_CheckedChanged(object sender, EventArgs e)
    {
        pnlOnibus.Visible = false;
        pnlCaminhao.Visible = true;
        pbVeiculo.Image = Properties.Resources.caminhao;
    }

    private void btCadastrar_Click(object sender, EventArgs e)
    {
        if (rbOnibus.Checked)
        {
            Veiculo Busao = new Onibus(mtbPlaca.Text, Convert.ToInt32(tbAno.Text), Convert.ToInt32((tbQtdAssentos.Text)));
            lvTelinha.Columns.Add(Busao.Placa);
            lvTelinha.Columns.Add(tbAno.Text);
            lvTelinha.Columns.Add(tbQtdAssentos.Text);

        }
        else if (rbCaminhao.Checked)
        {
            Veiculo Caminha = new Caminhao(mtbPlaca.Text, Convert.ToInt32(tbAno.Text), Convert.ToInt32(tbQtdEixos.Text));
            lvTelinha.Columns.Add(Caminha.Placa);
            lvTelinha.Columns.Add(tbAno.Text);
            lvTelinha.Columns.Add(tbQtdAssentos.Text);
        }
    }

    private void btLimpar_Click(object sender, EventArgs e)
    {
        lvTelinha.Clear();
    }

    private void lvTelinha_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
