using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 包周期云硬盘退订的结果
    /// </summary>
    public class UnsubscribeVolume 
    {

        /// <summary>
        /// 卷id对应的结果
        /// </summary>
        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }

        /// <summary>
        /// 卷id对应的退订订单id，如果是已到期的云硬盘退订，则不显示此字段。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// volume_id对应的退订结果，只有SUCCESS 和 FAIL两种结果。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 当result为FAIL时，此字段显示具体的失败原因。 result为SUCCESS时，不显示此字段。
        /// </summary>
        [JsonProperty("fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnsubscribeVolume {\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  failReason: ").Append(FailReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnsubscribeVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnsubscribeVolume input)
        {
            if (input == null) return false;
            if (this.VolumeId != input.VolumeId || (this.VolumeId != null && !this.VolumeId.Equals(input.VolumeId))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.FailReason != input.FailReason || (this.FailReason != null && !this.FailReason.Equals(input.FailReason))) return false;

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
                if (this.VolumeId != null) hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.FailReason != null) hashCode = hashCode * 59 + this.FailReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
