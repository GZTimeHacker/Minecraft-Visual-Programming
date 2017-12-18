using System.Windows;
using MahApps.Metro.Controls;
using System.Text.RegularExpressions;

namespace Minecraft_Visual_Programming
{
    /// <summary>
    /// MinAndMax.xaml 的交互逻辑
    /// </summary>
    public partial class MinAndMax : MetroWindow
    {
        public MinAndMax()
        {
            InitializeComponent();
        }
        public string result = "";
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            result = "\r\n\t\t\t\t{";
            if ((bool)IsMIN.IsChecked) { result += "\r\n\t\t\t\t" + "\"min\": " + EditMIN.Value + "," ; }
            if ((bool)IsMAX.IsChecked) { result += "\r\n\t\t\t\t" + "\"max\": " + EditMAX.Value + ","; }
            if (!(bool)IsMAX.IsChecked & !(bool)IsMIN.IsChecked)
            {
                MessageBox.Show(Properties.Resources.NoIsChecked, Properties.Resources.Error);
                result = "";
            }
            result = result.TrimEnd(',');
            result += "\r\n\t\t\t\t}";
        }
        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            PreviewForm PR = new PreviewForm();
            PR.NewText(result);
            PR.ShowDialog();
        }
        /// <summary>
        /// 设置最大值及最小值
        /// </summary>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        public void SetMaxAndMin(int min,int max)
        {
            EditMIN.Maximum = min;
            EditMAX.Maximum = max;
        }

        public string GetMaxAndMin() { return result; }

        private void IsMIN_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsMIN.IsChecked) { EditMIN.IsEnabled = true; } else { EditMIN.IsEnabled = false; }
            if ((bool)IsMIN.IsChecked) { MinText.IsEnabled = true; } else { MinText.IsEnabled = false; }
        }

        private void IsMAX_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsMAX.IsChecked) { EditMAX.IsEnabled = true; } else { EditMAX.IsEnabled = false; }
            if ((bool)IsMAX.IsChecked) { MaxText.IsEnabled = true; } else { MaxText.IsEnabled = false; }
        }

        private void MinText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (regex.IsMatch(MinText.Text))
            {
                int i;
                if(int.TryParse(MinText.Text,out i)) { EditMIN.Value = i; }
                else { MessageBox.Show(Properties.Resources.NotInt, Properties.Resources.Error); }
                if (i > EditMIN.Maximum) { MinText.Text = EditMIN.Maximum.ToString(); }
            }
            else
            {
                MessageBox.Show(Properties.Resources.NotInt,Properties.Resources.Error);
            }
        }

        private void MaxText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            if (regex.IsMatch(MaxText.Text))
            {
                int i;
                if(int.TryParse(MaxText.Text,out i)) { EditMAX.Value = i; }
                else { MessageBox.Show(Properties.Resources.NotInt, Properties.Resources.Error); }
                if (i > EditMAX.Maximum) { MaxText.Text = EditMAX.Maximum.ToString(); }
            }
            else
            {
                MessageBox.Show(Properties.Resources.NotInt, Properties.Resources.Error);
            }
        }

    }
}
