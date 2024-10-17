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
    public class ShowListHistoryResponse : SdkResponse
    {

        /// <summary>
        /// 构建历史列表
        /// </summary>
        [JsonProperty("history_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<HistoryRecord> HistoryRecords { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowListHistoryResponse {\n");
            sb.Append("  historyRecords: ").Append(HistoryRecords).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowListHistoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowListHistoryResponse input)
        {
            if (input == null) return false;
            if (this.HistoryRecords != input.HistoryRecords || (this.HistoryRecords != null && input.HistoryRecords != null && !this.HistoryRecords.SequenceEqual(input.HistoryRecords))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.HistoryRecords != null) hashCode = hashCode * 59 + this.HistoryRecords.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
