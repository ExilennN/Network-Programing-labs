using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SpyClient
{
    internal class IDPair
    {
        public IPEndPoint ipEndPoint { get; set; }
        public string machineID { get; set; }

        public IDPair(IPEndPoint _ipEndPoint, string _machineID) { ipEndPoint = _ipEndPoint; machineID = _machineID; }
    }
}
