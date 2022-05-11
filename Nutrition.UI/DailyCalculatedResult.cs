using Nutrition.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrition.UI
{
    public partial class DailyCalculatedResult : Form
    {
        public User User { get; set; }
        public DailyCalculatedResult()
        {
            InitializeComponent();
        }

        public DailyCalculatedResult(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void DailyCalculatedResult_Load(object sender, EventArgs e)
        {

        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage(User);
            homePage.Show();    
        }
    }
}
