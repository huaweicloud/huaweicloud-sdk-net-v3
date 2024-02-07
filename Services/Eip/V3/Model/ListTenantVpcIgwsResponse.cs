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
    public class ListTenantVpcIgwsResponse : SdkResponse
    {

        /// <summary>
        /// 虚拟IGW列表对象
        /// </summary>
        [JsonProperty("vpc_igws", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcIgwsTenantResp> VpcIgws { get; set; }

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
            sb.Append("class ListTenantVpcIgwsResponse {\n");
            sb.Append("  vpcIgws: ").Append(VpcIgws).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTenantVpcIgwsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTenantVpcIgwsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VpcIgws == input.VpcIgws ||
                    this.VpcIgws != null &&
                    input.VpcIgws != null &&
                    this.VpcIgws.SequenceEqual(input.VpcIgws)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.VpcIgws != null)
                    hashCode = hashCode * 59 + this.VpcIgws.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
