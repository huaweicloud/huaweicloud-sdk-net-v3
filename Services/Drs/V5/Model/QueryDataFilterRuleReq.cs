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
    /// 查询数据过滤规则请求
    /// </summary>
    public class QueryDataFilterRuleReq 
    {

        /// <summary>
        /// 数据过滤类型，取值分别是common、config。common表示简单条件过滤， config表示关联表过滤
        /// </summary>
        [JsonProperty("filter_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterType { get; set; }

        /// <summary>
        /// 标记是否查询全部过滤规则（含已同步和未下发的），即 true（查询所有）、false（仅查询已同步）
        /// </summary>
        [JsonProperty("is_all_rules", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAllRules { get; set; }

        /// <summary>
        /// 查询返回记录的数量限制。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量，表示查询该偏移量后面的记录。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDataFilterRuleReq {\n");
            sb.Append("  filterType: ").Append(FilterType).Append("\n");
            sb.Append("  isAllRules: ").Append(IsAllRules).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryDataFilterRuleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryDataFilterRuleReq input)
        {
            if (input == null) return false;
            if (this.FilterType != input.FilterType || (this.FilterType != null && !this.FilterType.Equals(input.FilterType))) return false;
            if (this.IsAllRules != input.IsAllRules || (this.IsAllRules != null && !this.IsAllRules.Equals(input.IsAllRules))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.FilterType != null) hashCode = hashCode * 59 + this.FilterType.GetHashCode();
                if (this.IsAllRules != null) hashCode = hashCode * 59 + this.IsAllRules.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
