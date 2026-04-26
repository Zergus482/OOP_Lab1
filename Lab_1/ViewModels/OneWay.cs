using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.ViewModels
{
    public class OneWay : ViewModelBase
    {
        private string _sourceText = string.Empty;
        private int _sourceNumber = 200;
        private DateTime _currentTime = DateTime.Now;
        private string _computedValue = string.Empty;

        public OneWay()
        {
            ApplyLocalizedDefaults();
            UpdateComputedText();
        }

        public string SourceText
        {
            get => _sourceText;
            set
            {
                SetProperty(ref _sourceText, value);
                UpdateComputedText();
                OnPropertyChanged(nameof(DisplayText));
            }
        }

        public int SourceNumber
        {
            get => _sourceNumber;
            set
            {
                SetProperty(ref _sourceNumber, value);
                OnPropertyChanged(nameof(DisplayText));
            }
        }

        public DateTime CurrentTime
        {
            get => _currentTime;
            set => SetProperty(ref _currentTime, value);
        }

        public string ComputedValue
        {
            get => _computedValue;
            set => SetProperty(ref _computedValue, value);
        }

        public string DisplayText => string.Format(Tr("OneWay_Display_Format"), SourceText, SourceNumber);

        protected override void OnLanguageChanged()
        {
            ApplyLocalizedDefaults();
            UpdateComputedText();
            OnPropertyChanged(nameof(DisplayText));
        }

        private void ApplyLocalizedDefaults()
        {
            SourceText = Tr("OneWay_Default_SourceText");
        }

        private void UpdateComputedText()
        {
            ComputedValue = $"{Tr("OneWay_Default_ComputedPrefix")}: {SourceText}";
        }
    }
}
