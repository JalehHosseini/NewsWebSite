﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{

    public interface ILoginReposiory
    {
        bool IsExistUser(string username, string password);
    }

}