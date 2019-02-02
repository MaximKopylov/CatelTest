namespace SimpleTest.Views
{
  using Catel.Windows;

  public partial class MainWindow
  {
    public MainWindow() : base(DataWindowMode.Custom, focusFirstControl:false)
    {
      InitializeComponent();
    }
  }
}
