using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSubCustomersResponse : SdkResponse
    {

        /// <summary>
        /// 客户信息列表。 具体请参见表1。
        /// </summary>
        [JsonProperty("customer_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomerInformation> CustomerInfos { get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubCustomersResponse {\n");
            sb.Append("  customerInfos: ").Append(CustomerInfos).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubCustomersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubCustomersResponse input)
        {
            if (input == null) return false;
            if (this.CustomerInfos != input.CustomerInfos || (this.CustomerInfos != null && input.CustomerInfos != null && !this.CustomerInfos.SequenceEqual(input.CustomerInfos))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.CustomerInfos != null) hashCode = hashCode * 59 + this.CustomerInfos.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
