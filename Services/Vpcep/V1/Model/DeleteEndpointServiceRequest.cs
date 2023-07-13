using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteEndpointServiceRequest 
    {

        /// <summary>
        /// 终端节点服务的ID。
        /// </summary>
        [SDKProperty("vpc_endpoint_service_id", IsPath = true)]
        [JsonProperty("vpc_endpoint_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcEndpointServiceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteEndpointServiceRequest {\n");
            sb.Append("  vpcEndpointServiceId: ").Append(VpcEndpointServiceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteEndpointServiceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteEndpointServiceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VpcEndpointServiceId == input.VpcEndpointServiceId ||
                    (this.VpcEndpointServiceId != null &&
                    this.VpcEndpointServiceId.Equals(input.VpcEndpointServiceId))
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
                if (this.VpcEndpointServiceId != null)
                    hashCode = hashCode * 59 + this.VpcEndpointServiceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
