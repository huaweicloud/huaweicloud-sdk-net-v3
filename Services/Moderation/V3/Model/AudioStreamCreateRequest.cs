using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioStreamCreateRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public AudioStreamCreateRequestData Data { get; set; }

        /// <summary>
        /// 事件类型，可选值如下： default：默认事件 audiobook：有声书 education：教育音频 game：游戏语音房 live：秀场直播 ecommerce：电商直播 voiceroom：交友语音房 private：私密语音聊天
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 需要检测的风险类型，列表不能为空。 porn：涉黄检测 politics: 涉政检测 abuse: 辱骂检测 ad: 广告检测 moan: 娇喘检测
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// 回调http接口，服务将根据该字段回调通知用户审核结果，流未结束时，回调审核违规内容，流结束时，审核片段违规或不违规都将回调客户端。 回调内容如下： &#x60;&#x60;&#x60; {     \&quot;job_id\&quot;:\&quot;xxxxxx\&quot;,     \&quot;status\&quot;:\&quot;running\&quot;, //running - 审核中，succeeded - 审核完成，failed - 审核失败     \&quot;request_id\&quot;:\&quot;2419446b1fe14203f64e4018d12db3dd\&quot;,     \&quot;create_time\&quot;:\&quot;2022-07-30T08:57:11.011Z\&quot;,     \&quot;update_time\&quot;:\&quot;2022-07-30T08:57:14.014Z\&quot;,     \&quot;result\&quot;:{         \&quot;suggestion\&quot;:\&quot;block\&quot;,         \&quot;details\&quot;:[             {                 \&quot;suggestion\&quot;:\&quot;block\&quot;,                 \&quot;label\&quot;:\&quot;politics\&quot;,                 \&quot;audio_text\&quot;:\&quot;xxxx\&quot;,                 \&quot;start_time\&quot;:\&quot;2022-07-30T08:57:11.011Z\&quot;, // 当前音频片段开始的绝对时间                 \&quot;end_time\&quot;:\&quot;2022-07-30T08:57:21.011Z\&quot;,     // 当前音频片段结束的绝对时间                 \&quot;segments\&quot;:[                     {                         \&quot;segment\&quot;:\&quot;xxx\&quot;                     },                     {                         \&quot;segment\&quot;:\&quot;xxx\&quot;                     },                     {                         \&quot;segment\&quot;:\&quot;xxx\&quot;                     }                 ]             }         ],         \&quot;request_params\&quot;:{             \&quot;event_type\&quot;:\&quot;default\&quot;,             \&quot;data\&quot;:{                 \&quot;url\&quot;:\&quot;rtmp://xxxx\&quot;             },             \&quot;callback\&quot;:\&quot;http://xxx\&quot;,             \&quot;categories\&quot;:[                 \&quot;porn\&quot;,                 \&quot;ad\&quot;             ]         }     } }
        /// </summary>
        [JsonProperty("callback", NullValueHandling = NullValueHandling.Ignore)]
        public string Callback { get; set; }

        /// <summary>
        /// 用于回调通知时校验请求由华为云内容安全服务发起，由您自定义。随机字符串，由英文字母、数字、下划线组成，不超过64个字符。 说明：当seed非空时，headers中将包含X-Auth-Signature字段，字段的值使用HmacSHA256算法生成，待加密字符串由create_time、job_id、request_id、seed按照顺序拼接而成，密钥为seed。
        /// </summary>
        [JsonProperty("seed", NullValueHandling = NullValueHandling.Ignore)]
        public string Seed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioStreamCreateRequest {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  callback: ").Append(Callback).Append("\n");
            sb.Append("  seed: ").Append(Seed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioStreamCreateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioStreamCreateRequest input)
        {
            if (input == null) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.Categories != input.Categories || (this.Categories != null && input.Categories != null && !this.Categories.SequenceEqual(input.Categories))) return false;
            if (this.Callback != input.Callback || (this.Callback != null && !this.Callback.Equals(input.Callback))) return false;
            if (this.Seed != input.Seed || (this.Seed != null && !this.Seed.Equals(input.Seed))) return false;

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
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Categories != null) hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Callback != null) hashCode = hashCode * 59 + this.Callback.GetHashCode();
                if (this.Seed != null) hashCode = hashCode * 59 + this.Seed.GetHashCode();
                return hashCode;
            }
        }
    }
}
