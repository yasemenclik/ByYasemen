﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ByYsmn.Application.CompanyServices
{
    public interface ICompanyService
    {
        Task /*return list type*/ GetAll();
        Task /*return item type*/ Get();
        Task /*return just created item*/ Create(/*createinput*/);
        Task /* return modified item*/ Update(/*Update input*/);
        Task /* success or not success*/ Delete(/*Entity input*/);
    }
}
