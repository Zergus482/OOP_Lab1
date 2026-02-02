using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.ViewModels
{
    public class First_page : ViewModelBase
    {
        private string _textValue = "Значение по умолчанию";
        private int _numberValue = 42;
        private DateTime _dateValue = DateTime.Now;
        private bool _isChecked = true;

        public string TextValue
        {
            get => _textValue;
            set => SetProperty(ref _textValue, value);
        }

        public int NumberValue
        {
            get => _numberValue;
            set => SetProperty(ref _numberValue, value);
        }

        public DateTime DateValue
        {
            get => _dateValue;
            set => SetProperty(ref _dateValue, value);
        }

        public bool IsChecked
        {
            get => _isChecked;
            set => SetProperty(ref _isChecked, value);
        }
    }
}
