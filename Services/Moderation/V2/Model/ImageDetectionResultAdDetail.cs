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
    /// 广告检测详情
    /// </summary>
    public class ImageDetectionResultAdDetail 
    {

        /// <summary>
        /// 置信度，取值范围 0-1。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// ad：label为对应的广告识别结果信息 - 广告场景当前支持label列表如下：   - normal：正常   - ad：广告 - 图文审核场景当前支持label列表如下：   - normal：正常   - qr_code：二维   - politics：涉政   - porn：涉黄   - ad：广告   - abuse：辱骂   - contraband：违禁品   - 其他自定义黑库名称 
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 图文审核场景命中的文本列表。
        /// </summary>
        [JsonProperty("hit_contexts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HitContexts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDetectionResultAdDetail {\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  hitContexts: ").Append(HitContexts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageDetectionResultAdDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageDetectionResultAdDetail input)
        {
            if (input == null) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;
            if (this.HitContexts != input.HitContexts || (this.HitContexts != null && input.HitContexts != null && !this.HitContexts.SequenceEqual(input.HitContexts))) return false;

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
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.HitContexts != null) hashCode = hashCode * 59 + this.HitContexts.GetHashCode();
                return hashCode;
            }
        }
    }
}
