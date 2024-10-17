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
    public class CompareTaskListResult 
    {

        /// <summary>
        /// 对比任务列表。
        /// </summary>
        [JsonProperty("compare_task_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CompareTaskList> CompareTaskList { get; set; }

        /// <summary>
        /// 对比任务列表总数。
        /// </summary>
        [JsonProperty("compare_task_list_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompareTaskListCount { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareTaskListResult {\n");
            sb.Append("  compareTaskList: ").Append(CompareTaskList).Append("\n");
            sb.Append("  compareTaskListCount: ").Append(CompareTaskListCount).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareTaskListResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareTaskListResult input)
        {
            if (input == null) return false;
            if (this.CompareTaskList != input.CompareTaskList || (this.CompareTaskList != null && input.CompareTaskList != null && !this.CompareTaskList.SequenceEqual(input.CompareTaskList))) return false;
            if (this.CompareTaskListCount != input.CompareTaskListCount || (this.CompareTaskListCount != null && !this.CompareTaskListCount.Equals(input.CompareTaskListCount))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;

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
                if (this.CompareTaskList != null) hashCode = hashCode * 59 + this.CompareTaskList.GetHashCode();
                if (this.CompareTaskListCount != null) hashCode = hashCode * 59 + this.CompareTaskListCount.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
