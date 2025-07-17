using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowMgmtSiteStatusRequest 
    {

        /// <summary>
        /// 模版类型。
        /// </summary>
        [SDKProperty("X-Schema-Type", IsHeader = true)]
        [JsonProperty("X-Schema-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string XSchemaType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMgmtSiteStatusRequest {\n");
            sb.Append("  xSchemaType: ").Append(XSchemaType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMgmtSiteStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMgmtSiteStatusRequest input)
        {
            if (input == null) return false;
            if (this.XSchemaType != input.XSchemaType || (this.XSchemaType != null && !this.XSchemaType.Equals(input.XSchemaType))) return false;

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
                if (this.XSchemaType != null) hashCode = hashCode * 59 + this.XSchemaType.GetHashCode();
                return hashCode;
            }
        }
    }
}
