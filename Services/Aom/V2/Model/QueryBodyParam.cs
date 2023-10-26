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
    /// 
    /// </summary>
    public class QueryBodyParam 
    {

        /// <summary>
        /// 取值范围 app_log,node _log,custom_log 日志类型字段:app_log:应用日志 node_log:主机日志 custom_log:自定义配置路径日志。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 搜索结束时间(UTC时间，毫秒级)。
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 取值范围 0、1 。搜索时是否隐藏系统日志，默认0为隐藏1为显示。
        /// </summary>
        [JsonProperty("hideSyslog", NullValueHandling = NullValueHandling.Ignore)]
        public int? HideSyslog { get; set; }

        /// <summary>
        /// 1.支持关键词精确搜索。关键词指相邻两个分词符之间的单词。 2.支持关键词模糊匹配搜索，例如输入“RROR”或“ERRO?”或“*ROR*”或“ERR*”或“ER*OR”。 3.支持短语精确搜索，例如输入“Start to refresh alm Statistic”。 4.支持关键词的“与”、“或”组合搜索。格式为“query&amp;&amp;logs”或“query||logs”。 说明： 当前默认分词符有  , &#39;\&quot;;&#x3D;()[]{}@&amp;&lt;&gt;/:\\n\\t\\r
        /// </summary>
        [JsonProperty("keyWord", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 日志单行序列号第一次查询时不需要此参数，后续分页查询时需要使用可从上次查询的返回信息中获取.
        /// </summary>
        [JsonProperty("lineNum", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNum { get; set; }

        /// <summary>
        /// 表示每次查询的日志条数不填时默认为5000，建议您设置为100。 第一次查询时使用pageSize 后续分页查询时使用size。
        /// </summary>
        [JsonProperty("pageSize/size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSizeSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("searchKey", NullValueHandling = NullValueHandling.Ignore)]
        public SearchKey SearchKey { get; set; }

        /// <summary>
        /// 搜索起始时间(UTC时间，毫秒级)。
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 表示此次查询为分页查询，第一次查询时不需要此参数，后续分页查询时需要使用。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 标识按照lineNum升序查询还是降序查询。  true：降序（lineNum由大到小：时间从新到老）。  false：升序（lineNum由小到大：即时间从老到新）。
        /// </summary>
        [JsonProperty("isDesc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryBodyParam {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  hideSyslog: ").Append(HideSyslog).Append("\n");
            sb.Append("  keyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("  pageSizeSize: ").Append(PageSizeSize).Append("\n");
            sb.Append("  searchKey: ").Append(SearchKey).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  isDesc: ").Append(IsDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryBodyParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryBodyParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.HideSyslog == input.HideSyslog ||
                    (this.HideSyslog != null &&
                    this.HideSyslog.Equals(input.HideSyslog))
                ) && 
                (
                    this.KeyWord == input.KeyWord ||
                    (this.KeyWord != null &&
                    this.KeyWord.Equals(input.KeyWord))
                ) && 
                (
                    this.LineNum == input.LineNum ||
                    (this.LineNum != null &&
                    this.LineNum.Equals(input.LineNum))
                ) && 
                (
                    this.PageSizeSize == input.PageSizeSize ||
                    (this.PageSizeSize != null &&
                    this.PageSizeSize.Equals(input.PageSizeSize))
                ) && 
                (
                    this.SearchKey == input.SearchKey ||
                    (this.SearchKey != null &&
                    this.SearchKey.Equals(input.SearchKey))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IsDesc == input.IsDesc ||
                    (this.IsDesc != null &&
                    this.IsDesc.Equals(input.IsDesc))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.HideSyslog != null)
                    hashCode = hashCode * 59 + this.HideSyslog.GetHashCode();
                if (this.KeyWord != null)
                    hashCode = hashCode * 59 + this.KeyWord.GetHashCode();
                if (this.LineNum != null)
                    hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                if (this.PageSizeSize != null)
                    hashCode = hashCode * 59 + this.PageSizeSize.GetHashCode();
                if (this.SearchKey != null)
                    hashCode = hashCode * 59 + this.SearchKey.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsDesc != null)
                    hashCode = hashCode * 59 + this.IsDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
