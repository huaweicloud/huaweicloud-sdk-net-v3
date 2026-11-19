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
    /// 
    /// </summary>
    public class SwitchColdTableStorageReq 
    {

        /// <summary>
        /// **参数解释**：  操作类型。  **约束限制**：  不涉及。  **取值范围**：  - archive：创建冷表。 - unarchive：回迁冷表。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// **参数解释**：  需要操作的表信息。  **约束限制**：  数组长度小于等于50。
        /// </summary>
        [JsonProperty("tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<TableTarget> Tables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchColdTableStorageReq {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  tables: ").Append(Tables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchColdTableStorageReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchColdTableStorageReq input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Tables != input.Tables || (this.Tables != null && input.Tables != null && !this.Tables.SequenceEqual(input.Tables))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Tables != null) hashCode = hashCode * 59 + this.Tables.GetHashCode();
                return hashCode;
            }
        }
    }
}
