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
    public partial class PersonalGoal : Form
    {
        public User User { get; set; }

        public PersonalGoal()
        {
            InitializeComponent();
        }

        public PersonalGoal(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cbLooseWeight.Checked == true || cbGetWeight.Checked == true || cbKeepForm.Checked == true)
            {
                this.Hide();
                DailyRoutine dailyRoutine = new DailyRoutine(User);
                dailyRoutine.Show();    
            }
        }
    }
}
