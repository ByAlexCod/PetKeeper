using System;
using System.Collections.Generic;
using System.Text;

namespace PetKeeper.PetKeeperFacade
{
    class PetKeeperFacade: IPetKeeper
    {
        private CatKeeper.CatKeeper _cat = new CatKeeper.CatKeeper();
        private DogKeeper.DogtKeeper _dog = new DogKeeper.DogtKeeper();
        public void giveFood()
        {
            Console.WriteLine("We are feeding your pets: ");
            _cat.giveCatFood();
            _dog.giveDogFood();
        }

        public void tame()
        {
            Console.WriteLine("We are taming your pets: ");
            _cat.tame();
            _dog.tame();
        }

        public void sleepTime()
        {
            Console.WriteLine("We are putting your animals to sleep: ");
            _cat.sleepYouCat();
            _dog.coucouchePanier();
        }
    }
}
