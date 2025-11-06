using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDashBoardsResponse : SdkResponse
    {

        /// <summary>
        /// 当前页大小。
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 仪表盘详情列表。
        /// </summary>
        [JsonProperty("dashboards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dashboard> Dashboards { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDashBoardsResponse {\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  dashboards: ").Append(Dashboards).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDashBoardsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDashBoardsResponse input)
        {
            if (input == null) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Dashboards != input.Dashboards || (this.Dashboards != null && input.Dashboards != null && !this.Dashboards.SequenceEqual(input.Dashboards))) return false;

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
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Dashboards != null) hashCode = hashCode * 59 + this.Dashboards.GetHashCode();
                return hashCode;
            }
        }
    }
}
