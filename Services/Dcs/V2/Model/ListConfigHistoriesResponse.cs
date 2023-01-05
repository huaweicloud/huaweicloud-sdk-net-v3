using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListConfigHistoriesResponse : SdkResponse
    {

        /// <summary>
        /// 实例参数修改记录个数
        /// </summary>
        [JsonProperty("history_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? HistoryNum { get; set; }

        /// <summary>
        /// 实力参数修改记录详情
        /// </summary>
        [JsonProperty("histories", NullValueHandling = NullValueHandling.Ignore)]
        public List<HistoryInfo> Histories { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConfigHistoriesResponse {\n");
            sb.Append("  historyNum: ").Append(HistoryNum).Append("\n");
            sb.Append("  histories: ").Append(Histories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConfigHistoriesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConfigHistoriesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HistoryNum == input.HistoryNum ||
                    (this.HistoryNum != null &&
                    this.HistoryNum.Equals(input.HistoryNum))
                ) && 
                (
                    this.Histories == input.Histories ||
                    this.Histories != null &&
                    input.Histories != null &&
                    this.Histories.SequenceEqual(input.Histories)
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
                if (this.HistoryNum != null)
                    hashCode = hashCode * 59 + this.HistoryNum.GetHashCode();
                if (this.Histories != null)
                    hashCode = hashCode * 59 + this.Histories.GetHashCode();
                return hashCode;
            }
        }
    }
}
