using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteTenantVpcIgwRequest 
    {

        /// <summary>
        /// 虚拟igw的uuid
        /// </summary>
        [SDKProperty("vpc_igw_id", IsPath = true)]
        [JsonProperty("vpc_igw_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcIgwId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTenantVpcIgwRequest {\n");
            sb.Append("  vpcIgwId: ").Append(VpcIgwId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTenantVpcIgwRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTenantVpcIgwRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VpcIgwId == input.VpcIgwId ||
                    (this.VpcIgwId != null &&
                    this.VpcIgwId.Equals(input.VpcIgwId))
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
                if (this.VpcIgwId != null)
                    hashCode = hashCode * 59 + this.VpcIgwId.GetHashCode();
                return hashCode;
            }
        }
    }
}
