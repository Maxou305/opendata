﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opendata
{
    public interface IRequest
    {
        List<TransportLine>GetResponse();

    }
}
