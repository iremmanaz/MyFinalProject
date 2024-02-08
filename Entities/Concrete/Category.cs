
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category: IEntity
    {
        //Çıplak class kalmasın. Yani inheritance falan yapmak lazım. bi gruplama falan lazım.
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }  
}
