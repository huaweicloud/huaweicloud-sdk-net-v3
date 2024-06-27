using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpgradeInstancesVersionResponse : SdkResponse
    {

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("job_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> JobIds { get; set; }

        /// <summary>
        /// 下发成功的实例数量
        /// </summary>
        [JsonProperty("succeeded_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SucceededNum { get; set; }

        /// <summary>
        /// 下发失败的实例数量
        /// </summary>
        [JsonProperty("failed_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedNum { get; set; }

        /// <summary>
        /// 下发失败的实例ID列表
        /// </summary>
        [JsonProperty("failed_instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FailedInstanceIds { get; set; }

        /// <summary>
        /// 下发失败错误信息列表
        /// </summary>
        [JsonProperty("error_messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ErrorMessages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeInstancesVersionResponse {\n");
            sb.Append("  jobIds: ").Append(JobIds).Append("\n");
            sb.Append("  succeededNum: ").Append(SucceededNum).Append("\n");
            sb.Append("  failedNum: ").Append(FailedNum).Append("\n");
            sb.Append("  failedInstanceIds: ").Append(FailedInstanceIds).Append("\n");
            sb.Append("  errorMessages: ").Append(ErrorMessages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeInstancesVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeInstancesVersionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobIds == input.JobIds ||
                    this.JobIds != null &&
                    input.JobIds != null &&
                    this.JobIds.SequenceEqual(input.JobIds)
                ) && 
                (
                    this.SucceededNum == input.SucceededNum ||
                    (this.SucceededNum != null &&
                    this.SucceededNum.Equals(input.SucceededNum))
                ) && 
                (
                    this.FailedNum == input.FailedNum ||
                    (this.FailedNum != null &&
                    this.FailedNum.Equals(input.FailedNum))
                ) && 
                (
                    this.FailedInstanceIds == input.FailedInstanceIds ||
                    this.FailedInstanceIds != null &&
                    input.FailedInstanceIds != null &&
                    this.FailedInstanceIds.SequenceEqual(input.FailedInstanceIds)
                ) && 
                (
                    this.ErrorMessages == input.ErrorMessages ||
                    this.ErrorMessages != null &&
                    input.ErrorMessages != null &&
                    this.ErrorMessages.SequenceEqual(input.ErrorMessages)
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
                if (this.JobIds != null)
                    hashCode = hashCode * 59 + this.JobIds.GetHashCode();
                if (this.SucceededNum != null)
                    hashCode = hashCode * 59 + this.SucceededNum.GetHashCode();
                if (this.FailedNum != null)
                    hashCode = hashCode * 59 + this.FailedNum.GetHashCode();
                if (this.FailedInstanceIds != null)
                    hashCode = hashCode * 59 + this.FailedInstanceIds.GetHashCode();
                if (this.ErrorMessages != null)
                    hashCode = hashCode * 59 + this.ErrorMessages.GetHashCode();
                return hashCode;
            }
        }
    }
}
