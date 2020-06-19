using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.Entities;

namespace Test2.Services
{
    public interface IService
    {
        public void InitContext(Context context);
    }
}
