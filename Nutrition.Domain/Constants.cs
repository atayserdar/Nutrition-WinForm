namespace Nutrition.Domain
{
    public static class Constants
    {
        public const string Man = "Bay";
        public const string Woman = "Bayan";

        public enum ReturnValue
        {
            Success = 1,
            RecordAlreadyExist = 2,
            RecordNotFound = 3
        }

        public enum Meal
        {
            Breakfast = 1,
            Lunch,
            Dinner,
            Snack
        }
    }
}
