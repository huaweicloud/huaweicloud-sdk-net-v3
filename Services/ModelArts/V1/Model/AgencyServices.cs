using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgencyServices 
    {

        /// <summary>
        /// **参数解释**：服务ID。服务ID，标识目标云服务（如 \&quot;19\&quot; 代表 EVS） **约束限制**：不涉及。 **取值范围**：长度限制为64个字符。 **默认取值**：空。
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// **参数解释**：该服务下的细粒度权限操作列表，格式为 服务:资源:操作，如 \&quot;evs:volumes:delete\&quot; **约束限制**：不涉及。 **取值范围**：长度限制为256个字符。 **默认取值**：空。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Actions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgencyServices {\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgencyServices);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgencyServices input)
        {
            if (input == null) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;

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
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                return hashCode;
            }
        }
    }
}
