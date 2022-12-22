using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPublicBorderGroupsRequest 
    {

        /// <summary>
        /// 显示，形式为\&quot;fields&#x3D;id&amp;fields&#x3D;name&amp;...\&quot;  支持字段：publicip_pools/public_border_group
        /// </summary>
        [SDKProperty("fields", IsQuery = true)]
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public string Fields { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPublicBorderGroupsRequest {\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPublicBorderGroupsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPublicBorderGroupsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fields == input.Fields ||
                    (this.Fields != null &&
                    this.Fields.Equals(input.Fields))
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
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                return hashCode;
            }
        }
    }
}
