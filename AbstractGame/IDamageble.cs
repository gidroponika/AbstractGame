using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGame
{

    //інтерфейс що застосовуємо до всі ігрових персонажів,
    //що здатні наносити урон
    internal interface IDamageble
    {
        int InflictDamage();
    }
}
