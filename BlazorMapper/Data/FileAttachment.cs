namespace BlazorMapper.Data
{
    public class FileAttachment
    {
        public Guid DocumentId { get; set; }
        public string FileType { get; set; }
        public string AttachmentDescription { get; set; }
        public string Notes { get; set; }
        public string FileName { get; set; }
        public byte[] Attachment { get; set; }
    }
}
