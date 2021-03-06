﻿using Microsoft.Extensions.FileProviders;
using Microsoft.WindowsAzure.Storage.File;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LamondLu.AzureFileProvider
{
    public class AzureFileInfo : IFileInfo
    {
        private CloudFile _file = null;

        public AzureFileInfo(CloudFile file)
        {
            _file = file;
        }

        public bool Exists
        {
            get
            {
                return true;
            }
        }

        public long Length
        {
            get
            {
                return _file.Properties.Length;
            }
        }

        public string PhysicalPath
        {
            get
            {
                return _file.Uri.AbsolutePath;
            }
        }

        public string Name
        {
            get
            {
                return _file.Name;
            }
        }

        public DateTimeOffset LastModified
        {
            get
            {
                return _file.Properties.LastModified.GetValueOrDefault();
            }
        }

        public bool IsDirectory
        {
            get
            {
                return false;
            }
        }


        public Stream CreateReadStream()
        {
            throw new NotImplementedException();
        }
    }
}
