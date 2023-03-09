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
    public class VarsUriContentPrimitiveTypeHolder 
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
            sb.Append("class VarsUriContentPrimitiveTypeHolder {\n");
            sb.Append("  varsUriContent: ").Append(VarsUriContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VarsUriContentPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VarsUriContentPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VarsUriContent == input.VarsUriContent ||
                    (this.VarsUriContent != null &&
                    this.VarsUriContent.Equals(input.VarsUriContent))
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
                if (this.VarsUriContent != null)
                    hashCode = hashCode * 59 + this.VarsUriContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
