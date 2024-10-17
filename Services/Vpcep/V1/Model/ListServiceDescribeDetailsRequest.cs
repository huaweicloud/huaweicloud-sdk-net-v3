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
    public class ListServiceDescribeDetailsRequest 
    {

        /// <summary>
        /// 终端节点服务的名称。说明：该字段和id字段必须二选一，否则会出现错误。
        /// </summary>
        [SDKProperty("endpoint_service_name", IsQuery = true)]
        [JsonProperty("endpoint_service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointServiceName { get; set; }

        /// <summary>
        /// 终端节点服务的ID，唯一标识。 说明：该字段必须和endpoint_service_name字段二选一，否则会出现错误。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServiceDescribeDetailsRequest {\n");
            sb.Append("  endpointServiceName: ").Append(EndpointServiceName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServiceDescribeDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServiceDescribeDetailsRequest input)
        {
            if (input == null) return false;
            if (this.EndpointServiceName != input.EndpointServiceName || (this.EndpointServiceName != null && !this.EndpointServiceName.Equals(input.EndpointServiceName))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;

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
                if (this.EndpointServiceName != null) hashCode = hashCode * 59 + this.EndpointServiceName.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
