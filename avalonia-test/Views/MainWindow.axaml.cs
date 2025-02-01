using System;
using avalonia_test.ViewModels;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace avalonia_test.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CompareButton_OnClick(object? sender, RoutedEventArgs e)
    {
        var data = (MainWindowViewModel) DataContext!;
        Console.WriteLine($"TODO: compare {data.SourceDatasource.Host} to {data.TargetDatasource.Host}");
    }
}