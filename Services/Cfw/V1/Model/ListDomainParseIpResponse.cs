using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDomainParseIpResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 域名解析数据，包括域名IP列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Data { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDomainParseIpResponse {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDomainParseIpResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDomainParseIpResponse input)
        {
            if (input == null) return false;
            if (this.Data != input.Data || (this.Data != null && input.Data != null && !this.Data.SequenceEqual(input.Data))) return false;

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
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }
    }
}
