

namespace ERP.Domain
{
    public class LookUp :BaseEntity<int>
    {
        public string TableName { get; set; } = string.Empty;
        public string KeyFieldName { get; set; } = string.Empty;
        public string ValueExpression { get; set; } = string.Empty;
    }
}
