using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 转推参数
    /// </summary>
    public class PublishParam 
    {

        /// <summary>
        /// 合流任务完成后，转推的RTMP推流地址。
        /// </summary>
        [JsonProperty("rtmp_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RtmpUrls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishParam {\n");
            sb.Append("  rtmpUrls: ").Append(RtmpUrls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublishParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublishParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RtmpUrls == input.RtmpUrls ||
                    this.RtmpUrls != null &&
                    input.RtmpUrls != null &&
                    this.RtmpUrls.SequenceEqual(input.RtmpUrls)
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
                if (this.RtmpUrls != null)
                    hashCode = hashCode * 59 + this.RtmpUrls.GetHashCode();
                return hashCode;
            }
        }
    }
}
