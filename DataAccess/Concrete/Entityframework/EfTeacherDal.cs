﻿using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Entityframework
{
    public class EfTeacherDal : EfBaseRepository<Teacher, WebAPIContext>, ITeacherDal
    {
    }
}
