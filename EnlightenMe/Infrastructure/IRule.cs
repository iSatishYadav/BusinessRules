using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EnlightenMe.Infrastructure
{
    public interface IRule
    {
        string MemberName { get; set; }

        string Operator { get; set; }

        string DesiredValue { get; set; }

    }
}
