using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// RTC回调事件配置。兼容处理，未携带配置则默认订阅LIVE_PROGRESS
    /// </summary>
    public class RTCLiveEventCallBackConfig 
    {

        /// <summary>
        /// RTC回调的直播事件类型列表。  当前仅支持如下取值： * LIVE_PROGRESS：直播剧本进度通知。  * REPLY_COMMAND_FINISH：回复播放完成通知。  回调事件结构体定义： * message_type：消息类型。 * data：消息描述。   - LIVE_PROGRESS事件回调定义如下：     &#x60;&#x60;&#x60;json     {         \&quot;message_type\&quot;: \&quot;live_progress_notify\&quot;,         \&quot;data\&quot;: {             \&quot;script_name\&quot;: \&quot;场景一\&quot;,             \&quot;shoot_script_sequence_no\&quot;: 2,             \&quot;shoot_script_title\&quot;: \&quot;引导语\&quot;,             \&quot;offset\&quot;: \&quot;247\&quot;,             \&quot;reply_id\&quot;: \&quot;e87104f76d7546ce8a46ac6b04c49c3c\&quot;         }     }     &#x60;&#x60;&#x60;   - REPLY_COMMAND_FINISH回调定义如下：     &#x60;&#x60;&#x60;json     {       \&quot;message_type\&quot;: \&quot;reply_command_finish_notify\&quot;,       \&quot;data\&quot;:\&quot;{         \&quot;reply_id\&quot;:\&quot;e87104f76d7546ce8a46ac6b04c49c3c\&quot;       }\&quot;     }     &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("rtc_callback_event_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RtcCallbackEventType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RTCLiveEventCallBackConfig {\n");
            sb.Append("  rtcCallbackEventType: ").Append(RtcCallbackEventType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RTCLiveEventCallBackConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RTCLiveEventCallBackConfig input)
        {
            if (input == null) return false;
            if (this.RtcCallbackEventType != input.RtcCallbackEventType || (this.RtcCallbackEventType != null && input.RtcCallbackEventType != null && !this.RtcCallbackEventType.SequenceEqual(input.RtcCallbackEventType))) return false;

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
                if (this.RtcCallbackEventType != null) hashCode = hashCode * 59 + this.RtcCallbackEventType.GetHashCode();
                return hashCode;
            }
        }
    }
}
