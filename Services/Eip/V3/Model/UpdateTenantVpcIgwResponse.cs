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
    /// Response Object
    /// </summary>
    public class UpdateTenantVpcIgwResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vpc_igw", NullValueHandling = NullValueHandling.Ignore)]
        public VpcIgwsTenantResp VpcIgw { get; set; }

        /// <summary>
        /// 本次请求编号
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTenantVpcIgwResponse {\n");
            sb.Append("  vpcIgw: ").Append(VpcIgw).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTenantVpcIgwResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTenantVpcIgwResponse input)
        {
            if (input == null) return false;
            if (this.VpcIgw != input.VpcIgw || (this.VpcIgw != null && !this.VpcIgw.Equals(input.VpcIgw))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;

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
                if (this.VpcIgw != null) hashCode = hashCode * 59 + this.VpcIgw.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
