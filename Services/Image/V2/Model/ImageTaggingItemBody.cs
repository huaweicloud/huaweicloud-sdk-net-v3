using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageTaggingItemBody 
    {

        /// <summary>
        /// 置信度，将Float型置信度转为String类型返回,取值范围：0-100。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public string Confidence { get; set; }

        /// <summary>
        /// 标签的类别。返回的标签类型，包含二十多种大类，具体可以参考[图像标签](http://support.huaweicloud.com/image_faq/image_01_0037.html)。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 标签名称。
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("i18n_tag", NullValueHandling = NullValueHandling.Ignore)]
        public ImageTaggingItemBodyI18nTag I18nTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("i18n_type", NullValueHandling = NullValueHandling.Ignore)]
        public ImageTaggingItemBodyI18nType I18nType { get; set; }

        /// <summary>
        /// 目标检测框信息(该服务不返回目标检测信息)。
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageTaggingInstance> Instances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageTaggingItemBody {\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  i18nTag: ").Append(I18nTag).Append("\n");
            sb.Append("  i18nType: ").Append(I18nType).Append("\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageTaggingItemBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageTaggingItemBody input)
        {
            if (input == null) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.I18nTag != input.I18nTag || (this.I18nTag != null && !this.I18nTag.Equals(input.I18nTag))) return false;
            if (this.I18nType != input.I18nType || (this.I18nType != null && !this.I18nType.Equals(input.I18nType))) return false;
            if (this.Instances != input.Instances || (this.Instances != null && input.Instances != null && !this.Instances.SequenceEqual(input.Instances))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.I18nTag != null) hashCode = hashCode * 59 + this.I18nTag.GetHashCode();
                if (this.I18nType != null) hashCode = hashCode * 59 + this.I18nType.GetHashCode();
                if (this.Instances != null) hashCode = hashCode * 59 + this.Instances.GetHashCode();
                return hashCode;
            }
        }
    }
}
