﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galt.Crawler.Util
{
    public class VPackage
    { 
        public VPackage(string packageId, Version version)
        {
            if( packageId == null && version == null ) throw new ArgumentException();

            PackageId = packageId;
            Version = version;
        }

        public string PackageId { get; }

        public Version Version { get; }

        public Dependencies Dependencies { get; set; }

        public string PublicationDate { get; set; }

    }
}