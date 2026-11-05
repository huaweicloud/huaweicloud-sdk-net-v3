using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListServiceStatusesRequest 
    {

        /// <summary>
        /// **参数解释**：服务编码列表，逗号分隔，如aom,cce,ces,swr-ee。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("service_codes", IsQuery = true)]
        [JsonProperty("service_codes", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceCodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServiceStatusesRequest {\n");
            sb.Append("  serviceCodes: ").Append(ServiceCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServiceStatusesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServiceStatusesRequest input)
        {
            if (input == null) return false;
            if (this.ServiceCodes != input.ServiceCodes || (this.ServiceCodes != null && !this.ServiceCodes.Equals(input.ServiceCodes))) return false;

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
                if (this.ServiceCodes != null) hashCode = hashCode * 59 + this.ServiceCodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
