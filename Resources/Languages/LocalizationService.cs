using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace V2DO.Resources.Languages
{
    public class LocalizationService
    {
        private static readonly ResourceManager _resourceManager =
            new ResourceManager("V2DO.Resources.Languages.AppResources", Assembly.GetExecutingAssembly());
    
        public string GetString(string key)
        {
            return _resourceManager.GetString(key, CultureInfo.CurrentUICulture) ?? key;
        }

        public void SetLanguage(string cultureCode)
        {
            CultureInfo cultureInfo = new CultureInfo(cultureCode);
            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;
        }
    
    }
}
