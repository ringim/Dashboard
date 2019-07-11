using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    class FormControls
    {
        public const int MaxFingers = 10;
        // shared data
        public int EnrolledFingersMask = 0;
        public int MaxEnrollFingerCount = MaxFingers;
        public bool IsEventHandlerSucceeds = true;
        public bool IsFeatureSetMatched = false;
        public int FalseAcceptRate = 0;
        public DPFP.Template[] Templates = new DPFP.Template[MaxFingers];

        public byte[] Datum = null;

        //THis will hold the list of all users to avoid long booting while initializing Attendance
        public List<tblPersonalDetail> Tablue;
    }
}
