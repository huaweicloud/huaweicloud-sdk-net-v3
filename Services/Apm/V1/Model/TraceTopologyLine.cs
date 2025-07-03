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
    /// 拓扑图上的组件调用指向线。
    /// </summary>
    public class TraceTopologyLine 
    {

        /// <summary>
        /// 开始节点id。
        /// </summary>
        [JsonProperty("start_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartNodeId { get; set; }

        /// <summary>
        /// 结束节点id。
        /// </summary>
        [JsonProperty("end_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndNodeId { get; set; }

        /// <summary>
        /// 调用跨度id。
        /// </summary>
        [JsonProperty("span_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("client_info", NullValueHandling = NullValueHandling.Ignore)]
        public TraceTopologyLineInfo ClientInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("server_info", NullValueHandling = NullValueHandling.Ignore)]
        public TraceTopologyLineInfo ServerInfo { get; set; }

        /// <summary>
        /// id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 获取一条线的提示信息。
        /// </summary>
        [JsonProperty("hint", NullValueHandling = NullValueHandling.Ignore)]
        public string Hint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TraceTopologyLine {\n");
            sb.Append("  startNodeId: ").Append(StartNodeId).Append("\n");
            sb.Append("  endNodeId: ").Append(EndNodeId).Append("\n");
            sb.Append("  spanId: ").Append(SpanId).Append("\n");
            sb.Append("  clientInfo: ").Append(ClientInfo).Append("\n");
            sb.Append("  serverInfo: ").Append(ServerInfo).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  hint: ").Append(Hint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TraceTopologyLine);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TraceTopologyLine input)
        {
            if (input == null) return false;
            if (this.StartNodeId != input.StartNodeId || (this.StartNodeId != null && !this.StartNodeId.Equals(input.StartNodeId))) return false;
            if (this.EndNodeId != input.EndNodeId || (this.EndNodeId != null && !this.EndNodeId.Equals(input.EndNodeId))) return false;
            if (this.SpanId != input.SpanId || (this.SpanId != null && !this.SpanId.Equals(input.SpanId))) return false;
            if (this.ClientInfo != input.ClientInfo || (this.ClientInfo != null && !this.ClientInfo.Equals(input.ClientInfo))) return false;
            if (this.ServerInfo != input.ServerInfo || (this.ServerInfo != null && !this.ServerInfo.Equals(input.ServerInfo))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Hint != input.Hint || (this.Hint != null && !this.Hint.Equals(input.Hint))) return false;

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
                if (this.StartNodeId != null) hashCode = hashCode * 59 + this.StartNodeId.GetHashCode();
                if (this.EndNodeId != null) hashCode = hashCode * 59 + this.EndNodeId.GetHashCode();
                if (this.SpanId != null) hashCode = hashCode * 59 + this.SpanId.GetHashCode();
                if (this.ClientInfo != null) hashCode = hashCode * 59 + this.ClientInfo.GetHashCode();
                if (this.ServerInfo != null) hashCode = hashCode * 59 + this.ServerInfo.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Hint != null) hashCode = hashCode * 59 + this.Hint.GetHashCode();
                return hashCode;
            }
        }
    }
}
