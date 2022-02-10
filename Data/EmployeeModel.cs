namespace BlazorApp.Data
{
    public class EmployeeModel
    {
        public int ID { get; set; }

        public string Name { get; set; } = "";
        public DateTime Joined { get; set; }
        public string Image { get; set; } = "";
        public string Email { get; set; } = "";
    }
}
