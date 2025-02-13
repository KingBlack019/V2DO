using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2DO.Resources.Languages;

namespace V2DO.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly LocalizationService _localizationService;

        public LoginViewModel() 
        {
            _localizationService = new LocalizationService();
            LoadLocalizedTexts();
        }

        private void LoadLocalizedTexts()
        {
            
        }

        public event PropertyChangedEventHandler? PropertyChanged;

    }
}
