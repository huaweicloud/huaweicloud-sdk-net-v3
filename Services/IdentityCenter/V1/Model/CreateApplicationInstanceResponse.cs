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
    /// Response Object
    /// </summary>
    public class CreateApplicationInstanceResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("application_instance", NullValueHandling = NullValueHandling.Ignore)]
        public ApplicationInstanceDto ApplicationInstance { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApplicationInstanceResponse {\n");
            sb.Append("  applicationInstance: ").Append(ApplicationInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateApplicationInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateApplicationInstanceResponse input)
        {
            if (input == null) return false;
            if (this.ApplicationInstance != input.ApplicationInstance || (this.ApplicationInstance != null && !this.ApplicationInstance.Equals(input.ApplicationInstance))) return false;

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
                if (this.ApplicationInstance != null) hashCode = hashCode * 59 + this.ApplicationInstance.GetHashCode();
                return hashCode;
            }
        }
    }
}
