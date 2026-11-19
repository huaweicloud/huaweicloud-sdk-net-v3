using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListRealTimeSessionsRequestBody 
    {

        /// <summary>
        /// **参数解释**： 节点ID。 **约束限制**： 仅支持非日志类型的CN或DN节点。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**： 组件ID。 **约束限制**： 仅支持非日志类型的CN或DN节点。 **取值范围**： 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// **参数解释**： 是否展示本地会话。 **约束限制**： 不涉及。 **取值范围**： - true：展示本地会话 - false：不展示本地会话  **默认取值**: false。
        /// </summary>
        [JsonProperty("support_local", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportLocal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("query_info", NullValueHandling = NullValueHandling.Ignore)]
        public SessionQueryInfoOption QueryInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRealTimeSessionsRequestBody {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  supportLocal: ").Append(SupportLocal).Append("\n");
            sb.Append("  queryInfo: ").Append(QueryInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRealTimeSessionsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRealTimeSessionsRequestBody input)
        {
            if (input == null) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;
            if (this.SupportLocal != input.SupportLocal || (this.SupportLocal != null && !this.SupportLocal.Equals(input.SupportLocal))) return false;
            if (this.QueryInfo != input.QueryInfo || (this.QueryInfo != null && !this.QueryInfo.Equals(input.QueryInfo))) return false;

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
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.SupportLocal != null) hashCode = hashCode * 59 + this.SupportLocal.GetHashCode();
                if (this.QueryInfo != null) hashCode = hashCode * 59 + this.QueryInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
