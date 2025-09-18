using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// update Health Check request
    /// </summary>
    public class UpdateHealthCheckRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("health_check", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateHealthCheckOption HealthCheck { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHealthCheckRequestBody {\n");
            sb.Append("  healthCheck: ").Append(HealthCheck).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHealthCheckRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHealthCheckRequestBody input)
        {
            if (input == null) return false;
            if (this.HealthCheck != input.HealthCheck || (this.HealthCheck != null && !this.HealthCheck.Equals(input.HealthCheck))) return false;

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
                if (this.HealthCheck != null) hashCode = hashCode * 59 + this.HealthCheck.GetHashCode();
                return hashCode;
            }
        }
    }
}
