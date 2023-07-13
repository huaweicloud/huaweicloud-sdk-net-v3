using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V2.Model
{
    /// <summary>
    /// 反黄，暴恐检测详情
    /// </summary>
    public class ImageDetectionResultSimpleDetail 
    {

        /// <summary>
        /// 置信度，取值范围 0-1。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// 每个检测结果的标签化说明： - terrorism：label为对应的涉政暴恐元素信息。 - 涉政暴恐场景当前支持label列表如下：   - normal：正常   - knife：刀   - gun：枪   - fire：火灾   - bloody ：血腥   - terrorist：暴恐组织及标志   - fascist：法西斯组织及标志   - cult：邪教组织及标志   - negative_politics ：涉政负面组织及标志   - negative_political_events：涉政负面事件及标志   - special_characters ：特殊文字   - kidnap：绑架   - corpse：尸体   - riot：暴乱事件   - parade ：游行示威   - sensitive_landmarks：敏感地标   - military_weapon：军事武器   - army：警察部队   - positive_politics：涉政正面组织及标志   - crowd：人群聚集 - porn：label为对应的涉黄分类（涉黄、性感等）信息。 - 鉴黄场景当前支持label列表如下：   - normal：正常   - porn：色情   - sexy：性感 
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDetectionResultSimpleDetail {\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageDetectionResultSimpleDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageDetectionResultSimpleDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                return hashCode;
            }
        }
    }
}
