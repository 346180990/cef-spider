using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

//对配置文件的写入
namespace AutoSingIn
{
    class WriteConfigSupport: ConfigSupport
    {
        string state = null;

        public WriteConfigSupport(string name, string newKey, string newValue)
        {
            this.state = setConfig(name, newKey, newValue);
        }
        public string State
        {
            get { return this.state; }
        }
        /*
         name:传入的key
         newKey:新添加的key
         newValue:value值
         */
        private string setConfig(string name, string newKey, string newValue) {
            //取得配置文件对象
            Configuration config =ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //判断key是否之前存在
            bool exist = false;
            if (config.AppSettings.Settings[name].Value != null)
            {
                exist = true;
            }
            if (exist)
            {
                config.AppSettings.Settings.Remove(name);
            }
            //写入操作
            try
            {
                config.AppSettings.Settings.Add(newKey, newValue);
           
            }
            catch(Exception ex)
            {
                System.Console.Write("写入失败:"+ex.Message);
                return "写入失败:" + ex.Message;
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            return "写入成功。";
        }
    }
}
