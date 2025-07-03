using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowTokenRequest 
    {

        /// <summary>
        /// 应用id。
        /// </summary>
        [SDKProperty("business_id", IsPath = true)]
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessId { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [SDKProperty("x-business-id", IsHeader = true)]
        [JsonProperty("x-business-id", NullValueHandling = NullValueHandling.Ignore)]
        public int? XBusinessId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTokenRequest {\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("  xBusinessId: ").Append(XBusinessId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTokenRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTokenRequest input)
        {
            if (input == null) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;
            if (this.XBusinessId != input.XBusinessId || (this.XBusinessId != null && !this.XBusinessId.Equals(input.XBusinessId))) return false;

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
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                if (this.XBusinessId != null) hashCode = hashCode * 59 + this.XBusinessId.GetHashCode();
                return hashCode;
            }
        }
    }
}
