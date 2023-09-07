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
    public class RetainAllResourcesTypeHolder 
    {

        /// <summary>
        /// 删除资源栈是否保留资源的标志位，如果不传默认为false，即默认不保留资源（删除资源栈后会删除资源栈中的资源）  * DeleteStackEnhanced API中，若该参数未在RequestBody中给予，则删除时不会保留资源栈中的资源*
        /// </summary>
        [JsonProperty("retain_all_resources", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RetainAllResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetainAllResourcesTypeHolder {\n");
            sb.Append("  retainAllResources: ").Append(RetainAllResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetainAllResourcesTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetainAllResourcesTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RetainAllResources == input.RetainAllResources ||
                    (this.RetainAllResources != null &&
                    this.RetainAllResources.Equals(input.RetainAllResources))
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
                if (this.RetainAllResources != null)
                    hashCode = hashCode * 59 + this.RetainAllResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
