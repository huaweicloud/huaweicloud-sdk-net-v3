using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateResourceShareResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_share", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceShare ResourceShare { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateResourceShareResponse {\n");
            sb.Append("  resourceShare: ").Append(ResourceShare).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateResourceShareResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateResourceShareResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceShare == input.ResourceShare ||
                    (this.ResourceShare != null &&
                    this.ResourceShare.Equals(input.ResourceShare))
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
                if (this.ResourceShare != null)
                    hashCode = hashCode * 59 + this.ResourceShare.GetHashCode();
                return hashCode;
            }
        }
    }
}
