//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Blocke
//{
//    private string Name;
//    private int FloresCount;
//    private int RoomCount;
//    private string supervisor;
//    public List<Rooms> room;
//    private string DormitoryName;
//    public Blocke(string Name, int FloresCount, int RoomCount, string supervisor, string DormitoryName, List<Rooms> room)
//    {
//        this.Name=Name;
//        this.FloresCount=FloresCount;
//        this.RoomCount=RoomCount;
//        this.supervisor=supervisor;
//        this.room = room;
//    }


//}
////public class Dormitory
////{
////    private string Name;
////    private string Address;
////    private long Capacity;
////    private string supervisor;
////    private List<Blocke> block;
////    private List<Rooms> room;
////    public Dormitory(string Name, string Address, long Capacity, string supervisor, List<Blocke> block, List<Rooms> room)
////    {
////        this.Name=Name;
////        this.Address=Address;
////        this.Capacity=Capacity;
////        this.supervisor=supervisor;
////        this.block = block;
////        this.room = room;
////    }
////}
//public class Rooms
//{
//    private double RoomNum;
//    private int Floor;
//    private int Capacity;
//    private string BlockName;
//    private List<student> daneshgo;
//    private List<Tools> tool;

//    public Rooms(double RoomNum, int Floor, int Capacity, string BlockName, List<student> daneshgo, List<Tools> tool)
//    {
//        this.RoomNum=RoomNum;
//        this.Floor=Floor;
//        this.Capacity=Capacity;
//        this.BlockName=BlockName;
//        this.daneshgo=daneshgo;
//        this.tool=tool;
//    }

////}
////public enum status
////{
////    Healty,
////    Defective,
////    UnderRepair
////}
////public enum Assets
////{
////    bed,
////    desk,
////    commode,
////    chair,
////    fridge
////}
////public class Tools
////{
////    private Assets Type;
////    private string[] PartNum;
////    private string Number;
////    private status status;
////    private int RoomNum;
////    private string OwnerName;

////    public Tools(Assets type, string[] partNum, string number, status status, int roomNum, string ownerName)
////    {
////        Type=type;
////        PartNum=partNum;
////        Number=number;
////        this.status=status;
////        RoomNum=roomNum;
////        OwnerName=ownerName;
////    }
////}



////public class Person
////{
////    protected string Firstname;
////    protected string Lastname;
////    protected string IdNum;
////    protected string TelNum;
////    protected string Address;

////    public Person(string Firstname, string Lastname, string IdNum, string TelNum, string Address)
////    {
////        this.Firstname=Firstname;
////        this.Lastname=Lastname;
////        this.IdNum=IdNum;
////        this.TelNum=TelNum;
////        this.Address=Address;
////    }
////    /*
////    public string FirstName
////    {
////        get { return FirstName; }
////        set { FirstName = value; }
////    }
////    public string LastName
////    {
////        get { return LastName; }
////        set { LastName = value; }
////    }
////    public string IdNumber
////    {
////        get { return IdNum; }
////        set { IdNum = value; }
////    }
////    public string TelephoneNumber
////    {
////        get { return TelNum; }
////        set { TelNum = value; }
////    }
////    public string Addresss
////    {
////        get { return Address; }
////        set { Address = value; }
////    }
////    */
////}
//public class student : Person
//{
//    protected string StudentId;
//    protected int Room;
//    protected int Block;
//    protected int dormitory;
//    private List<Tools> tools;
//    public student(string firstname, string lastname, string idNum, string telNum, string address, string StudentId, int Room, int Block, int dormitory, List<Tools> tool)
//       : base(firstname, lastname, idNum, telNum, address)
//    {
//        this.StudentId=StudentId;
//        this.Room=Room;
//        this.Block=Block;
//        this.dormitory=dormitory;
//        this.tools=tool;
//    }
//    /*
//    public string StudentID
//    {
//        get { return StudentId; }
//        set { StudentId = value; }
//    }
//    public int RoomNumber
//    {
//        get { return Room; }
//        set { Room = value; }
//    }
//    public int BlockNumber
//    {
//        get { return Block; }
//        set { Block = value; }
//    }
//    public int DormitoryNumber
//    {
//        get { return dormitory; }
//        set { dormitory = value; }
//    }
//    */
//}
////public class BlocksManager : student
////{
////    private string Position;
////    private int controledBlock;

////    public BlocksManager(string firstname, string lastname, string idNum, string telNum, string address, string StudentId, int Room, int Block, int dormitory, string position, int controledBlock)
////        : base(firstname, lastname, idNum, telNum, address, StudentId, Room, Block, dormitory)
////    {
////        Position=position;
////        this.controledBlock=controledBlock;
////    }
////}
////public class DormitoryManager : Person
////{
////    private string position;
////    private int controledDormitory;

////    public DormitoryManager(string firstname, string lastname, string idNum, string telNum, string address, string position, int controledDormitory)
////        : base(firstname, lastname, idNum, telNum, address)

////    {
////        this.position=position;
////        this.controledDormitory=controledDormitory;
////    }
////}
//class DormitoryManager
//{
//    public string FirstName;
//    public string LastName;
//    public string Position;
//    public string Phone;
//    public string Address;

//}


