using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StackSetVarsURIContentPrimitiveTypeHolder 
    {

        /// <summary>
        /// vars_uri对应的文件内容
        /// </summary>
        [JsonProperty("vars_uri_content", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsUriContent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackSetVarsURIContentPrimitiveTypeHolder {\n");
            sb.Append("  varsUriContent: ").Append(VarsUriContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackSetVarsURIContentPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackSetVarsURIContentPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.VarsUriContent != input.VarsUriContent || (this.VarsUriContent != null && !this.VarsUriContent.Equals(input.VarsUriContent))) return false;

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
                if (this.VarsUriContent != null) hashCode = hashCode * 59 + this.VarsUriContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
