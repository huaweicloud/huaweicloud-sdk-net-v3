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
    /// 全量迁移进度。
    /// </summary>
    public class ProgressCompleteInfo 
    {

        /// <summary>
        /// 完成进度。
        /// </summary>
        [JsonProperty("completed", NullValueHandling = NullValueHandling.Ignore)]
        public string Completed { get; set; }

        /// <summary>
        /// 预计剩余时间。
        /// </summary>
        [JsonProperty("remaining_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainingTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgressCompleteInfo {\n");
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
            return this.Equals(input as ProgressCompleteInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProgressCompleteInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && 
                (
                    this.RemainingTime == input.RemainingTime ||
                    (this.RemainingTime != null &&
                    this.RemainingTime.Equals(input.RemainingTime))
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
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.RemainingTime != null)
                    hashCode = hashCode * 59 + this.RemainingTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
