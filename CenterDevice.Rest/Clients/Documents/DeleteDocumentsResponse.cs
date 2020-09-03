﻿using RestSharp.Deserializers;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Documents
{
    public class DeleteDocumentsResponse
    {
        [DeserializeAs(Name = "failed-documents")]
        public List<string> FailedDocuments { get; set; }
    }
}
