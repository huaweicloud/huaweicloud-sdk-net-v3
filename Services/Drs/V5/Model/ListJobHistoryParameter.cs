using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 任务参数配置历史修改响应体
    /// </summary>
    public class ListJobHistoryParameter 
    {

        /// <summary>
        /// 参数名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 旧参数值。
        /// </summary>
        [JsonProperty("old_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OldValue { get; set; }

        /// <summary>
        /// 新参数值。
        /// </summary>
        [JsonProperty("new_value", NullValueHandling = NullValueHandling.Ignore)]
        public string NewValue { get; set; }

        /// <summary>
        /// 更新结果。true：成功，false：失败
        /// </summary>
        [JsonProperty("is_update_success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUpdateSuccess { get; set; }

        /// <summary>
        /// 是否已应用。true：已应用，false：未应用
        /// </summary>
        [JsonProperty("is_applied", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsApplied { get; set; }

        /// <summary>
        /// 参数修改时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 参数应用时间。
        /// </summary>
        [JsonProperty("apply_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListJobHistoryParameter {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  oldValue: ").Append(OldValue).Append("\n");
            sb.Append("  newValue: ").Append(NewValue).Append("\n");
            sb.Append("  isUpdateSuccess: ").Append(IsUpdateSuccess).Append("\n");
            sb.Append("  isApplied: ").Append(IsApplied).Append("\n");
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
            return this.Equals(input as ListJobHistoryParameter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJobHistoryParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OldValue == input.OldValue ||
                    (this.OldValue != null &&
                    this.OldValue.Equals(input.OldValue))
                ) && 
                (
                    this.NewValue == input.NewValue ||
                    (this.NewValue != null &&
                    this.NewValue.Equals(input.NewValue))
                ) && 
                (
                    this.IsUpdateSuccess == input.IsUpdateSuccess ||
                    (this.IsUpdateSuccess != null &&
                    this.IsUpdateSuccess.Equals(input.IsUpdateSuccess))
                ) && 
                (
                    this.IsApplied == input.IsApplied ||
                    (this.IsApplied != null &&
                    this.IsApplied.Equals(input.IsApplied))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.ApplyTime == input.ApplyTime ||
                    (this.ApplyTime != null &&
                    this.ApplyTime.Equals(input.ApplyTime))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OldValue != null)
                    hashCode = hashCode * 59 + this.OldValue.GetHashCode();
                if (this.NewValue != null)
                    hashCode = hashCode * 59 + this.NewValue.GetHashCode();
                if (this.IsUpdateSuccess != null)
                    hashCode = hashCode * 59 + this.IsUpdateSuccess.GetHashCode();
                if (this.IsApplied != null)
                    hashCode = hashCode * 59 + this.IsApplied.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ApplyTime != null)
                    hashCode = hashCode * 59 + this.ApplyTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
