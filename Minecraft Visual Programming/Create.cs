using System.Windows;
using MahApps.Metro.Controls;
using System.Text.RegularExpressions;

namespace Minecraft_Visual_Programming
{
    public partial class MainWindow : MetroWindow
    {
        public string Create_Part1()
        {
            string str = "";
            //正则表达式(开头结尾都是｛｝)
            Regex regex = new Regex(@"^\{|\}$");
            //格式化字符串
            if(!int.TryParse(Icon_Data_Input.Text, out icon_data)) { MessageBox.Show(Properties.Resources.NotInt, Properties.Resources.Error); }
            icon_item = "\"" + Icon_Input.Text + "\"";
            title =Title_Input.Text;
            description = Description_Input.Text;
            frame = "\"" + data.GetFrame(GetFrameOrder())[0] + "\"";
            IsAnnounce_to_chat = isAnnounce_to_chat.IsChecked.ToString().ToLower() ;
            IsHidden = isHidden.IsChecked.ToString().ToLower();
            IsShow_toast = isShow_toast.IsChecked.ToString().ToLower();
            background = "\"" + Background_Input.Text + "\"";
            parent = "\"" + Parent_Input.Text + "\"";
            //选择格式并更改字符串
            if (!regex.IsMatch(title)) { title = "\"" + title + "\""; }
            if (!regex.IsMatch(description)) { description = "\"" + description + "\""; }
            //合并及生成字符串
            str = "{"+ "\r\n\t" + "\"display\": "+ "\r\n\t" + "{";
            str += "\r\n\t\t" + "\"icon\": " + "\r\n\t\t" + " { " + "\r\n\t\t\t" + "\"item\": " + icon_item + ",";
            str += "\t\r\n\t\t\t"+"\"data\":" +icon_data + "\r\n\t\t"+ "},";
            str += "\r\n\t\t"+"\"title\":" +title+",";
            str += "\r\n\t\t"+"\"description\":" +description+",";
            str += "\r\n\t\t" + "\"frame\":" + frame + ",";
            if ((bool)isRoot.IsChecked) { str += "\r\n\t\t" + "\"background\":" + background + ","; }
            str += "\r\n\t\t" + "\"show_toast\":" + IsShow_toast+",";
            str += "\r\n\t\t" + "\"announce_to_chat\":" + IsAnnounce_to_chat+",";
            str += "\r\n\t\t" + "\"hidden\":" + IsHidden;
            str += "\r\n\t" + "},";
            if (!(bool)isRoot.IsChecked) { str+= "\r\n\t" + "\"parent\":" + parent + ","; }
            //返回字符串
            return str;
        }

        public string Create_Part2()
        {
            //合并触发器
            criteria = "\r\n\t" + "\"criteria\": ";
            criteria += "\r\n\t" + "{";
            criteria += Data.Global.TriggerText;
            criteria += "\r\n\t" + "},";
            return criteria;
        }

        public string Create_Part3()
        {
            string str="";
            //检查奖励
            if ((bool)R_Recipes.IsChecked) { recipes = "\r\n\t"+"\"recipes\":\"" + R_Recipes_Input.Text+ "\","; } else { recipes = ""; }
            if ((bool)R_Experience.IsChecked)
            {
                bool isSuccess=int.TryParse(R_Experience_Input.Text,out experience);
                if (experience < 0) { isSuccess = false; }
                if (!isSuccess) { MessageBox.Show(Properties.Resources.NotSuccess,Properties.Resources.Error); } else
                {
                    experience_s = "\r\n\t" + "\"experience\":" + experience.ToString() + ",";
                }
            }else { experience_s = ""; }
            if ((bool)R_Function.IsChecked) { function = "\r\n\t"+"\"function\":\"" + R_Function_Input.Text + "\","; } else { function = ""; }
            if ((bool)R_Loot.IsChecked) { loot = "\r\n\t"+"\"loot\":\"" +R_Loot_Input.Text + "\","; } else { loot = ""; }
            //合并及输出字符串
            str += "\r\n\t"+"\"rewards\":"+"\r\n\t"+"{";
            str += recipes + loot + experience_s + function;
            //去除末尾的","
            str = str.TrimEnd(',');
            str += "\r\n\t}";
            return str;
        }

        public static void ReturnTGText(string str)
        {
            if (Data.Global.TGOrder == 1)
            {
                Data.Global.TriggerText += "\r\n\t" + str;
                Data.Global.TGOrder++;
            }
            else
            {
                Data.Global.TriggerText += ",\r\n\t" + str;
                Data.Global.TGOrder++;
            }
        }
    }
}
