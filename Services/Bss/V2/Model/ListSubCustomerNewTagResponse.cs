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
    public class ListSubCustomerNewTagResponse : SdkResponse
    {

        /// <summary>
        /// 新客标签信息列表。只有成功的时候才返回。 此列表不包含非子客户的数据。批量查询客户新客标签时，若入参携带了非子客户，会被过滤。 具体请参见表1 NewCustomerTagItem。
        /// </summary>
        [JsonProperty("new_customer_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<NewCustomerTagItem> NewCustomerTags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubCustomerNewTagResponse {\n");
            sb.Append("  newCustomerTags: ").Append(NewCustomerTags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubCustomerNewTagResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubCustomerNewTagResponse input)
        {
            if (input == null) return false;
            if (this.NewCustomerTags != input.NewCustomerTags || (this.NewCustomerTags != null && input.NewCustomerTags != null && !this.NewCustomerTags.SequenceEqual(input.NewCustomerTags))) return false;

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
                if (this.NewCustomerTags != null) hashCode = hashCode * 59 + this.NewCustomerTags.GetHashCode();
                return hashCode;
            }
        }
    }
}
