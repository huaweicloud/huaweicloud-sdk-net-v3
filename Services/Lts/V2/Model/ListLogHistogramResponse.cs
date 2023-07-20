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
    public class ListLogHistogramResponse : SdkResponse
    {

        /// <summary>
        /// 直方图结果
        /// </summary>
        [JsonProperty("histogram", NullValueHandling = NullValueHandling.Ignore)]
        public string Histogram { get; set; }

        /// <summary>
        /// 日志条数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// 是否查询完成。
        /// </summary>
        [JsonProperty("isQueryComplete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsQueryComplete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLogHistogramResponse {\n");
            sb.Append("  histogram: ").Append(Histogram).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  isQueryComplete: ").Append(IsQueryComplete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLogHistogramResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLogHistogramResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Histogram == input.Histogram ||
                    (this.Histogram != null &&
                    this.Histogram.Equals(input.Histogram))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.IsQueryComplete == input.IsQueryComplete ||
                    (this.IsQueryComplete != null &&
                    this.IsQueryComplete.Equals(input.IsQueryComplete))
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
                if (this.Histogram != null)
                    hashCode = hashCode * 59 + this.Histogram.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.IsQueryComplete != null)
                    hashCode = hashCode * 59 + this.IsQueryComplete.GetHashCode();
                return hashCode;
            }
        }
    }
}
