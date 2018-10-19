using ReactjsCoreTest.Data.Entities;
using ReactjsCoreTest.Infrastrusture.Interfaces;
using ReactjsCoreTest.Infrastrusture.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReactjsCoreTest.Application.Interfaces
{
    public interface IProductRepository<T>: IRepository<T> where T :class, IDomainEntity
    {    

    }
}
