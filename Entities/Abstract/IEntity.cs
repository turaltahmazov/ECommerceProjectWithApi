using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    //database from table id
   public interface IEntity
    {

        int Id { get; set; }
    }
}
