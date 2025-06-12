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
    public class NodePublicIP 
    {

        /// <summary>
        /// **参数解释**： 已有的弹性IP的ID列表。数量不得大于待创建节点数 &gt; 若已配置ids参数，则无需配置count和eip参数 **约束限制**： 该参数仅给节点使用
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// **参数解释**： 要动态创建的弹性IP个数。 &gt; count参数与eip参数必须同时配置。 **约束限制**： 该参数仅给节点使用
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eip", NullValueHandling = NullValueHandling.Ignore)]
        public NodeEIPSpec Eip { get; set; }

        /// <summary>
        /// **参数解释**： 表示节点所属分区。分区可以选择中心云[或者[边缘小站](https://support.huaweicloud.com/usermanual-cloudpond/ies_02_0401.html)。](tag:hws)[或者[边缘小站](https://support.huaweicloud.com/intl/zh-cn/usermanual-cloudpond/ies_02_0401.html)。](tag:hws_hk) 仅开启了对分布式云支持的Turbo集群支持指定该字段。 弹性IP类型，取值请参见申请EIP接口中publicip.type说明。 [链接请参见[申请EIP](https://support.huaweicloud.com/api-eip/eip_api_0001.html)](tag:hws) [链接请参见[申请EIP](https://support.huaweicloud.com/intl/zh-cn/api-eip/eip_api_0001.html)](tag:hws_hk) **约束限制**： 该参数仅给节点池使用 
        /// </summary>
        [JsonProperty("iptype", NullValueHandling = NullValueHandling.Ignore)]
        public string Iptype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public NodeBandwidth Bandwidth { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePublicIP {\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  eip: ").Append(Eip).Append("\n");
            sb.Append("  iptype: ").Append(Iptype).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePublicIP);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePublicIP input)
        {
            if (input == null) return false;
            if (this.Ids != input.Ids || (this.Ids != null && input.Ids != null && !this.Ids.SequenceEqual(input.Ids))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.Eip != input.Eip || (this.Eip != null && !this.Eip.Equals(input.Eip))) return false;
            if (this.Iptype != input.Iptype || (this.Iptype != null && !this.Iptype.Equals(input.Iptype))) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;

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
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Eip != null) hashCode = hashCode * 59 + this.Eip.GetHashCode();
                if (this.Iptype != null) hashCode = hashCode * 59 + this.Iptype.GetHashCode();
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
