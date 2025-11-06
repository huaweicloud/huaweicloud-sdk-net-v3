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
    public class ConflictSectionDto 
    {

        /// <summary>
        /// 是否冲突
        /// </summary>
        [JsonProperty("conflict", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Conflict { get; set; }

        /// <summary>
        /// 冲突行列表
        /// </summary>
        [JsonProperty("lines", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConflictSectionLineDto> Lines { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConflictSectionDto {\n");
            sb.Append("  conflict: ").Append(Conflict).Append("\n");
            sb.Append("  lines: ").Append(Lines).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConflictSectionDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConflictSectionDto input)
        {
            if (input == null) return false;
            if (this.Conflict != input.Conflict || (this.Conflict != null && !this.Conflict.Equals(input.Conflict))) return false;
            if (this.Lines != input.Lines || (this.Lines != null && input.Lines != null && !this.Lines.SequenceEqual(input.Lines))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;

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
                if (this.Conflict != null) hashCode = hashCode * 59 + this.Conflict.GetHashCode();
                if (this.Lines != null) hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
