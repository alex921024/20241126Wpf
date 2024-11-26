using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _20241126wpf
{
    public partial class MyDocumentViewer : Window
    {
        // 定義字體顏色，初始為黑色
        Color fontColor = Colors.Black;

        public MyDocumentViewer()
        {
            InitializeComponent();

            // 設定顏色選擇器的初始選擇顏色
            fontColorPicker.SelectedColor = fontColor;

            // 將系統字體添加到字體下拉選單
            foreach (FontFamily fontFamily in Fonts.SystemFontFamilies)
            {
                fontFamilyComboBox.Items.Add(fontFamily.Source);
            }

            // 設定字體下拉選單的初始選擇項
            fontFamilyComboBox.SelectedIndex = 13;

            // 設定字體大小下拉選單的資料來源
            fontSizeComboBox.ItemsSource = new List<double>()
            {
                8, 9, 10, 12, 14, 16, 18, 20, 22, 24, 32, 40, 50, 60, 80, 100
            };

            // 設定字體大小下拉選單的初始選擇項
            fontSizeComboBox.SelectedIndex = 3;
        }

        // 當執行「新建」命令時創建並顯示新視窗
        private void NewCommand_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            MyDocumentViewer myDocumentViewer = new MyDocumentViewer();
            myDocumentViewer.Show();
        }

        // 當執行「開啟」命令時的操作（此處為空）
        private void OpenCommand_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            // 此處可以添加開啟文件的相關操作
        }

        // 當執行「儲存」命令時的操作（此處為空）
        private void SaveCommand_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            // 此處可以添加儲存文件的相關操作
        }
    }
}
