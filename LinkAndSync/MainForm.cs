#region
using System.ComponentModel;
using LinkAndSync.Properties;
#endregion

namespace LinkAndSync.Gui;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        if (DesignMode || Program.IsRunTime == false)
            return;

        uscSource.Path = Settings.Default.Source;
        uscLink.Path = Settings.Default.Link;
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        Settings.Default.Source = uscSource.Path;
        Settings.Default.Link = uscLink.Path;
        Settings.Default.Save();

        base.OnClosing(e);
    }

    private void btnGo_Click(object sender, EventArgs e)
    {
        Enabled = false;

        bgwWorker.RunWorkerAsync();
    }

    private void DeleteLinks(string targetDirectory)
    {
        var directories = Directory.GetDirectories(targetDirectory);
        foreach (var directory in directories)
            Directory.Delete(directory, true);

        var files = Directory.GetFiles(targetDirectory);
        var count = 0;
        foreach (var file in files)
        {
            File.Delete(file);
            ReportProgress(++count, files.Length);
        }
    }

    private void CopyDirectories(string sourceDirectory, string targetDirectory)
    {
        var sourceDirectories = Directory.GetDirectories(sourceDirectory, "*.*", SearchOption.AllDirectories);

        var targetDirectories = sourceDirectories.Select(x => x.Replace(sourceDirectory, targetDirectory)).ToList();

        var count = 0;
        foreach (var directory in targetDirectories)
        {
            Directory.CreateDirectory(directory);
            ReportProgress(++count, targetDirectories.Count);
        }
    }

    private void CreateLinks(string sourceDirectory, string targetDirectory)
    {
        var sourceFiles = Directory.GetFiles(sourceDirectory, "*.*", SearchOption.AllDirectories);
        var pairs = sourceFiles.Select(x => new { Source = x, Target = x.Replace(sourceDirectory, targetDirectory) })
            .ToList();

        var count = 0;
        foreach (var pair in pairs)
        {
            Linker.Instance.Create(pair.Target, pair.Source);
            ReportProgress(++count, pairs.Count);
        }
    }

    private void ReportProgress(int count, int total)
    {
        var progress = (int)(count * 100.0 / total);
        bgwWorker.ReportProgress(progress);
    }

    private void bgwWorker_DoWork(object sender, DoWorkEventArgs e)
    {
        bgwWorker.ReportProgress(0, nameof(DeleteLinks));
        DeleteLinks(uscLink.Path);

        bgwWorker.ReportProgress(0, nameof(CopyDirectories));
        CopyDirectories(uscSource.Path, uscLink.Path);

        bgwWorker.ReportProgress(0, nameof(CreateLinks));
        CreateLinks(uscSource.Path, uscLink.Path);
    }

    private void bgwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
        if (e.UserState is string status)
            lblStatus.Text = status;

        prbProgress.Value = e.ProgressPercentage;
    }

    private void bgwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        lblStatus.Text = "";
        prbProgress.Value = 0;
        Enabled = true;
    }
}