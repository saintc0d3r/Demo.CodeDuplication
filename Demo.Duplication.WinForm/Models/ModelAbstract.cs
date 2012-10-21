
namespace Demo.Duplication.WinForm.Models
{
    public abstract class ModelAbstract
    {
        protected ModelAbstract()
        {
            Id = long.MinValue;
            ExpiredDate = 99991231;
            CreatedDate = 99991231;
            ModifiedDate = 99991231;
        }

        public long Id { set; get; }
        public uint CreatedDate { set; get; }
        public uint ModifiedDate { set; get; }
        public uint ExpiredDate { set; get; }
        public string Code { set; get; }
        public string DisplayedName { set; get; }
    }
}
