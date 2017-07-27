using System.Windows;
using MahApps.Metro.Controls;

namespace Minecraft_Visual_Programming
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        #region 变量
        string result = "";
        string title = "";
        string description = "";
        string frame = "";
        string background = "";
        string parent = "";
        string icon_item = "";
        string criteria = "";
        string recipes = "";
        string loot = "";
        string function = "";
        string experience_s = "";
        int experience = 0;
        int icon_data = 0;
        string IsShow_toast = "\"true\"";
        string IsAnnounce_to_chat = "\"true\"";
        string IsHidden = "\"false\"";
        #endregion
        #region 设置读取
        string MVPLanguage = Setting.Settings.Default.Language;
        string MCVersion = Setting.Settings.Default.MCVersion;
        bool IsCheckUpdate = Setting.Settings.Default.CheckUpdate;
        #endregion
        /*
        #region 快捷键
        void selectAll(object sender, RoutedEventArgs e)
        {

        }
        void copy(object sender, RoutedEventArgs e)
        {

        }
        void paste(object sender, RoutedEventArgs e)
        {

        }
        #endregion
        */
        Data.Data data = new Data.Data();
        public MainWindow()
        {
            InitializeComponent();
            for (int i=0;i<data.GetTriggerCount();i++)
            {
                SelTrigger.Items.Add(data.GetTrigger(i)[0]+"\r\n"+data.GetTrigger(i)[1]);
            }
            for(int i = 0; i < data.GetFrameCount(); i++)
            {
                SelFrame.Items.Add(data.GetFrame(i)[1]+":"+data.GetFrame(i)[0]);
            }
        }
        /// <summary>
        /// 获取选择器序号并启动相应编辑窗口
        /// </summary>
        /// <param name="TgInfo">Trigger的长字符串:data.GetTrigger(i)[0]+"\r\n"+data.GetTrigger(i)[1]</param>
        public void GetTrigger(string TgInfo)
        {
            int TriggerOrder = -1;
            for (int i = 0; i < data.GetTriggerCount(); i++)
            {
                if (TgInfo == data.GetTrigger(i)[0] + "\r\n" + data.GetTrigger(i)[1]) { TriggerOrder = i; }
            }
            if (TriggerOrder == -1)
            {
                MessageBox.Show(Properties.Resources.ErrorTriggerOrder, Properties.Resources.Error);
                return;
            }
            ChangeWindow(TriggerOrder);
        }

        private void ChangeWindow(int TGOrder)
        {
            switch (TGOrder)
            {
                case 0:
                    Trigger.bred_animals BA = new Trigger.bred_animals();
                    BA.ShowDialog();
                    break;
                case 1:
                    Trigger.brewed_potion BP = new Trigger.brewed_potion();
                    BP.ShowDialog();
                    break;
                case 2:
                    Trigger.changed_dimension CD = new Trigger.changed_dimension();
                    CD.ShowDialog();
                    break;
                case 3:
                    Trigger.construct_beacon CB = new Trigger.construct_beacon();
                    CB.ShowDialog();
                    break;
                case 4:
                    Trigger.consume_item CI =new Trigger.consume_item();
                    CI.ShowDialog();
                    break;
                case 5:
                    Trigger.cured_zombie_villager CZV = new Trigger.cured_zombie_villager();
                    CZV.ShowDialog();
                    break;
                case 6:
                    Trigger.effects_changed EC = new Trigger.effects_changed();
                    EC.ShowDialog();
                    break;
                case 7:
                    Trigger.enchanted_item EI = new Trigger.enchanted_item();
                    EI.ShowDialog();
                    break;
                case 8:
                    Trigger.enter_block EB = new Trigger.enter_block();
                    EB.ShowDialog();
                    break;
                case 9:
                    Trigger.entity_hurt_player EHP = new Trigger.entity_hurt_player();
                    EHP.ShowDialog();
                    break;
                default:
                    MessageBox.Show(Properties.Resources.AccidentalOrder,Properties.Resources.Error);
                    break;
            }
        }

        private void EditTriggerBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            if (SelTrigger.SelectionBoxItem.ToString()=="")
            {
                MessageBox.Show(Properties.Resources.NoSelTriggerInfo,Properties.Resources.NoSelTrigger);
                this.Show();
            }
            else
            {
                GetTrigger(SelTrigger.SelectionBoxItem.ToString());
                this.Show();
                this.TriggerOutput.Text = Data.Global.TriggerText;
                criteria = Data.Global.TriggerText;
            }
        }

        private void isRoot_Click(object sender, RoutedEventArgs e)
        {
            if (isRoot.IsChecked == true)
            {
                Parent_Input.IsEnabled = false;
                Background_Input.IsEnabled = true;
            }
            else
            {
                Background_Input.IsEnabled = false;
                Parent_Input.IsEnabled = true;
            }
        }

        private void IsRewards_Click(object sender, RoutedEventArgs e)
        {
            if (IsRewards.IsChecked == true)
            {
                R_Experience.IsEnabled = true;
                R_Experience_Input.IsEnabled = true;
                R_Function.IsEnabled = true;
                R_Function_Input.IsEnabled = true;
                R_Loot.IsEnabled = true;
                R_Loot_Input.IsEnabled = true;
                R_Recipes.IsEnabled = true;
                R_Recipes_Input.IsEnabled = true;
            }
            else
            {
                R_Experience.IsEnabled = false;
                R_Experience_Input.IsEnabled = false;
                R_Function.IsEnabled = false;
                R_Function_Input.IsEnabled = false;
                R_Loot.IsEnabled = false;
                R_Loot_Input.IsEnabled = false;
                R_Recipes.IsEnabled = false;
                R_Recipes_Input.IsEnabled = false;
            }
        }

        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            PreviewForm PR = new PreviewForm();
            PR.NewText(result);
            PR.ShowDialog();
        }

        private int GetFrameOrder()
        {
            string Str=SelFrame.SelectionBoxItem.ToString();
            int FrameOrder = -1;
            for (int i = 0; i < data.GetFrameCount(); i++)
            {
                if (Str == data.GetFrame(i)[1] + ":" + data.GetFrame(i)[0]) { FrameOrder = i; }
            }
            if (FrameOrder == -1)
            {
                MessageBox.Show(Properties.Resources.ErrorFrameOrder, Properties.Resources.Error);
            }
            return FrameOrder;
        }
        
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (IsRewards.IsChecked == true)
            {
                result = Create_Part1() + Create_Part2() + Create_Part3();
            }
            else
            {
                result = Create_Part1() + Create_Part2() ;
            }
            result = result.TrimEnd(',');
            result += "\r\n}";
            Output.Text = result;
        }

        private void ClearTrigger_Click(object sender, RoutedEventArgs e)
        {
            TriggerOutput.Text = "";
            Data.Global.TriggerText = "";
            Data.Global.TGOrder = 1;
        }
        /// <summary>
        /// 获取最大值最小值代码
        /// </summary>
        /// <param name="min">最小值的最大值</param>
        /// <param name="max">最大值的最大值</param>
        public static string GetMIN_MAX(int min,int max)
        {
            MinAndMax GetI_A = new MinAndMax();
            GetI_A.SetMaxAndMin(min, max);
            GetI_A.ShowDialog();
            return GetI_A.GetMaxAndMin();
        }

        private void TriggerOutput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            Data.Global.TriggerText = TriggerOutput.Text;
        }

        public static string GetEffects()
        {
            Effects Ef = new Effects();
            Ef.ShowDialog();
            return Ef.GetEffects();
        }

        public static string GetLocation()
        {
            Location LC = new Location();
            LC.ShowDialog();
            return LC.GetLocation();
        }

        private void EditEntity_Click(object sender, RoutedEventArgs e)
        {
            Entity Et = new Entity();
            Et.ShowDialog();
        }

        private void EditLocation_Click(object sender, RoutedEventArgs e)
        {
            Location LC = new Location();
            LC.ShowDialog();
        }

        private void EditEffect_Click(object sender, RoutedEventArgs e)
        {
            Effects EF = new Effects();
            EF.ShowDialog();
        }
    }
}
