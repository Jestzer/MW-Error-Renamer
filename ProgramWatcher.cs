using System.ComponentModel;
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
                        if (process.MainWindowTitle.Contains("License Manager Error -") && process.ProcessName.Equals("MATLAB", StringComparison.OrdinalIgnoreCase))
                        {
                            // Extract your error code and print a message accordingly.
                            string errorCode = process.MainWindowTitle.Split('-')[1];
                            string errorWindowMessage = errorCode switch
                            {
                                "1" => "Stop pointing to things that don't exist.",
                                "3" => "You got an error -3. How?? That's basically an error -15, but an old-ass version of it. Use a newer version of MATLAB, old man.",
                                "4" => "Guess what? You don't have unlimited seats on your license. Tell Joe to stop hogging all the seats and log off his goddamn computer when he's done running his shitty code, okay?",
                                "5" => "No, you don't have this product. Try getting it first? idk lmao",
                                "6" => "Oh, look at me, I'm using old versions of MATLAB because I HATE CHANGE",
                                "7" => "This is a messy one. Why don't you just give up now?",
                                "8" => "https://www.youtube.com/watch?v=GVXCr6upWUo",
                                "9" => "You didn't follow directions closely enough and now your program's DRM is ANGEERRRYYY at you :(",
                                "15" => "You got the classic connection error.\nDon't come running to me whining about how your ports are already opened and that your lousy telnet test passed. I don't care. Turn off your goddamn stupid firewall for fuck's sake.\n\nYes, really, this message applies to you. You're not special.",
                                "96" => "No, you didn't open your ports. Try again STOOPID.",
                                "117" => "What kind of shit did you fuck up to end up here??",
                                _ => string.Empty,
                            };

                            // Get rid of the original error message. You don't need it anymore. :)
                            process.Kill();
                            process.WaitForExit();

                            // Nothing other than a good video is needed.
                            if (errorCode == "8")
                            {
                                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(errorWindowMessage) { UseShellExecute = true });
                            }
                            else
                            {
                                this.Invoke(new Action(() =>
                                {
                                    new ErrorWindow($"Sike! {errorWindowMessage}\n\nLicense Manager Error: -{errorCode}, AKA u dumb.").ShowDialog();
                                }));
                            }

                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error showing your custom error message: {ex.Message}");
                    }
                }
                await Task.Delay(500, stoppingToken); // Wait before checking again.
            }
        }
    }
}
