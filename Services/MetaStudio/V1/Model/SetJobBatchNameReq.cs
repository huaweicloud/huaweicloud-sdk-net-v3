using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 设置任务批次信息
    /// </summary>
    public class SetJobBatchNameReq 
    {

        /// <summary>
        /// 批次名称
        /// </summary>
        [JsonProperty("batch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchName { get; set; }

        /// <summary>
        /// 任务id列表
        /// </summary>
        [JsonProperty("job_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> JobIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetJobBatchNameReq {\n");
            sb.Append("  batchName: ").Append(BatchName).Append("\n");
            sb.Append("  jobIds: ").Append(JobIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetJobBatchNameReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetJobBatchNameReq input)
        {
            if (input == null) return false;
            if (this.BatchName != input.BatchName || (this.BatchName != null && !this.BatchName.Equals(input.BatchName))) return false;
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
                if (this.BatchName != null) hashCode = hashCode * 59 + this.BatchName.GetHashCode();
                if (this.JobIds != null) hashCode = hashCode * 59 + this.JobIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
