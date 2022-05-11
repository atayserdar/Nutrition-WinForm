using Nutrition.BusinessLayer;
using Nutrition.Domain;
using Nutrition.Domain.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Nutrition.UI
{
    public partial class HomePage : Form
    {
        public User User { get; set; }
        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Hoş Geldiniz" + " " + User.FullName;
            FillMealComboBox();
            FillFoodComboBox();
            FillDailyNutritionDataGridView();
        }

        private void FillDailyNutritionDataGridView()
        {
            DailyNutritionService dailyNutritionService = new DailyNutritionService();
            var dailyNutritionList = dailyNutritionService.ListByUserId(User.Id);

            if (dailyNutritionList == null || !dailyNutritionList.Any())
            {
                return;
            }

            FoodService foodService = new FoodService();
            var foodList = foodService.List();

            MealService mealService = new MealService();
            var mealList = mealService.List();

            foreach (DailyNutrition dailyNutrition in dailyNutritionList)
            {
                dailyNutrition.Meal = mealList.FirstOrDefault(x => x.Id == dailyNutrition.MealId);
                dailyNutrition.Food = foodList.FirstOrDefault(x => x.Id == dailyNutrition.FoodId);

                int calory = dailyNutrition.Food.Kcal * dailyNutrition.PortionQuantity;

                dgvDailyNutritionList.Rows.Add(dailyNutrition.Id,
                                               dailyNutrition.Meal.Name,
                                               Image.FromFile(dailyNutrition.Food.PhotoPath),
                                               dailyNutrition.Food.Name,
                                               dailyNutrition.PortionQuantity,
                                               calory,
                                               dailyNutrition.Meal.Id);
            }
            SetTotalCaloryLabel();
        }

        private void FillFoodComboBox()
        {
            FoodService foodService = new FoodService();
            var foodList = foodService.List();
            cmbFood.DisplayMember = "Name";
            cmbFood.ValueMember = "Id";
            foreach (var food in foodList)
            {
                cmbFood.Items.Add(food);
            }
        }

        private void FillMealComboBox()
        {
            MealService mealService = new MealService();
            var mealList = mealService.List();
            cmbMeal.DisplayMember = "Name";
            cmbMeal.ValueMember = "Id";
            foreach (var meal in mealList)
            {
                cmbMeal.Items.Add(meal);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Meal meal = (Meal)cmbMeal.SelectedItem;
            Food food = (Food)cmbFood.SelectedItem;
            int portionQuantity = (int)nudQuantity.Value;

            if (cmbMeal.SelectedItem == null || cmbFood.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Öğün veya Yemek Seçiniz.");
                return;
            }

            var id = AddSelectedValueIntoDB(meal, food, portionQuantity);
            AddSelectedValueIntoDataGridView(id, meal, food, portionQuantity);
            SetTotalCaloryLabel();
        }

        private int AddSelectedValueIntoDB(Meal meal, Food food, int portionQuantity)
        {
            DailyNutrition dailyNutrition = new DailyNutrition();
            dailyNutrition.FoodId = food.Id;
            dailyNutrition.MealId = meal.Id;
            dailyNutrition.PortionQuantity = (byte)portionQuantity;
            dailyNutrition.UserId = User.Id;
            dailyNutrition.CreatedDate = DateTime.Now;
            dailyNutrition.UpdatedDate = DateTime.Now;

            DailyNutritionService dailyNutritionService = new DailyNutritionService();
            return dailyNutritionService.AddDailyNutrition(dailyNutrition);
        }

        private void AddSelectedValueIntoDataGridView(int id, Meal meal, Food food, int portionQuantity)
        {
            int calory = food.Kcal * portionQuantity;

            dgvDailyNutritionList.Rows.Add(id,
                                           meal.Name,
                                           Image.FromFile(food.PhotoPath),
                                           food.Name,
                                           portionQuantity,
                                           calory,
                                           meal.Id);
        }
        private void SetTotalCaloryLabel()
        {
            int breakfastCalory = 0;
            int lunchCalory = 0;
            int dinnerCalory = 0;
            int snackCalory = 0;
            int totalCalory = 0;

            foreach (DataGridViewRow row in dgvDailyNutritionList.Rows)
            {
                if ((int)row.Cells[6].Value == (int)Constants.Meal.Breakfast)
                {
                    breakfastCalory += (int)row.Cells[5].Value;
                }
                else if ((int)row.Cells[6].Value == (int)Constants.Meal.Lunch)
                {
                    lunchCalory += (int)row.Cells[5].Value;
                }
                else if ((int)row.Cells[6].Value == (int)Constants.Meal.Dinner)
                {
                    dinnerCalory += (int)row.Cells[5].Value;
                }
                else if ((int)row.Cells[6].Value == (int)Constants.Meal.Snack)
                {
                    snackCalory += (int)row.Cells[5].Value;
                }
                totalCalory += (int)row.Cells[5].Value;
            }

            lblBreakfastCalory.Text = breakfastCalory.ToString() + " " + "kcal";
            lblLunchCalory.Text = lunchCalory.ToString() + " " + "kcal";
            lblDinnerCalory.Text = dinnerCalory.ToString() + " " + "kcal";
            lblSnackCalory.Text = snackCalory.ToString() + " " + "kcal";
            lblTotalCalory.Text = totalCalory.ToString() + " " + "kcal";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dgvDailyNutritionList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir satır seçiniz.");
                return;
            }

            DataGridViewRow selectedRow = dgvDailyNutritionList.SelectedRows[0];
            int selectedId = Convert.ToInt32(selectedRow.Cells[0].Value);
            DeleteSelectedRowFromDB(selectedId);
            dgvDailyNutritionList.Rows.Remove(selectedRow);
            SetTotalCaloryLabel();
        }
        private void DeleteSelectedRowFromDB(int id)
        {
            DailyNutritionService dailyNutritionService = new DailyNutritionService();
            var result = dailyNutritionService.DeleteDailyNurition(id);
            if (result == Constants.ReturnValue.Success)
            {
                MessageBox.Show("Seçilen kayıt başarıyla silindi.");
                return;
            }
            MessageBox.Show("Kayıt bulunamadı, işlem başarısız.");
        }
    }
}
