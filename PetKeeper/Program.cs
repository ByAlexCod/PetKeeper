using System;
using PetKeeper.PetKeeperFacade;

namespace PetKeeper
{
    class Program
    {
        private static IPetKeeper petKeeper = new PetKeeperFacade.PetKeeperFacade();
        static void Main(string[] args)
        {
            petKeeper.tame();
            petKeeper.giveFood();
            petKeeper.sleepTime();
        }
    }
}
