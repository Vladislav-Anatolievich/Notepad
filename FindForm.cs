using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotepadCSharp
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }
        // Создаем перечисление, возвращающее параметр FindCondition
        public string FindText
        {
            get { return txtFind.Text; }
            set { txtFind.Text = value; }
        }
        public RichTextBoxFinds FindCondition
        {
            get
            {
                if (cbMatchCase.Checked && cbMatchWhole.Checked)
                {
                    return RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord;

                }
                if (cbMatchCase.Checked)
                {
                    return RichTextBoxFinds.MatchCase;
                }
                if (cbMatchWhole.Checked)
                {
                    return RichTextBoxFinds.WholeWord;
                }
                return RichTextBoxFinds.None;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {

        }
    }
}