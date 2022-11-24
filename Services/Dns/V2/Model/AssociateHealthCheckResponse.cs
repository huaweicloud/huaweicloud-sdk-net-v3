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
    public class AssociateHealthCheckResponse : SdkResponse
    {

        /// <summary>
        /// 健康检查ID。 通过云解析服务的管理控制台，在健康检查的详情页面中获取。
        /// </summary>
        [JsonProperty("health_check_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HealthCheckId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateHealthCheckResponse {\n");
            sb.Append("  healthCheckId: ").Append(HealthCheckId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateHealthCheckResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateHealthCheckResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HealthCheckId == input.HealthCheckId ||
                    (this.HealthCheckId != null &&
                    this.HealthCheckId.Equals(input.HealthCheckId))
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
                if (this.HealthCheckId != null)
                    hashCode = hashCode * 59 + this.HealthCheckId.GetHashCode();
                return hashCode;
            }
        }
    }
}
