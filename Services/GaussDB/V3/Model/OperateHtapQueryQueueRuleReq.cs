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
    /// **参数解释**：  设置查询当前查询队列阈值请求体。  **约束限制**：  不涉及。
    /// </summary>
    public class OperateHtapQueryQueueRuleReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("query_queue_rule", NullValueHandling = NullValueHandling.Ignore)]
        public HtapQueryQueueRule QueryQueueRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperateHtapQueryQueueRuleReq {\n");
            sb.Append("  queryQueueRule: ").Append(QueryQueueRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateHtapQueryQueueRuleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateHtapQueryQueueRuleReq input)
        {
            if (input == null) return false;
            if (this.QueryQueueRule != input.QueryQueueRule || (this.QueryQueueRule != null && !this.QueryQueueRule.Equals(input.QueryQueueRule))) return false;

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
                if (this.QueryQueueRule != null) hashCode = hashCode * 59 + this.QueryQueueRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
