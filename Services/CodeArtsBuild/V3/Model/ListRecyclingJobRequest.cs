using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListRecyclingJobRequest 
    {

        /// <summary>
        /// 每页显示的条目数量，page_size小于等于100
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 分页页码， 表示从此页开始查询， page_no大于等于1
        /// </summary>
        [SDKProperty("page_no", IsQuery = true)]
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 搜索的任务名称
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRecyclingJobRequest {\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRecyclingJobRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRecyclingJobRequest input)
        {
            if (input == null) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;

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
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                return hashCode;
            }
        }
    }
}
