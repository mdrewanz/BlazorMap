namespace BlazorMapper.Models
{
    public class ProjectDto
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public string FormattedName
        {
            get { return this.ToString(); }
        }

        public override string ToString()
        {
            return $"{Code} # {Name}";
        }
    }
}
