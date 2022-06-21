namespace BlazorMapper.Models
{
    public class CostCenterDto
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public string FormattedName { get { return this.ToString(); } }

        public override string ToString()
        {
            var code = (Code / 100.0).ToString("F2");

            code = code.Replace(',', '.');                  // due use of CultureInfo pt-BR

            return $"{code} # {Name}";
        }

    }
}
