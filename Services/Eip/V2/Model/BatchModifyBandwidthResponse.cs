using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchModifyBandwidthResponse : SdkResponse
    {

        /// <summary>
        /// 成功资源
        /// </summary>
        [JsonProperty("success_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<SuccessResources> SuccessResources { get; set; }

        /// <summary>
        /// 失败资源
        /// </summary>
        [JsonProperty("failure_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<FailureResources> FailureResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchModifyBandwidthResponse {\n");
            sb.Append("  successResources: ").Append(SuccessResources).Append("\n");
            sb.Append("  failureResources: ").Append(FailureResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchModifyBandwidthResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchModifyBandwidthResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SuccessResources == input.SuccessResources ||
                    this.SuccessResources != null &&
                    input.SuccessResources != null &&
                    this.SuccessResources.SequenceEqual(input.SuccessResources)
                ) && 
                (
                    this.FailureResources == input.FailureResources ||
                    this.FailureResources != null &&
                    input.FailureResources != null &&
                    this.FailureResources.SequenceEqual(input.FailureResources)
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
                if (this.SuccessResources != null)
                    hashCode = hashCode * 59 + this.SuccessResources.GetHashCode();
                if (this.FailureResources != null)
                    hashCode = hashCode * 59 + this.FailureResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
