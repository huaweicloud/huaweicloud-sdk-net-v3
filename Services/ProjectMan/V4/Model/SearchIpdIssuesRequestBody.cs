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
    public class SearchIpdIssuesRequestBody 
    {

        /// <summary>
        /// 过滤条件
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, ConditionVO>> Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoVO Page { get; set; }

        /// <summary>
        /// 返回字段
        /// </summary>
        [JsonProperty("return_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReturnFields { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public List<SortInfo> Sort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchIpdIssuesRequestBody {\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  returnFields: ").Append(ReturnFields).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchIpdIssuesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchIpdIssuesRequestBody input)
        {
            if (input == null) return false;
            if (this.Filter != input.Filter || (this.Filter != null && input.Filter != null && !this.Filter.SequenceEqual(input.Filter))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.ReturnFields != input.ReturnFields || (this.ReturnFields != null && input.ReturnFields != null && !this.ReturnFields.SequenceEqual(input.ReturnFields))) return false;
            if (this.Sort != input.Sort || (this.Sort != null && input.Sort != null && !this.Sort.SequenceEqual(input.Sort))) return false;

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
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.ReturnFields != null) hashCode = hashCode * 59 + this.ReturnFields.GetHashCode();
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                return hashCode;
            }
        }
    }
}
