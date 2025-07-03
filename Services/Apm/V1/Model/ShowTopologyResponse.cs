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
    public class ShowTopologyResponse : SdkResponse
    {

        /// <summary>
        /// 全局traceId。
        /// </summary>
        [JsonProperty("global_trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalTraceId { get; set; }

        /// <summary>
        /// 组件之间调用指向线列表。
        /// </summary>
        [JsonProperty("line_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TraceTopologyLine> LineList { get; set; }

        /// <summary>
        /// 组件节点列表。
        /// </summary>
        [JsonProperty("node_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TraceTopologyNode> NodeList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTopologyResponse {\n");
            sb.Append("  globalTraceId: ").Append(GlobalTraceId).Append("\n");
            sb.Append("  lineList: ").Append(LineList).Append("\n");
            sb.Append("  nodeList: ").Append(NodeList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTopologyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTopologyResponse input)
        {
            if (input == null) return false;
            if (this.GlobalTraceId != input.GlobalTraceId || (this.GlobalTraceId != null && !this.GlobalTraceId.Equals(input.GlobalTraceId))) return false;
            if (this.LineList != input.LineList || (this.LineList != null && input.LineList != null && !this.LineList.SequenceEqual(input.LineList))) return false;
            if (this.NodeList != input.NodeList || (this.NodeList != null && input.NodeList != null && !this.NodeList.SequenceEqual(input.NodeList))) return false;

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
                if (this.GlobalTraceId != null) hashCode = hashCode * 59 + this.GlobalTraceId.GetHashCode();
                if (this.LineList != null) hashCode = hashCode * 59 + this.LineList.GetHashCode();
                if (this.NodeList != null) hashCode = hashCode * 59 + this.NodeList.GetHashCode();
                return hashCode;
            }
        }
    }
}
