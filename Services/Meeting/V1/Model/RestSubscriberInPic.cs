using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 子画面信息。
    /// </summary>
    public class RestSubscriberInPic 
    {

        /// <summary>
        /// 多画面中每个画面的编号。编号从1开始。默认值为“1”。
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public int? Index { get; set; }

        /// <summary>
        /// 每个画面中与会者号码，从[[查询会议实时信息](https://support.huaweicloud.com/api-meeting/meeting_21_0029.html)](tag:hws)[[查询会议实时信息](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0029.html)](tag:hk)接口返回participants中的phone中获取。
        /// </summary>
        [JsonProperty("subscriber", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Subscriber { get; set; }

        /// <summary>
        /// 是否为辅流。默认值为0。 * 0： 不是辅流 * 1： 是辅流 
        /// </summary>
        [JsonProperty("isAssistStream", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAssistStream { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestSubscriberInPic {\n");
            sb.Append("  index: ").Append(Index).Append("\n");
            sb.Append("  subscriber: ").Append(Subscriber).Append("\n");
            sb.Append("  isAssistStream: ").Append(IsAssistStream).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestSubscriberInPic);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestSubscriberInPic input)
        {
            if (input == null) return false;
            if (this.Index != input.Index || (this.Index != null && !this.Index.Equals(input.Index))) return false;
            if (this.Subscriber != input.Subscriber || (this.Subscriber != null && input.Subscriber != null && !this.Subscriber.SequenceEqual(input.Subscriber))) return false;
            if (this.IsAssistStream != input.IsAssistStream || (this.IsAssistStream != null && !this.IsAssistStream.Equals(input.IsAssistStream))) return false;

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
                if (this.Index != null) hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Subscriber != null) hashCode = hashCode * 59 + this.Subscriber.GetHashCode();
                if (this.IsAssistStream != null) hashCode = hashCode * 59 + this.IsAssistStream.GetHashCode();
                return hashCode;
            }
        }
    }
}
