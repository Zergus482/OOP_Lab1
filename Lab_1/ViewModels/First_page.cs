using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.ViewModels
{
    public class First_page : ViewModelBase
    {
        private string _textValue = string.Empty;
        private int _numberValue = 42;
        private DateTime _dateValue = DateTime.Now;
        private bool _isChecked = true;

        private string _directTextValue = string.Empty;
        private bool _directTextHasBeenEdited = false;
        private bool _isUpdatingFromCode = false;  

        public First_page()
        {
            ApplyLocalizedDefaults();
        }

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

        public string DirectTextValue
        {
            get => _directTextValue;
            set
            {
                if (_directTextValue != value)
                {
                    _directTextValue = value;

                    if (!_isUpdatingFromCode)
                    {
                        _directTextHasBeenEdited = true;
                    }

                    OnPropertyChanged();
                }
            }
        }

        protected override void OnLanguageChanged()
        {
            ApplyLocalizedDefaults();
        }

        private void ApplyLocalizedDefaults()
        {
            TextValue = Tr("Default_Sample_TextValue");

            if (!_directTextHasBeenEdited)
            {
                _isUpdatingFromCode = true;
                DirectTextValue = Tr("Default_TextBox_EnterText");
                _isUpdatingFromCode = false;
            }
        }
    }
}