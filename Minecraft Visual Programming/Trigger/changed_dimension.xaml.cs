using System.Windows;
using MahApps.Metro.Controls;

namespace Minecraft_Visual_Programming.Trigger
{
    /// <summary>
    /// changed_dimension.xaml 的交互逻辑
    /// </summary>
    public partial class changed_dimension : MetroWindow
    {
        public changed_dimension()
        {
            InitializeComponent();
            From_input.Items.Add("overworld");
            From_input.Items.Add("the_nether");
            From_input.Items.Add("the_end");
            To_input.Items.Add("overworld");
            To_input.Items.Add("the_nether");
            To_input.Items.Add("the_end");
        }
 
        public string result = "";

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            result = "\"" + Data.Global.Trigger + Data.Global.TGOrder.ToString() + "\": ";
            result += "\r\n\t\t" + "{";
            result += "\r\n\t\t" + "\"trigger\": \"minecraft:changed_dimension\",";
            result += "\r\n\t\t" + "\"conditions\": ";
            result += "\r\n\t\t\t" + "{";
            result += "\r\n\t\t\t" + "\"from\":\"" + From_input.SelectionBoxItem.ToString() + "\",";
            result += "\r\n\t\t\t" + "\"to\":\"" + To_input.SelectionBoxItem.ToString()+"\"";
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
