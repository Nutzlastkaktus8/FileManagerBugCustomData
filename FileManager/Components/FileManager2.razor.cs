using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using BFIFileManager;
using BFIFileManager.Layout;
using Syncfusion.Blazor;
using Syncfusion.Blazor.FileManager;

namespace BFIFileManager.Components
{
    public partial class FileManager2
    {
        public string Url = "http://localhost:62869/api/FileManager/FileOperations";
        public string DownloadUrl = "http://localhost:62869/api/FileManager/Download";
        public string UploadUrl = "http://localhost:62869/api/FileManager/Upload";
        public int FileSize { get; set; } = 15 * 1024 * 1024;
        public string[] ValidFileTypes = new string[]
        {
            "pdf",
            "txt",
            "jpg",
            "doc",
            "msg",
            "docx",
            "xls",
            "zip",
            "odt",
            "jpeg",
            "xlsx",
            "rtf",
            "htm",
            "bmp",
            "vcf",
            "rar",
            "tif",
            "png",
            "gif"
        };
        public string FileTypes
        {
            get
            {
                return "." + string.Join(", .", ValidFileTypes);
            }
        }

        public async Task Send(BeforeSendEventArgs args)
        {
            if (args.Action == "Upload")
            {
                var newdiconary = new Dictionary<string, object>
                {
                    { "CurrentFolderId", 1},
                };
                args.CustomData = newdiconary;
            }
        }
    }
}