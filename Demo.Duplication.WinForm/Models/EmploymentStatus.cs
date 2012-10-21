
namespace Demo.Duplication.WinForm.Models
{
    #region Duplicated version
    //public class EmploymentStatus : ModelAbstract
    //{
    //    private const string IN_ACTIVE = "InActive";
    //    private const string DISPLAYED_IN_ACTIVE = "Non Aktif";

    //    public EmploymentStatus()
    //    {
    //        // SAP's Date style : 99991231 = 31/12/9999 , default date. For a specific date like 05/06/2012 it would be written as 20120605
    //        Id = long.MinValue;
    //        ExpiredDate = 99991231;
    //        CreatedDate = 99991231;
    //        ModifiedDate = 99991231;
    //        Code = IN_ACTIVE;
    //        DisplayedName = DISPLAYED_IN_ACTIVE;
    //    }

    //    public long Id { set; get; }
    //    public uint CreatedDate { set; get; }
    //    public uint ModifiedDate { set; get; }
    //    public uint ExpiredDate { set; get; }
    //    public string Code { set; get; }
    //    public string DisplayedName { set; get; }
    //} 
    #endregion

    public class EmploymentStatus : ModelAbstract
    {
        private const string IN_ACTIVE = "InActive";
        private const string DISPLAYED_IN_ACTIVE = "Non Aktif";

        public EmploymentStatus()
        {
            Code = IN_ACTIVE;
            DisplayedName = DISPLAYED_IN_ACTIVE;            
        }
    }
}
