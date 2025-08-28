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
    /// 更新中心网络连接信息。 * 带宽类型：按照带宽包分配、按照流量计费（当前版本暂不支持，预留后续支持按流量计费模式）、测试带宽类型 * 带宽包ID：按照带宽包分配必填，其他类型不填； * 带宽取值：按照带宽包分配和按照流量计费必填，代表限速带宽，按照带宽包分配下不能超过带宽包大小，测试带宽类型不填；
    /// </summary>
    public class UpdateCentralNetworkConnection 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth_type", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthTypeEnum BandwidthType { get; set; }
        /// <summary>
        /// 全域互联带宽ID。
        /// </summary>
        [JsonProperty("global_connection_bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalConnectionBandwidthId { get; set; }

        /// <summary>
        /// 带宽值，单位Mbps。
        /// </summary>
        [JsonProperty("bandwidth_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? BandwidthSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCentralNetworkConnection {\n");
            sb.Append("  bandwidthType: ").Append(BandwidthType).Append("\n");
            sb.Append("  globalConnectionBandwidthId: ").Append(GlobalConnectionBandwidthId).Append("\n");
            sb.Append("  bandwidthSize: ").Append(BandwidthSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCentralNetworkConnection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCentralNetworkConnection input)
        {
            if (input == null) return false;
            if (this.BandwidthType != input.BandwidthType) return false;
            if (this.GlobalConnectionBandwidthId != input.GlobalConnectionBandwidthId || (this.GlobalConnectionBandwidthId != null && !this.GlobalConnectionBandwidthId.Equals(input.GlobalConnectionBandwidthId))) return false;
            if (this.BandwidthSize != input.BandwidthSize || (this.BandwidthSize != null && !this.BandwidthSize.Equals(input.BandwidthSize))) return false;

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
                hashCode = hashCode * 59 + this.BandwidthType.GetHashCode();
                if (this.GlobalConnectionBandwidthId != null) hashCode = hashCode * 59 + this.GlobalConnectionBandwidthId.GetHashCode();
                if (this.BandwidthSize != null) hashCode = hashCode * 59 + this.BandwidthSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
