using System;
using System.Collections.Generic;
using System.Text;

namespace Bitspace.Services
{
    public interface IDeviceInformationService
    {
        bool IsiOS { get; }
        bool IsAndroid { get; }
    }
}
