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
    /// 图文审核场景的黑白词库传入参数设置。
    /// </summary>
    public class ImgTextConfig 
    {

        /// <summary>
        /// 检测时使用的自定义黑名单词库列表。
        /// </summary>
        [JsonProperty("black_glossary_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BlackGlossaryNames { get; set; }

        /// <summary>
        /// 检测时使用的自定义白名单词库列表。
        /// </summary>
        [JsonProperty("white_glossary_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WhiteGlossaryNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImgTextConfig {\n");
            sb.Append("  blackGlossaryNames: ").Append(BlackGlossaryNames).Append("\n");
            sb.Append("  whiteGlossaryNames: ").Append(WhiteGlossaryNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImgTextConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImgTextConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlackGlossaryNames == input.BlackGlossaryNames ||
                    this.BlackGlossaryNames != null &&
                    input.BlackGlossaryNames != null &&
                    this.BlackGlossaryNames.SequenceEqual(input.BlackGlossaryNames)
                ) && 
                (
                    this.WhiteGlossaryNames == input.WhiteGlossaryNames ||
                    this.WhiteGlossaryNames != null &&
                    input.WhiteGlossaryNames != null &&
                    this.WhiteGlossaryNames.SequenceEqual(input.WhiteGlossaryNames)
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
                if (this.BlackGlossaryNames != null)
                    hashCode = hashCode * 59 + this.BlackGlossaryNames.GetHashCode();
                if (this.WhiteGlossaryNames != null)
                    hashCode = hashCode * 59 + this.WhiteGlossaryNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
