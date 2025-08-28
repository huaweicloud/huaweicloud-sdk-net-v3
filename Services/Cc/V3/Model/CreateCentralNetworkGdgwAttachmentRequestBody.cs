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
    /// 创建中心网络GDGW附件的请求体。
    /// </summary>
    public class CreateCentralNetworkGdgwAttachmentRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("central_network_gdgw_attachment", NullValueHandling = NullValueHandling.Ignore)]
        public CreateCentralNetworkGdgwAttachment CentralNetworkGdgwAttachment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCentralNetworkGdgwAttachmentRequestBody {\n");
            sb.Append("  centralNetworkGdgwAttachment: ").Append(CentralNetworkGdgwAttachment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCentralNetworkGdgwAttachmentRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCentralNetworkGdgwAttachmentRequestBody input)
        {
            if (input == null) return false;
            if (this.CentralNetworkGdgwAttachment != input.CentralNetworkGdgwAttachment || (this.CentralNetworkGdgwAttachment != null && !this.CentralNetworkGdgwAttachment.Equals(input.CentralNetworkGdgwAttachment))) return false;

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
                if (this.CentralNetworkGdgwAttachment != null) hashCode = hashCode * 59 + this.CentralNetworkGdgwAttachment.GetHashCode();
                return hashCode;
            }
        }
    }
}
