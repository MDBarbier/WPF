using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BackgroundWorker_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BackgroundWorker bgWorker;

        public MainWindow()
        {
            InitializeComponent();
            bgWorker = ((BackgroundWorker)this.FindResource("backgroundWorker"));
        }

        private int DoSlowProcess(int iterations, BackgroundWorker bgWorker, DoWorkEventArgs e)
        {
            int result = 0;
            for (int i = 0; i <= iterations; i++)
            {
                if (bgWorker != null)
                {
                    if (bgWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return result;
                    }

                    if (bgWorker.WorkerReportsProgress)
                    {
                        int percentComplete = (int)((float)i / (float)iterations * 100);
                        bgWorker.ReportProgress(percentComplete);
                    }

                }

                Thread.Sleep(100);
                result = i;
            }
            return result;
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            int iterations = 0;
            if (int.TryParse(InputTB.Text, out iterations))
            {
                bgWorker.RunWorkerAsync(iterations);
                StartButton.IsEnabled = false;
                CancelButton.IsEnabled = true;
                OutputTB.Text = "";
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgw = sender as BackgroundWorker;
            e.Result = DoSlowProcess((int)e.Argument, bgw, e);
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                OutputTB.Text = "Cancelled";
            }
            else
            {
                OutputTB.Text = e.Result.ToString();
                ProgressBar.Value = 0;
            }
            StartButton.IsEnabled = true;
            CancelButton.IsEnabled = false;
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.bgWorker.CancelAsync();
        }
    }
}
