using System.Windows;
using MahApps.Metro.Controls;


namespace Minecraft_Visual_Programming.Trigger
{
    /// <summary>
    /// cured_zombie_villager.xaml 的交互逻辑
    /// </summary>
    public partial class consume_item : MetroWindow
    {
        public consume_item()
        {
            InitializeComponent();
        }

        public string result = "";
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            result = "\"" + Data.Global.Trigger + Data.Global.TGOrder.ToString() + "\": ";
            result += "\r\n\t\t" + "{";
            result += "\r\n\t\t" + "\"trigger\": \"minecraft:consume_item\",";
            result += "\r\n\t\t" + "\"conditions\": ";
            result += "\r\n\t\t\t" + "{";
            result += "\r\n\t\t\t" + "\"item\":" + Item_input.Text;
            result += "\r\n\t\t\t" + "}" + "\r\n\t\t" + "}";
            MainWindow.ReturnTGText(result);
        }
        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            PreviewForm PR = new PreviewForm();
            PR.NewText(result);
            PR.ShowDialog();
        }
    }
}
