using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyRecyclePolicyReq 
    {

        /// <summary>
        /// **参数解释**： 保留天数。 **约束限制**： 不涉及。 **取值范围**： 1~7天。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// **参数解释**： 是否使用回收站。  **约束限制**： 不涉及。 **取值范围**： - true：使用回收站。 - false：不使用回收站。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("default_use_recycle", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultUseRecycle { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyRecyclePolicyReq {\n");
            sb.Append("  retentionDays: ").Append(RetentionDays).Append("\n");
            sb.Append("  defaultUseRecycle: ").Append(DefaultUseRecycle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyRecyclePolicyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyRecyclePolicyReq input)
        {
            if (input == null) return false;
            if (this.RetentionDays != input.RetentionDays || (this.RetentionDays != null && !this.RetentionDays.Equals(input.RetentionDays))) return false;
            if (this.DefaultUseRecycle != input.DefaultUseRecycle || (this.DefaultUseRecycle != null && !this.DefaultUseRecycle.Equals(input.DefaultUseRecycle))) return false;

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
                if (this.RetentionDays != null) hashCode = hashCode * 59 + this.RetentionDays.GetHashCode();
                if (this.DefaultUseRecycle != null) hashCode = hashCode * 59 + this.DefaultUseRecycle.GetHashCode();
                return hashCode;
            }
        }
    }
}
