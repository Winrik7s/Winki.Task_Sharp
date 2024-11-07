namespace Winki.Task_Sharp
{
    public class Staff
    {
        private decimal salary;

        public string? Name { get; set; }
        public string? Position { get; set; }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
            }
        }
    }
}
