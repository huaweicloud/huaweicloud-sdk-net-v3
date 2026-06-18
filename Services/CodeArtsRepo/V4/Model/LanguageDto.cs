using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LanguageDto 
    {

        /// <summary>
        /// **参数解释：** 语言名称。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 文件后缀名。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("extension_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExtensionList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanguageDto {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  extensionList: ").Append(ExtensionList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LanguageDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LanguageDto input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ExtensionList != input.ExtensionList || (this.ExtensionList != null && input.ExtensionList != null && !this.ExtensionList.SequenceEqual(input.ExtensionList))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ExtensionList != null) hashCode = hashCode * 59 + this.ExtensionList.GetHashCode();
                return hashCode;
            }
        }
    }
}
