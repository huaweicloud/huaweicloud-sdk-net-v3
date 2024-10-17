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
    /// 生成对比任务结果文件请求体。
    /// </summary>
    public class ExportCompareResultReq 
    {

        /// <summary>
        /// 对比任务类型： - contents： 内容对比。 - lines：行数对比。 - random：抽样对比。 - objects_comparison：对象对比。
        /// </summary>
        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareType { get; set; }

        /// <summary>
        /// 对比任务的ID，内容对比、抽样对比、行数对比场景必填。
        /// </summary>
        [JsonProperty("compare_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareJobId { get; set; }

        /// <summary>
        /// 时区，如GMT+08:00，用于生成当前时间标识，拼接到文件名称中。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportCompareResultReq {\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  compareJobId: ").Append(CompareJobId).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportCompareResultReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportCompareResultReq input)
        {
            if (input == null) return false;
            if (this.CompareType != input.CompareType || (this.CompareType != null && !this.CompareType.Equals(input.CompareType))) return false;
            if (this.CompareJobId != input.CompareJobId || (this.CompareJobId != null && !this.CompareJobId.Equals(input.CompareJobId))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;

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
                if (this.CompareType != null) hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                if (this.CompareJobId != null) hashCode = hashCode * 59 + this.CompareJobId.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
