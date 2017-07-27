using System.Windows;
using MahApps.Metro.Controls;
using System.Text.RegularExpressions;

namespace Minecraft_Visual_Programming
{
    /// <summary>
    /// Entity.xaml 的交互逻辑
    /// </summary>
    public partial class Entity : MetroWindow
    {
        Data.Data data = new Data.Data();
        public Entity()
        {
            InitializeComponent();
            for (int i = 0; i < data.GetEntityCount(); i++)
            {
                SelEntity.Items.Add(data.GetEntity(i)[1] + ":" + data.GetEntity(i)[0]);
            }
        }

        private int GetEntityOrder()
        {
            string Str = SelEntity.SelectionBoxItem.ToString();
            int EntityOrder = -1;
            for (int i = 0; i < data.GetEntityCount(); i++)
            {
                if (Str == data.GetEntity(i)[1] + ":" + data.GetEntity(i)[0]) { EntityOrder = i; }
            }
            if (EntityOrder == -1)
            {
                MessageBox.Show(Properties.Resources.ErrorEntityOrder, Properties.Resources.Error);
            }
            return EntityOrder;
        }

        #region 变量定义
        public string EntityID = "";
        public string EntityNBT = "";
        public int DistanceInt = 0;
        public string DistanceStr = "";
        public string Absolute = "";
        public string Horizontal = "";
        public string X = "";
        public string Y = "";
        public string Z = "";
        public string result = "";
        public string EntityEffects = "";
        public string EntityLocation = "";
        #endregion
        #region 单选按钮
        private void IsEntityID_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsEntityID.IsChecked) { SelEntity.IsEditable = true; } else { SelEntity.IsEditable = false; }
        }

        private void IsEntityNBT_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsEntityNBT.IsChecked) { GetNBT.IsEnabled = true; } else { GetNBT.IsEnabled = false; }
        }

        private void IsEntityLocation_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsEntityLocation.IsChecked) { GetLocation.IsEnabled = true; } else { GetLocation.IsEnabled = false; }
        }

        private void IsEntityEffect_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsEntityEffect.IsChecked) { GetEffect.IsEnabled = true; } else { GetEffect.IsEnabled = false; }
        }

        private void IsDistanceInt_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsDistanceInt.IsChecked) { GetDistance.IsEnabled = true; } else { GetDistance.IsEnabled = false; }
        }

        private void IsDistanceMore_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsDistanceMore.IsChecked)
            {
                GetAbsolute.IsEnabled = true;
                GetHorizontal.IsEnabled = true;
                GetX.IsEnabled = true;
                GetY.IsEnabled = true;
                GetZ.IsEnabled = true;
                IsAbsolute.IsEnabled = true;
                IsHorizontal.IsEnabled = true;
                IsX.IsEnabled = true;
                IsY.IsEnabled = true;
                IsZ.IsEnabled = true;
            }
            else
            {
                GetAbsolute.IsEnabled = false;
                GetHorizontal.IsEnabled = false;
                GetX.IsEnabled = false;
                GetY.IsEnabled = false;
                GetZ.IsEnabled = false;
                IsAbsolute.IsEnabled = false;
                IsHorizontal.IsEnabled = false;
                IsX.IsEnabled = false;
                IsY.IsEnabled = false;
                IsZ.IsEnabled = false;
                Absolute = "";
                Horizontal = "";
                X = "";
                Y = "";
                Z = "";
                DistanceStr = "";
            }
        }

        private void CheckEveryDistanceMore()
        {
            if (IsAbsolute.IsChecked == false && IsHorizontal.IsChecked == false && IsX.IsChecked == false && IsY.IsChecked == false && IsZ.IsChecked == false)
            {
                IsDistanceMore.IsChecked = false;
                GetAbsolute.IsEnabled = false;
                GetHorizontal.IsEnabled = false;
                GetX.IsEnabled = false;
                GetY.IsEnabled = false;
                GetZ.IsEnabled = false;
                IsAbsolute.IsEnabled = false;
                IsHorizontal.IsEnabled = false;
                IsX.IsEnabled = false;
                IsY.IsEnabled = false;
                IsZ.IsEnabled = false;
                Absolute = "";
                Horizontal = "";
                X = "";
                Y = "";
                Z = "";
                DistanceStr = "";
            }
        }

        private void IsAbsolute_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsAbsolute.IsChecked) { GetAbsolute.IsEnabled = true; } else { GetAbsolute.IsEnabled = false; }
            CheckEveryDistanceMore();
        }

        private void IsHorizontal_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsHorizontal.IsChecked) { GetHorizontal.IsEnabled = true; } else { GetHorizontal.IsEnabled = false; }
            CheckEveryDistanceMore();
        }

        private void IsX_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsX.IsChecked) { GetX.IsEnabled = true; } else { GetX.IsEnabled = false; }
            CheckEveryDistanceMore();
        }

        private void IsY_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsY.IsChecked) { GetY.IsEnabled = true; } else { GetY.IsEnabled = false; }
            CheckEveryDistanceMore();
        }

        private void IsZ_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)IsZ.IsChecked) { GetZ.IsEnabled = true; } else { GetZ.IsEnabled = false; }
            CheckEveryDistanceMore();
        }
        #endregion
        #region 创建及单选按钮
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            result = "\r\n\t\t\t{";
            if ((bool)IsDistanceInt.IsChecked) { result += "\r\n\t\t\t" + "\"distance\":" + DistanceInt + ","; }
            if ((bool)IsDistanceMore.IsChecked) { result += "\r\n\t\t\t" + "\"distance\":" + "\r\n\t\t\t\t{"+DistanceStr+"\r\n\t\t\t\t}"; }
            if ((bool)IsEntityEffect.IsChecked) { result += EntityEffects + ","; }
            if ((bool)IsEntityLocation.IsChecked) { result += EntityLocation + ","; }
            if ((bool)IsEntityNBT.IsChecked) { result += "\r\n\t\t\t" + "\"nbt\":\"" + GetNBT.Text + "\","; }
            if ((bool)IsEntityID.IsChecked) { result += "\r\n\t\t\t" + "\"type\":\"" + data.GetEntity(GetEntityOrder())[0] + "\","; }
            result = result.TrimEnd(',');
            result += "\r\n\t\t\t}";
        }
        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            PreviewForm PR = new PreviewForm();
            PR.NewText(result);
            PR.ShowDialog();
        }
        #endregion
        #region 获取距离详细信息
        private void GetAbsolute_Click(object sender, RoutedEventArgs e)
        {
            Absolute = "\r\n\t\t\t\t"+ "\" absolute\":";
            Absolute += MainWindow.GetMIN_MAX(1000,1000);
            Absolute += ",";
            CreateDistance();
        }

        private void GetHorizontal_Click(object sender, RoutedEventArgs e)
        {
            Horizontal = "\r\n\t\t\t\t" + "\"horizontal\":";
            Horizontal += MainWindow.GetMIN_MAX(1000, 1000);
            Horizontal += ",";
            CreateDistance();
        }

        private void GetX_Click(object sender, RoutedEventArgs e)
        {
            X = "\r\n\t\t\t\t" + "\"x\":";
            X += MainWindow.GetMIN_MAX(1000,1000);
            X += ",";
            CreateDistance();
        }

        private void GetY_Click(object sender, RoutedEventArgs e)
        {
            Y = "\r\n\t\t\t\t" + "\"y\":";
            Y += MainWindow.GetMIN_MAX(1000, 1000);
            Y += ",";
            CreateDistance();
        }

        private void GetZ_Click(object sender, RoutedEventArgs e)
        {
            Z = "\r\n\t\t\t\t" + "\"z\":";
            Z += MainWindow.GetMIN_MAX(1000, 1000);
            Z += ",";
            CreateDistance();
        }
        #endregion
        #region 距离信息杂项
        private void GetDistance_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            if (regex.IsMatch(GetDistance.Text))
            {
                int i;
                if (int.TryParse(GetDistance.Text, out i)) { DistanceInt = i; }
                else { MessageBox.Show(Properties.Resources.NotInt, Properties.Resources.Error); GetDistance.Text = "100"; }
            }
            else
            {
                MessageBox.Show(Properties.Resources.NotInt, Properties.Resources.Error);
                GetDistance.Text = "100";
            }
        }

        private void CreateDistance()
        {
            DistanceStr = "";
            if ((bool)IsAbsolute.IsChecked) { DistanceStr += Absolute; }
            if ((bool)IsHorizontal.IsChecked) { DistanceStr+= Horizontal; }
            if ((bool)IsX.IsChecked) { DistanceStr +=  X; }
            if ((bool)IsY.IsChecked){ DistanceStr +=  Y; }
            if ((bool)IsZ.IsChecked) { DistanceStr +=  Z; }
            DistanceStr = DistanceStr.TrimEnd(',');
            CheckEveryDistanceMore();
        }

        private void ResetDistance_Click(object sender, RoutedEventArgs e)
        {
            IsDistanceMore.IsChecked = false;
            GetAbsolute.IsEnabled = false;
            GetHorizontal.IsEnabled = false;
            GetX.IsEnabled = false;
            GetY.IsEnabled = false;
            GetZ.IsEnabled = false;
            IsAbsolute.IsEnabled = false;
            IsHorizontal.IsEnabled = false;
            IsX.IsEnabled = false;
            IsY.IsEnabled = false;
            IsZ.IsEnabled = false;
            Absolute = "";
            Horizontal = "";
            X = "";
            Y = "";
            Z = "";
            DistanceStr = "";
            MessageBox.Show(Properties.Resources.ResetSuccess, Properties.Resources.Tip);
        }

        #endregion

        private void GetEffect_Click(object sender, RoutedEventArgs e)
        {
            EntityEffects=MainWindow.GetEffects();
        }

        private void GetLocation_Click(object sender, RoutedEventArgs e)
        {
            EntityLocation = MainWindow.GetLocation();
        }
    }
}
