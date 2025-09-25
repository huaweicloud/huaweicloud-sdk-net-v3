using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBlobsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 文件字节大小。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// **参数解释：** 文件编码方式。 **约束限制：** - base64。
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string Encoding { get; set; }

        /// <summary>
        /// **参数解释：** 经过base64编码后的文件内容。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// **参数解释：** bolb文件ID。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("blob_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BlobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Total", IsHeader = true)]
        [JsonProperty("X-Total", NullValueHandling = NullValueHandling.Ignore)]
        public string XTotal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBlobsResponse {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  encoding: ").Append(Encoding).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  blobId: ").Append(BlobId).Append("\n");
            sb.Append("  xTotal: ").Append(XTotal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBlobsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBlobsResponse input)
        {
            if (input == null) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Encoding != input.Encoding || (this.Encoding != null && !this.Encoding.Equals(input.Encoding))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.BlobId != input.BlobId || (this.BlobId != null && !this.BlobId.Equals(input.BlobId))) return false;
            if (this.XTotal != input.XTotal || (this.XTotal != null && !this.XTotal.Equals(input.XTotal))) return false;

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
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Encoding != null) hashCode = hashCode * 59 + this.Encoding.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.BlobId != null) hashCode = hashCode * 59 + this.BlobId.GetHashCode();
                if (this.XTotal != null) hashCode = hashCode * 59 + this.XTotal.GetHashCode();
                return hashCode;
            }
        }
    }
}
