using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSqlFilterRuleResponse : SdkResponse
    {

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// SQL限流规则
        /// </summary>
        [JsonProperty("sql_filter_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<SqlFilterRule> SqlFilterRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSqlFilterRuleResponse {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  sqlFilterRules: ").Append(SqlFilterRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSqlFilterRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSqlFilterRuleResponse input)
        {
            if (input == null) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.SqlFilterRules != input.SqlFilterRules || (this.SqlFilterRules != null && input.SqlFilterRules != null && !this.SqlFilterRules.SequenceEqual(input.SqlFilterRules))) return false;

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
                if (this.SqlFilterRules != null) hashCode = hashCode * 59 + this.SqlFilterRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
