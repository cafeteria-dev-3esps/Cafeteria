namespace Cafeteria.UI;

/// <summary>
/// Paleta de cores e estilos visuais compartilhados por todas as telas.
/// </summary>
public static class Tema
{
    public static readonly Color Cafe = Color.FromArgb(62, 39, 35);
    public static readonly Color CafeMedio = Color.FromArgb(109, 76, 65);
    public static readonly Color Caramelo = Color.FromArgb(198, 134, 66);
    public static readonly Color Creme = Color.FromArgb(245, 235, 224);
    public static readonly Color Verde = Color.FromArgb(46, 125, 50);
    public static readonly Color Vermelho = Color.FromArgb(183, 28, 28);
    public static readonly Color Cinza = Color.FromArgb(120, 110, 105);

    public static void EstilizarBotao(Button botao, Color fundo)
    {
        botao.FlatStyle = FlatStyle.Flat;
        botao.FlatAppearance.BorderSize = 0;
        botao.BackColor = fundo;
        botao.ForeColor = Color.White;
        botao.Cursor = Cursors.Hand;
        botao.FlatAppearance.MouseOverBackColor = ControlPaint.Light(fundo, 0.25f);
        botao.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(fundo, 0.1f);
    }

    public static void EstilizarGrid(DataGridView grid)
    {
        grid.BackgroundColor = Color.White;
        grid.BorderStyle = BorderStyle.None;
        grid.GridColor = Color.FromArgb(230, 220, 210);
        grid.EnableHeadersVisualStyles = false;
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        grid.ColumnHeadersHeight = 36;
        grid.ColumnHeadersDefaultCellStyle.BackColor = CafeMedio;
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = CafeMedio;
        grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grid.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
        grid.DefaultCellStyle.SelectionBackColor = Caramelo;
        grid.DefaultCellStyle.SelectionForeColor = Color.White;
        grid.AlternatingRowsDefaultCellStyle.BackColor = Creme;
        grid.RowTemplate.Height = 30;
        grid.ReadOnly = true;
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AllowUserToResizeRows = false;
        grid.RowHeadersVisible = false;
        grid.MultiSelect = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    public static void Aviso(IWin32Window dono, string mensagem) =>
        MessageBox.Show(dono, mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
