﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            string email = "pesho.peshev@email.bg";
            string text="My name is Pesho Peshev. I am from Sofia, my"+ 
                       " email is:pesho.peshev@email.bg (not pesho.peshev@email.com)."+ 
                        "Test: pesho.meshev@email.bg, pesho.peshev@email.bg";
            int username = email.IndexOf("@");
            string replase = new string('*', username)+email.Substring(username);

            text = text.Replace(email, replase);
            Console.WriteLine(text);

        }
    }

