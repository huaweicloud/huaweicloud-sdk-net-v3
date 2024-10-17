using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 分页请求体
    /// </summary>
    public class PageReq 
    {

        /// <summary>
        /// 当前页, 不能超过item除每页任务数量的最大页 
        /// </summary>
        [JsonProperty("cur_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurPage { get; set; }

        /// <summary>
        /// 每页item数量，填0获取全部item
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageReq {\n");
            sb.Append("  curPage: ").Append(CurPage).Append("\n");
            sb.Append("  perPage: ").Append(PerPage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PageReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PageReq input)
        {
            if (input == null) return false;
            if (this.CurPage != input.CurPage || (this.CurPage != null && !this.CurPage.Equals(input.CurPage))) return false;
            if (this.PerPage != input.PerPage || (this.PerPage != null && !this.PerPage.Equals(input.PerPage))) return false;

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
                if (this.CurPage != null) hashCode = hashCode * 59 + this.CurPage.GetHashCode();
                if (this.PerPage != null) hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                return hashCode;
            }
        }
    }
}
