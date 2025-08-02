using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace HostelManagement
{
    public static class DataStorage
    {
        private const string FilePath = "data.json";

        public static void SaveData()
        {
            var data = new DataContainer
            {
                Dormitories = DATA.Dormitories,
                Blocks = DATA.Blocks,
                Students = DATA.Students,
                DormitoryManagers = DATA.DormitoryManagers,
                BlockManagers = DATA.BlockManagers,
                Tools = DATA.Tools
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve,
                IncludeFields = true
            };

            string json = JsonSerializer.Serialize(data, options);
            File.WriteAllText(FilePath, json);

        }

        public static void LoadData()
        {
            if (!File.Exists(FilePath))
                return;

            string json = File.ReadAllText(FilePath);
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                IncludeFields = true
            };

            var data = JsonSerializer.Deserialize<DataContainer>(json, options);
            if (data != null)
            {
                DATA.Dormitories = data.Dormitories ?? new();
                DATA.Blocks = data.Blocks ?? new();
                DATA.Students = data.Students ?? new();
                DATA.DormitoryManagers = data.DormitoryManagers ?? new();
                DATA.BlockManagers = data.BlockManagers ?? new();
                DATA.Tools = data.Tools ?? new();
            }
        }

        public class DataContainer
        {
            public List<Dormitory> Dormitories { get; set; }
            public List<Block> Blocks { get; set; }
            public List<Student> Students { get; set; }
            public List<DormitoryManager> DormitoryManagers { get; set; }
            public List<BlocksManager> BlockManagers { get; set; }
            public List<Tool> Tools { get; set; }
        }
        public static void ResetData()
        {
            DATA.Dormitories.Clear();
            DATA.Blocks.Clear();
            DATA.Students.Clear();
            DATA.DormitoryManagers.Clear();
            DATA.BlockManagers.Clear();
            DATA.Tools.Clear();

            string filePath = "data.json";
            if (File.Exists(filePath))
                File.Delete(filePath);
        }

    }
}
