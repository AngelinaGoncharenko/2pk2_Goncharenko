using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GoncharenkoTR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isSaved = false;
        bool isUnderline = false;
        string filePath = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_showModal(object sender, RoutedEventArgs e)
        {
            Window1 about = new Window1();
            about.ShowDialog();
        }

        private void newFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                FileInfo fileInfo = new FileInfo(fileStream.Name);
                filePath = fileStream.Name;
                TextRange range = new TextRange(richTB.Document.ContentStart, richTB.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
                isSaved = true;
                dateCreation.Text = Convert.ToString(fileInfo.LastAccessTime);
                fileSize.Text = "размер: " + Convert.ToString(fileInfo.Length / 1024) + "кб";
            }
        }
        private void openFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                FileInfo fileInfo = new FileInfo(fileStream.Name);
                filePath = fileStream.Name;
                TextRange range = new TextRange(richTB.Document.ContentStart, richTB.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
                dateCreation.Text = Convert.ToString(fileInfo.LastAccessTime);
                fileSize.Text = "размер: " + Convert.ToString(fileInfo.Length / 1024) + "кб";
            }
            UpdateCursorPosition();
        }
        private void saveFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                isSaved = true;
                save_not.Text = "сохранено";
                TextRange range = new TextRange(
                    richTB.Document.ContentStart, richTB.Document.ContentEnd);
 
                using (FileStream fs = File.Create(dlg.FileName))
                {
                    range.Save(fs, DataFormats.Rtf);
                }

            }
        }
        private void deleteFile(object sender, RoutedEventArgs e)
        {
            File.Delete(filePath);
            richTB.Document.Blocks.Clear();
            fileSize.Text = "";
            dateCreation.Text = "";
            position.Text = "";
        }

        private void UpdateCursorPosition()
        {
            TextPointer caretLineStart = richTB.CaretPosition.GetLineStartPosition(0);
            TextPointer p = richTB.Document.ContentStart.GetLineStartPosition(0);
            int currentLineNumber = 0;

            int column = Math.Max(new TextRange(caretLineStart, richTB.CaretPosition).Text.Length + 1, 1);
            int row = new TextRange(richTB.CaretPosition.GetLineStartPosition(0), richTB.CaretPosition).Text.Length + 1;

            while (true)
            {
                if (p == null || (caretLineStart != null && caretLineStart.CompareTo(p) < 0))
                {
                    break;
                }

                p = p.GetLineStartPosition(1, out var result);

                if (result == 0)
                {
                    break;
                }

                currentLineNumber++;
            }

            position.Text = "строка:" + Convert.ToString(Math.Max(1, currentLineNumber)) + " столбец:" + Convert.ToString(column);
        }

        private void makeItalic(object sender, RoutedEventArgs e)
        {
            if (richTB.Selection != null)
            {
                richTB.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
            }
            else
                richTB.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, null);
        }

        private void makeBold(object sender, RoutedEventArgs e)
        {
            if (richTB.Selection != null)
            {
                richTB.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            }
            else
                richTB.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, null);
        }

        private void makeUnderline(object sender, RoutedEventArgs e)
        {
            if (!isUnderline)
            {
                richTB.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
                isUnderline = true;
            }
            richTB.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
            isUnderline = false;
        }

        private void richTB_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateCursorPosition();
        }

        private void richTB_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateCursorPosition();
        }

        private void richTB_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            isSaved = false;
            if (isSaved) 
            {
                save_not.Text = "сохранено";
            }
            save_not.Text = "требуется сохранение";

        }
    }

}
