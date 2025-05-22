using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MigrateAZRequestBody 
    {

        /// <summary>
        /// **参数解释**： 新可用区。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("new_available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NewAvailableZones { get; set; }

        /// <summary>
        /// **参数解释**： 是否立即执行变更。 **约束限制**： 不涉及。 **取值范围**： true：立即执行变更。 false：暂不执行变更。 **默认取值**： true 
        /// </summary>
        [JsonProperty("execute_immediately", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExecuteImmediately { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateAZRequestBody {\n");
            sb.Append("  newAvailableZones: ").Append(NewAvailableZones).Append("\n");
            sb.Append("  executeImmediately: ").Append(ExecuteImmediately).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateAZRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateAZRequestBody input)
        {
            if (input == null) return false;
            if (this.NewAvailableZones != input.NewAvailableZones || (this.NewAvailableZones != null && input.NewAvailableZones != null && !this.NewAvailableZones.SequenceEqual(input.NewAvailableZones))) return false;
            if (this.ExecuteImmediately != input.ExecuteImmediately || (this.ExecuteImmediately != null && !this.ExecuteImmediately.Equals(input.ExecuteImmediately))) return false;

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
                if (this.NewAvailableZones != null) hashCode = hashCode * 59 + this.NewAvailableZones.GetHashCode();
                if (this.ExecuteImmediately != null) hashCode = hashCode * 59 + this.ExecuteImmediately.GetHashCode();
                return hashCode;
            }
        }
    }
}
