
namespace Demo.Duplication.WinForm.Models
{
    #region Contain duplicated properties
    //public class Department
    //{        
    //    private const string UNKNOWN_DEPARTMENT = "Unknown";

    //    public Department()
    //    {
    //        // SAP's Date style : 99991231 = 31/12/9999 , default date. For a specific date like 05/06/2012 it would be written as 20120605
    //        Id = long.MinValue;
    //        ExpiredDate = 99991231;
    //        CreatedDate = 99991231;
    //        ModifiedDate = 99991231;
    //        Code = string.Empty;
    //        DisplayedName = UNKNOWN_DEPARTMENT;
    //    }

    //    public long Id { set; get; }
    //    public uint CreatedDate { set; get; }
    //    public uint ModifiedDate { set; get; }
    //    public uint ExpiredDate { set; get; }
    //    public string Code { set; get; }
    //    public string DisplayedName { set; get; }
    //}
    #endregion Contain duplicated properties

    public class Department : ModelAbstract
    {
        private const string UNKNOWN_DEPARTMENT = "Unknown";

        public Department()
        {
            Code = string.Empty;
            DisplayedName = UNKNOWN_DEPARTMENT;
        }        
    }
}
