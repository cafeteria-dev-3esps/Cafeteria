using Cafeteria.Services;

namespace Cafeteria.Forms;

/// <summary>
/// Tela de abertura: simula o carregamento do sistema com barra de progresso.
/// </summary>
public partial class FormSplash : Form
{
    private static readonly string[] MensagensCarregamento =
    {
        "Moendo os grãos...",
        "Aquecendo a máquina de espresso...",
        "Compilando o cardápio...",
        "Carregando o histórico de vendas...",
        "Servindo o primeiro café..."
    };

    private const int Incremento = 2;
    private int _progresso;

    public FormSplash()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        timerCarregamento.Start();
    }

    private void timerCarregamento_Tick(object sender, EventArgs e)
    {
        _progresso = Math.Min(_progresso + Incremento, 100);

        pnlBarraProgresso.Width = pnlBarraFundo.Width * _progresso / 100;

        var indice = Math.Min(_progresso * MensagensCarregamento.Length / 100, MensagensCarregamento.Length - 1);
        lblStatus.Text = $"{MensagensCarregamento[indice]}  {_progresso}%";

        // Pré-carrega as vendas salvas durante a abertura.
        if (_progresso == 60)
            _ = VendaRepository.ObterTodas();

        if (_progresso >= 100)
        {
            timerCarregamento.Stop();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
