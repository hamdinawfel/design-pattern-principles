namespace LSP;


public class Program
{
    public static void Main(string[] args)
    {

        var manager = new Manager();

        manager.FirstName = "Jhon";
        manager.LastName = "Doe";
        manager.AssignManager(manager);
        manager.CalculatePerHourRate(4);

        var emp = new Employee();

        emp.FirstName = "Hamdi";
        emp.LastName = "Nawfel";
        emp.AssignManager(manager);
        emp.CalculatePerHourRate(2);


        Console.WriteLine($"{emp.FirstName} {emp.LastName} has a salary of : {emp.Salary} and managed by {emp.Manager.FirstName} {emp.Manager.LastName}");
    }
}