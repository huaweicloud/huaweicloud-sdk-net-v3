using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 设置内核故障的处理策略请求体。
    /// </summary>
    public class RdsDBFaultPolicyReq 
    {

        /// <summary>
        /// **参数解释**：  内核故障的处理策略。  **约束限制**：  不涉及。  **取值范围**：  - repairFirst：优先修复 - failoverFirst：优先切换  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("db_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string DbPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RdsDBFaultPolicyReq {\n");
            sb.Append("  dbPolicy: ").Append(DbPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RdsDBFaultPolicyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RdsDBFaultPolicyReq input)
        {
            if (input == null) return false;
            if (this.DbPolicy != input.DbPolicy || (this.DbPolicy != null && !this.DbPolicy.Equals(input.DbPolicy))) return false;

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
                if (this.DbPolicy != null) hashCode = hashCode * 59 + this.DbPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
