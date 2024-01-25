namespace Adopt_An_Insect
{
    class Player
    {
        public string Name;
        public Insect PlayerInsect;

        public Player()
        {
            PlayerInsect = new Insect("Insect Buddy", "Pink");
        }
    }
}