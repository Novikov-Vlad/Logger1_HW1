﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_logger1
{
    class Starter
    {
        public void Run()
        {
            Random rand = new Random();
            Actions act = new Actions();
            Logger log = new Logger.GetInstance();

            for(int i = 0; i < 100; i++)
            {
                try
                {
                    int funcRandNum = rand.Next(1, 4);
                    switch (funcRandNum)
                    {
                        case 1:
                            act.MethodFirst();
                            break;
                        case 2:
                            act.MethodSecond();
                            break;
                        case 3:
                            act.MethodThird();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(log.NewMessage(GlobalConstant.Error, ex));
                }
            }
        }
    }
}
