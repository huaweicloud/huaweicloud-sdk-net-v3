using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterPortalAPI.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAccountAgenciesResponse : SdkResponse
    {

        /// <summary>
        /// 满足查询条件的委托或信任委托对象列表
        /// </summary>
        [JsonProperty("agency_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AgencyInfo> AgencyList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoDto PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAccountAgenciesResponse {\n");
            sb.Append("  agencyList: ").Append(AgencyList).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAccountAgenciesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAccountAgenciesResponse input)
        {
            if (input == null) return false;
            if (this.AgencyList != input.AgencyList || (this.AgencyList != null && input.AgencyList != null && !this.AgencyList.SequenceEqual(input.AgencyList))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.AgencyList != null) hashCode = hashCode * 59 + this.AgencyList.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
