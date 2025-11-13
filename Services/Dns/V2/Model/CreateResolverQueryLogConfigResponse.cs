using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateResolverQueryLogConfigResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resolver_query_log_config", NullValueHandling = NullValueHandling.Ignore)]
        public ResolverQueryLogConfig ResolverQueryLogConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResolverQueryLogConfigResponse {\n");
            sb.Append("  resolverQueryLogConfig: ").Append(ResolverQueryLogConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateResolverQueryLogConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateResolverQueryLogConfigResponse input)
        {
            if (input == null) return false;
            if (this.ResolverQueryLogConfig != input.ResolverQueryLogConfig || (this.ResolverQueryLogConfig != null && !this.ResolverQueryLogConfig.Equals(input.ResolverQueryLogConfig))) return false;

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
                if (this.ResolverQueryLogConfig != null) hashCode = hashCode * 59 + this.ResolverQueryLogConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
