using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGame
{
    //ігрова сцена, що містить в собі всіх ігрових персонажів
    internal class GameScene
    {
        public GamePerson[] gamePersons;
        public GameScene(Hero hero, params Enemy[] persons)
        {
            gamePersons = new GamePerson[persons.Length + 1];
            gamePersons[0] = hero;
            for (int i = 1; i < gamePersons.Length; i++)
            {
                gamePersons[i] = persons[i - 1];
            }
        }

        //перевіряє, чи може хтось із ігрових персонажів,
        //що здатні відроджуватись
        //відродитись, тих що не відродився, видаляє з ігровоЇ сцени
        public void DeletePerson()
        {
            for (int i = 0; i < gamePersons.Length; i++)
            {
                if (gamePersons[i].IsDead && gamePersons[i] is IRespawner)
                {
                    IRespawner resp = (IRespawner)gamePersons[i];
                    gamePersons[i] = (GamePerson)resp.Respawn();
                }
            }
            for (int i = 0; i < gamePersons.Length; i++)
            {
                if (gamePersons[i] == null)
                {
                    Delete(gamePersons[i]);
                }
            }
        }
        void Delete(GamePerson person)
        {
            //метод який нібито удаляє null GamePerson із сцени
        }
    }
}
