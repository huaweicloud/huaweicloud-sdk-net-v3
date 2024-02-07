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
    /// 修改虚拟IGW的请求体
    /// </summary>
    public class UpdateTenantVpcIgwRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vpc_igw", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateTenantVpcIgwRequestBodyVpcIgw VpcIgw { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTenantVpcIgwRequestBody {\n");
            sb.Append("  vpcIgw: ").Append(VpcIgw).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTenantVpcIgwRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTenantVpcIgwRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VpcIgw == input.VpcIgw ||
                    (this.VpcIgw != null &&
                    this.VpcIgw.Equals(input.VpcIgw))
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
                if (this.VpcIgw != null)
                    hashCode = hashCode * 59 + this.VpcIgw.GetHashCode();
                return hashCode;
            }
        }
    }
}
