using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDistributionResponse : SdkResponse
    {

        /// <summary>
        /// 状态。normal，abnormal，creating，createfail
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 分发服务器实例id。
        /// </summary>
        [JsonProperty("distributor_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DistributorInstanceId { get; set; }

        /// <summary>
        /// 分发服务器实例名称。
        /// </summary>
        [JsonProperty("distributor_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DistributorInstanceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDistributionResponse {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  distributorInstanceId: ").Append(DistributorInstanceId).Append("\n");
            sb.Append("  distributorInstanceName: ").Append(DistributorInstanceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDistributionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDistributionResponse input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.DistributorInstanceId != input.DistributorInstanceId || (this.DistributorInstanceId != null && !this.DistributorInstanceId.Equals(input.DistributorInstanceId))) return false;
            if (this.DistributorInstanceName != input.DistributorInstanceName || (this.DistributorInstanceName != null && !this.DistributorInstanceName.Equals(input.DistributorInstanceName))) return false;

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
                if (this.DistributorInstanceId != null) hashCode = hashCode * 59 + this.DistributorInstanceId.GetHashCode();
                if (this.DistributorInstanceName != null) hashCode = hashCode * 59 + this.DistributorInstanceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
