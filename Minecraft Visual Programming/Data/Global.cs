namespace Minecraft_Visual_Programming.Data
{
    class Global
    {
        private static string _TriggerText = "";
        /// <summary>
        /// 触发器输出文本
        /// </summary>
        public static string TriggerText
        {
            get { return _TriggerText; }
            set { _TriggerText = value; }
        }

        private static int _TGOrder = 1;
        /// <summary>
        /// 触发器编号
        /// </summary>
        public static int TGOrder
        {
            get { return _TGOrder; }
            set { _TGOrder = value; }
        }

        public static string Trigger = "Trigger";
    }
}
