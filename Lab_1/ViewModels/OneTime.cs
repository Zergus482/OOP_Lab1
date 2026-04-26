using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.ViewModels
{
    public class OneTime : ViewModelBase
    {
        private string _initialValue = string.Empty;
        private int _initialNumber = 100;
        private string _staticText = string.Empty;

        public OneTime()
        {
            ApplyLocalizedDefaults();
        }

        public string InitialValue
        {
            get => _initialValue;
            set => SetProperty(ref _initialValue, value);
        }

        public int InitialNumber
        {
            get => _initialNumber;
            set => SetProperty(ref _initialNumber, value);
        }

        public string StaticText
        {
            get => _staticText;
            set => SetProperty(ref _staticText, value);
        }

        protected override void OnLanguageChanged()
        {
            ApplyLocalizedDefaults();
        }

        private void ApplyLocalizedDefaults()
        {
            InitialValue = Tr("OneTime_Default_InitialValue");
            StaticText = Tr("OneTime_Default_StaticText");
        }
    }
}
