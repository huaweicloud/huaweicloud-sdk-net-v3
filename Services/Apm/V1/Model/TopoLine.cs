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
    /// 组件之间调用指向线。
    /// </summary>
    public class TopoLine 
    {

        /// <summary>
        /// 开始节点。
        /// </summary>
        [JsonProperty("from_node", NullValueHandling = NullValueHandling.Ignore)]
        public string FromNode { get; set; }

        /// <summary>
        /// 结束节点。
        /// </summary>
        [JsonProperty("to_node", NullValueHandling = NullValueHandling.Ignore)]
        public string ToNode { get; set; }

        /// <summary>
        /// 指向。
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// 采集器名称。
        /// </summary>
        [JsonProperty("collector", NullValueHandling = NullValueHandling.Ignore)]
        public string Collector { get; set; }

        /// <summary>
        /// 环境id。
        /// </summary>
        [JsonProperty("target_env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetEnvId { get; set; }

        /// <summary>
        /// 线条上的提示信息。
        /// </summary>
        [JsonProperty("hints", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Hints { get; set; }

        /// <summary>
        /// 过滤值。
        /// </summary>
        [JsonProperty("filter_value", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopoLine {\n");
            sb.Append("  fromNode: ").Append(FromNode).Append("\n");
            sb.Append("  toNode: ").Append(ToNode).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  collector: ").Append(Collector).Append("\n");
            sb.Append("  targetEnvId: ").Append(TargetEnvId).Append("\n");
            sb.Append("  hints: ").Append(Hints).Append("\n");
            sb.Append("  filterValue: ").Append(FilterValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopoLine);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopoLine input)
        {
            if (input == null) return false;
            if (this.FromNode != input.FromNode || (this.FromNode != null && !this.FromNode.Equals(input.FromNode))) return false;
            if (this.ToNode != input.ToNode || (this.ToNode != null && !this.ToNode.Equals(input.ToNode))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.Collector != input.Collector || (this.Collector != null && !this.Collector.Equals(input.Collector))) return false;
            if (this.TargetEnvId != input.TargetEnvId || (this.TargetEnvId != null && !this.TargetEnvId.Equals(input.TargetEnvId))) return false;
            if (this.Hints != input.Hints || (this.Hints != null && input.Hints != null && !this.Hints.SequenceEqual(input.Hints))) return false;
            if (this.FilterValue != input.FilterValue || (this.FilterValue != null && !this.FilterValue.Equals(input.FilterValue))) return false;

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
                if (this.FromNode != null) hashCode = hashCode * 59 + this.FromNode.GetHashCode();
                if (this.ToNode != null) hashCode = hashCode * 59 + this.ToNode.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Collector != null) hashCode = hashCode * 59 + this.Collector.GetHashCode();
                if (this.TargetEnvId != null) hashCode = hashCode * 59 + this.TargetEnvId.GetHashCode();
                if (this.Hints != null) hashCode = hashCode * 59 + this.Hints.GetHashCode();
                if (this.FilterValue != null) hashCode = hashCode * 59 + this.FilterValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
