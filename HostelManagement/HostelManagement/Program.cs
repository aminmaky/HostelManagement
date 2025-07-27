using HostelManagement;

namespace HostelManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //////////////////////////////////////////////////////////////////////////////////////////
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            // ????? ??????? SQLite
            HostelDataService.InitializeDatabase();

            // ????? ?? ?????????? ??????
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Login());
        }
    }

    //// Data:
    public static class DATA
    {
        public static List<Dormitory> Dormitories = new List<Dormitory>();
        public static List<Block> Blocks = new List<Block>();
        public static List<Student> Students = new List<Student>();
        public static List<DormitoryManager> DormitoryManagers = new List<DormitoryManager>();
        public static List<BlocksManager> BlockManagers = new List<BlocksManager>();



    }
    ///////////////////////////////////////////// Owner Class //////////////////////////////////////////




    //// Classes required for this application:
    ///*
    //class PremiumArray<G>
    //{
    //    G[] array;

    //    public PremiumArray(int Size)
    //    {
    //        array = new G[Size];
    //    }
    //    public PremiumArray()
    //    {
    //        array = new G[100];
    //    }
    //    public int Lenght
    //    {
    //        get
    //        {
    //            return array.Length;
    //        }
    //        set
    //        {
    //            G[] NewArray = new G[value];
    //            for (int i = 0; i < (array.Length < NewArray.Length ? array.Length : NewArray.Length); i++)
    //            {
    //                NewArray[i] = array[i];
    //            }
    //            array = NewArray;
    //        }
    //    }
    //    public G this[int index]
    //    {
    //        get { return array[index]; }
    //        set { array[index] = value; }
    //    }

    //}
    //class Phonebook
    //{
    //    PremiumArray<string> Names;
    //    PremiumArray<long> Numbers;
    //    // <Temp>
    //    int Counter;

    //    public Phonebook()
    //    {
    //        Names = new PremiumArray<string>();
    //        Numbers = new PremiumArray<long>();
    //        Counter = 0;
    //    }
    //    public long this[string A]
    //    {
    //        get
    //        {
    //            for (int i = 0; i < Counter; i++)
    //            {
    //                if (Names[i] == A)
    //                {
    //                    return Numbers[i];
    //                }
    //            }
    //            return -1; // for checking ...
    //            // throw new Exception("Not Found!");
    //        }
    //        set
    //        {
    //            Names[Counter] = A;
    //            Numbers[Counter] = value;
    //            Counter++;
    //            if (Counter == Names.Lenght)
    //            {
    //                Names.Lenght = Names.Lenght + 5;
    //                Numbers.Lenght = Numbers.Lenght + 5;
    //            }
    //        }
    //    }

    //    public string this[long A]
    //    {
    //        get
    //        {
    //            for (int i = 0; i < Counter; i++)
    //            {
    //                if (Numbers[i] == A)
    //                {
    //                    return Names[i];
    //                }
    //            }
    //            return "-1"; // for checking ...
    //            // throw new Exception("Not Found!");
    //        }
    //        set
    //        {
    //            Names[Counter] = value;
    //            Numbers[Counter] = A;
    //            Counter++;
    //            if (Counter == Names.Lenght)
    //            {
    //                Names.Lenght = Names.Lenght + 5;
    //                Numbers.Lenght = Numbers.Lenght + 5;
    //            }
    //        }
    //    }

    //    public void Remove(string name)
    //    {
    //        for (int i = 0; i < Counter; i++)
    //        {
    //            if (Names[i] == name)
    //            {
    //                for (; i < Counter; i++)
    //                {
    //                    Numbers[i] = Numbers[i + 1];
    //                    Names[i] = Names[i + 1];
    //                }
    //                Counter--;
    //                return;
    //            }
    //        }
    //        throw new Exception("Remove No one?");
    //    }

    //}
    //*/
    //abstract class Person
    //{
    //    protected string name;
    //    protected string address;
    //    protected int    id;
    //    protected string phone;



    //    //public Person(string Name, string Address, int Id, string Phone) 
    //    //{
    //    //    name = Name;
    //    //    address = Address;
    //    //    id = Id;
    //    //    phone = Phone;
    //    //}
    //    //public string Name 
    //    //{ 
    //    //    get { return name; } 
    //    //    set { name = value; } 
    //    //}



    //    public  string Name { get { return name;  } set { name = value; } }
    //    public string Address { get { return address; } set { address = value; } }
    //    public int Id { get { return id; } set { id = value; } }
    //    public string Phone { get { return phone; } set { phone = value; } }
    //}
    //class HostelManager : Person
    //{
    //    protected string position;
    //    public string Position { get { return position; } set { position = value; } }

    //}

}