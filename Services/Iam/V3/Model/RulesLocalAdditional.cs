using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RulesLocalAdditional 
    {

        /// <summary>
        /// user：联邦用户在本系统中的用户名称。 &#x60;&#x60;&#x60; \&quot;user\&quot;:{\&quot;name\&quot;:\&quot;{0}\&quot;} &#x60;&#x60;&#x60;  group：联邦用户在本系统中所属用户组。 &#x60;&#x60;&#x60; \&quot;group\&quot;:{\&quot;name\&quot;:\&quot;0cd5e9\&quot;} &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RulesLocalAdditional {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RulesLocalAdditional);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RulesLocalAdditional input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
