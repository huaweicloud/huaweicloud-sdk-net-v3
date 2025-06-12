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
    /// 
    /// </summary>
    public class LiveEvent 
    {

        /// <summary>
        /// **参数解释**： 事件戳。从1970-01-01 00:00:00:000开始的毫秒数
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// **参数解释**： 事件类型。 * 1 弹幕信息 * 2 用户入场 * 3 用户点赞 * 4 用户送礼 * 5 用户订阅\\关注 * 6 房间观看人数
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// 事件内容。 事件类型不同，content内容也不同，定义如下所示： - type&#x3D;1 弹幕信息   content定义：     * user:用户，json     * content: string,弹幕内容     user定义：     * userId：用户id，string     * name：用户姓名，string     * level：用户平台等级，int     * badge：用户牌子名称，string     * badgeLevel：牌子等级，int     举例：   &#x60;&#x60;&#x60;json   {     \&quot;timestamp\&quot;: 1694481224245,     \&quot;type\&quot;: 1,     \&quot;content\&quot;: \&quot;{\\\&quot;user\\\&quot;:{\\\&quot;userId\\\&quot;:\\\&quot;2027271526\\\&quot;,\\\&quot;name\\\&quot;:\\\&quot;***\\\&quot;,\\\&quot;level\\\&quot;:17,\\\&quot;badge\\\&quot;:\\\&quot;\\\&quot;,\\\&quot;badgeLevel\\\&quot;:0},\\\&quot;content\\\&quot;:\\\&quot;***\\\&quot;}\&quot;   }   &#x60;&#x60;&#x60; - type&#x3D;2 用户入场   content定义：     * user:用户，json     举例：   &#x60;&#x60;&#x60;json   {     \&quot;timestamp\&quot;: 1694481227655,     \&quot;type\&quot;: 2,     \&quot;content\&quot;: \&quot;{\\\&quot;user\\\&quot;:{\\\&quot;userId\\\&quot;:\\\&quot;2978899271\\\&quot;,\\\&quot;name\\\&quot;:\\\&quot;***\\\&quot;,\\\&quot;level\\\&quot;:1,\\\&quot;badge\\\&quot;:\\\&quot;\\\&quot;,\\\&quot;badgeLevel\\\&quot;:0}}\&quot;   }   &#x60;&#x60;&#x60; - type&#x3D;3 用户点赞    content定义：     * user：用户，json     举例：   &#x60;&#x60;&#x60;json   {     \&quot;timestamp\&quot;: 1694481227655,     \&quot;type\&quot;: 2,     \&quot;content\&quot;: \&quot;{\\\&quot;user\\\&quot;:{\\\&quot;userId\\\&quot;:\\\&quot;2978899271\\\&quot;,\\\&quot;name\\\&quot;:\\\&quot;***\\\&quot;,\\\&quot;level\\\&quot;:1,\\\&quot;badge\\\&quot;:\\\&quot;\\\&quot;,\\\&quot;badgeLevel\\\&quot;:0}}\&quot;   }   &#x60;&#x60;&#x60; - type&#x3D;4 用户送礼   content定义：     * user：用户，json     * gift：礼物信息,json     gift定义：     * giftName：礼物名称，string     * giftNum：礼物数量，int     * totalValue：此处礼物总价值，int     * giftValue：单个礼物价值，int     举例：   &#x60;&#x60;&#x60;json   {     \&quot;timestamp\&quot;: 1690531652862,     \&quot;type\&quot;: 4,     \&quot;content\&quot;: \&quot;{\\\&quot;gift\\\&quot;:{\\\&quot;giftName\\\&quot;:\\\&quot;小星星\\\&quot;,\\\&quot;giftNum\\\&quot;:10,\\\&quot;totalValue\\\&quot;:10,\\\&quot;giftValue\\\&quot;:3},\\\&quot;user\\\&quot;:{\\\&quot;userId\\\&quot;:\\\&quot;douyin_95882940927\\\&quot;,\\\&quot;name\\\&quot;:\\\&quot;纯爱战士熙熙\\\&quot;,\\\&quot;level\\\&quot;:2,\\\&quot;badge\\\&quot;:\\\&quot;\\\&quot;,\\\&quot;badgeLevel\\\&quot;:0}}\&quot;   }   &#x60;&#x60;&#x60; - type&#x3D;5 用户订阅    暂未使用 - type&#x3D;6 房间观看人数   content定义：     * numberOfViewers：房间观看人数，int     举例：   &#x60;&#x60;&#x60;json   {     \&quot;timestamp\&quot;: 1694481236886,     \&quot;type\&quot;: 6,     \&quot;content\&quot;: \&quot;{\\\&quot;numberOfViewers\\\&quot;:5466}\&quot;   }   &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveEvent {\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveEvent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveEvent input)
        {
            if (input == null) return false;
            if (this.Timestamp != input.Timestamp || (this.Timestamp != null && !this.Timestamp.Equals(input.Timestamp))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;

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
                if (this.Timestamp != null) hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }
}
