using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 连接类型。
    /// </summary>
    public class AttachmentInstanceType 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attachment_instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public AttachmentInstanceTypeEnum _AttachmentInstanceType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentInstanceType {\n");
            sb.Append("  _attachmentInstanceType: ").Append(_AttachmentInstanceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachmentInstanceType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachmentInstanceType input)
        {
            if (input == null) return false;
            if (this._AttachmentInstanceType != input._AttachmentInstanceType) return false;

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
                hashCode = hashCode * 59 + this._AttachmentInstanceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
