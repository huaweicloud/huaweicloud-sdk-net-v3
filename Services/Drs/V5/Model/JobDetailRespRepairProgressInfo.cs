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
    /// 修复进度明细。
    /// </summary>
    public class JobDetailRespRepairProgressInfo 
    {

        /// <summary>
        /// 修复状态。 取值：\&quot;FAILED\&quot;, \&quot;SUCCEEDED\&quot;, \&quot;FINISHED\&quot;, \&quot;SUCCESS\&quot;
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 修复进度，百分比。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("repair_progress_details", NullValueHandling = NullValueHandling.Ignore)]
        public JobDetailRespRepairProgressInfoRepairProgressDetails RepairProgressDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobDetailRespRepairProgressInfo {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  repairProgressDetails: ").Append(RepairProgressDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobDetailRespRepairProgressInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobDetailRespRepairProgressInfo input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.RepairProgressDetails != input.RepairProgressDetails || (this.RepairProgressDetails != null && !this.RepairProgressDetails.Equals(input.RepairProgressDetails))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.RepairProgressDetails != null) hashCode = hashCode * 59 + this.RepairProgressDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
