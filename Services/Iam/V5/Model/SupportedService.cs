using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 支持服务专属凭证的云服务信息。
    /// </summary>
    public class SupportedService 
    {

        /// <summary>
        /// 云服务名称。
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 关联的服务的展示名称（受语言控制）。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportedService {\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SupportedService);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SupportedService input)
        {
            if (input == null) return false;
            if (this.ServiceName != input.ServiceName || (this.ServiceName != null && !this.ServiceName.Equals(input.ServiceName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;

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
                if (this.ServiceName != null) hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                return hashCode;
            }
        }
    }
}
