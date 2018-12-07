using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Documents;
using System.IO;


namespace WpfApplication1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile =
                new System.Windows.Forms.OpenFileDialog();
            openFile.InitialDirectory = @"C:\1\";
            openFile.Filter = "RTF files (*.rtf)|*.rtf|(*.txt)|*.txt|All files (*.*)|*.*";
            string content = "";
            openFile.ShowDialog();
            if (openFile.FileName.Length >0)
             {
                TextRange tr = new TextRange(
                 RichTextBox1.Document.ContentStart, RichTextBox1.Document.ContentEnd);

                using (FileStream fs = File.Open(openFile.FileName, FileMode.Open))
                {
                    if (System.IO.Path.GetExtension(openFile.FileName).ToLower() == ".rtf")
                        tr.Load(fs, DataFormats.Rtf);
                    else if (System.IO.Path.GetExtension(openFile.FileName).ToLower() == ".txt")
                        tr.Load(fs, DataFormats.Text);
                    else
                        tr.Load(fs, DataFormats.Xaml);
                   
               }
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.SaveFileDialog sfd = new System.Windows.Forms.SaveFileDialog();
            sfd.Filter = "RTF files (*.rtf)|*.rtf|(*.txt)|*.txt|All files (*.*)|*.*";
            sfd.ShowDialog();

            TextRange doc = new TextRange(RichTextBox1.Document.ContentStart, RichTextBox1.Document.ContentEnd);
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
                        doc.Save(fs, DataFormats.Rtf);
                    else if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".txt")
                        doc.Save(fs, DataFormats.Text);
                    else
                        doc.Save(fs, DataFormats.Xaml);
                }
    
        }

        private void cmdFormatting_Click(object sender, RoutedEventArgs e)
        {
            // Ссылка на объект выделения
            TextSelection selection = RichTextBox1.Selection;

            // Если текст не найден, код интерпретирует
            // шрифт как обычный
            FontWeight weightState = FontWeights.Normal;
            FontStyle styleState = FontStyles.Normal;
            TextDecorationCollection currentState = null;

            if (e.OriginalSource == cmdBold)
            {
                // Проверка, выведен ли фрагмент полужирным цветом
                if (selection.GetPropertyValue(Run.FontWeightProperty) !=
                    DependencyProperty.UnsetValue)
                {
                    weightState = (FontWeight)selection.GetPropertyValue(
                        Run.FontWeightProperty);
                }

                if (weightState == FontWeights.Normal)
                {
                    selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Bold);
                }
                else
                {
                    selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Normal);
                }
            }

            if (e.OriginalSource == cmdItalic)
            {
                // Проверка, выведен ли фрагмент наклонным стилем
                if (selection.GetPropertyValue(Run.FontStyleProperty) != DependencyProperty.UnsetValue)
                    styleState = (FontStyle)selection.GetPropertyValue(Run.FontStyleProperty);

                if (styleState == FontStyles.Italic)
                {
                    selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Normal);
                }
                else
                {
                    selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Italic);
                }
            }

            if (e.OriginalSource == cmdUnder)
            {
                // Проверка, выведен ли фрагмент с подчеркиванием
                if (selection.GetPropertyValue(Run.TextDecorationsProperty) != DependencyProperty.UnsetValue)
                    currentState = (TextDecorationCollection)selection.GetPropertyValue(Run.TextDecorationsProperty);

                if (currentState != TextDecorations.Underline)
                {
                    selection.ApplyPropertyValue(Run.TextDecorationsProperty, TextDecorations.Underline);
                }
                else
                {
                    selection.ApplyPropertyValue(Run.TextDecorationsProperty, null);
                }
            }

            // Возврат фокуса полю, чтобы пользователь мог продолжить работу с ним
            RichTextBox1.Focus();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            RichTextBox1.Document.Blocks.Clear();

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            TextSelection selection = RichTextBox1.Selection;
            System.Windows.Forms.ColorDialog colorDialog1 = new System.Windows.Forms.ColorDialog();

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
  //              string sss = colorDialog1.Color.Name;

                selection.ApplyPropertyValue(TextElement.ForegroundProperty, colorDialog1.Color.Name);
          
            }
        }


    }
}
