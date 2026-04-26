using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.ViewModels
{
    public class Page2 : ViewModelBase
    {
        private string _name = string.Empty;
        private string _surname = string.Empty;
        private int _age = 25;
        private string _email = "ivan@example.com";
        private double _sliderValue = 50.0;

        public Page2()
        {
            ApplyLocalizedDefaults();
        }

        public string Name
        {
            get => _name;
            set
            {
                SetProperty(ref _name, value);
                OnPropertyChanged(nameof(FullInfo));
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                SetProperty(ref _surname, value);
                OnPropertyChanged(nameof(FullInfo));
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                SetProperty(ref _age, value);
                OnPropertyChanged(nameof(FullInfo));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                SetProperty(ref _email, value);
                OnPropertyChanged(nameof(FullInfo));
            }
        }

        public double SliderValue
        {
            get => _sliderValue;
            set => SetProperty(ref _sliderValue, value);
        }

        public string FullInfo => string.Format(Tr("Page2_FullInfo_Format"), Name, Surname, Age, Email);

        protected override void OnLanguageChanged()
        {
            ApplyLocalizedDefaults();
            OnPropertyChanged(nameof(FullInfo));
        }

        private void ApplyLocalizedDefaults()
        {
            Name = Tr("Page2_Default_Name");
            Surname = Tr("Page2_Default_Surname");
        }
    }
}
