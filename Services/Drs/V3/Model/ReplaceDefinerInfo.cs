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
    /// 设置replaceDefiner信息
    /// </summary>
    public class ReplaceDefinerInfo 
    {

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 是否使用目标库的用户替换掉definer
        /// </summary>
        [JsonProperty("replace_definer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReplaceDefiner { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplaceDefinerInfo {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  replaceDefiner: ").Append(ReplaceDefiner).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplaceDefinerInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplaceDefinerInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.ReplaceDefiner == input.ReplaceDefiner ||
                    (this.ReplaceDefiner != null &&
                    this.ReplaceDefiner.Equals(input.ReplaceDefiner))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ReplaceDefiner != null)
                    hashCode = hashCode * 59 + this.ReplaceDefiner.GetHashCode();
                return hashCode;
            }
        }
    }
}
