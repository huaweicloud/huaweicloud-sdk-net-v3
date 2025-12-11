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
    public class ShowSqlAutoSqlLimitingResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  实例ID，此参数是实例的唯一标识。  **取值范围**：  只能由英文字母、数字组成，后缀为in07，长度为36个字符。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**  节点的自治限流规则。
        /// </summary>
        [JsonProperty("auto_sql_limiting_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeSqlAutoSqlLimiting> AutoSqlLimitingRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSqlAutoSqlLimitingResponse {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  autoSqlLimitingRules: ").Append(AutoSqlLimitingRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSqlAutoSqlLimitingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSqlAutoSqlLimitingResponse input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.AutoSqlLimitingRules != input.AutoSqlLimitingRules || (this.AutoSqlLimitingRules != null && input.AutoSqlLimitingRules != null && !this.AutoSqlLimitingRules.SequenceEqual(input.AutoSqlLimitingRules))) return false;

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
                if (this.AutoSqlLimitingRules != null) hashCode = hashCode * 59 + this.AutoSqlLimitingRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
