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
    /// Response Object
    /// </summary>
    public class CheckKernelUpgradeResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  预检查任务ID集合。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("job_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> JobIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckKernelUpgradeResponse {\n");
            sb.Append("  jobIds: ").Append(JobIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckKernelUpgradeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckKernelUpgradeResponse input)
        {
            if (input == null) return false;
            if (this.JobIds != input.JobIds || (this.JobIds != null && input.JobIds != null && !this.JobIds.SequenceEqual(input.JobIds))) return false;

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
                if (this.JobIds != null) hashCode = hashCode * 59 + this.JobIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
