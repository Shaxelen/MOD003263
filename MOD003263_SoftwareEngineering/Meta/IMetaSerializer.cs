using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD003263_SoftwareEngineering.Meta {
    public interface IMetaSerializer<T> {
        T Load();
        bool Save(T TIn); 
    }
}
