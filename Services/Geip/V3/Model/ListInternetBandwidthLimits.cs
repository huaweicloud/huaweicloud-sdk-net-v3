using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListInternetBandwidthLimits 
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 全域公网带宽的计费模式
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 该类型全域公网带宽可购买的最小size
        /// </summary>
        [JsonProperty("min_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ext_limit", NullValueHandling = NullValueHandling.Ignore)]
        public ExtLimitPojo ExtLimit { get; set; }

        /// <summary>
        /// 该类型全域公网带宽可购买的最大size
        /// </summary>
        [JsonProperty("max_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxSize { get; set; }

        /// <summary>
        /// 全域公网带宽类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInternetBandwidthLimits {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  minSize: ").Append(MinSize).Append("\n");
            sb.Append("  extLimit: ").Append(ExtLimit).Append("\n");
            sb.Append("  maxSize: ").Append(MaxSize).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInternetBandwidthLimits);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInternetBandwidthLimits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ChargeMode == input.ChargeMode ||
                    (this.ChargeMode != null &&
                    this.ChargeMode.Equals(input.ChargeMode))
                ) && 
                (
                    this.MinSize == input.MinSize ||
                    (this.MinSize != null &&
                    this.MinSize.Equals(input.MinSize))
                ) && 
                (
                    this.ExtLimit == input.ExtLimit ||
                    (this.ExtLimit != null &&
                    this.ExtLimit.Equals(input.ExtLimit))
                ) && 
                (
                    this.MaxSize == input.MaxSize ||
                    (this.MaxSize != null &&
                    this.MaxSize.Equals(input.MaxSize))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ChargeMode != null)
                    hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.MinSize != null)
                    hashCode = hashCode * 59 + this.MinSize.GetHashCode();
                if (this.ExtLimit != null)
                    hashCode = hashCode * 59 + this.ExtLimit.GetHashCode();
                if (this.MaxSize != null)
                    hashCode = hashCode * 59 + this.MaxSize.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
