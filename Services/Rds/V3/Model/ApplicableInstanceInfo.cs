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
    /// **参数解释**：  可应用参数模板的实例详情  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
    /// </summary>
    public class ApplicableInstanceInfo 
    {

        /// <summary>
        /// **参数解释**：  实例id  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("entity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityId { get; set; }

        /// <summary>
        /// **参数解释**：  实例名称  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("entity_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicableInstanceInfo {\n");
            sb.Append("  entityId: ").Append(EntityId).Append("\n");
            sb.Append("  entityName: ").Append(EntityName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicableInstanceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplicableInstanceInfo input)
        {
            if (input == null) return false;
            if (this.EntityId != input.EntityId || (this.EntityId != null && !this.EntityId.Equals(input.EntityId))) return false;
            if (this.EntityName != input.EntityName || (this.EntityName != null && !this.EntityName.Equals(input.EntityName))) return false;

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
                if (this.EntityId != null) hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.EntityName != null) hashCode = hashCode * 59 + this.EntityName.GetHashCode();
                return hashCode;
            }
        }
    }
}
