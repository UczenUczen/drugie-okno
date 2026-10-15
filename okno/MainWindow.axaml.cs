using System;
using Avalonia.Controls;
using Avalonia.Threading;

namespace okno;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        UpdateDateTime();

        var timer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        timer.Tick += (s, e) => UpdateDateTime();
        timer.Start();
    }

    private void UpdateDateTime()
    {
        var dateTimeTextBlock = this.FindControl<TextBlock>("DateTimeTextBlock");
        if (dateTimeTextBlock != null)
        {
            dateTimeTextBlock.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}