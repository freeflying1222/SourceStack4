﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Suggest:Content
    {
        public override void Agree()
        {
            throw new NotImplementedException();
        }

        public override void Disagree()
        {
            throw new NotImplementedException();
        }

        //标题,内容，作者，评论，赞，踩

        public override void ReleseHelpMoney()
        {
            Console.WriteLine("不需要消耗帮帮币");
        }

    }
}