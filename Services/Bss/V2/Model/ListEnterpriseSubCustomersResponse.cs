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
    public class ListEnterpriseSubCustomersResponse : SdkResponse
    {

        /// <summary>
        /// 结果集数量，成功才有。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 客户信息列表，成功才有。 具体请参见表2。
        /// </summary>
        [JsonProperty("sub_customer_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubCustomerInfoV2> SubCustomerInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnterpriseSubCustomersResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  subCustomerInfos: ").Append(SubCustomerInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnterpriseSubCustomersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnterpriseSubCustomersResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.SubCustomerInfos != input.SubCustomerInfos || (this.SubCustomerInfos != null && input.SubCustomerInfos != null && !this.SubCustomerInfos.SequenceEqual(input.SubCustomerInfos))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.SubCustomerInfos != null) hashCode = hashCode * 59 + this.SubCustomerInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
