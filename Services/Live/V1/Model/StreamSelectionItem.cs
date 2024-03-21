using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 从全量流中过滤出一个码率在[min, max]区间的流。如果不需要码率过滤可不选。
    /// </summary>
    public class StreamSelectionItem 
    {

        /// <summary>
        /// 拉流URL中用于码率过滤的参数
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 最小码率，单位：bps 取值范围：0 - 104,857,600（100Mbps）
        /// </summary>
        [JsonProperty("max_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxBandwidth { get; set; }

        /// <summary>
        /// 最小码率，单位：bps 取值范围：0 - 104,857,600（100Mbps）
        /// </summary>
        [JsonProperty("min_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinBandwidth { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamSelectionItem {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  maxBandwidth: ").Append(MaxBandwidth).Append("\n");
            sb.Append("  minBandwidth: ").Append(MinBandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StreamSelectionItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StreamSelectionItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.MaxBandwidth == input.MaxBandwidth ||
                    (this.MaxBandwidth != null &&
                    this.MaxBandwidth.Equals(input.MaxBandwidth))
                ) && 
                (
                    this.MinBandwidth == input.MinBandwidth ||
                    (this.MinBandwidth != null &&
                    this.MinBandwidth.Equals(input.MinBandwidth))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.MaxBandwidth != null)
                    hashCode = hashCode * 59 + this.MaxBandwidth.GetHashCode();
                if (this.MinBandwidth != null)
                    hashCode = hashCode * 59 + this.MinBandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
