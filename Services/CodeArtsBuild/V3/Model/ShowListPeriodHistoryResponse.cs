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
    /// Response Object
    /// </summary>
    public class ShowListPeriodHistoryResponse : SdkResponse
    {

        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 构建历史列表
        /// </summary>
        [JsonProperty("history_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<HistoryRecord1> HistoryRecords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowListPeriodHistoryResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  historyRecords: ").Append(HistoryRecords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowListPeriodHistoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowListPeriodHistoryResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.HistoryRecords != input.HistoryRecords || (this.HistoryRecords != null && input.HistoryRecords != null && !this.HistoryRecords.SequenceEqual(input.HistoryRecords))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.HistoryRecords != null) hashCode = hashCode * 59 + this.HistoryRecords.GetHashCode();
                return hashCode;
            }
        }
    }
}
