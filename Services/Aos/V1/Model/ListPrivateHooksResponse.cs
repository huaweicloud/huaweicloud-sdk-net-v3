using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPrivateHooksResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// 私有hook的列表。默认以创建时间降序排序。
        /// </summary>
        [JsonProperty("hooks", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrivateHookSummary> Hooks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPrivateHooksResponse {\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("  hooks: ").Append(Hooks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPrivateHooksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPrivateHooksResponse input)
        {
            if (input == null) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;
            if (this.Hooks != input.Hooks || (this.Hooks != null && input.Hooks != null && !this.Hooks.SequenceEqual(input.Hooks))) return false;

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
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                if (this.Hooks != null) hashCode = hashCode * 59 + this.Hooks.GetHashCode();
                return hashCode;
            }
        }
    }
}
