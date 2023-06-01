using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 媒资审核参数
    /// </summary>
    public class Review 
    {

        /// <summary>
        /// 审核模板ID。您可以在视频点播控制台配置审核模板后获取，具体请参见[审核设置](https://support.huaweicloud.com/usermanual-vod/vod_01_0057.html)。
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 截图检测时间间隔，取值范围为[0,100]，该参数在请求参数中忽略。 置信度越高，说明审核结果越可信。未开启或设置为0时，表示不进行此项检测。
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// 鉴政内容检测置信度，取值范围为[0,100]，该参数在请求参数中忽略。 置信度越高，说明审核结果越可信。未开启或设置为0时，表示不进行此项检测。
        /// </summary>
        [JsonProperty("politics", NullValueHandling = NullValueHandling.Ignore)]
        public int? Politics { get; set; }

        /// <summary>
        /// 鉴恐内容的检测置信度，取值范围为[0,100]，该参数在请求参数中忽略。 置信度越高，说明审核结果越可信。未开启或设置为0时，表示不进行此项检测。
        /// </summary>
        [JsonProperty("terrorism", NullValueHandling = NullValueHandling.Ignore)]
        public int? Terrorism { get; set; }

        /// <summary>
        /// 鉴黄内容的检测置信度，取值范围为[0,100]，该参数在请求参数中忽略。 置信度越高，说明审核结果越可信。未开启或设置为0时，表示不进行此项检测。  
        /// </summary>
        [JsonProperty("porn", NullValueHandling = NullValueHandling.Ignore)]
        public int? Porn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Review {\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  politics: ").Append(Politics).Append("\n");
            sb.Append("  terrorism: ").Append(Terrorism).Append("\n");
            sb.Append("  porn: ").Append(Porn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Review);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Review input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.Politics == input.Politics ||
                    (this.Politics != null &&
                    this.Politics.Equals(input.Politics))
                ) && 
                (
                    this.Terrorism == input.Terrorism ||
                    (this.Terrorism != null &&
                    this.Terrorism.Equals(input.Terrorism))
                ) && 
                (
                    this.Porn == input.Porn ||
                    (this.Porn != null &&
                    this.Porn.Equals(input.Porn))
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
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Politics != null)
                    hashCode = hashCode * 59 + this.Politics.GetHashCode();
                if (this.Terrorism != null)
                    hashCode = hashCode * 59 + this.Terrorism.GetHashCode();
                if (this.Porn != null)
                    hashCode = hashCode * 59 + this.Porn.GetHashCode();
                return hashCode;
            }
        }
    }
}
