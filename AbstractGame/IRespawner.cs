using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGame
{

    //інтерфейс що застосовуємо до всі ігрових персонажів,
    //що здатні відроджуватись
    internal interface IRespawner
    {
        IRespawner Respawn();
    }
}
