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
    public class AudioInfo 
    {

        /// <summary>
        /// **参数解释**： 音频id。 &gt; * 获取方式：剧本为音频驱动时，查询剧本详情或者更新剧本会返回audio_id  **约束限制**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("audio_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudioId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioInfo {\n");
            sb.Append("  audioId: ").Append(AudioId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioInfo input)
        {
            if (input == null) return false;
            if (this.AudioId != input.AudioId || (this.AudioId != null && !this.AudioId.Equals(input.AudioId))) return false;

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
                if (this.AudioId != null) hashCode = hashCode * 59 + this.AudioId.GetHashCode();
                return hashCode;
            }
        }
    }
}
