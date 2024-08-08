using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDM.V5.Model
{
    /// <summary>
    /// 企业版实例的SNAT配置，配置开启后，企业版实例可以在公共网络中进行外部通信。 约束：只有企业版实例支持修改流转配置。 
    /// </summary>
    public class UpdateForwardingInfo 
    {

        /// <summary>
        /// **参数说明**：是否启用SNAT配置。企业版实例开启SNAT配置后，可以在公共网络中进行外部通信。 约束：只有企业版实例支持配置SNAT配置，SNAT配置开启后将不支持关闭 **取值范围**： - true: 启用SNAT配置 
        /// </summary>
        [JsonProperty("enable_snat", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSnat { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateForwardingInfo {\n");
            sb.Append("  enableSnat: ").Append(EnableSnat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateForwardingInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateForwardingInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableSnat == input.EnableSnat ||
                    (this.EnableSnat != null &&
                    this.EnableSnat.Equals(input.EnableSnat))
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
                if (this.EnableSnat != null)
                    hashCode = hashCode * 59 + this.EnableSnat.GetHashCode();
                return hashCode;
            }
        }
    }
}
