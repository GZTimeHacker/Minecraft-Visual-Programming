using System.Windows;
using MahApps.Metro.Controls;

namespace Minecraft_Visual_Programming.Trigger
{
    /// <summary>
    /// construct_beacon.xaml 的交互逻辑
    /// </summary>
    public partial class construct_beacon : MetroWindow
    {
        public construct_beacon()
        {
            InitializeComponent();
        }
        public string result = "";
        public string level = "";

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            result = "\"" + Data.Global.Trigger + Data.Global.TGOrder.ToString() + "\": ";
            result += "\r\n\t\t" + "{";
            result += "\r\n\t\t" + "\"trigger\": \"minecraft:construct_beacon\",";
            result += "\r\n\t\t" + "\"conditions\": ";
            result += "\r\n\t\t\t" + "{";
            result += "\r\n\t\t\t" + "\"levels\":" + level;
            result += "\r\n\t\t\t" + "}" + "\r\n\t\t" + "}";
            MainWindow.ReturnTGText(result);
        }
        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            PreviewForm PR = new PreviewForm();
            PR.NewText(result);
            PR.ShowDialog();
        }

        private void GetLevel_Click(object sender, RoutedEventArgs e)
        {
            level = MainWindow.GetMIN_MAX(4, 4);
        }
    }
}
