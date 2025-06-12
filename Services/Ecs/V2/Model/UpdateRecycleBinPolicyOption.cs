using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateRecycleBinPolicyOption 
    {

        /// <summary>
        /// 虚拟机进入回收站后多久删除
        /// </summary>
        [JsonProperty("retention_hour", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionHour { get; set; }

        /// <summary>
        /// 创建多久的虚拟机可以进入回收站
        /// </summary>
        [JsonProperty("recycle_threshold_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecycleThresholdDay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRecycleBinPolicyOption {\n");
            sb.Append("  retentionHour: ").Append(RetentionHour).Append("\n");
            sb.Append("  recycleThresholdDay: ").Append(RecycleThresholdDay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRecycleBinPolicyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRecycleBinPolicyOption input)
        {
            if (input == null) return false;
            if (this.RetentionHour != input.RetentionHour || (this.RetentionHour != null && !this.RetentionHour.Equals(input.RetentionHour))) return false;
            if (this.RecycleThresholdDay != input.RecycleThresholdDay || (this.RecycleThresholdDay != null && !this.RecycleThresholdDay.Equals(input.RecycleThresholdDay))) return false;

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
                if (this.RetentionHour != null) hashCode = hashCode * 59 + this.RetentionHour.GetHashCode();
                if (this.RecycleThresholdDay != null) hashCode = hashCode * 59 + this.RecycleThresholdDay.GetHashCode();
                return hashCode;
            }
        }
    }
}
