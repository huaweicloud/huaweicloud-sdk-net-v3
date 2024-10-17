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
    public class ParamGroupHistoryResponse 
    {

        /// <summary>
        /// 参数名称。
        /// </summary>
        [JsonProperty("parameter_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParameterName { get; set; }

        /// <summary>
        /// 修改前参数值。
        /// </summary>
        [JsonProperty("old_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OldValue { get; set; }

        /// <summary>
        /// 修改后参数值。
        /// </summary>
        [JsonProperty("new_value", NullValueHandling = NullValueHandling.Ignore)]
        public string NewValue { get; set; }

        /// <summary>
        /// 更新结果。
        /// </summary>
        [JsonProperty("update_result", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateResult { get; set; }

        /// <summary>
        /// 是否应用。 - true：是。 - false：否。
        /// </summary>
        [JsonProperty("is_applied", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsApplied { get; set; }

        /// <summary>
        /// 修改时间。格式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 应用时间。格式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("applied", NullValueHandling = NullValueHandling.Ignore)]
        public string Applied { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParamGroupHistoryResponse {\n");
            sb.Append("  parameterName: ").Append(ParameterName).Append("\n");
            sb.Append("  oldValue: ").Append(OldValue).Append("\n");
            sb.Append("  newValue: ").Append(NewValue).Append("\n");
            sb.Append("  updateResult: ").Append(UpdateResult).Append("\n");
            sb.Append("  isApplied: ").Append(IsApplied).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  applied: ").Append(Applied).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParamGroupHistoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParamGroupHistoryResponse input)
        {
            if (input == null) return false;
            if (this.ParameterName != input.ParameterName || (this.ParameterName != null && !this.ParameterName.Equals(input.ParameterName))) return false;
            if (this.OldValue != input.OldValue || (this.OldValue != null && !this.OldValue.Equals(input.OldValue))) return false;
            if (this.NewValue != input.NewValue || (this.NewValue != null && !this.NewValue.Equals(input.NewValue))) return false;
            if (this.UpdateResult != input.UpdateResult || (this.UpdateResult != null && !this.UpdateResult.Equals(input.UpdateResult))) return false;
            if (this.IsApplied != input.IsApplied || (this.IsApplied != null && !this.IsApplied.Equals(input.IsApplied))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.Applied != input.Applied || (this.Applied != null && !this.Applied.Equals(input.Applied))) return false;

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
                if (this.IsApplied != null) hashCode = hashCode * 59 + this.IsApplied.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Applied != null) hashCode = hashCode * 59 + this.Applied.GetHashCode();
                return hashCode;
            }
        }
    }
}
