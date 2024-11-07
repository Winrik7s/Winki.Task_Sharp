using System.Linq;

namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Staff> stf = new() { new Staff("Artem", "Roofer", 1600), new Staff("Katya", "Teacher", 800), new Staff("Ivan", "Programmer", 2000)};

            Console.WriteLine("Staff list:");
            stf.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));

            foreach(Staff staff in stf)
            {
                Console.WriteLine($"Name: {staff.Name}, Position: {staff.Position}, Salary: {staff.Salary}");
            }
        }
    }
}