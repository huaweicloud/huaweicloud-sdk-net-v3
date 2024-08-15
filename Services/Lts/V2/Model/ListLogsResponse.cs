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
    /// Response Object
    /// </summary>
    public class ListLogsResponse : SdkResponse
    {

        /// <summary>
        /// 日志条数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 日志信息。
        /// </summary>
        [JsonProperty("logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogContents> Logs { get; set; }

        /// <summary>
        /// 是否查询完成。
        /// </summary>
        [JsonProperty("isQueryComplete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsQueryComplete { get; set; }

        /// <summary>
        /// 分析日志返回响应体
        /// </summary>
        [JsonProperty("analysisLogs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, string>> AnalysisLogs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLogsResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  logs: ").Append(Logs).Append("\n");
            sb.Append("  isQueryComplete: ").Append(IsQueryComplete).Append("\n");
            sb.Append("  analysisLogs: ").Append(AnalysisLogs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLogsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Logs == input.Logs ||
                    this.Logs != null &&
                    input.Logs != null &&
                    this.Logs.SequenceEqual(input.Logs)
                ) && 
                (
                    this.IsQueryComplete == input.IsQueryComplete ||
                    (this.IsQueryComplete != null &&
                    this.IsQueryComplete.Equals(input.IsQueryComplete))
                ) && 
                (
                    this.AnalysisLogs == input.AnalysisLogs ||
                    this.AnalysisLogs != null &&
                    input.AnalysisLogs != null &&
                    this.AnalysisLogs.SequenceEqual(input.AnalysisLogs)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Logs != null)
                    hashCode = hashCode * 59 + this.Logs.GetHashCode();
                if (this.IsQueryComplete != null)
                    hashCode = hashCode * 59 + this.IsQueryComplete.GetHashCode();
                if (this.AnalysisLogs != null)
                    hashCode = hashCode * 59 + this.AnalysisLogs.GetHashCode();
                return hashCode;
            }
        }
    }
}
