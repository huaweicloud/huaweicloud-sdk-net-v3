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
    /// 单文件下检视意见详情。
    /// </summary>
    public class CommentPathDto 
    {

        /// <summary>
        /// **参数解释：** 位于文件对比结果右侧的检视意见集合。
        /// </summary>
        [JsonProperty("new", NullValueHandling = NullValueHandling.Ignore)]
        public List<LineDiscussionDto> New { get; set; }

        /// <summary>
        /// **参数解释：** 位于文件对比结果左侧的检视意见集合。
        /// </summary>
        [JsonProperty("old", NullValueHandling = NullValueHandling.Ignore)]
        public List<LineDiscussionDto> Old { get; set; }

        /// <summary>
        /// **参数解释：** 文件名。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentPathDto {\n");
            sb.Append("  New: ").Append(New).Append("\n");
            sb.Append("  old: ").Append(Old).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommentPathDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommentPathDto input)
        {
            if (input == null) return false;
            if (this.New != input.New || (this.New != null && input.New != null && !this.New.SequenceEqual(input.New))) return false;
            if (this.Old != input.Old || (this.Old != null && input.Old != null && !this.Old.SequenceEqual(input.Old))) return false;
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
                if (this.New != null) hashCode = hashCode * 59 + this.New.GetHashCode();
                if (this.Old != null) hashCode = hashCode * 59 + this.Old.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }
    }
}
