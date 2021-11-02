using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.ServiceInterface
{
    public interface IValidator<in T>
    {
        void DefaultValidation(T entity);
    }
}
