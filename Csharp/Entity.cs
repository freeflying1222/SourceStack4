﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    //4、再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，
    //包含一个只读的Id属性。试一试，Suggest能有Id属性么？good
   public  class Entity
    {
        public  int Id { get; }
        public Entity()
        {

        }
        public Entity( int number)
        {
            Id = number;
        }
    }
}
