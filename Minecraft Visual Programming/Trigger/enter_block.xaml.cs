using System.Windows;
using MahApps.Metro.Controls;


namespace Minecraft_Visual_Programming.Trigger
{
    /// <summary>
    /// enter_block.xaml 的交互逻辑
    /// </summary>
    public partial class enter_block : MetroWindow
    {
        public enter_block()
        {
            InitializeComponent();
        }

        public string result = "";
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            result = "\"" + Data.Global.Trigger + Data.Global.TGOrder.ToString() + "\": ";
            result += "\r\n\t\t" + "{";
            result += "\r\n\t\t" + "\"trigger\": \"minecraft:enter_block\",";
            result += "\r\n\t\t" + "\"conditions\": ";
            result += "\r\n\t\t\t" + "{";
            result += "\r\n\t\t\t" + "\"block\":" +"\""+Block_input.Text+"\"";
            if ((bool)IsState.IsChecked)
            {
                result += ","+"\r\n\t\t\t\t" + "\"state\":" + "{";
                result += "\r\n\t\t\t\t" + State_input.Text;
                result += "\r\n\t\t\t\t" + "}";
            }
            result += "\r\n\t\t\t" + "}" + "\r\n\t\t" + "}";
            MainWindow.ReturnTGText(result);
        }
        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            PreviewForm PR = new PreviewForm();
            PR.NewText(result);
            PR.ShowDialog();
        }

        private void IsState_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsState.IsChecked) { State_input.IsEnabled = true; } else { State_input.IsEnabled = false; }
        }
    }
}
