using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 参数修改历史记录明细信息。
    /// </summary>
    public class ListHistoryOperationsResult 
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
        /// 修改状态 (SUCCESS | FAILED)。
        /// </summary>
        [JsonProperty("update_result", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateResult { get; set; }

        /// <summary>
        /// 修改时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHistoryOperationsResult {\n");
            sb.Append("  parameterName: ").Append(ParameterName).Append("\n");
            sb.Append("  oldValue: ").Append(OldValue).Append("\n");
            sb.Append("  newValue: ").Append(NewValue).Append("\n");
            sb.Append("  updateResult: ").Append(UpdateResult).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHistoryOperationsResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHistoryOperationsResult input)
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
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
