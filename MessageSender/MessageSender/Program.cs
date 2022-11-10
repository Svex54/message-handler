using MessageSender;
using System.Configuration;

using (MessageDbContext db = new())
{
    int maxMessagePerIteration = int.Parse(ConfigurationManager.AppSettings["maxMessagePerIteration"]);
    int maxHoursIdle = int.Parse(ConfigurationManager.AppSettings["maxHoursIdle"]);
    var random = new Random();

    //Re-creation db
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    //Simulation of the endless operation of the system.
    while (true)
    {
        var generator = new MessageGenerator();
        var messages = generator.GenerateNMessages(random.Next(maxMessagePerIteration));
        db.Messages.AddRange(messages);
        db.SaveChanges();
        
        //Idle
        Thread.Sleep(new TimeSpan(random.Next(1, maxHoursIdle), 0, 0));
    }
}


