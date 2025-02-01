namespace avalonia_test.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public LiveDatasourceViewModel SourceDatasource { get; } = new();
    public LiveDatasourceViewModel TargetDatasource { get; } = new();
}