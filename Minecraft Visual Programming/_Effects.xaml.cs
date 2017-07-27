using System.Windows;
using MahApps.Metro.Controls;

namespace Minecraft_Visual_Programming
{
    /// <summary>
    /// Effects.xaml 的交互逻辑
    /// </summary>
    public partial class Effects : MetroWindow
    {
        Data.Data data = new Data.Data();
        public Effects()
        {
            InitializeComponent();
            for(int i = 0; i < data.GetEffectCount(); i++)
            {
                SelEffect.Items.Add(data.GetEffect(i)[1]+":"+data.GetEffect(i)[0]);
            }
        }
        public string result = "";
        public string amplifier = "";
        public string duration = "";

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            result += "\r\n\t\t\t" + "\"effects\":";
            result += "\r\n\t\t\t" + "{\r\n\t\t\t\t\"" + data.GetEffect(GetEffectOrder())[0] + "\":";
            result += "\r\n\t\t\t\t" + "{";
            if ((bool)IsAmplifier.IsChecked) { result += "\r\n\t\t\t\t" + "\"amplifier\":" + amplifier + ","; }
            if ((bool)IsDuration.IsChecked) { result += "\r\n\t\t\t\t" + "\"duration\":" + duration + ","; }
            result = result.TrimEnd(',');
            result += "\r\n\t\t\t\t" + "}" + "\r\n\t\t\t" + "}";
        }

        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            PreviewForm PR = new PreviewForm();
            PR.NewText(result);
            PR.ShowDialog();
        }

        private void GetAmplifier_Click(object sender, RoutedEventArgs e)
        {
            amplifier=MainWindow.GetMIN_MAX(255, 255);
        }

        private void GetDuration_Click(object sender, RoutedEventArgs e)
        {
            duration = MainWindow.GetMIN_MAX(9999, 9999);
        }

        private int GetEffectOrder()
        {
            string Str = SelEffect.SelectionBoxItem.ToString();
            int EffectOrder = -1;
            for (int i = 0; i < data.GetEffectCount(); i++)
            {
                if (Str == data.GetEffect(i)[1] + ":" + data.GetEffect(i)[0]) { EffectOrder = i; }
            }
            if (EffectOrder == -1)
            {
                MessageBox.Show(Properties.Resources.ErrorEffectOrder, Properties.Resources.Error);
            }
            return EffectOrder;
        }

        private void IsAmplifier_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsAmplifier.IsChecked) { GetAmplifier.IsEnabled = true; } else { GetAmplifier.IsEnabled = false; }
        }

        private void IsDuration_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsDuration.IsChecked) { GetDuration.IsEnabled = true; } else { GetDuration.IsEnabled = false; }
        }

        public string GetEffects() { return result; }
    }
}
