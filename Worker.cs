using System.Diagnostics;

namespace MW_Error_Renamer
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    // Check for "License Manager Error" in running processes.
                    var processes = Process.GetProcesses();
                    bool licenseManagerErrorFound = false;
                    foreach (var process in processes)
                    {
                        if (process.MainWindowTitle.Contains("License Manager Error -1"))
                        {
                            licenseManagerErrorFound = true;
                            _logger.LogInformation("A program with the name containing 'License Manager Error' is found on the system.");
                            break;
                        }
                    }

                    if (!licenseManagerErrorFound)
                    {
                        _logger.LogInformation("No license manager errors found.");
                    }
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
