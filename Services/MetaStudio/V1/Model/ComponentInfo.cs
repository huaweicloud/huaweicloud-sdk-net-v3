using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 组件信息。
    /// </summary>
    public class ComponentInfo 
    {

        /// <summary>
        /// **参数解释**： 组件名称。 **约束限制**： 不涉及。 **取值范围**： 字符长度1-256位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("component_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentName { get; set; }

        /// <summary>
        /// **参数解释**： 组件类型。 **约束限制**： 不涉及。 **取值范围**： 字符长度1-256位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("component_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentType { get; set; }

        /// <summary>
        /// **参数解释**： 组件描述。 **约束限制**： 不涉及。 **取值范围**： 字符长度0-512位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("component_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComponentInfo {\n");
            sb.Append("  componentName: ").Append(ComponentName).Append("\n");
            sb.Append("  componentType: ").Append(ComponentType).Append("\n");
            sb.Append("  componentDesc: ").Append(ComponentDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ComponentInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ComponentInfo input)
        {
            if (input == null) return false;
            if (this.ComponentName != input.ComponentName || (this.ComponentName != null && !this.ComponentName.Equals(input.ComponentName))) return false;
            if (this.ComponentType != input.ComponentType || (this.ComponentType != null && !this.ComponentType.Equals(input.ComponentType))) return false;
            if (this.ComponentDesc != input.ComponentDesc || (this.ComponentDesc != null && !this.ComponentDesc.Equals(input.ComponentDesc))) return false;

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
                if (this.ComponentName != null) hashCode = hashCode * 59 + this.ComponentName.GetHashCode();
                if (this.ComponentType != null) hashCode = hashCode * 59 + this.ComponentType.GetHashCode();
                if (this.ComponentDesc != null) hashCode = hashCode * 59 + this.ComponentDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
