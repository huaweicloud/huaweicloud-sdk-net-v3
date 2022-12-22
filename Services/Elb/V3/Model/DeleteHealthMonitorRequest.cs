using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteHealthMonitorRequest 
    {

        /// <summary>
        /// 健康检查ID。
        /// </summary>
        [SDKProperty("healthmonitor_id", IsPath = true)]
        [JsonProperty("healthmonitor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HealthmonitorId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteHealthMonitorRequest {\n");
            sb.Append("  healthmonitorId: ").Append(HealthmonitorId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteHealthMonitorRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteHealthMonitorRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HealthmonitorId == input.HealthmonitorId ||
                    (this.HealthmonitorId != null &&
                    this.HealthmonitorId.Equals(input.HealthmonitorId))
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
                if (this.HealthmonitorId != null)
                    hashCode = hashCode * 59 + this.HealthmonitorId.GetHashCode();
                return hashCode;
            }
        }
    }
}
