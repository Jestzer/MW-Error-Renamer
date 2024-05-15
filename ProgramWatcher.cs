using System.Diagnostics;

namespace MW_Error_Renamer
{
    public partial class ProgramWatcher : Form
    {
        public ProgramWatcher()
        {
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            this.Load += (sender, e) => { this.Visible = false; };
            StartWatching();
        }

        private void StartWatching()
        {
            Task.Run(() => WatchForProcess(CancellationToken.None));
        }

        private async Task WatchForProcess(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var processes = Process.GetProcesses();
                foreach (var process in processes)
                {
                    try
                    {
                        if (process.MainWindowTitle.Contains("License Manager Error -1"))
                        {
                            process.Kill();
                            process.WaitForExit();

                            this.Invoke(new Action(() =>
                            {
                                new ErrorWindow("Sike! Stop pointing to things that don't exist.\nLicense Manager Error: u dumb.").ShowDialog();
                            }));

                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error showing your custom error message: {ex.Message}");
                    }
                }
                await Task.Delay(1000, stoppingToken); // Wait before checking again.
            }
        }
    }
}
