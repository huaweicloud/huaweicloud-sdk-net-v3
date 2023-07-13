using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 操作详情
    /// </summary>
    public class IterationHistoryDetails 
    {

        /// <summary>
        /// 变更的字段
        /// </summary>
        [JsonProperty("operate_field_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateFieldName { get; set; }

        /// <summary>
        /// 操作后的值
        /// </summary>
        [JsonProperty("new_value", NullValueHandling = NullValueHandling.Ignore)]
        public string NewValue { get; set; }

        /// <summary>
        /// 操作前的值
        /// </summary>
        [JsonProperty("old_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OldValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IterationHistoryDetails {\n");
            sb.Append("  operateFieldName: ").Append(OperateFieldName).Append("\n");
            sb.Append("  newValue: ").Append(NewValue).Append("\n");
            sb.Append("  oldValue: ").Append(OldValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IterationHistoryDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IterationHistoryDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperateFieldName == input.OperateFieldName ||
                    (this.OperateFieldName != null &&
                    this.OperateFieldName.Equals(input.OperateFieldName))
                ) && 
                (
                    this.NewValue == input.NewValue ||
                    (this.NewValue != null &&
                    this.NewValue.Equals(input.NewValue))
                ) && 
                (
                    this.OldValue == input.OldValue ||
                    (this.OldValue != null &&
                    this.OldValue.Equals(input.OldValue))
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
                if (this.OperateFieldName != null)
                    hashCode = hashCode * 59 + this.OperateFieldName.GetHashCode();
                if (this.NewValue != null)
                    hashCode = hashCode * 59 + this.NewValue.GetHashCode();
                if (this.OldValue != null)
                    hashCode = hashCode * 59 + this.OldValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
