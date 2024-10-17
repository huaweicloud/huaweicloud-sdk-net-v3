using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplyHistoryRsp 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 生效时间，格式为\&quot;yyyy-MM-ddTHH:mm:ssZ\&quot;。  [其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。](tag:hc)  [其中，T指某个时间的开始；Z指时区偏移量。](tag:hk)
        /// </summary>
        [JsonProperty("applied_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AppliedAt { get; set; }

        /// <summary>
        /// - SUCCESS：应用成功。 - FAILED:应用失败。
        /// </summary>
        [JsonProperty("apply_result", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyResult { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("failure_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailureReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyHistoryRsp {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  appliedAt: ").Append(AppliedAt).Append("\n");
            sb.Append("  applyResult: ").Append(ApplyResult).Append("\n");
            sb.Append("  failureReason: ").Append(FailureReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyHistoryRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyHistoryRsp input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.AppliedAt != input.AppliedAt || (this.AppliedAt != null && !this.AppliedAt.Equals(input.AppliedAt))) return false;
            if (this.ApplyResult != input.ApplyResult || (this.ApplyResult != null && !this.ApplyResult.Equals(input.ApplyResult))) return false;
            if (this.FailureReason != input.FailureReason || (this.FailureReason != null && !this.FailureReason.Equals(input.FailureReason))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.AppliedAt != null) hashCode = hashCode * 59 + this.AppliedAt.GetHashCode();
                if (this.ApplyResult != null) hashCode = hashCode * 59 + this.ApplyResult.GetHashCode();
                if (this.FailureReason != null) hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
