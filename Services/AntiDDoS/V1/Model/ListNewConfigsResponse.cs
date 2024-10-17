using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListNewConfigsResponse : SdkResponse
    {

        /// <summary>
        /// 流量限制列表
        /// </summary>
        [JsonProperty("traffic_limited_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TriggerBpsDict> TrafficLimitedList { get; set; }

        /// <summary>
        /// HTTP限制列表
        /// </summary>
        [JsonProperty("http_limited_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TriggerQpsDict> HttpLimitedList { get; set; }

        /// <summary>
        /// 连接数限制列表
        /// </summary>
        [JsonProperty("connection_limited_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CleanLimitDict> ConnectionLimitedList { get; set; }

        /// <summary>
        /// 扩展配置列表
        /// </summary>
        [JsonProperty("extend_ddos_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtendDDoSSet> ExtendDdosConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNewConfigsResponse {\n");
            sb.Append("  trafficLimitedList: ").Append(TrafficLimitedList).Append("\n");
            sb.Append("  httpLimitedList: ").Append(HttpLimitedList).Append("\n");
            sb.Append("  connectionLimitedList: ").Append(ConnectionLimitedList).Append("\n");
            sb.Append("  extendDdosConfig: ").Append(ExtendDdosConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNewConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNewConfigsResponse input)
        {
            if (input == null) return false;
            if (this.TrafficLimitedList != input.TrafficLimitedList || (this.TrafficLimitedList != null && input.TrafficLimitedList != null && !this.TrafficLimitedList.SequenceEqual(input.TrafficLimitedList))) return false;
            if (this.HttpLimitedList != input.HttpLimitedList || (this.HttpLimitedList != null && input.HttpLimitedList != null && !this.HttpLimitedList.SequenceEqual(input.HttpLimitedList))) return false;
            if (this.ConnectionLimitedList != input.ConnectionLimitedList || (this.ConnectionLimitedList != null && input.ConnectionLimitedList != null && !this.ConnectionLimitedList.SequenceEqual(input.ConnectionLimitedList))) return false;
            if (this.ExtendDdosConfig != input.ExtendDdosConfig || (this.ExtendDdosConfig != null && input.ExtendDdosConfig != null && !this.ExtendDdosConfig.SequenceEqual(input.ExtendDdosConfig))) return false;

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
                if (this.TrafficLimitedList != null) hashCode = hashCode * 59 + this.TrafficLimitedList.GetHashCode();
                if (this.HttpLimitedList != null) hashCode = hashCode * 59 + this.HttpLimitedList.GetHashCode();
                if (this.ConnectionLimitedList != null) hashCode = hashCode * 59 + this.ConnectionLimitedList.GetHashCode();
                if (this.ExtendDdosConfig != null) hashCode = hashCode * 59 + this.ExtendDdosConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
