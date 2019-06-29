using ByYsmn.Application.CompanyServices.Dtos;
using ByYsmn.Core.Companies;
using System;
using ByYsmn.Application.Shared;
namespace ByYsmn.Application.CompanyServices
{
    public interface ICompanyService
        :IBaseService<Guid, CompanyCreateInput, CompanyUpdateInput, Company>
    {
        //Task/*return list type*/ GetAll();
        //Task/*return item type*/ Get(/*EntityInput*/);
        //Task/*return just created item*/ Create(/*createinput*/);
        //Task/*return modified item*/ Update(/*Update input*/);
        //Task/*success or not success*/ Delete(/*EntityInput*/);
    }
}