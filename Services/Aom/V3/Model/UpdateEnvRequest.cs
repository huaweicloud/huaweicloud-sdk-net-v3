using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateEnvRequest 
    {

        /// <summary>
        /// 环境id
        /// </summary>
        [SDKProperty("environment_id", IsPath = true)]
        [JsonProperty("environment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public EnvParam Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEnvRequest {\n");
            sb.Append("  environmentId: ").Append(EnvironmentId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateEnvRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateEnvRequest input)
        {
            if (input == null) return false;
            if (this.EnvironmentId != input.EnvironmentId || (this.EnvironmentId != null && !this.EnvironmentId.Equals(input.EnvironmentId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.EnvironmentId != null) hashCode = hashCode * 59 + this.EnvironmentId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
