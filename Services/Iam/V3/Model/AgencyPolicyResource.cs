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
    public class AgencyPolicyResource 
    {

        /// <summary>
        /// 委托资源的URI。格式为：/iam/agencies/委托ID。例： &#x60;&#x60;&#x60; \&quot;uri\&quot;: [\&quot;/iam/agencies/07805acaba800fdd4fbdc00b8f888c7c\&quot;] &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Uri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgencyPolicyResource {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgencyPolicyResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgencyPolicyResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uri == input.Uri ||
                    this.Uri != null &&
                    input.Uri != null &&
                    this.Uri.SequenceEqual(input.Uri)
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                return hashCode;
            }
        }
    }
}
