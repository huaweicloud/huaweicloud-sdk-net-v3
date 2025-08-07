using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowEpConfigsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("support_item", NullValueHandling = NullValueHandling.Ignore)]
        public EnterpriseProjectConfig SupportItem { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEpConfigsResponse {\n");
            sb.Append("  supportItem: ").Append(SupportItem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEpConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEpConfigsResponse input)
        {
            if (input == null) return false;
            if (this.SupportItem != input.SupportItem || (this.SupportItem != null && !this.SupportItem.Equals(input.SupportItem))) return false;

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
                if (this.SupportItem != null) hashCode = hashCode * 59 + this.SupportItem.GetHashCode();
                return hashCode;
            }
        }
    }
}
