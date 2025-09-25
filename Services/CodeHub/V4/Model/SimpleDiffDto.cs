using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SimpleDiffDto 
    {

        /// <summary>
        /// **参数解释：** 增加行数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("added_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddedLine { get; set; }

        /// <summary>
        /// **参数解释：** 删除行数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("deleted_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeletedLine { get; set; }

        /// <summary>
        /// **参数解释：** 路径。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleDiffDto {\n");
            sb.Append("  addedLine: ").Append(AddedLine).Append("\n");
            sb.Append("  deletedLine: ").Append(DeletedLine).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SimpleDiffDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SimpleDiffDto input)
        {
            if (input == null) return false;
            if (this.AddedLine != input.AddedLine || (this.AddedLine != null && !this.AddedLine.Equals(input.AddedLine))) return false;
            if (this.DeletedLine != input.DeletedLine || (this.DeletedLine != null && !this.DeletedLine.Equals(input.DeletedLine))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;

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
                if (this.AddedLine != null) hashCode = hashCode * 59 + this.AddedLine.GetHashCode();
                if (this.DeletedLine != null) hashCode = hashCode * 59 + this.DeletedLine.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }
    }
}
