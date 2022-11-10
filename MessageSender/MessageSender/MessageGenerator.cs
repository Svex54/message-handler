namespace MessageSender
{
    public class MessageGenerator
    {
        private readonly Random _random;
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public MessageGenerator()
        {
            _random = new Random();
        }

        public MessageModel GenerateMessage(int length)
        {
            var priority = GeneratePriority(10);
            var message = GenerateMessageText(length);
            return new MessageModel() { Priority = priority, Message = message, Processed = false };
        }

        public List<MessageModel> GenerateNMessages(int N)
        {

            var messages = new List<MessageModel>();
            for (int i = 0; i < N; i++)
            {
                messages.Add(GenerateMessage(15));
            }
            return messages;
        }

        private int GeneratePriority(int v)
        {
            return _random.Next(v);
        }

        private string GenerateMessageText(int length)
        {
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
