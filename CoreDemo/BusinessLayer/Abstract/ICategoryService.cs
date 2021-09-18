using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void Add(Category c);
        void Delete(Category c);
        void Update(Category c);
        List<Category> GetAll();
        Category GetById(int id);

    }
}
