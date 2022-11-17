using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrePaidServerEip 
    {

        /// <summary>
        /// 弹性IP地址类型。  详情请参见“[申请弹性公网IP](https://support.huaweicloud.com/api-eip/eip_api_0001.html)”章节的“publicip”字段说明。
        /// </summary>
        [JsonProperty("iptype", NullValueHandling = NullValueHandling.Ignore)]
        public string Iptype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public PrePaidServerEipBandwidth Bandwidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendparam", NullValueHandling = NullValueHandling.Ignore)]
        public PrePaidServerEipExtendParam Extendparam { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrePaidServerEip {\n");
            sb.Append("  iptype: ").Append(Iptype).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  extendparam: ").Append(Extendparam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrePaidServerEip);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrePaidServerEip input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Iptype == input.Iptype ||
                    (this.Iptype != null &&
                    this.Iptype.Equals(input.Iptype))
                ) && 
                (
                    this.Bandwidth == input.Bandwidth ||
                    (this.Bandwidth != null &&
                    this.Bandwidth.Equals(input.Bandwidth))
                ) && 
                (
                    this.Extendparam == input.Extendparam ||
                    (this.Extendparam != null &&
                    this.Extendparam.Equals(input.Extendparam))
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
                if (this.Iptype != null)
                    hashCode = hashCode * 59 + this.Iptype.GetHashCode();
                if (this.Bandwidth != null)
                    hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.Extendparam != null)
                    hashCode = hashCode * 59 + this.Extendparam.GetHashCode();
                return hashCode;
            }
        }
    }
}
