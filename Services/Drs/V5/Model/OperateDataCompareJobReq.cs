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
    /// 操作对比任务请求体
    /// </summary>
    public class OperateDataCompareJobReq 
    {

        /// <summary>
        /// 操作的对比任务ID列表。
        /// </summary>
        [JsonProperty("compare_job_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CompareJobIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperateDataCompareJobReq {\n");
            sb.Append("  compareJobIds: ").Append(CompareJobIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateDataCompareJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateDataCompareJobReq input)
        {
            if (input == null) return false;
            if (this.CompareJobIds != input.CompareJobIds || (this.CompareJobIds != null && input.CompareJobIds != null && !this.CompareJobIds.SequenceEqual(input.CompareJobIds))) return false;

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
                if (this.CompareJobIds != null) hashCode = hashCode * 59 + this.CompareJobIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
