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
    public partial class DailyRoutine : Form
    {
        public User User { get; set; }
        public DailyRoutine()
        {
            InitializeComponent();
        }
        public DailyRoutine(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(cbLowActivity.Checked == true || cbNormal.Checked == true || cbHighActivity.Checked == true)
            {
                this.Hide();
                ExpectedResult expectedResult = new ExpectedResult(User);   
                expectedResult.Show();
            } 
        }
    }
}
