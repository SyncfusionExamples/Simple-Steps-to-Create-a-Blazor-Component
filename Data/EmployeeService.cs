namespace BlazorApp.Data
{
    public class EmployeeService
    {
        private static readonly string[] Name = new[]
        {
        "Nancy", "Margaret", "Michael", "Robert", "Anne" 
        };
        private static readonly string[] Mail = new[]
        {
        "nancy@domain.com", "margaret@domain.com", "michael@domain.com", "robert@domain.com","anne@domain.com"
        };

        public Task<EmployeeModel[]> GetEmployeeAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(0, 5).Select(index => new EmployeeModel
            {
              Joined = startDate.AddDays(index),
              Name = Name[index],
              Email = Mail[index],
              Image = "../" + Name[index] +".PNG",
              ID = Random.Shared.Next(200, 555)

            }).ToArray());
        }
    }
}
