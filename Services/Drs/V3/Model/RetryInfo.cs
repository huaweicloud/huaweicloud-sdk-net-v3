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
    /// 
    /// </summary>
    public class RetryInfo 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 再编辑之后启动，必填为true。
        /// </summary>
        [JsonProperty("is_sync_re_edit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSyncReEdit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetryInfo {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  isSyncReEdit: ").Append(IsSyncReEdit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetryInfo input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.IsSyncReEdit != input.IsSyncReEdit || (this.IsSyncReEdit != null && !this.IsSyncReEdit.Equals(input.IsSyncReEdit))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.IsSyncReEdit != null) hashCode = hashCode * 59 + this.IsSyncReEdit.GetHashCode();
                return hashCode;
            }
        }
    }
}
