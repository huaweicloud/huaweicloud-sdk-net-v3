using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 查询可用链路信息响应体
    /// </summary>
    public class SupportLinksResp 
    {

        /// <summary>
        /// 列表中的项目总数，与分页无关。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 支持的链路
        /// </summary>
        [JsonProperty("support_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<SupportLinkInfo> SupportLinks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportLinksResp {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  supportLinks: ").Append(SupportLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SupportLinksResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SupportLinksResp input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.SupportLinks != input.SupportLinks || (this.SupportLinks != null && input.SupportLinks != null && !this.SupportLinks.SequenceEqual(input.SupportLinks))) return false;

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
                if (this.SupportLinks != null) hashCode = hashCode * 59 + this.SupportLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
