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
    /// **参数解释**：  开启/关闭查询队列参数体。  **约束限制**：  不涉及。
    /// </summary>
    public class OperateHtapQueryQueueControlReq 
    {

        /// <summary>
        /// **参数解释**：  查询队列的开关状态。  **约束限制**：  不涉及。  **取值范围**：  - true：表示开启。 - false：表示关闭。  **默认值**：  false。
        /// </summary>
        [JsonProperty("enable_query_queue_select", NullValueHandling = NullValueHandling.Ignore)]
        public string EnableQueryQueueSelect { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperateHtapQueryQueueControlReq {\n");
            sb.Append("  enableQueryQueueSelect: ").Append(EnableQueryQueueSelect).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateHtapQueryQueueControlReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateHtapQueryQueueControlReq input)
        {
            if (input == null) return false;
            if (this.EnableQueryQueueSelect != input.EnableQueryQueueSelect || (this.EnableQueryQueueSelect != null && !this.EnableQueryQueueSelect.Equals(input.EnableQueryQueueSelect))) return false;

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
                if (this.EnableQueryQueueSelect != null) hashCode = hashCode * 59 + this.EnableQueryQueueSelect.GetHashCode();
                return hashCode;
            }
        }
    }
}
