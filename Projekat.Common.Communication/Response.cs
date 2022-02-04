using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Communication
{
    [Serializable]
    public class Response
    {
        public string Message { get; set; }
        public bool IsSuccessful { get; set; } = true;
        public object Result { get; set; }

    }
}
