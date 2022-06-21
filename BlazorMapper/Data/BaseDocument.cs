namespace BlazorMapper.Data
{
    public abstract class BaseDocument : IBaseDocument
    {
        public string Id { get; set; }
        public DateTime LastUpdatedOn => System.DateTime.Now;
    }
}
