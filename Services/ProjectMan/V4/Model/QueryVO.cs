using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryVO 
    {

        /// <summary>
        /// 查询过滤器
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, ConditionVO>> Filter { get; set; }

        /// <summary>
        /// 过滤模式
        /// </summary>
        [JsonProperty("filter_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoVO Page { get; set; }

        /// <summary>
        /// 排序条件
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public List<SortInfo> Sort { get; set; }

        /// <summary>
        /// 返回字段
        /// </summary>
        [JsonProperty("return_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReturnFields { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryVO {\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  filterMode: ").Append(FilterMode).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  returnFields: ").Append(ReturnFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryVO input)
        {
            if (input == null) return false;
            if (this.Filter != input.Filter || (this.Filter != null && input.Filter != null && !this.Filter.SequenceEqual(input.Filter))) return false;
            if (this.FilterMode != input.FilterMode || (this.FilterMode != null && !this.FilterMode.Equals(input.FilterMode))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.Sort != input.Sort || (this.Sort != null && input.Sort != null && !this.Sort.SequenceEqual(input.Sort))) return false;
            if (this.ReturnFields != input.ReturnFields || (this.ReturnFields != null && input.ReturnFields != null && !this.ReturnFields.SequenceEqual(input.ReturnFields))) return false;

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
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.FilterMode != null) hashCode = hashCode * 59 + this.FilterMode.GetHashCode();
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.ReturnFields != null) hashCode = hashCode * 59 + this.ReturnFields.GetHashCode();
                return hashCode;
            }
        }
    }
}
