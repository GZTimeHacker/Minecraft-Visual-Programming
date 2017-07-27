using System.Windows;
using MahApps.Metro.Controls;

namespace Minecraft_Visual_Programming.Trigger
{
    /// <summary>
    /// entity_hurt_player.xaml 的交互逻辑
    /// </summary>
    public partial class entity_hurt_player : MetroWindow
    {
        public entity_hurt_player()
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
            result += "\r\n\t\t" + "\"trigger\": \"minecraft:bred_animals\",";
            result += "\r\n\t\t" + "\"conditions\": ";
            result += "\r\n\t\t\t" + "{";

            result += "\r\n\t\t\t" + "\"damage\":";
            result += "\r\n\t\t\t\t" + "{";
            result += "\r\n\t\t\t\t" + Damage_input.Text;
            result += "\r\n\t\t\t\t" + "}";

            result += "\r\n\t\t\t" + "}" + "\r\n\t\t" + "}";

            MainWindow.ReturnTGText(result);
        }
    }
}
