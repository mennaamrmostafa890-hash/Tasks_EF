using EF2_ITI.Data;

namespace EF2_ITI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ITIContext db = new ITIContext())
            {
                var res = db.Departments.ToList();
                foreach (var item in res)
                {
                    Console.WriteLine($"{item.Id}) {item.Dept_Name} " +
                        $", Capacity {item.Capacity}");
                }
            }
        }
    }
}
