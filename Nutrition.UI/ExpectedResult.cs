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
    public partial class ExpectedResult : Form
    {
        public User User { get; set; }
        public ExpectedResult()
        {
            InitializeComponent();
        }

        public ExpectedResult(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            DailyCalculatedResult dailyCalculatedResult = new DailyCalculatedResult(User);
            dailyCalculatedResult.Show();
        }
    }
}
