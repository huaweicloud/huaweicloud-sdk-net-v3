using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释：** 服务运行配置。 **约束限制：** 不涉及。
    /// </summary>
    public class RuntimeConfig 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("service_invoke", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceInvoke ServiceInvoke { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("service_limit", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceLimit ServiceLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("service_secret", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceSecret ServiceSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("server_task_limit", NullValueHandling = NullValueHandling.Ignore)]
        public ServerTaskLimit ServerTaskLimit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuntimeConfig {\n");
            sb.Append("  serviceInvoke: ").Append(ServiceInvoke).Append("\n");
            sb.Append("  serviceLimit: ").Append(ServiceLimit).Append("\n");
            sb.Append("  serviceSecret: ").Append(ServiceSecret).Append("\n");
            sb.Append("  serverTaskLimit: ").Append(ServerTaskLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuntimeConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuntimeConfig input)
        {
            if (input == null) return false;
            if (this.ServiceInvoke != input.ServiceInvoke || (this.ServiceInvoke != null && !this.ServiceInvoke.Equals(input.ServiceInvoke))) return false;
            if (this.ServiceLimit != input.ServiceLimit || (this.ServiceLimit != null && !this.ServiceLimit.Equals(input.ServiceLimit))) return false;
            if (this.ServiceSecret != input.ServiceSecret || (this.ServiceSecret != null && !this.ServiceSecret.Equals(input.ServiceSecret))) return false;
            if (this.ServerTaskLimit != input.ServerTaskLimit || (this.ServerTaskLimit != null && !this.ServerTaskLimit.Equals(input.ServerTaskLimit))) return false;

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
                if (this.ServiceInvoke != null) hashCode = hashCode * 59 + this.ServiceInvoke.GetHashCode();
                if (this.ServiceLimit != null) hashCode = hashCode * 59 + this.ServiceLimit.GetHashCode();
                if (this.ServiceSecret != null) hashCode = hashCode * 59 + this.ServiceSecret.GetHashCode();
                if (this.ServerTaskLimit != null) hashCode = hashCode * 59 + this.ServerTaskLimit.GetHashCode();
                return hashCode;
            }
        }
    }
}
