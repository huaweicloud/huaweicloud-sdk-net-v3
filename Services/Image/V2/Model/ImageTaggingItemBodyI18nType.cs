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
    /// 标签类别的多种语言输出。
    /// </summary>
    public class ImageTaggingItemBodyI18nType 
    {

        /// <summary>
        /// 中文标签类别
        /// </summary>
        [JsonProperty("zh", NullValueHandling = NullValueHandling.Ignore)]
        public string Zh { get; set; }

        /// <summary>
        /// 英文标签类别
        /// </summary>
        [JsonProperty("en", NullValueHandling = NullValueHandling.Ignore)]
        public string En { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageTaggingItemBodyI18nType {\n");
            sb.Append("  zh: ").Append(Zh).Append("\n");
            sb.Append("  en: ").Append(En).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageTaggingItemBodyI18nType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageTaggingItemBodyI18nType input)
        {
            if (input == null) return false;
            if (this.Zh != input.Zh || (this.Zh != null && !this.Zh.Equals(input.Zh))) return false;
            if (this.En != input.En || (this.En != null && !this.En.Equals(input.En))) return false;

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
                if (this.Zh != null) hashCode = hashCode * 59 + this.Zh.GetHashCode();
                if (this.En != null) hashCode = hashCode * 59 + this.En.GetHashCode();
                return hashCode;
            }
        }
    }
}
