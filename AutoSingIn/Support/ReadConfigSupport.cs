using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

//对配置文件的读取
namespace AutoSingIn
{
    class ReadConfigSupport:ConfigSupport
    {
        public string[] account;
        public ReadConfigSupport(string name, ConfigChoice choice) {
           this.account = getAccount(name, choice);
        }
        public string[] Account
        {
            get { return this.account; }
        }
        private string[] getAccount(string name, ConfigChoice choice) {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string connectionString = config.AppSettings.Settings[name].Value;
             //因为参数保存方式不同，通过枚举判断下，不同情况取值方式

             string[] account = connectionString.Split(',');

            return account;
        }

    }
}
