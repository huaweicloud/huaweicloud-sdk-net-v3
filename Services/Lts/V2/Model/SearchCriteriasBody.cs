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
    public class SearchCriteriasBody 
    {

        /// <summary>
        /// 单个日志流的快速查询
        /// </summary>
        [JsonProperty("criterias", NullValueHandling = NullValueHandling.Ignore)]
        public List<GetQuerySearchCriteriasBody> Criterias { get; set; }

        /// <summary>
        /// 日志流id
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// 日志流名称
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// **参数解释：** 快速查询类型。 **取值范围：** - ORIGINALLOG：原始日志 - VISUALIZATION：可视化日志
        /// </summary>
        [JsonProperty("search_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchCriteriasBody {\n");
            sb.Append("  criterias: ").Append(Criterias).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("  searchType: ").Append(SearchType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchCriteriasBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchCriteriasBody input)
        {
            if (input == null) return false;
            if (this.Criterias != input.Criterias || (this.Criterias != null && input.Criterias != null && !this.Criterias.SequenceEqual(input.Criterias))) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;
            if (this.SearchType != input.SearchType || (this.SearchType != null && !this.SearchType.Equals(input.SearchType))) return false;

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
                if (this.Criterias != null) hashCode = hashCode * 59 + this.Criterias.GetHashCode();
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                if (this.SearchType != null) hashCode = hashCode * 59 + this.SearchType.GetHashCode();
                return hashCode;
            }
        }
    }
}
