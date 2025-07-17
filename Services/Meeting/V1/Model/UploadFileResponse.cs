using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UploadFileResponse : SdkResponse
    {

        /// <summary>
        /// 文件Id。
        /// </summary>
        [JsonProperty("fileId", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("imageModeration", NullValueHandling = NullValueHandling.Ignore)]
        public ImageModerationResult ImageModeration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadFileResponse {\n");
            sb.Append("  fileId: ").Append(FileId).Append("\n");
            sb.Append("  imageModeration: ").Append(ImageModeration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadFileResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadFileResponse input)
        {
            if (input == null) return false;
            if (this.FileId != input.FileId || (this.FileId != null && !this.FileId.Equals(input.FileId))) return false;
            if (this.ImageModeration != input.ImageModeration || (this.ImageModeration != null && !this.ImageModeration.Equals(input.ImageModeration))) return false;

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
                if (this.FileId != null) hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.ImageModeration != null) hashCode = hashCode * 59 + this.ImageModeration.GetHashCode();
                return hashCode;
            }
        }
    }
}
