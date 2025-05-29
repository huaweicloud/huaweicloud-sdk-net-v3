using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 返回结果
    /// </summary>
    public class ShowImageTemplateListResponseBodyResult 
    {

        /// <summary>
        /// 镜像模版列表
        /// </summary>
        [JsonProperty("image_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowImageTemplateListResponseBodyResultImageTemplates> ImageTemplates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowImageTemplateListResponseBodyResult {\n");
            sb.Append("  imageTemplates: ").Append(ImageTemplates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowImageTemplateListResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowImageTemplateListResponseBodyResult input)
        {
            if (input == null) return false;
            if (this.ImageTemplates != input.ImageTemplates || (this.ImageTemplates != null && input.ImageTemplates != null && !this.ImageTemplates.SequenceEqual(input.ImageTemplates))) return false;

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
                if (this.ImageTemplates != null) hashCode = hashCode * 59 + this.ImageTemplates.GetHashCode();
                return hashCode;
            }
        }
    }
}
