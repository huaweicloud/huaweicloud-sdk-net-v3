using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 负载均衡器
    /// </summary>
    public class ModifyLb 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lbaas_listener", NullValueHandling = NullValueHandling.Ignore)]
        public LbaasListener LbaasListener { get; set; }

        /// <summary>
        /// 经典型负载均衡器信息
        /// </summary>
        [JsonProperty("listener", NullValueHandling = NullValueHandling.Ignore)]
        public string Listener { get; set; }

        /// <summary>
        /// 负载均衡器迁移失败原因。
        /// </summary>
        [JsonProperty("failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }

        /// <summary>
        /// 负载均衡器迁移失败详情。
        /// </summary>
        [JsonProperty("failed_details", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyLb {\n");
            sb.Append("  lbaasListener: ").Append(LbaasListener).Append("\n");
            sb.Append("  listener: ").Append(Listener).Append("\n");
            sb.Append("  failedReason: ").Append(FailedReason).Append("\n");
            sb.Append("  failedDetails: ").Append(FailedDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyLb);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyLb input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LbaasListener == input.LbaasListener ||
                    (this.LbaasListener != null &&
                    this.LbaasListener.Equals(input.LbaasListener))
                ) && 
                (
                    this.Listener == input.Listener ||
                    (this.Listener != null &&
                    this.Listener.Equals(input.Listener))
                ) && 
                (
                    this.FailedReason == input.FailedReason ||
                    (this.FailedReason != null &&
                    this.FailedReason.Equals(input.FailedReason))
                ) && 
                (
                    this.FailedDetails == input.FailedDetails ||
                    (this.FailedDetails != null &&
                    this.FailedDetails.Equals(input.FailedDetails))
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
                if (this.LbaasListener != null)
                    hashCode = hashCode * 59 + this.LbaasListener.GetHashCode();
                if (this.Listener != null)
                    hashCode = hashCode * 59 + this.Listener.GetHashCode();
                if (this.FailedReason != null)
                    hashCode = hashCode * 59 + this.FailedReason.GetHashCode();
                if (this.FailedDetails != null)
                    hashCode = hashCode * 59 + this.FailedDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
