using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowClusterAccessKeyListRequest 
    {

        /// <summary>
        /// 密码集群ID
        /// </summary>
        [SDKProperty("cluster_id", IsPath = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 指定查询返回记录条数，默认值10
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 索引位置，从page_num指定的下一条数据开始查询默认值为0
        /// </summary>
        [SDKProperty("page_num", IsQuery = true)]
        [JsonProperty("page_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNum { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [SDKProperty("app_name", IsQuery = true)]
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 排序属性，目前支持以下属性： - **create_time** : 应用的创建时间（默认）
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// 排序方向，支持以下值： - **DESC** : 降序（默认） - **ASC** : 升序
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowClusterAccessKeyListRequest {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  pageNum: ").Append(PageNum).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowClusterAccessKeyListRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowClusterAccessKeyListRequest input)
        {
            if (input == null) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.PageNum != input.PageNum || (this.PageNum != null && !this.PageNum.Equals(input.PageNum))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;

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
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.PageNum != null) hashCode = hashCode * 59 + this.PageNum.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                return hashCode;
            }
        }
    }
}
