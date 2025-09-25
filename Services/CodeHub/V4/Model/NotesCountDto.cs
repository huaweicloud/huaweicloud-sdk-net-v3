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
    public class NotesCountDto 
    {

        /// <summary>
        /// 检视意见总数
        /// </summary>
        [JsonProperty("notes_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotesCount { get; set; }

        /// <summary>
        /// 未解决的检视意见数量
        /// </summary>
        [JsonProperty("unresolved_notes_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnresolvedNotesCount { get; set; }

        /// <summary>
        /// 已解决的检视意见数量
        /// </summary>
        [JsonProperty("already_resolved_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlreadyResolvedCount { get; set; }

        /// <summary>
        /// 需要解决的检视意见总数
        /// </summary>
        [JsonProperty("need_resolved_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? NeedResolvedCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotesCountDto {\n");
            sb.Append("  notesCount: ").Append(NotesCount).Append("\n");
            sb.Append("  unresolvedNotesCount: ").Append(UnresolvedNotesCount).Append("\n");
            sb.Append("  alreadyResolvedCount: ").Append(AlreadyResolvedCount).Append("\n");
            sb.Append("  needResolvedCount: ").Append(NeedResolvedCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotesCountDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NotesCountDto input)
        {
            if (input == null) return false;
            if (this.NotesCount != input.NotesCount || (this.NotesCount != null && !this.NotesCount.Equals(input.NotesCount))) return false;
            if (this.UnresolvedNotesCount != input.UnresolvedNotesCount || (this.UnresolvedNotesCount != null && !this.UnresolvedNotesCount.Equals(input.UnresolvedNotesCount))) return false;
            if (this.AlreadyResolvedCount != input.AlreadyResolvedCount || (this.AlreadyResolvedCount != null && !this.AlreadyResolvedCount.Equals(input.AlreadyResolvedCount))) return false;
            if (this.NeedResolvedCount != input.NeedResolvedCount || (this.NeedResolvedCount != null && !this.NeedResolvedCount.Equals(input.NeedResolvedCount))) return false;

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
                if (this.NotesCount != null) hashCode = hashCode * 59 + this.NotesCount.GetHashCode();
                if (this.UnresolvedNotesCount != null) hashCode = hashCode * 59 + this.UnresolvedNotesCount.GetHashCode();
                if (this.AlreadyResolvedCount != null) hashCode = hashCode * 59 + this.AlreadyResolvedCount.GetHashCode();
                if (this.NeedResolvedCount != null) hashCode = hashCode * 59 + this.NeedResolvedCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
