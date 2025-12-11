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
    /// **参数解释**：  SQL限流规则。
    /// </summary>
    public class HistoricalSqlFilterRule 
    {

        /// <summary>
        /// **参数解释**：  实例ID，此参数是实例的唯一标识。  **取值范围**：  只能由英文字母、数字组成，后缀为in07，长度为36个字符。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  节点ID。  **取值范围**：  与入参中的节点ID一致。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**：  SQL限流规则。  **取值范围**：  由一个或多个关键字（最多为128个关键字）组成，关键字之间通过\&quot;~\&quot;分隔符分开，如select~from~t1。规则中不能包含‘\\’、中英文逗号、‘~~’，不能以‘~’结尾。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string Pattern { get; set; }

        /// <summary>
        /// **参数解释**：  SQL限流类型。  **取值范围**：  - SELECT：查询语句。 - UPDATE：更新语句。 - DELETE：删除语句。 - INSERT：插入语句。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("sql_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlType { get; set; }

        /// <summary>
        /// **参数解释**：  最大并发数。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("max_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// **参数解释**：  SQL限流规则创建时间。  **取值范围**：  0 - 9223372036854775807。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// **参数解释**：  SQL限流规则失效时间。  **取值范围**：  0 - 9223372036854775807。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("expire_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireAt { get; set; }

        /// <summary>
        /// **参数解释**：  SQL限流规则删除时间。  **取值范围**：  0 - 9223372036854775807。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("delete_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeleteAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricalSqlFilterRule {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  pattern: ").Append(Pattern).Append("\n");
            sb.Append("  sqlType: ").Append(SqlType).Append("\n");
            sb.Append("  maxConcurrency: ").Append(MaxConcurrency).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  expireAt: ").Append(ExpireAt).Append("\n");
            sb.Append("  deleteAt: ").Append(DeleteAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HistoricalSqlFilterRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HistoricalSqlFilterRule input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.Pattern != input.Pattern || (this.Pattern != null && !this.Pattern.Equals(input.Pattern))) return false;
            if (this.SqlType != input.SqlType || (this.SqlType != null && !this.SqlType.Equals(input.SqlType))) return false;
            if (this.MaxConcurrency != input.MaxConcurrency || (this.MaxConcurrency != null && !this.MaxConcurrency.Equals(input.MaxConcurrency))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.ExpireAt != input.ExpireAt || (this.ExpireAt != null && !this.ExpireAt.Equals(input.ExpireAt))) return false;
            if (this.DeleteAt != input.DeleteAt || (this.DeleteAt != null && !this.DeleteAt.Equals(input.DeleteAt))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Pattern != null) hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.SqlType != null) hashCode = hashCode * 59 + this.SqlType.GetHashCode();
                if (this.MaxConcurrency != null) hashCode = hashCode * 59 + this.MaxConcurrency.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.ExpireAt != null) hashCode = hashCode * 59 + this.ExpireAt.GetHashCode();
                if (this.DeleteAt != null) hashCode = hashCode * 59 + this.DeleteAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
