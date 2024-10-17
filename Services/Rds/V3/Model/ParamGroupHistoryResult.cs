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
    /// 
    /// </summary>
    public class ParamGroupHistoryResult 
    {

        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("parameter_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParameterName { get; set; }

        /// <summary>
        /// 旧值
        /// </summary>
        [JsonProperty("old_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OldValue { get; set; }

        /// <summary>
        /// 新值
        /// </summary>
        [JsonProperty("new_value", NullValueHandling = NullValueHandling.Ignore)]
        public string NewValue { get; set; }

        /// <summary>
        /// 更新结果 成功：SUCCESS 失败： FAILED
        /// </summary>
        [JsonProperty("update_result", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateResult { get; set; }

        /// <summary>
        /// 是否已应用 true：已应用 false：未应用
        /// </summary>
        [JsonProperty("applied", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Applied { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 应用时间
        /// </summary>
        [JsonProperty("apply_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParamGroupHistoryResult {\n");
            sb.Append("  parameterName: ").Append(ParameterName).Append("\n");
            sb.Append("  oldValue: ").Append(OldValue).Append("\n");
            sb.Append("  newValue: ").Append(NewValue).Append("\n");
            sb.Append("  updateResult: ").Append(UpdateResult).Append("\n");
            sb.Append("  applied: ").Append(Applied).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  applyTime: ").Append(ApplyTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParamGroupHistoryResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParamGroupHistoryResult input)
        {
            if (input == null) return false;
            if (this.ParameterName != input.ParameterName || (this.ParameterName != null && !this.ParameterName.Equals(input.ParameterName))) return false;
            if (this.OldValue != input.OldValue || (this.OldValue != null && !this.OldValue.Equals(input.OldValue))) return false;
            if (this.NewValue != input.NewValue || (this.NewValue != null && !this.NewValue.Equals(input.NewValue))) return false;
            if (this.UpdateResult != input.UpdateResult || (this.UpdateResult != null && !this.UpdateResult.Equals(input.UpdateResult))) return false;
            if (this.Applied != input.Applied || (this.Applied != null && !this.Applied.Equals(input.Applied))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.ApplyTime != input.ApplyTime || (this.ApplyTime != null && !this.ApplyTime.Equals(input.ApplyTime))) return false;

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
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ApplyTime != null) hashCode = hashCode * 59 + this.ApplyTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
