﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalDemo.Data.Domain;

namespace PersonalDemo.Service.Profiles
{
    public interface IProfileService
    {
        IQueryable<Profile> GetAll();
    }
}
