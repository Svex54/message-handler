using MessageSender;

using (MessageDbContext db = new())
{
    var messages = db.Messages.Where(x => !x.Processed).OrderBy(x => x.Priority).ToList();

    //Simulation of the endless operation of the system.
    while (true)
    {
        while (messages.Any())
        {
            var resultMessage = Processing(messages.First());
            db.Messages.Update(resultMessage);
            db.SaveChanges();
            messages = db.Messages.Where(x => !x.Processed).OrderBy(x => x.Priority).ToList();
        }
    }
}

static MessageModel Processing(MessageModel message)
{
    Console.WriteLine(message.Message);
    message.Processed = true;
    Thread.Sleep(1000);
    return message;
}