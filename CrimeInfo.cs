public class CrimeInfo
{
    public static List<CrimeInfo> crimeList = new List<CrimeInfo>();
    public string typeOfCrime { get; set; }
    public string placeOfCrime { get; set; }
    public string timeOfCrime { get; set; }
    public string officersOnScene { get; set; }
    public string reportNr { get; set; }
    public string crimeDate { get; set; }
    public string policeStation { get; set; }
    public string crimeDescription { get; set; }

    public CrimeInfo(string typeOfCrime, string placeOfCrime, string timeOfCrime, string officersOnScene, string reportNr, string crimeDate, string policeStation, string crimeDescription) 
    {
        this.typeOfCrime = typeOfCrime;
        this.placeOfCrime = placeOfCrime;
        this.timeOfCrime = timeOfCrime;
        this.officersOnScene = officersOnScene;
        this.reportNr = reportNr;
        this.crimeDate = crimeDate;
        this.policeStation = policeStation;
        this.crimeDescription = crimeDescription;
    }
    
    public static void RegCallout()
    {
        try
        {
            Console.Write("Ange Typ Av Brott: ");
            string typeOfCrime = Console.ReadLine();
            Console.Write("Ange Plats: ");
            string placeOfCrime = Console.ReadLine();
            Console.Write("Ange Tidpunkt: ");
            string timeOfCrime = Console.ReadLine();
            Console.Write("Ange Deltagande Poliser: ");
            string officersOnScene = Console.ReadLine();
            Console.Clear();

            string reportNr = null;
            string crimeDate = null;
            string policeStation = null;
            string crimeDescription = null;

            crimeList.Add(new CrimeInfo (typeOfCrime, placeOfCrime, timeOfCrime, officersOnScene, reportNr, crimeDate, policeStation, crimeDescription));
        }
        catch(Exception)
        {
            Console.WriteLine("Du har valt en felaktig input");
            Thread.Sleep(2000);
            Console.Clear();
            RegCallout();  
        }     

        Console.WriteLine("Brott Registrerat");
        Console.Write("\nTryck på ENTER för att fortsätta");
        Console.ReadLine();
        Console.Clear();
    }
    
    public static void Report()
    {
        int i = 0;
        
        foreach (CrimeInfo crime in crimeList)
        {
            Console.WriteLine($"Brott {i}: {crime.typeOfCrime}, {crime.timeOfCrime}, {crime.placeOfCrime}, {crime.officersOnScene}");
            i++;
        }

        try
        {
            Console.Write("\nAnge brott du vill rapportera: ");
            int inputIndex = int.Parse(Console.ReadLine());
                
            Console.Write($"RAPPORTNUMMER: ");
            crimeList[inputIndex].reportNr += Console.ReadLine();
            Console.Write("Ange Datum: ");
            crimeList[inputIndex].crimeDate += Console.ReadLine();
            Console.Write("Ange Polisstation: ");
            crimeList[inputIndex].policeStation += Console.ReadLine();
            Console.Write("Beskriving: ");
            crimeList[inputIndex].crimeDescription += Console.ReadLine();
            Console.Clear();
        }
        catch(Exception)
        {
            Console.WriteLine("Du har valt en felaktig input");
            Thread.Sleep(2000);
            Console.Clear();
            Report();   
        } 
        
        Console.WriteLine("Brott Rapporterat");
        Console.Write("\nTryck på ENTER för att fortsätta");
        Console.ReadLine();
        Console.Clear();
    }

    public static void Info()
    {
        while(true)
        {
            try
            {
                Console.WriteLine("[1] Se Brottslista");
                Console.WriteLine("[2] Se Anställda");
                Console.WriteLine("[3] Tillbaka Till Menyn");
                Console.Write("\nMenyval: ");
                int input = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (input)
                {
                    case 1:
                        for (int i = 0; i < crimeList.Count; i++)
                        {
                            Console.WriteLine($"---- Brott {i+1} ----");
                            Console.WriteLine($"Rapportnummer:\t\t{crimeList[i].reportNr}");
                            Console.WriteLine($"Datum:\t\t\t{crimeList[i].crimeDate}");
                            Console.WriteLine($"Tidpunkt:\t\t{crimeList[i].timeOfCrime}");
                            Console.WriteLine($"Brottstyp:\t\t{crimeList[i].typeOfCrime}");
                            Console.WriteLine($"Plats:\t\t\t{crimeList[i].placeOfCrime}");
                            Console.WriteLine($"Poliser på plats:\t{crimeList[i].officersOnScene}");
                            Console.WriteLine($"Polisstation:\t\t{crimeList[i].policeStation}");
                            Console.WriteLine($"Beskrivning:\t\t{crimeList[i].crimeDescription} \n");
                        }

                        Console.Write("Tryck på ENTER för att fortsätta");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("---- Anställda ----\n");
                        for (int j = 0; j < EmployeeInfo.employeeList.Count; j++)
                        {
                            Console.WriteLine(j+1 + $". {EmployeeInfo.employeeList[j].employeeName} ({EmployeeInfo.employeeList[j].employeeID})");
                        }

                        Console.Write("\nTryck på ENTER för att fortsätta");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Program.Main();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Du har valt en felaktig input");
                Thread.Sleep(2000);
                Console.Clear(); 
            }
        }    
    }
}