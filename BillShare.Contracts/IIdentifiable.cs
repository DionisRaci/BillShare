using System;
using System.Collections.Generic;
using System.Text;

namespace BillShare.Contracts
{
    public interface IIdentifiable
    {
        int Id { get; set; }
    }
}
