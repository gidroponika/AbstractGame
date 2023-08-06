namespace AbstractGame
{
    internal class Program
    {
        static void Main()
        {
            Hero hero = new Hero(100, 10, 5);
            GameScene game = new GameScene(hero, new OrdinaryEnemy(35, 5, 3),
                                                 new OrdinaryEnemy(35, 5, 3),
                                                 new OrdinaryEnemy(35, 5, 3),
                                                 new HardEnemy(200, 15, 10),
                                                 new HardEnemy(200, 15, 10),
                                                 new HardEnemy(200, 15, 10));
            //тут нібито відбувається якась логіка гри

        }
    }
}