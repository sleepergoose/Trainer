﻿using System.IO;
using System.Threading.Tasks;

namespace Shared.AzureBlobStorage
{
    public interface IBlobService
    {
        Task<string> UploadAsync(Stream fileStream, string fileName, string contentType);
        Task DeleteFileAsync(string fileName);
    }
}
