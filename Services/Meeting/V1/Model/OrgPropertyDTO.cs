using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OrgPropertyDTO 
    {

        /// <summary>
        /// 配置项key。 开通本地录制功能，参数填写：enableClientRecord。 
        /// </summary>
        [JsonProperty("propertyKey", NullValueHandling = NullValueHandling.Ignore)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// 配置项值。 开通本地录制功能，参数填写：true。 
        /// </summary>
        [JsonProperty("propertyValue", NullValueHandling = NullValueHandling.Ignore)]
        public string PropertyValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgPropertyDTO {\n");
            sb.Append("  propertyKey: ").Append(PropertyKey).Append("\n");
            sb.Append("  propertyValue: ").Append(PropertyValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrgPropertyDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrgPropertyDTO input)
        {
            if (input == null) return false;
            if (this.PropertyKey != input.PropertyKey || (this.PropertyKey != null && !this.PropertyKey.Equals(input.PropertyKey))) return false;
            if (this.PropertyValue != input.PropertyValue || (this.PropertyValue != null && !this.PropertyValue.Equals(input.PropertyValue))) return false;

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
                if (this.PropertyKey != null) hashCode = hashCode * 59 + this.PropertyKey.GetHashCode();
                if (this.PropertyValue != null) hashCode = hashCode * 59 + this.PropertyValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
