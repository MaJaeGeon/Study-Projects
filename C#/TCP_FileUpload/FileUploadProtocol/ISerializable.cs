using System;
using System.Collections.Generic;
using System.Text;

namespace FileUploadProtocol
{
    public interface ISerializable
    {
        byte[] GetBytes();
        int GetSize();
    }
}
