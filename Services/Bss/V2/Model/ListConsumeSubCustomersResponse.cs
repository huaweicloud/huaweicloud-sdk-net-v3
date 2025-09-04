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
    public class ListConsumeSubCustomersResponse : SdkResponse
    {

        /// <summary>
        /// 子客户列表。 具体请参见表SubCustomerInfo。
        /// </summary>
        [JsonProperty("sub_customers", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubCustomerInfoV3> SubCustomers { get; set; }

        /// <summary>
        /// 结果集数量，只有成功才返回这个参数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConsumeSubCustomersResponse {\n");
            sb.Append("  subCustomers: ").Append(SubCustomers).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConsumeSubCustomersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConsumeSubCustomersResponse input)
        {
            if (input == null) return false;
            if (this.SubCustomers != input.SubCustomers || (this.SubCustomers != null && input.SubCustomers != null && !this.SubCustomers.SequenceEqual(input.SubCustomers))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.SubCustomers != null) hashCode = hashCode * 59 + this.SubCustomers.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
