﻿using System.Reflection;
using EPiServer.Core;

namespace JOS.ContentSerializer.Internal
{
    public class DefaultBoolPropertyHandler : IPropertyHandler<bool>
    {
        public object Handle(bool value, PropertyInfo property, IContentData contentData)
        {
            return value;
        }
    }
}