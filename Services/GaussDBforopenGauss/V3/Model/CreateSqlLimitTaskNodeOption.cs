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
    public class CreateSqlLimitTaskNodeOption 
    {

        /// <summary>
        /// **参数解释**: 节点ID。 **约束限制**: 必须是当前实例的某一个节点ID。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**: 该节点执行的SQL语句ID。 **约束限制**: 每个节点最多可以下发的SQL ID数量不可以超过10。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("sql_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SqlIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSqlLimitTaskNodeOption {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  sqlIds: ").Append(SqlIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSqlLimitTaskNodeOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSqlLimitTaskNodeOption input)
        {
            if (input == null) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.SqlIds != input.SqlIds || (this.SqlIds != null && input.SqlIds != null && !this.SqlIds.SequenceEqual(input.SqlIds))) return false;

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
                if (this.SqlIds != null) hashCode = hashCode * 59 + this.SqlIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
