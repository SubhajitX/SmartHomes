using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHomeStatusDetection.Interfaces;

namespace SmartHomeStatusDetection
{
    class GasLeakStatus : IProblemStatus
    {
        public bool Status()
        {
            Status status = new Status();
            bool problemStatus = status.GetStatus();

            return problemStatus;
        }
    }
}
