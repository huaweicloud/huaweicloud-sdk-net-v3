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
    public class BatchDeleteProtectedTagsBodyDto 
    {

        /// <summary>
        /// **参数解释：** 保护Tag名或通配符列表。 **约束限制：** 必填 **取值范围：** 不涉及 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Names { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteProtectedTagsBodyDto {\n");
            sb.Append("  names: ").Append(Names).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteProtectedTagsBodyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteProtectedTagsBodyDto input)
        {
            if (input == null) return false;
            if (this.Names != input.Names || (this.Names != null && input.Names != null && !this.Names.SequenceEqual(input.Names))) return false;

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
                if (this.Names != null) hashCode = hashCode * 59 + this.Names.GetHashCode();
                return hashCode;
            }
        }
    }
}
