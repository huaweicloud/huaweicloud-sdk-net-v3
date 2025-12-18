using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigurationHistoryRsp 
    {

        /// <summary>
        /// **参数解释：** 参数名称。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("parameter_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParameterName { get; set; }

        /// <summary>
        /// **参数解释：** 参数旧值。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("old_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OldValue { get; set; }

        /// <summary>
        /// **参数解释：** 参数新值。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("new_value", NullValueHandling = NullValueHandling.Ignore)]
        public string NewValue { get; set; }

        /// <summary>
        /// **参数解释：** 更新结果。 **约束限制：** 不涉及。 **取值范围：** - SUCCESS：成功。 - FAILED：失败。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("update_result", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateResult { get; set; }

        /// <summary>
        /// **参数解释：** 是否生效。 **约束限制：** 不涉及。 **取值范围：** - true:已生效。 - false:未生效。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("applied", NullValueHandling = NullValueHandling.Ignore)]
        public string Applied { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。 **约束限制：** 不涉及。 **取值范围：** 格式为\&quot;yyyy-MM-ddTHH:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 生效时间。 **约束限制：** 不涉及。 **取值范围：** 格式为\&quot;yyyy-MM-ddTHH:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("applied_at", NullValueHandling = NullValueHandling.Ignore)]
        public string AppliedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationHistoryRsp {\n");
            sb.Append("  parameterName: ").Append(ParameterName).Append("\n");
            sb.Append("  oldValue: ").Append(OldValue).Append("\n");
            sb.Append("  newValue: ").Append(NewValue).Append("\n");
            sb.Append("  updateResult: ").Append(UpdateResult).Append("\n");
            sb.Append("  applied: ").Append(Applied).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  appliedAt: ").Append(AppliedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigurationHistoryRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigurationHistoryRsp input)
        {
            if (input == null) return false;
            if (this.ParameterName != input.ParameterName || (this.ParameterName != null && !this.ParameterName.Equals(input.ParameterName))) return false;
            if (this.OldValue != input.OldValue || (this.OldValue != null && !this.OldValue.Equals(input.OldValue))) return false;
            if (this.NewValue != input.NewValue || (this.NewValue != null && !this.NewValue.Equals(input.NewValue))) return false;
            if (this.UpdateResult != input.UpdateResult || (this.UpdateResult != null && !this.UpdateResult.Equals(input.UpdateResult))) return false;
            if (this.Applied != input.Applied || (this.Applied != null && !this.Applied.Equals(input.Applied))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.AppliedAt != input.AppliedAt || (this.AppliedAt != null && !this.AppliedAt.Equals(input.AppliedAt))) return false;

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
                if (this.ParameterName != null) hashCode = hashCode * 59 + this.ParameterName.GetHashCode();
                if (this.OldValue != null) hashCode = hashCode * 59 + this.OldValue.GetHashCode();
                if (this.NewValue != null) hashCode = hashCode * 59 + this.NewValue.GetHashCode();
                if (this.UpdateResult != null) hashCode = hashCode * 59 + this.UpdateResult.GetHashCode();
                if (this.Applied != null) hashCode = hashCode * 59 + this.Applied.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.AppliedAt != null) hashCode = hashCode * 59 + this.AppliedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
