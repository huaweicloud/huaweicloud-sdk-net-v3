using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UploadPluginIconRequestBody : IFormDataBody
    {

        /// <summary>
        /// 图标文件
        /// </summary>
        [JsonProperty("upload_file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart UploadFile { get; set; }


        
        public UploadPluginIconRequestBody WithUploadFile(Stream stream, string filename)
        {
            this.UploadFile = new FormDataFilePart(stream, filename);
            return this;
        }

        public UploadPluginIconRequestBody WithUploadFile(Stream stream, string filename, string contentType)
        {
            this.UploadFile = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("upload_file", UploadFile);

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadPluginIconRequestBody {\n");
            sb.Append("  uploadFile: ").Append(UploadFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadPluginIconRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadPluginIconRequestBody input)
        {
            if (input == null) return false;
            if (this.UploadFile != input.UploadFile || (this.UploadFile != null && !this.UploadFile.Equals(input.UploadFile))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.UploadFile != null) hashCode = hashCode * 59 + this.UploadFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
