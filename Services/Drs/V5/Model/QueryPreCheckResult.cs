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
    /// 预检查结果信息体。
    /// </summary>
    public class QueryPreCheckResult 
    {

        /// <summary>
        /// 返回的预检查结果是否通过。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Result { get; set; }

        /// <summary>
        /// 预检查进度百分比。
        /// </summary>
        [JsonProperty("process", NullValueHandling = NullValueHandling.Ignore)]
        public string Process { get; set; }

        /// <summary>
        /// 预检查通过百分比。
        /// </summary>
        [JsonProperty("total_passed_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPassedRate { get; set; }

        /// <summary>
        /// 数据库实例ID。
        /// </summary>
        [JsonProperty("rds_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RdsInstanceId { get; set; }

        /// <summary>
        /// 迁移方向。
        /// </summary>
        [JsonProperty("job_direction", NullValueHandling = NullValueHandling.Ignore)]
        public string JobDirection { get; set; }

        /// <summary>
        /// 预检查各项结果。
        /// </summary>
        [JsonProperty("precheck_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrecheckResult> PrecheckResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryPreCheckResult {\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  process: ").Append(Process).Append("\n");
            sb.Append("  totalPassedRate: ").Append(TotalPassedRate).Append("\n");
            sb.Append("  rdsInstanceId: ").Append(RdsInstanceId).Append("\n");
            sb.Append("  jobDirection: ").Append(JobDirection).Append("\n");
            sb.Append("  precheckResults: ").Append(PrecheckResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryPreCheckResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryPreCheckResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Process == input.Process ||
                    (this.Process != null &&
                    this.Process.Equals(input.Process))
                ) && 
                (
                    this.TotalPassedRate == input.TotalPassedRate ||
                    (this.TotalPassedRate != null &&
                    this.TotalPassedRate.Equals(input.TotalPassedRate))
                ) && 
                (
                    this.RdsInstanceId == input.RdsInstanceId ||
                    (this.RdsInstanceId != null &&
                    this.RdsInstanceId.Equals(input.RdsInstanceId))
                ) && 
                (
                    this.JobDirection == input.JobDirection ||
                    (this.JobDirection != null &&
                    this.JobDirection.Equals(input.JobDirection))
                ) && 
                (
                    this.PrecheckResults == input.PrecheckResults ||
                    this.PrecheckResults != null &&
                    input.PrecheckResults != null &&
                    this.PrecheckResults.SequenceEqual(input.PrecheckResults)
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
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Process != null)
                    hashCode = hashCode * 59 + this.Process.GetHashCode();
                if (this.TotalPassedRate != null)
                    hashCode = hashCode * 59 + this.TotalPassedRate.GetHashCode();
                if (this.RdsInstanceId != null)
                    hashCode = hashCode * 59 + this.RdsInstanceId.GetHashCode();
                if (this.JobDirection != null)
                    hashCode = hashCode * 59 + this.JobDirection.GetHashCode();
                if (this.PrecheckResults != null)
                    hashCode = hashCode * 59 + this.PrecheckResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
