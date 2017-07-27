using System.Windows;
using MahApps.Metro.Controls;

namespace Minecraft_Visual_Programming.Trigger
{
    /// <summary>
    /// bred_animals.xaml 的交互逻辑
    /// </summary>
    public partial class bred_animals : MetroWindow
    {
        public bred_animals()
        {
            InitializeComponent();
        }
        public string result = "";
        public string child = "";
        public string parent = "";
        public string partner = "";

        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            PreviewForm PR = new PreviewForm();
            PR.NewText(result);
            PR.ShowDialog();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            child = Child_input.Text;
            parent = Parent_input.Text;
            partner = Partner_input.Text;
            result = "\"" + Data.Global.Trigger + Data.Global.TGOrder.ToString() + "\": ";
            result += "\r\n\t\t" + "{";
            result += "\r\n\t\t" + "\"trigger\": \"minecraft:bred_animals\",";
            result += "\r\n\t\t" + "\"conditions\": ";
            result += "\r\n\t\t\t" + "{";
            result += "\r\n\t\t\t" + "\"child\":" + child + ",";
            result += "\r\n\t\t\t" + "\"parent\":" + parent + ",";
            result += "\r\n\t\t\t" + "\"partner\":" + partner;
            result += "\r\n\t\t\t}" + "\r\n\t\t}";
            MainWindow.ReturnTGText(result);
        }
    }
}
