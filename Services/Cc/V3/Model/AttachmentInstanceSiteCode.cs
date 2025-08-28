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
    /// 中心网络附件对端实例的站点编码。
    /// </summary>
    public class AttachmentInstanceSiteCode 
    {

        /// <summary>
        /// 中心网络附件对端实例的站点编码。
        /// </summary>
        [JsonProperty("attachment_instance_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string _AttachmentInstanceSiteCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentInstanceSiteCode {\n");
            sb.Append("  _attachmentInstanceSiteCode: ").Append(_AttachmentInstanceSiteCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachmentInstanceSiteCode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachmentInstanceSiteCode input)
        {
            if (input == null) return false;
            if (this._AttachmentInstanceSiteCode != input._AttachmentInstanceSiteCode || (this._AttachmentInstanceSiteCode != null && !this._AttachmentInstanceSiteCode.Equals(input._AttachmentInstanceSiteCode))) return false;

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
                if (this._AttachmentInstanceSiteCode != null) hashCode = hashCode * 59 + this._AttachmentInstanceSiteCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
