using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ResizeClusterResponse : SdkResponse
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("jobID", NullValueHandling = NullValueHandling.Ignore)]
        public string JobID { get; set; }

        /// <summary>
        /// 包周期集群变更规格订单ID
        /// </summary>
        [JsonProperty("orderID", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeClusterResponse {\n");
            sb.Append("  jobID: ").Append(JobID).Append("\n");
            sb.Append("  orderID: ").Append(OrderID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeClusterResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeClusterResponse input)
        {
            if (input == null) return false;
            if (this.JobID != input.JobID || (this.JobID != null && !this.JobID.Equals(input.JobID))) return false;
            if (this.OrderID != input.OrderID || (this.OrderID != null && !this.OrderID.Equals(input.OrderID))) return false;

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
                if (this.JobID != null) hashCode = hashCode * 59 + this.JobID.GetHashCode();
                if (this.OrderID != null) hashCode = hashCode * 59 + this.OrderID.GetHashCode();
                return hashCode;
            }
        }
    }
}
