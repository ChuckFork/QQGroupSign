namespace QQGroupSign
{
    public class QQGroup
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }

        public override string ToString()
        {
            return GroupName;
        }
    }
}
