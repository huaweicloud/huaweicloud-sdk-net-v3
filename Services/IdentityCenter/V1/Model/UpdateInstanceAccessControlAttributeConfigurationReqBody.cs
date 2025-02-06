using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// the request body of UpdateInstanceAccessControlAttributeConfiguration
    /// </summary>
    public class UpdateInstanceAccessControlAttributeConfigurationReqBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance_access_control_attribute_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceAccessControlAttributeConfigurationDto InstanceAccessControlAttributeConfiguration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstanceAccessControlAttributeConfigurationReqBody {\n");
            sb.Append("  instanceAccessControlAttributeConfiguration: ").Append(InstanceAccessControlAttributeConfiguration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstanceAccessControlAttributeConfigurationReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstanceAccessControlAttributeConfigurationReqBody input)
        {
            if (input == null) return false;
            if (this.InstanceAccessControlAttributeConfiguration != input.InstanceAccessControlAttributeConfiguration || (this.InstanceAccessControlAttributeConfiguration != null && !this.InstanceAccessControlAttributeConfiguration.Equals(input.InstanceAccessControlAttributeConfiguration))) return false;

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
                if (this.InstanceAccessControlAttributeConfiguration != null) hashCode = hashCode * 59 + this.InstanceAccessControlAttributeConfiguration.GetHashCode();
                return hashCode;
            }
        }
    }
}
