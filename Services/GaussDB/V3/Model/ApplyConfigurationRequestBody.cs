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
    public class ApplyConfigurationRequestBody 
    {

        /// <summary>
        /// 实例ID列表。列表长度限制在10以内。
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// **参数解释**：  是否更新实例参数组版本，更新后实例规格变更时默认的规格参数值会以最新版本的为准。  **约束限制**：  不涉及。  **取值范围**：  - true：是。 - false：否。  **默认取值**：    false。
        /// </summary>
        [JsonProperty("is_update_param_group_version", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUpdateParamGroupVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyConfigurationRequestBody {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  isUpdateParamGroupVersion: ").Append(IsUpdateParamGroupVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyConfigurationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyConfigurationRequestBody input)
        {
            if (input == null) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.IsUpdateParamGroupVersion != input.IsUpdateParamGroupVersion || (this.IsUpdateParamGroupVersion != null && !this.IsUpdateParamGroupVersion.Equals(input.IsUpdateParamGroupVersion))) return false;

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
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.IsUpdateParamGroupVersion != null) hashCode = hashCode * 59 + this.IsUpdateParamGroupVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
