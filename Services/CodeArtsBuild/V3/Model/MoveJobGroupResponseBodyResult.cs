using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 任务组
    /// </summary>
    public class MoveJobGroupResponseBodyResult 
    {

        /// <summary>
        /// 任务编号
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 分组路径
        /// </summary>
        [JsonProperty("group_path_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupPathId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoveJobGroupResponseBodyResult {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  groupPathId: ").Append(GroupPathId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MoveJobGroupResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MoveJobGroupResponseBodyResult input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.GroupPathId != input.GroupPathId || (this.GroupPathId != null && !this.GroupPathId.Equals(input.GroupPathId))) return false;

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
                if (this.GroupPathId != null) hashCode = hashCode * 59 + this.GroupPathId.GetHashCode();
                return hashCode;
            }
        }
    }
}
