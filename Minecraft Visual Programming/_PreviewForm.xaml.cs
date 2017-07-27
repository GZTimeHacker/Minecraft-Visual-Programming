using MahApps.Metro.Controls;

namespace Minecraft_Visual_Programming
{
    /// <summary>
    /// PreviewForm.xaml 的交互逻辑
    /// </summary>
    public partial class PreviewForm : MetroWindow
    {
        public PreviewForm()
        {
            InitializeComponent();
        }

        public void NewText(string text)
        {
            Preview_box.Text = text;
        }
    }
}
