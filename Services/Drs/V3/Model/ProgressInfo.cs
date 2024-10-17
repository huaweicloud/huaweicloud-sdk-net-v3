using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 迁移进度信息体
    /// </summary>
    public class ProgressInfo 
    {

        /// <summary>
        /// 完成进度
        /// </summary>
        [JsonProperty("completed", NullValueHandling = NullValueHandling.Ignore)]
        public string Completed { get; set; }

        /// <summary>
        /// 预计剩余时间
        /// </summary>
        [JsonProperty("remaining_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainingTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgressInfo {\n");
            sb.Append("  completed: ").Append(Completed).Append("\n");
            sb.Append("  remainingTime: ").Append(RemainingTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProgressInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProgressInfo input)
        {
            if (input == null) return false;
            if (this.Completed != input.Completed || (this.Completed != null && !this.Completed.Equals(input.Completed))) return false;
            if (this.RemainingTime != input.RemainingTime || (this.RemainingTime != null && !this.RemainingTime.Equals(input.RemainingTime))) return false;

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
                if (this.Completed != null) hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.RemainingTime != null) hashCode = hashCode * 59 + this.RemainingTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
