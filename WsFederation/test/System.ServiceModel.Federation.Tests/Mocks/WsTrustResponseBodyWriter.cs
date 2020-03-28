﻿using System.ServiceModel.Channels;
using System.Xml;
using Microsoft.IdentityModel.Protocols.WsTrust;

namespace System.ServiceModel.Federation.Tests.Mocks
{
    internal class WsTrustResponseBodyWriter: BodyWriter
    {
        private readonly WsTrustResponse _response;

        public WsTrustResponseBodyWriter(WsTrustResponse response): base(false)
        {
            _response = response;
        }

        protected override void OnWriteBodyContents(XmlDictionaryWriter writer)
        {
            var serializer = new WsTrustSerializer();
            serializer.WriteResponse(writer, WsTrustVersion.Trust13, _response);
        }
    }
}