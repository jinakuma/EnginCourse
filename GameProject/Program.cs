using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { BirthDay = 1984,FirstName = "Murat", LastName = "utlu", NationalatyId = 61252319098 });
        }
    }
}
