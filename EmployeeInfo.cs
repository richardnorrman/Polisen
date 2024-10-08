public class EmployeeInfo
{
    public static List<EmployeeInfo> employeeList = new List<EmployeeInfo>();
    public string employeeName { get; set; }
    public int employeeID { get; set;}

    public EmployeeInfo(string employeeName, int employeeID)
    {
        this.employeeName = employeeName;
        this.employeeID = employeeID;
    }
    
    public static void RegEmployee()
    {
        try
        {
            Console.WriteLine("---- Registrera Anställd ----\n");
            Console.Write("Tjänstenummer: ");
            int employeeID = int.Parse(Console.ReadLine());
            Console.Write("Förnamn Och Efternamn: ");
            string employeeName = Console.ReadLine();

            employeeList.Add(new EmployeeInfo (employeeName, employeeID));
        }
        catch(Exception)
        {
            Console.WriteLine("Du har valt en felaktig input");
            Thread.Sleep(2000);
            RegEmployee();
            Console.Clear();   
        } 
        
        Console.WriteLine("\nNy Anställd Registrerad");
        Console.Write("\nTryck på ENTER för att fortsätta");
        Console.ReadLine();
        Console.Clear();
    }
}