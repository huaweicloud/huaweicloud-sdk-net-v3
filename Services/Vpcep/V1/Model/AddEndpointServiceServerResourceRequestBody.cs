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
    /// 终端节点服务添加后端服务资源请求结构体。
    /// </summary>
    public class AddEndpointServiceServerResourceRequestBody 
    {

        /// <summary>
        /// 后端elb实例ID和elb所在的az信息列表。
        /// </summary>
        [JsonProperty("server_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerResource> ServerResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddEndpointServiceServerResourceRequestBody {\n");
            sb.Append("  serverResources: ").Append(ServerResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddEndpointServiceServerResourceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddEndpointServiceServerResourceRequestBody input)
        {
            if (input == null) return false;
            if (this.ServerResources != input.ServerResources || (this.ServerResources != null && input.ServerResources != null && !this.ServerResources.SequenceEqual(input.ServerResources))) return false;

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
                if (this.ServerResources != null) hashCode = hashCode * 59 + this.ServerResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
