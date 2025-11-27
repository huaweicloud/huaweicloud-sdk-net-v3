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
    /// 分发服务器信息。
    /// </summary>
    public class CreateDistributionRequestBody 
    {

        /// <summary>
        /// 配置为分发服务器的实例id。
        /// </summary>
        [JsonProperty("distributor_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DistributorInstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDistributionRequestBody {\n");
            sb.Append("  distributorInstanceId: ").Append(DistributorInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDistributionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDistributionRequestBody input)
        {
            if (input == null) return false;
            if (this.DistributorInstanceId != input.DistributorInstanceId || (this.DistributorInstanceId != null && !this.DistributorInstanceId.Equals(input.DistributorInstanceId))) return false;

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
                if (this.DistributorInstanceId != null) hashCode = hashCode * 59 + this.DistributorInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
