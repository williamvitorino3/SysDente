using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SysDente.Entities;

namespace SysDente.Controllers
{
    public interface IControllerBase<T> where T : class, IEntity
    {
        IActionResult GetAll();
        IActionResult Find(int id);
        IActionResult Add(T newObject);
        IActionResult Update(int id, T newObject);
        IActionResult Remove(int id);
    }
}