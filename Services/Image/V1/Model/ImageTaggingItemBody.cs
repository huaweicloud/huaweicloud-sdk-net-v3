using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageTaggingItemBody 
    {

        /// <summary>
        /// 置信度，取值范围：0-100。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public string Confidence { get; set; }

        /// <summary>
        /// 标签的类别 object：实体标签 scene：场景标签 concept：概念标签
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
        public ImageTaggingI18nTag I18nTag { get; set; }


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
            if (input == null)
                return false;

            return 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.I18nTag == input.I18nTag ||
                    (this.I18nTag != null &&
                    this.I18nTag.Equals(input.I18nTag))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.I18nTag != null)
                    hashCode = hashCode * 59 + this.I18nTag.GetHashCode();
                return hashCode;
            }
        }
    }
}
