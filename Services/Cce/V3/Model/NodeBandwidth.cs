using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeBandwidth 
    {

        /// <summary>
        /// 带宽的计费类型：  - 未传该字段，表示按带宽计费。 - 字段值为空，表示按带宽计费。  - 字段值为“traffic”，表示按流量计费。  - 字段为其它值，会导致创建云服务器失败。  &gt; - 按带宽计费：按公网传输速率（单位为Mbps）计费。当您的带宽利用率高于10%时，建议优先选择按带宽计费。 &gt; - 按流量计费：只允许在创建按需节点时指定，按公网传输的数据总量（单位为GB）计费。当您的带宽利用率低于10%时，建议优先选择按流量计费。 
        /// </summary>
        [JsonProperty("chargemode", NullValueHandling = NullValueHandling.Ignore)]
        public string Chargemode { get; set; }

        /// <summary>
        /// 带宽大小，取值请参见取值请参见申请EIP接口中bandwidth.size说明。 [链接请参见[申请EIP](https://support.huaweicloud.com/api-eip/eip_api_0001.html)](tag:hws) [链接请参见[申请EIP](https://support.huaweicloud.com/intl/zh-cn/api-eip/eip_api_0001.html)](tag:hws_hk) 
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 带宽的共享类型，共享类型枚举：PER，表示独享。WHOLE，表示共享。
        /// </summary>
        [JsonProperty("sharetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Sharetype { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeBandwidth {\n");
            sb.Append("  chargemode: ").Append(Chargemode).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  sharetype: ").Append(Sharetype).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeBandwidth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeBandwidth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Chargemode == input.Chargemode ||
                    (this.Chargemode != null &&
                    this.Chargemode.Equals(input.Chargemode))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Sharetype == input.Sharetype ||
                    (this.Sharetype != null &&
                    this.Sharetype.Equals(input.Sharetype))
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
                if (this.Chargemode != null)
                    hashCode = hashCode * 59 + this.Chargemode.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Sharetype != null)
                    hashCode = hashCode * 59 + this.Sharetype.GetHashCode();
                return hashCode;
            }
        }
    }
}
