using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharedMemoryReader.Services
{
    public class SharedMemoryReader<M> where M : struct
    {
        protected string Path { get; set; }

        public SharedMemoryReader(string path)
        {
            Path = path;
        }

        public M? ReadSharedMemory()
        {
            var mappedFile =  MemoryMappedFile.OpenExisting(Path);
            if (mappedFile == null)
                return null;

            using (var stream = mappedFile.CreateViewStream())
            {
                using (var reader = new BinaryReader(stream))
                {
                    var size = Marshal.SizeOf(typeof(M));
                    var bytes = reader.ReadBytes(size);
                    var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                    var data = (M)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(M));
                    handle.Free();
                    return data;
                }
            }
        }
    }
}
