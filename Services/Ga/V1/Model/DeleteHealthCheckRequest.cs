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
    /// Request Object
    /// </summary>
    public class DeleteHealthCheckRequest 
    {

        /// <summary>
        /// 健康检查ID。
        /// </summary>
        [SDKProperty("health_check_id", IsPath = true)]
        [JsonProperty("health_check_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HealthCheckId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteHealthCheckRequest {\n");
            sb.Append("  healthCheckId: ").Append(HealthCheckId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteHealthCheckRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteHealthCheckRequest input)
        {
            if (input == null) return false;
            if (this.HealthCheckId != input.HealthCheckId || (this.HealthCheckId != null && !this.HealthCheckId.Equals(input.HealthCheckId))) return false;

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
                if (this.HealthCheckId != null) hashCode = hashCode * 59 + this.HealthCheckId.GetHashCode();
                return hashCode;
            }
        }
    }
}
