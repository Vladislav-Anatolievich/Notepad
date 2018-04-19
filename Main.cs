using System;
using System.Windows.Forms;

namespace NotepadCSharp
{
    public partial class fmmain : Form
    {
       

        private int openDocuments = 0;
       
        public fmmain()
        {
            InitializeComponent();
            mnuSave.Enabled = false;
            
           
        }
  public RichTextBox GetRichTextBox()
    {

          
        RichTextBox rtb = null;
        if (ActiveMdiChild != null)
        {
            rtb = (RichTextBox)ActiveMdiChild.Controls[0];
        }
        return rtb;
             
    }
               private void mnuNew_Click(object sender, EventArgs e)
        {
            //создаем новый экземпляр формы
            Blank frm = new Blank();
            /*Указываем, что родительским контейнером
            нового экземпляра будет эта, главная форма.
             */
            frm.DockName = "Untitled " + ++openDocuments;
            frm.Text = frm.DockName;

            frm.MdiParent = this;
            //Вызываем форму
            frm.Show();

        }

        private void mnuArrangeIcons_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
         private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            try
            {
                GetRichTextBox().Cut();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Действие Cut невозможна", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            try
            {
                GetRichTextBox().Copy();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Действие Copy невозможна", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            try
            {
                GetRichTextBox().Paste();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Действие Paste невозможна", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Blank form = (Blank)this.ActiveMdiChild;
                form.Delete();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Действие Delete невозможна", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                GetRichTextBox().SelectAll();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Действие Select All невозможна", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

           private void mnuCloseDocument(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void mnuCloseDocumentAll_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
        }

        private void cmnuCut_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Cut();
        }

        private void cmnuCopy_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }

        private void cmnuPaste_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();
        }

        private void cmnuDelete_Click(object sender, EventArgs e)
        {
            Blank form = (Blank)this.ActiveMdiChild;
            form.Delete();
            
        }

        private void cmnuSelectAll_Click(object sender, EventArgs e)
        {
            GetRichTextBox().SelectAll();
            
        }

    

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            //Можно программно задавать доступные для обзора расширения файлов 
            //openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            
            //Если выбран диалог открытия файла, выполняем условие

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Создаем новый документ
                Blank frm = new Blank();
                //Вызываем метод Open формы blank
                frm.Open(openFileDialog1.FileName);
                //Указываем, что родительской формой является форма frmmain
                frm.MdiParent = this;
                //Присваиваем переменной DocName имя открываемого файла
                frm.DockName = openFileDialog1.FileName;
                //Свойству Text формы присваиваем переменную DocName
                frm.Text = frm.DockName;
                //Вызываем форму frm
                frm.Show();
                mnuSave.Enabled = true;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            //Можно программно задавать доступные для обзора расширения файлов 
          //  openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            //Если выбран диалог открытия файла, выполняем условие
         
                //Переключаем фокус на данную форму.
                Blank frm = (Blank)this.ActiveMdiChild;
                frm.Save(frm.DockName);
                frm.IsSaved = true;
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            mnuSave.Enabled = true;
            //Можно программно задавать доступные для обзора расширения файлов 
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            //Если выбран диалог открытия файла, выполняем условие
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Переключаем фокус на данную форму.
                try
                {
                    Blank frm = (Blank)this.ActiveMdiChild;
                    frm.Save(saveFileDialog1.FileName);
                    frm.MdiParent = this;
                    frm.DockName = saveFileDialog1.FileName;
                    frm.Text = frm.DockName;
                    frm.IsSaved = true;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Файл сохранить невозможно", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                           }
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            try
            {
                Blank frm = (Blank)this.ActiveMdiChild;
                frm.MdiParent = this;
                fontDialog1.ShowColor = true;
                //Связываем свойства SelectionFont и SelectionColor элемента RichTextBox 
                //с соответствующими свойствами диалога
                fontDialog1.Font = frm.richTextBox1.SelectionFont;
                fontDialog1.Color = frm.richTextBox1.SelectionColor;
                //Если выбран диалог открытия файла, выполняем условие
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    frm.richTextBox1.SelectionFont = fontDialog1.Font;
                    frm.richTextBox1.SelectionColor = fontDialog1.Color;
                }
                frm.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Операция невозможно выполнить", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            try
            {
                Blank frm = (Blank)this.ActiveMdiChild;
                frm.MdiParent = this;
                colorDialog1.Color = frm.richTextBox1.SelectionColor;
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    frm.richTextBox1.SelectionColor = colorDialog1.Color;
                }
                frm.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Операция невозможно выполнить", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void mnuFind_Click(object sender, EventArgs e)
        {
            FindForm frm = new FindForm();
            if (frm.ShowDialog(this) == DialogResult.Cancel) return;
            Blank form = (Blank)this.ActiveMdiChild;
            form.MdiParent = this;
            int start = form.richTextBox1.SelectionStart;
            form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

               }
    }


