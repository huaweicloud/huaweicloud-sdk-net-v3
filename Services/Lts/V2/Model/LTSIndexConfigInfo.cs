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
    public class LTSIndexConfigInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fullTextIndex", NullValueHandling = NullValueHandling.Ignore)]
        public LTSFullTextIndexInfo FullTextIndex { get; set; }

        /// <summary>
        /// 字段索引配置
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<LTSFieldsInfo> Fields { get; set; }

        /// <summary>
        /// 是否开启可视化
        /// </summary>
        [JsonProperty("sqlAnalysisEnable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SqlAnalysisEnable { get; set; }

        /// <summary>
        /// 日志流id
        /// </summary>
        [JsonProperty("logStreamId", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LTSIndexConfigInfo {\n");
            sb.Append("  fullTextIndex: ").Append(FullTextIndex).Append("\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("  sqlAnalysisEnable: ").Append(SqlAnalysisEnable).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LTSIndexConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LTSIndexConfigInfo input)
        {
            if (input == null) return false;
            if (this.FullTextIndex != input.FullTextIndex || (this.FullTextIndex != null && !this.FullTextIndex.Equals(input.FullTextIndex))) return false;
            if (this.Fields != input.Fields || (this.Fields != null && input.Fields != null && !this.Fields.SequenceEqual(input.Fields))) return false;
            if (this.SqlAnalysisEnable != input.SqlAnalysisEnable || (this.SqlAnalysisEnable != null && !this.SqlAnalysisEnable.Equals(input.SqlAnalysisEnable))) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;

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
                if (this.FullTextIndex != null) hashCode = hashCode * 59 + this.FullTextIndex.GetHashCode();
                if (this.Fields != null) hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.SqlAnalysisEnable != null) hashCode = hashCode * 59 + this.SqlAnalysisEnable.GetHashCode();
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                return hashCode;
            }
        }
    }
}
