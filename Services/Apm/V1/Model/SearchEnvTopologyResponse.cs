using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SearchEnvTopologyResponse : SdkResponse
    {

        /// <summary>
        /// 组件节点列表。
        /// </summary>
        [JsonProperty("node_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopoNode> NodeList { get; set; }

        /// <summary>
        /// 组件之间调用指向线列表。
        /// </summary>
        [JsonProperty("line_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopoLine> LineList { get; set; }

        /// <summary>
        /// 采集器配置。
        /// </summary>
        [JsonProperty("collector_config", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, CollectorConfigModel> CollectorConfig { get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("real_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RealStartTime { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("real_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RealEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchEnvTopologyResponse {\n");
            sb.Append("  nodeList: ").Append(NodeList).Append("\n");
            sb.Append("  lineList: ").Append(LineList).Append("\n");
            sb.Append("  collectorConfig: ").Append(CollectorConfig).Append("\n");
            sb.Append("  realStartTime: ").Append(RealStartTime).Append("\n");
            sb.Append("  realEndTime: ").Append(RealEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchEnvTopologyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchEnvTopologyResponse input)
        {
            if (input == null) return false;
            if (this.NodeList != input.NodeList || (this.NodeList != null && input.NodeList != null && !this.NodeList.SequenceEqual(input.NodeList))) return false;
            if (this.LineList != input.LineList || (this.LineList != null && input.LineList != null && !this.LineList.SequenceEqual(input.LineList))) return false;
            if (this.CollectorConfig != input.CollectorConfig || (this.CollectorConfig != null && input.CollectorConfig != null && !this.CollectorConfig.SequenceEqual(input.CollectorConfig))) return false;
            if (this.RealStartTime != input.RealStartTime || (this.RealStartTime != null && !this.RealStartTime.Equals(input.RealStartTime))) return false;
            if (this.RealEndTime != input.RealEndTime || (this.RealEndTime != null && !this.RealEndTime.Equals(input.RealEndTime))) return false;

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
                if (this.NodeList != null) hashCode = hashCode * 59 + this.NodeList.GetHashCode();
                if (this.LineList != null) hashCode = hashCode * 59 + this.LineList.GetHashCode();
                if (this.CollectorConfig != null) hashCode = hashCode * 59 + this.CollectorConfig.GetHashCode();
                if (this.RealStartTime != null) hashCode = hashCode * 59 + this.RealStartTime.GetHashCode();
                if (this.RealEndTime != null) hashCode = hashCode * 59 + this.RealEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
