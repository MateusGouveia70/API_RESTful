using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful.HiperMedia.Abstract
{
    public interface ISupportHypeMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
