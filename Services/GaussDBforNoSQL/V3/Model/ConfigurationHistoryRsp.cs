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
        /// 参数名称。
        /// </summary>
        [JsonProperty("parameter_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParameterName { get; set; }

        /// <summary>
        /// 参数旧值
        /// </summary>
        [JsonProperty("old_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OldValue { get; set; }

        /// <summary>
        /// 参数新值
        /// </summary>
        [JsonProperty("new_value", NullValueHandling = NullValueHandling.Ignore)]
        public string NewValue { get; set; }

        /// <summary>
        /// 更新结果
        /// </summary>
        [JsonProperty("update_result", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateResult { get; set; }

        /// <summary>
        /// - true:已生效 - false:未生效
        /// </summary>
        [JsonProperty("applied", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Applied { get; set; }

        /// <summary>
        /// 更新时间，格式为\&quot;yyyy-MM-ddTHH:mm:ssZ\&quot;。  [其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。](tag:hc)  [其中，T指某个时间的开始；Z指时区偏移量。](tag:hk)
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 生效时间，格式为\&quot;yyyy-MM-ddTHH:mm:ssZ\&quot;。  [其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。](tag:hc)  [其中，T指某个时间的开始；Z指时区偏移量。](tag:hk)
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
            if (input == null)
                return false;

            return 
                (
                    this.ParameterName == input.ParameterName ||
                    (this.ParameterName != null &&
                    this.ParameterName.Equals(input.ParameterName))
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
                    this.UpdateResult == input.UpdateResult ||
                    (this.UpdateResult != null &&
                    this.UpdateResult.Equals(input.UpdateResult))
                ) && 
                (
                    this.Applied == input.Applied ||
                    (this.Applied != null &&
                    this.Applied.Equals(input.Applied))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.AppliedAt == input.AppliedAt ||
                    (this.AppliedAt != null &&
                    this.AppliedAt.Equals(input.AppliedAt))
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
                if (this.ParameterName != null)
                    hashCode = hashCode * 59 + this.ParameterName.GetHashCode();
                if (this.OldValue != null)
                    hashCode = hashCode * 59 + this.OldValue.GetHashCode();
                if (this.NewValue != null)
                    hashCode = hashCode * 59 + this.NewValue.GetHashCode();
                if (this.UpdateResult != null)
                    hashCode = hashCode * 59 + this.UpdateResult.GetHashCode();
                if (this.Applied != null)
                    hashCode = hashCode * 59 + this.Applied.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.AppliedAt != null)
                    hashCode = hashCode * 59 + this.AppliedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
