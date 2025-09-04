using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UploadAppIconRequestBody : IFormDataBody
    {

        /// <summary>
        /// 应用图标，png格式，限制大小8KB。
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart Data { get; set; }

        /// <summary>
        /// base64编码后的png格式图标。
        /// </summary>
        [JsonProperty("icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUrl { get; set; }


        
        public UploadAppIconRequestBody WithData(Stream stream, string filename)
        {
            this.Data = new FormDataFilePart(stream, filename);
            return this;
        }

        public UploadAppIconRequestBody WithData(Stream stream, string filename, string contentType)
        {
            this.Data = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            if (Data != null) {
                formData.Add("data", Data);
            }
            if (IconUrl != null) {
                formData.Add("icon_url", new FormDataPart<string>(IconUrl));
            }

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadAppIconRequestBody {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  iconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadAppIconRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadAppIconRequestBody input)
        {
            if (input == null) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.IconUrl != input.IconUrl || (this.IconUrl != null && !this.IconUrl.Equals(input.IconUrl))) return false;

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
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.IconUrl != null) hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
