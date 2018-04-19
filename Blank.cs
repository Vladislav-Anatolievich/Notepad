using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace NotepadCSharp
{
    public partial class Blank : Form
    {
        public string DockName = "";
    
        public bool IsSaved = false;
        public Blank()
        {
            InitializeComponent();
            sbTime.Text ="Время: "+ Convert.ToString(System.DateTime.Now.ToLongTimeString());
            sbTime.ToolTipText = Convert.ToString(System.DateTime.Today.ToLongTimeString());
        }
   public void Delete()
   {

   int StartPosDel = richTextBox1.SelectionStart;
   int LenSelection = richTextBox1.SelectionLength;
   richTextBox1.Text = richTextBox1.Text.Remove(StartPosDel, LenSelection);
   }

            public void Open(string OpenFileName)
        { 
        //Если файл не выбран, возвращаемся назад
            if (OpenFileName == "")
            {
                return;
            }
            else
            { 
            //Создаем новый объект StreamReader и передаем ему переменную OpenFileName
                StreamReader sr = new StreamReader(OpenFileName);
                //Читаем весь файл и записываем его в richTextbox1
                richTextBox1.Text = sr.ReadToEnd();
                //Закрываем поток
                sr.Close();
                DockName = OpenFileName;
            
            }          
        }
        //Создаем метод Save, в качестве параметра объявляем строку адреса  файла.
            public void Save(string SaveFileName)
            {
                //Если файл не выбран, возвращаемся назад (появится встроенное предупреждение)
                if (SaveFileName == "")
                {
                    return;
                }
                else
                {
                    //Создаем новый объект StreamWriter и передаем ему переменную //OpenFileName
                    StreamWriter sw = new StreamWriter(SaveFileName);
                    //Содержимое richTextBox1 записываем в файл
                    sw.WriteLine(richTextBox1.Text);
                    //Закрываем поток
                    sw.Close();
                    //Устанавливаем в качестве имени документа название сохраненного файла
                    DockName = SaveFileName;
                }
            }
        private void Blank_FormClosing(object sender, FormClosingEventArgs e)
            {
                //Если переменная IsSaved имеет значение true, т. е.  новый документ 
                //был сохранен (Save As) или в открытом документе были сохранены изменения (Save), то //выполняется условие
                if (IsSaved == true)
                //Появляется диалоговое окно, предлагающее сохранить документ.
                    if (MessageBox.Show("Вы хотите сохранить изменения в " + this.DockName + "?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //Если была нажата  кнопка Yes, вызываем метод Save
                    {
                        this.Save(this.DockName);
                    }

            }
                  
           private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
            {
                
                if (e.KeyCode == Keys.Enter)
                {

                   richTextBox1.AppendText("\t");                
                 }
               
            }
        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            long kpr = 0;
            long kzap = 0;
            long kvoskl = 0;
            long kvopr = 0;
            long klit = 0;
            long kabs = 0;
            
            sbAmount.Text = "Количество символов: " + richTextBox1.Text.Length.ToString();

            for (int i = 0; i < richTextBox1.Text.Length; ++i)
                if (richTextBox1.Text[i] == ' ' || richTextBox1.Text[i] == '\t')

                    kpr++;
            if (kpr > 0)
            {
                sbSpace.Text = "Количество пробелов: " + kpr.ToString();
            }

            foreach (char voskl in richTextBox1.Text)
                if (voskl == '!')
                {
                    kvoskl++;
                    sbVoskl.Text = "Количество воскл. знаков: " + kvoskl.ToString();
                }

            foreach (char zap in richTextBox1.Text)
                if (zap == ',')
                {
                    kzap++;
                    sbKoma.Text = "Количество запятых: " + kzap.ToString();
                }

            foreach (char vopr in richTextBox1.Text)
                if (vopr == '?')
                {
                    kvopr++;
                    sbVopr.Text = "Кол-во вопросительных: " + kvopr.ToString();
                }

            foreach (char l in richTextBox1.Text)
                if (Char.IsLetter(l))
                {
                    klit++;
                    sbLiter.Text = "Кол-во букв: " + klit.ToString();
                }
            foreach (char abs in richTextBox1.Text)
                if (abs == '\t')
                {
                    kabs++;
                    sbAbsac.Text = "Кол-во абзацев: " + kabs.ToString();
                }
    
            char[] symb = new char[] { '.', '!', '?', ';'};
            int res = richTextBox1.Text.Split(symb, StringSplitOptions.RemoveEmptyEntries).GetLength(0);
             sbProportinal.Text = "Кол-во предложений: " + res.ToString();

            char[] charSeparators = new char[] { ' ' };
                string[] result = richTextBox1.Text.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                sbWords.Text = "Количество слов: " + result.Length.ToString();
                   
                // поиск даты
                //Регулярное выражение даты
                string pattern = "(((0|1)[0-9]|2[0-9]|3[0-1])\\.(0[1-9]|1[0-2])\\.((19|20)\\d\\d))$";
                Regex reg = new Regex(pattern);
          
               Match match = reg.Match(richTextBox1.Text);
               while (match.Success)
                {
                    int index = -1;
                    int selectStart = richTextBox1.SelectionStart;
                     while ((index = richTextBox1.Text.IndexOf(match.ToString(), (index+1)))!=-1)
                    {
                        richTextBox1.Select((index), match.ToString().Length);
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
                        richTextBox1.Select(selectStart, 0);
                    }
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
                           match = match.NextMatch();
                           
                   }              
            }
            //После точки на верхний регистр
            bool upper = false;
            private void richTextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
            {
                if (upper )
                {
                    e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
                    upper = false;
                }
                if (e.KeyChar == 46)
                    upper = true;        
            }

      
        }
        
        }