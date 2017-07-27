using System.Windows;
using MahApps.Metro.Controls;

namespace Minecraft_Visual_Programming.Trigger
{
    /// <summary>
    /// enchanted_item.xaml 的交互逻辑
    /// </summary>
    public partial class enchanted_item : MetroWindow
    {
        Data.Data data = new Data.Data();
        public enchanted_item()
        {
            InitializeComponent();
        }
        public string result = "";
        public string levels = "";

        private void Create_Click(object sender, RoutedEventArgs e)
        {

            result = "\"" + Data.Global.Trigger + Data.Global.TGOrder.ToString() + "\": ";
            result += "\r\n\t\t" + "{";
            result += "\r\n\t\t" + "\"trigger\": \"minecraft:enchanted_item\",";
            result += "\r\n\t\t" + "\"conditions\": ";
            result += "\r\n\t\t\t" + "{";
            if ((bool)IsItem.IsChecked) { result += "\r\n\t\t\t" + "\"item\":" + Item_input.Text + ","; }
            if ((bool)IsLevels.IsChecked) { result += "\r\n\t\t\t" + "\"levels\":" + levels + ","; }
            if (!(bool)IsItem.IsChecked & !(bool)IsLevels.IsChecked)
            {
                MessageBox.Show(Properties.Resources.NoIsChecked, Properties.Resources.Error);
                result = "";
            }
            result = result.TrimEnd(',');
            result += "\r\n\t\t\t" + "}" + "\r\n\t\t" + "}";

            MainWindow.ReturnTGText(result);
        }
        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            PreviewForm PR = new PreviewForm();
            PR.NewText(result);
            PR.ShowDialog();
        }

        private void GetLevels_Click(object sender, RoutedEventArgs e)
        {
            levels=MainWindow.GetMIN_MAX(100,100);
        }

        private void IsItem_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsItem.IsChecked) { Item_input.IsEnabled = true; } else { Item_input.IsEnabled=false;}
        }

        private void IsLevels_Click(object sender, RoutedEventArgs e)
        {
            if ((bool) IsLevels.IsChecked){ GetLevels.IsEnabled = true; } else { GetLevels.IsEnabled = false; }
        }
    }
}
