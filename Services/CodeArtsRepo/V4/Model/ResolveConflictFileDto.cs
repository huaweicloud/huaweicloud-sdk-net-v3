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
    public class ResolveConflictFileDto 
    {

        /// <summary>
        /// **参数解释：** 旧文件路径    
        /// </summary>
        [JsonProperty("old_path", NullValueHandling = NullValueHandling.Ignore)]
        public string OldPath { get; set; }

        /// <summary>
        /// **参数解释：** 新文件路径    
        /// </summary>
        [JsonProperty("new_path", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPath { get; set; }

        /// <summary>
        /// **参数解释：** 只有选择接受不同分支选项的时候才需要    
        /// </summary>
        [JsonProperty("sections", NullValueHandling = NullValueHandling.Ignore)]
        public Object Sections { get; set; }

        /// <summary>
        /// **参数解释：** 只有在线编辑冲突文件的时候才需要，内容即为文件内容    
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResolveConflictFileDto {\n");
            sb.Append("  oldPath: ").Append(OldPath).Append("\n");
            sb.Append("  newPath: ").Append(NewPath).Append("\n");
            sb.Append("  sections: ").Append(Sections).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResolveConflictFileDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResolveConflictFileDto input)
        {
            if (input == null) return false;
            if (this.OldPath != input.OldPath || (this.OldPath != null && !this.OldPath.Equals(input.OldPath))) return false;
            if (this.NewPath != input.NewPath || (this.NewPath != null && !this.NewPath.Equals(input.NewPath))) return false;
            if (this.Sections != input.Sections || (this.Sections != null && !this.Sections.Equals(input.Sections))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;

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
                if (this.OldPath != null) hashCode = hashCode * 59 + this.OldPath.GetHashCode();
                if (this.NewPath != null) hashCode = hashCode * 59 + this.NewPath.GetHashCode();
                if (this.Sections != null) hashCode = hashCode * 59 + this.Sections.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }
}
