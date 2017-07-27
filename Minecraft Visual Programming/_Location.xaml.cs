using System.Windows;
using MahApps.Metro.Controls;

namespace Minecraft_Visual_Programming
{
    /// <summary>
    /// Location.xaml 的交互逻辑
    /// </summary>
    public partial class Location : MetroWindow
    {
        Data.Data data = new Data.Data();
        public Location()
        {
            InitializeComponent();
            for (int i = 0;i<data.GetBiomeCount();i++)
            {
                SelBiome.Items.Add(data.GetBiome(i)[1]+":\r\n"+data.GetBiome(i)[0]);
            }
            SelDimension.Items.Add("overworld");
            SelDimension.Items.Add("the_nether");
            SelDimension.Items.Add("the_end");
            for(int i = 0; i < data.GetStructuresCount(); i++)
            {
                SelFeature.Items.Add(data.GetStructures(i)[1]+":\r\n"+data.GetStructures(i)[0]);
            }
        }

        private int GetBiomeOrder()
        {
            string Str = SelBiome.SelectionBoxItem.ToString();
            int BiomeOrder = -1;
            for (int i = 0; i < data.GetBiomeCount(); i++)
            {
                if (Str == data.GetBiome(i)[1] + ":\r\n" + data.GetBiome(i)[0]) { BiomeOrder = i; }
            }
            if (BiomeOrder == -1)
            {
                MessageBox.Show(Properties.Resources.ErrorBiomeOrder, Properties.Resources.Error);
            }
            return BiomeOrder;
        }

        private int GetStructuresOrder()
        {
            string Str = SelFeature.SelectionBoxItem.ToString();
            int FeatureOrder = -1;
            for (int i = 0; i < data.GetStructuresCount(); i++)
            {
                if (Str == data.GetStructures(i)[1] + ":\r\n" + data.GetStructures(i)[0]) { FeatureOrder = i; }
            }
            if (FeatureOrder == -1)
            {
                MessageBox.Show(Properties.Resources.ErrorFeatureOrder, Properties.Resources.Error);
            }
            return FeatureOrder;
        }

        public string GetLocation() { return result; }

        #region 变量定义
        public string biome = "";
        public string dimension = "";
        public string feature = "";
        public string x = "";
        public string y = "";
        public string z = "";
        public string position = "";
        public string result = "";
        #endregion
        #region 创建与预览按钮
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            result = "";
            if ((bool)IsBiome.IsChecked) { result += "\r\n\t\t\t" + "\"biome\":\"" + data.GetBiome(GetBiomeOrder())[0] + "\","; }
            if ((bool)IsDimension.IsChecked) { result += "\r\n\t\t\t" + "\"dimension\":\"" + SelDimension.SelectionBoxItem.ToString() + "\","; }
            if ((bool)IsFeature.IsChecked) { result += "\r\n\t\t\t" + "\"feature\":\"" + data.GetStructures(GetStructuresOrder())[0] + "\","; }
            if ((bool)IsPosition.IsChecked) { result += "\r\n\t\t\t" + "\"position\":" + position+","; }
            result = result.TrimEnd(',');
        }
        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            PreviewForm PR = new PreviewForm();
            PR.NewText(result);
            PR.ShowDialog();
        }
        #endregion
        #region 创建Position
        private void CreatePosition()
        {
            position = "\r\n\t\t\t"+"{";
            if ((bool)IsX.IsChecked) { position += x; }
            if ((bool)IsY.IsChecked) { position += y; }
            if ((bool)IsZ.IsChecked) { position += z; }
            position = position.TrimEnd(',');
            position += "\r\n\t\t\t" + "}";
            CheckEveryPosition();
        }

        private void CheckEveryPosition()
        {
            if (IsX.IsChecked == false && IsY.IsChecked == false && IsZ.IsChecked == false)
            {
                IsPosition.IsChecked = false;
                IsX.IsEnabled = false;
                IsY.IsEnabled = false;
                IsZ.IsEnabled = false;
                GetX.IsEnabled = false;
                GetY.IsEnabled = false;
                GetZ.IsEnabled = false;
                x = "";
                y = "";
                z = "";
                position = "";
            }
        }

        private void GetX_Click(object sender, RoutedEventArgs e)
        {
            x = "\r\n\t\t\t\t" + "\"x\":";
            x += MainWindow.GetMIN_MAX(999999,999999);
            x += ",";
            CreatePosition();
        }

        private void GetY_Click(object sender, RoutedEventArgs e)
        {
            y = "\r\n\t\t\t\t" + "\"y\":";
            y += MainWindow.GetMIN_MAX(255, 255);
            y += ",";
            CreatePosition();
        }

        private void GetZ_Click(object sender, RoutedEventArgs e)
        {
            z = "\r\n\t\t\t\t" + "\"z\":";
            z += MainWindow.GetMIN_MAX(999999, 999999);
            z += ",";
            CreatePosition();
        }

        private void ResetPosition_Click(object sender, RoutedEventArgs e)
        {
            IsPosition.IsChecked = false;
            IsX.IsEnabled = false;
            IsY.IsEnabled = false;
            IsZ.IsEnabled = false;
            GetX.IsEnabled = false;
            GetY.IsEnabled = false;
            GetZ.IsEnabled = false;
            x = "";
            y = "";
            z = "";
            position = "";
            MessageBox.Show(Properties.Resources.ResetSuccess, Properties.Resources.Tip);
        }
        #endregion
        #region 单选框
        private void IsBiome_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsBiome.IsChecked) { SelBiome.IsEnabled = true; } else { SelBiome.IsEnabled = false; }
        }

        private void IsDimension_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsDimension.IsChecked) { SelDimension.IsEnabled = true; } else { SelDimension.IsEnabled = false; }
        }

        private void IsFeature_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsFeature.IsChecked) { SelFeature.IsEnabled = true; } else { SelFeature.IsEnabled = false; }
        }

        private void IsPosition_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsPosition.IsChecked)
            {
                IsX.IsEnabled = true;
                IsY.IsEnabled = true;
                IsZ.IsEnabled = true;
                GetX.IsEnabled = true;
                GetY.IsEnabled = true;
                GetZ.IsEnabled = true;
            }
            else
            {
                IsX.IsEnabled = false;
                IsY.IsEnabled = false;
                IsZ.IsEnabled = false;
                GetX.IsEnabled = false;
                GetY.IsEnabled = false;
                GetZ.IsEnabled = false;
                x = "";
                y = "";
                z = "";
                position = "";
            }
        }

        private void IsX_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsX.IsChecked) { GetX.IsEnabled = true; } else { GetX.IsEnabled = false; }
            CheckEveryPosition();
        }

        private void IsY_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsY.IsChecked) { GetY.IsEnabled = true; } else { GetY.IsEnabled = false; }
            CheckEveryPosition();
        }

        private void IsZ_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsZ.IsChecked) { GetZ.IsEnabled = true; } else { GetZ.IsEnabled = false; }
            CheckEveryPosition();
        }
        #endregion
    }
}
