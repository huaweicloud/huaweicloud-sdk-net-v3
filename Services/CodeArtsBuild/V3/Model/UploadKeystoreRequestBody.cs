using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UploadKeystoreRequestBody : IFormDataBody
    {

        /// <summary>
        /// 文件
        /// </summary>
        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart File { get; set; }

        /// <summary>
        /// 同意隐私声明，允许使用用户敏感信息进行相关业务操作。
        /// </summary>
        [JsonProperty("privacy", NullValueHandling = NullValueHandling.Ignore)]
        public string Privacy { get; set; }

        /// <summary>
        /// 文件描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        
        public UploadKeystoreRequestBody WithFile(Stream stream, string filename)
        {
            this.File = new FormDataFilePart(stream, filename);
            return this;
        }

        public UploadKeystoreRequestBody WithFile(Stream stream, string filename, string contentType)
        {
            this.File = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("file", File);
            formData.Add("privacy", new FormDataPart<string>(Privacy));
            if (Description != null) {
                formData.Add("description", new FormDataPart<string>(Description));
            }

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadKeystoreRequestBody {\n");
            sb.Append("  file: ").Append(File).Append("\n");
            sb.Append("  privacy: ").Append(Privacy).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadKeystoreRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadKeystoreRequestBody input)
        {
            if (input == null) return false;
            if (this.File != input.File || (this.File != null && !this.File.Equals(input.File))) return false;
            if (this.Privacy != input.Privacy || (this.Privacy != null && !this.Privacy.Equals(input.Privacy))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.File != null) hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Privacy != null) hashCode = hashCode * 59 + this.Privacy.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
