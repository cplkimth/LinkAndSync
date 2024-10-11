namespace LinkAndSync.Gui;

public partial class FolderControl : UserControl
{
    public FolderControl()
    {
        InitializeComponent();
    }

    public string Path
    {
        get => txbBrowse.Text;
        set => txbBrowse.Text = value;
    }

    private void txbBrowse_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data!.GetDataPresent(DataFormats.FileDrop))
            e.Effect = DragDropEffects.Copy;
    }

    private void txbBrowse_DragDrop(object sender, DragEventArgs e)
    {
        var data = (string[])e.Data!.GetData(DataFormats.FileDrop);
        if (data!.Length != 1)
            return;

        txbBrowse.Text = data[0];
    }
}