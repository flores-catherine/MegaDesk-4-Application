using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void newQuote_Click(object sender, EventArgs e)
        {
            AddQuote AddQuoteForm = new AddQuote { Tag = this };
            AddQuoteForm.Show(this);
            Hide();
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes ViewQuotesForm = new ViewAllQuotes { Tag = this };
            ViewQuotesForm.Show(this);
            Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes SearchQuotesForm = new SearchQuotes { Tag = this };
            SearchQuotesForm.Show(this);
            Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
