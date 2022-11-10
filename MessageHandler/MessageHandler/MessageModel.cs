namespace MessageSender
{
    public class MessageModel
    {
        public int Id { get; set; }
        public int?  Priority { get; set; }
        public string? Message { get; set; }
        public bool Processed { get; set; }
    }
}
