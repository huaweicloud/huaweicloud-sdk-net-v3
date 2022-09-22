using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UploadAttachmentsRequestBody 
    {

        /// <summary>
        /// 附件文件， 最大上传大小为50M
        /// </summary>
        [JsonProperty("attachment", NullValueHandling = NullValueHandling.Ignore)]
        public System.IO.Stream Attachment { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadAttachmentsRequestBody {\n");
            sb.Append("  attachment: ").Append(Attachment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadAttachmentsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadAttachmentsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attachment == input.Attachment ||
                    (this.Attachment != null &&
                    this.Attachment.Equals(input.Attachment))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Attachment != null)
                    hashCode = hashCode * 59 + this.Attachment.GetHashCode();
                return hashCode;
            }
        }
    }
}
