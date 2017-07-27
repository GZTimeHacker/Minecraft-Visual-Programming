 using System.Windows;
using MahApps.Metro.Controls;

namespace Minecraft_Visual_Programming.Trigger
{
    /// <summary>
    /// cured_zombie_villager.xaml 的交互逻辑
    /// </summary>
    public partial class cured_zombie_villager : MetroWindow
    {
        public cured_zombie_villager()
        {
            InitializeComponent();
        }
        public string result = "";
        public string villager = "";
        public string zombie = "";

        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            PreviewForm PR = new PreviewForm();
            PR.NewText(result);
            PR.ShowDialog();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            villager = Villager_input.Text;
            zombie = Zombie_input.Text;
            result = "\"" + Data.Global.Trigger + Data.Global.TGOrder.ToString() + "\": ";
            result += "\r\n\t\t" + "{";
            result += "\r\n\t\t" + "\"trigger\": \"minecraft:cured_zombie_villager\",";
            result += "\r\n\t\t" + "\"conditions\": ";
            result += "\r\n\t\t\t" + "{";
            if ((bool)IsVillager.IsChecked) { result += "\r\n\t\t\t" + "\"villager\":" + villager + ","; }
            if ((bool)IsZombie.IsChecked) { result += "\r\n\t\t\t" + "\"zombie\":" + zombie + ","; }
            if (!(bool)IsVillager.IsChecked & !(bool)IsZombie.IsChecked)
            {
                MessageBox.Show(Properties.Resources.NoIsChecked, Properties.Resources.Error);
                result = "";
            }
            result = result.TrimEnd(',');
            result += "\r\n\t\t\t" + "}" + "\r\n\t\t" + "}";
            MainWindow.ReturnTGText(result);
        }
    }
}
