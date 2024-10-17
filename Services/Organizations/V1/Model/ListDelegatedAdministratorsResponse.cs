using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDelegatedAdministratorsResponse : SdkResponse
    {

        /// <summary>
        /// 组织中委托管理员列表。
        /// </summary>
        [JsonProperty("delegated_administrators", NullValueHandling = NullValueHandling.Ignore)]
        public List<DelegatedAdministratorDto> DelegatedAdministrators { get; set; }

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
            sb.Append("class ListDelegatedAdministratorsResponse {\n");
            sb.Append("  delegatedAdministrators: ").Append(DelegatedAdministrators).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDelegatedAdministratorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDelegatedAdministratorsResponse input)
        {
            if (input == null) return false;
            if (this.DelegatedAdministrators != input.DelegatedAdministrators || (this.DelegatedAdministrators != null && input.DelegatedAdministrators != null && !this.DelegatedAdministrators.SequenceEqual(input.DelegatedAdministrators))) return false;
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
                if (this.DelegatedAdministrators != null) hashCode = hashCode * 59 + this.DelegatedAdministrators.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
