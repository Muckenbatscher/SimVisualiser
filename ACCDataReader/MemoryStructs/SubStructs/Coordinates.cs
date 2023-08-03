using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ACCDataReader.MemoryStructs.SubStructs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Coordinates
    {
        public float X;
        public float Y;
        public float Z;
    }
}
