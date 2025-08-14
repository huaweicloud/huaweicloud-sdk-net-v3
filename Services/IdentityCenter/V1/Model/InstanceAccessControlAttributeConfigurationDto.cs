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
    /// Specifies the attributes to add to your attribute-based access control (ABAC) configuration.
    /// </summary>
    public class InstanceAccessControlAttributeConfigurationDto 
    {

        /// <summary>
        /// IAM Identity Center实例中ABAC配置的属性
        /// </summary>
        [JsonProperty("access_control_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessControlAttributeDto> AccessControlAttributes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceAccessControlAttributeConfigurationDto {\n");
            sb.Append("  accessControlAttributes: ").Append(AccessControlAttributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceAccessControlAttributeConfigurationDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceAccessControlAttributeConfigurationDto input)
        {
            if (input == null) return false;
            if (this.AccessControlAttributes != input.AccessControlAttributes || (this.AccessControlAttributes != null && input.AccessControlAttributes != null && !this.AccessControlAttributes.SequenceEqual(input.AccessControlAttributes))) return false;

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
                if (this.AccessControlAttributes != null) hashCode = hashCode * 59 + this.AccessControlAttributes.GetHashCode();
                return hashCode;
            }
        }
    }
}
