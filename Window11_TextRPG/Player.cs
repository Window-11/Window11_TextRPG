﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window11_TextRPG
{
    public class Player
    {
        public string name { get; set; } = "";
        public int level { get; set; } = 1;
        public string job { get; set; } = "전사";
        public int atk { get; set; } = 10;
        public int def { get; set; } = 5;
        public int hp { get; set; } = 100;
        public int gold { get; set; } = 1500;
        // public Item weapon { get; set; } = null;
        // public Item armor { get; set; } = null;

        public bool Hpcheck()
        {
            if (hp <= 0)
            {
                return true;
            }

            return false;
        }

    }
}
