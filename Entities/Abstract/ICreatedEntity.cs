using System;

namespace Entities.Abstract
{
    public  interface ICreatedEntity
    {
        int CretaedUserId { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
