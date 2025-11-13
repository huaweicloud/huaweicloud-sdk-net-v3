using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 审核附件上传地址
    /// </summary>
    public class AttachmentUploadingAddress 
    {

        /// <summary>
        /// 序号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public int? Number { get; set; }

        /// <summary>
        /// 上传url
        /// </summary>
        [JsonProperty("uploading_url", NullValueHandling = NullValueHandling.Ignore)]
        public string UploadingUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentUploadingAddress {\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  uploadingUrl: ").Append(UploadingUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachmentUploadingAddress);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachmentUploadingAddress input)
        {
            if (input == null) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.UploadingUrl != input.UploadingUrl || (this.UploadingUrl != null && !this.UploadingUrl.Equals(input.UploadingUrl))) return false;

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
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.UploadingUrl != null) hashCode = hashCode * 59 + this.UploadingUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
