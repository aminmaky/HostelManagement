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
            DataStorage.LoadData();
            Application.Run(new Login());
            Application.Run(new Login());
        }
    }

    // Data:
    public static class DATA
    {
        public static List<Dormitory> Dormitories = new List<Dormitory>();
        public static List<Block> Blocks = new List<Block>();
        public static List<Student> Students = new List<Student>();
        public static List<DormitoryManager> DormitoryManagers = new List<DormitoryManager>();
        public static List<BlocksManager> BlockManagers = new List<BlocksManager>();
        public static List<Tool> Tools = new List<Tool>();
    }
    
}