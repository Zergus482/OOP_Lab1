using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Windows;

namespace Lab_1.Localization
{
    public static class LocalizationService
    {
        private static readonly ResourceManager ResourceManager =
            new ResourceManager("Lab_1.Localization.Resources", Assembly.GetExecutingAssembly());

        private static readonly string[] Keys =
        {
            "MainWindow_Title",
            "Tab_DefaultBinding",
            "Tab_TwoWay",
            "Tab_OneTime",
            "Tab_OneWay",
            "Tab_Triggers",
            "Page_DefaultBinding_Title",
            "Page_TwoWay_Title",
            "Page_OneTime_Title",
            "Page_OneWay_Title",
            "Page_Triggers_Title",

            "Default_Group_DirectBinding_Header",
            "Default_Label_TextBoxToTextBlock",
            "Default_TextBox_EnterText",
            "Default_Label_CheckBoxToTextBlock",
            "Default_CheckBox_Content_Selected",
            "Default_Label_SliderToTextBlock",
            "Default_Label_ViewModel_Header",
            "Default_Label_TextBox_ViewModel",
            "Default_Label_Numeric_ViewModel",
            "Default_Label_Date_ViewModel",
            "Default_Label_CheckBox_ViewModel",
            "Default_text",

            "TwoWay_Group_Direct_Header",
            "TwoWay_Label_TwoTextBoxes",
            "TwoWay_Label_SliderAndTextBox",
            "TwoWay_Group_ViewModel_Header",
            "TwoWay_Label_Name",
            "TwoWay_Label_Surname",
            "TwoWay_Label_Age",
            "TwoWay_Label_Email",
            "TwoWay_Label_Slider",
            "TwoWay_Label_FullInfo",

            "OneTime_Group_Direct_Header",
            "OneTime_Label_DirectDescription",
            "OneTime_TextBox_InitialText",
            "OneTime_Label_TextDoesNotUpdate",
            "OneTime_Group_ViewModel_Header",
            "OneTime_Label_InitialValue",
            "OneTime_Label_InitialNumber",
            "OneTime_Label_StaticText",

            "OneWay_Group_Direct_Header",
            "OneWay_Label_SliderToTextBlock",
            "OneWay_Label_TextBoxToTextBlock",
            "OneWay_Label_TextDoesNotAffectSource",
            "OneWay_Group_ViewModel_Header",
            "OneWay_Label_SourceText",
            "OneWay_Label_SourceNumber",
            "OneWay_Label_ComputedValue",
            "OneWay_Label_DisplayText",
            "OneWay_Label_SourcesUpdateTargets",

            "Triggers_Group_Property_Header",
            "Triggers_Label_Property_Description",
            "Triggers_Button_Hover",
            "Triggers_Label_Property_Info",

            "Triggers_Group_Data_Header",
            "Triggers_Label_Data_Description",
            "Triggers_CheckBox_Enable",
            "Triggers_Label_Data_BlockText",
            "Triggers_Label_Data_Info",

            "Triggers_Group_MultiData_Header",
            "Triggers_Label_MultiData_Description",
            "Triggers_CheckBox_Cond1",
            "Triggers_CheckBox_Cond2",
            "Triggers_Button_Multi",
            "Triggers_Label_MultiData_Info",

            "Triggers_Group_Event_Header",
            "Triggers_Label_Event_Description",
            "Triggers_Button_Event",
            "Triggers_Label_Event_Info",
            "Name",

            "Triggers_Group_Compare_Header",
            "Triggers_Label_Compare_Property",
            "Triggers_Label_Compare_Data",
            "Triggers_Label_Compare_MultiData",
            "Triggers_Label_Compare_Event"
        };

        public static void ApplyLanguage(string cultureName)
        {
            var culture = new CultureInfo(cultureName);

            foreach (var key in Keys)
            {
                var value = ResourceManager.GetString(key, culture) ?? key;
                Application.Current.Resources[key] = value;
            }
        }
    }
}

