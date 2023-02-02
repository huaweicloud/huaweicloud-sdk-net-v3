using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInstanceExtendProductInfoResponse : SdkResponse
    {

        /// <summary>
        /// 表示[按需付费的](tag:hc,hk,hws,hws_hk,hws_ocb,ctc,sbc,hk_sbc,cmcc,g42,tm)产品列表。
        /// </summary>
        [JsonProperty("hourly", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowInstanceExtendProductInfoRespHourly> Hourly { get; set; }

        /// <summary>
        /// 表示包年包月的产品列表。当前暂不支持通过API创建包年包月的Kafka实例。
        /// </summary>
        [JsonProperty("monthly", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowInstanceExtendProductInfoRespHourly> Monthly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceExtendProductInfoResponse {\n");
            sb.Append("  hourly: ").Append(Hourly).Append("\n");
            sb.Append("  monthly: ").Append(Monthly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceExtendProductInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceExtendProductInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hourly == input.Hourly ||
                    this.Hourly != null &&
                    input.Hourly != null &&
                    this.Hourly.SequenceEqual(input.Hourly)
                ) && 
                (
                    this.Monthly == input.Monthly ||
                    this.Monthly != null &&
                    input.Monthly != null &&
                    this.Monthly.SequenceEqual(input.Monthly)
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
                if (this.Hourly != null)
                    hashCode = hashCode * 59 + this.Hourly.GetHashCode();
                if (this.Monthly != null)
                    hashCode = hashCode * 59 + this.Monthly.GetHashCode();
                return hashCode;
            }
        }
    }
}
