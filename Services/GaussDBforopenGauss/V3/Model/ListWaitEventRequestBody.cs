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
    public class ListWaitEventRequestBody 
    {

        /// <summary>
        /// **参数解释**: 节点ID，仅支持包含有CN或DN（主、备）组件的节点。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**: 是否查询系统用户。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("system", NullValueHandling = NullValueHandling.Ignore)]
        public bool? System { get; set; }

        /// <summary>
        /// **参数解释**: 查询记录数。 **约束限制**: 不能为负数。 **取值范围**: [1，100]。 **默认取值**: 默认为10。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**: 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询。 **约束限制**: 必须为数字，不能为负数。 **取值范围**: 不涉及。 **默认取值**: 默认为0（偏移0条数据，表示从第一条数据开始查询）。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**: 排序字段列表，内部List&lt;String&gt;。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("order_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<string>> OrderFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("wait_event_query_info", NullValueHandling = NullValueHandling.Ignore)]
        public WaitEventQueryInfo WaitEventQueryInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWaitEventRequestBody {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  system: ").Append(System).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  orderFields: ").Append(OrderFields).Append("\n");
            sb.Append("  waitEventQueryInfo: ").Append(WaitEventQueryInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWaitEventRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWaitEventRequestBody input)
        {
            if (input == null) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.System != input.System || (this.System != null && !this.System.Equals(input.System))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.OrderFields != input.OrderFields || (this.OrderFields != null && input.OrderFields != null && !this.OrderFields.SequenceEqual(input.OrderFields))) return false;
            if (this.WaitEventQueryInfo != input.WaitEventQueryInfo || (this.WaitEventQueryInfo != null && !this.WaitEventQueryInfo.Equals(input.WaitEventQueryInfo))) return false;

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
                if (this.System != null) hashCode = hashCode * 59 + this.System.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.OrderFields != null) hashCode = hashCode * 59 + this.OrderFields.GetHashCode();
                if (this.WaitEventQueryInfo != null) hashCode = hashCode * 59 + this.WaitEventQueryInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
