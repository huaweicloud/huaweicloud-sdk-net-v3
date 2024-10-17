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
    public class ShowEnvByNameRequest 
    {

        /// <summary>
        /// 环境名称
        /// </summary>
        [SDKProperty("environment_name", IsPath = true)]
        [JsonProperty("environment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// 环境region
        /// </summary>
        [SDKProperty("region", IsQuery = true)]
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 组件id
        /// </summary>
        [SDKProperty("component_id", IsQuery = true)]
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEnvByNameRequest {\n");
            sb.Append("  environmentName: ").Append(EnvironmentName).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEnvByNameRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEnvByNameRequest input)
        {
            if (input == null) return false;
            if (this.EnvironmentName != input.EnvironmentName || (this.EnvironmentName != null && !this.EnvironmentName.Equals(input.EnvironmentName))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;

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
                if (this.EnvironmentName != null) hashCode = hashCode * 59 + this.EnvironmentName.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
