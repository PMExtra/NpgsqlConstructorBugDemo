using NpgsqlTypes;

namespace BugDemo
{
    public class Model
    {
        public enum MyEnum
        {
            First,
            Second
        }

        public int Id { get; set; }

        public PostgisPoint Location { get; set; }

        public MyEnum EnumField { get; set; }
    }
}