using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.ViewModels
{
    public class OneTime : ViewModelBase
    {
        private string _initialValue = "Это значение загружается один раз";
        private int _initialNumber = 100;
        private string _staticText = "Статический текст";

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
    }
}
