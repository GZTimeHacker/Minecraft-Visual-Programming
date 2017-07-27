using System.Windows;
using MahApps.Metro.Controls;

namespace Minecraft_Visual_Programming.Trigger
{
    /// <summary>
    /// brewed_potion.xaml 的交互逻辑
    /// </summary>
    public partial class brewed_potion : MetroWindow
    {
        public brewed_potion()
        {
            InitializeComponent();
        }

        public string result = "";

        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            PreviewForm PR = new PreviewForm();
            PR.NewText(result);
            PR.ShowDialog();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            result = "\"" + Data.Global.Trigger + Data.Global.TGOrder.ToString() + "\": ";
            result += "\r\n\t\t" + "{";
            result += "\r\n\t\t" + "\"trigger\": \"minecraft:brewed_potion\",";
            result += "\r\n\t\t" + "\"conditions\": ";
            result += "\r\n\t\t\t" + "{";
            result += "\r\n\t\t\t" + "\" potion\":" + Potion_input.Text;
            result += "\r\n\t\t\t"+"}" + "\r\n\t\t"+"}";
            MainWindow.ReturnTGText(result);
        }
    }
}
