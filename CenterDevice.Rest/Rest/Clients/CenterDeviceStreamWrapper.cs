using CenterDevice.Rest.Clients.OAuth;
using CenterDevice.Rest.Exceptions;
using CenterDevice.Rest.ResponseHandler;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace CenterDevice.Rest.Clients
{
    /// <summary>
    /// A basic stream wrapper implementation
    /// </summary>
    class CenterDeviceStreamWrapper : IStreamWrapper
    {
        Stream IStreamWrapper.WrapDownloadStream(Stream stream)
        {
            return stream;
        }

        Stream IStreamWrapper.WrapUploadStream(Stream stream)
        {
            return stream;
        }
    }
}
