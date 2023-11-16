using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TopnRequstBody 
    {

        /// <summary>
        /// 结束时间时间戳，毫秒时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 是否降序  true / false
        /// </summary>
        [JsonProperty("is_desc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDesc { get; set; }

        /// <summary>
        /// 资源类型，log_group / log_stream / tenant
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 排序依据，index/write/storage/basicTransfer/seniorTransfer/coldStorage，必须是search_list中存在的数据
        /// </summary>
        [JsonProperty("sort_by", NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// 开始时间时间戳，毫秒时间，最多支持30天范围内的查询
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 查询前多少数据，范围1~100
        /// </summary>
        [JsonProperty("topn", NullValueHandling = NullValueHandling.Ignore)]
        public int? Topn { get; set; }

        /// <summary>
        /// 过滤条件 {     \&quot;log_group_id\&quot;: \&quot;xxxxxx\&quot; }过滤器，为一个map结构，键为过滤属性，值为属性值，不支持模糊匹配
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Filter { get; set; }

        /// <summary>
        /// 查询数据类型，字符串数组可多种搭配，只能在index/write/storage/basicTransfer/seniorTransfer/coldStorage中选填
        /// </summary>
        [JsonProperty("search_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SearchList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopnRequstBody {\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  isDesc: ").Append(IsDesc).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  sortBy: ").Append(SortBy).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  topn: ").Append(Topn).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  searchList: ").Append(SearchList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopnRequstBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopnRequstBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.IsDesc == input.IsDesc ||
                    (this.IsDesc != null &&
                    this.IsDesc.Equals(input.IsDesc))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    (this.SortBy != null &&
                    this.SortBy.Equals(input.SortBy))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Topn == input.Topn ||
                    (this.Topn != null &&
                    this.Topn.Equals(input.Topn))
                ) && 
                (
                    this.Filter == input.Filter ||
                    this.Filter != null &&
                    input.Filter != null &&
                    this.Filter.SequenceEqual(input.Filter)
                ) && 
                (
                    this.SearchList == input.SearchList ||
                    this.SearchList != null &&
                    input.SearchList != null &&
                    this.SearchList.SequenceEqual(input.SearchList)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.IsDesc != null)
                    hashCode = hashCode * 59 + this.IsDesc.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.SortBy != null)
                    hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Topn != null)
                    hashCode = hashCode * 59 + this.Topn.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.SearchList != null)
                    hashCode = hashCode * 59 + this.SearchList.GetHashCode();
                return hashCode;
            }
        }
    }
}
