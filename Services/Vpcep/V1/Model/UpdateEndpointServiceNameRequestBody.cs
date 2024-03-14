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
    /// 修改终端节点服务名称
    /// </summary>
    public class UpdateEndpointServiceNameRequestBody 
    {

        /// <summary>
        /// 终端节点服务名称
        /// </summary>
        [JsonProperty("endpoint_service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointServiceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEndpointServiceNameRequestBody {\n");
            sb.Append("  endpointServiceName: ").Append(EndpointServiceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateEndpointServiceNameRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateEndpointServiceNameRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndpointServiceName == input.EndpointServiceName ||
                    (this.EndpointServiceName != null &&
                    this.EndpointServiceName.Equals(input.EndpointServiceName))
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
                if (this.EndpointServiceName != null)
                    hashCode = hashCode * 59 + this.EndpointServiceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
