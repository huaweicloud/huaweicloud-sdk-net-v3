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
    public class ConflictSectionLineMetaDataDto 
    {

        /// <summary>
        /// 旧列位置
        /// </summary>
        [JsonProperty("old_pos", NullValueHandling = NullValueHandling.Ignore)]
        public int? OldPos { get; set; }

        /// <summary>
        /// 新列位置
        /// </summary>
        [JsonProperty("new_pos", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewPos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConflictSectionLineMetaDataDto {\n");
            sb.Append("  oldPos: ").Append(OldPos).Append("\n");
            sb.Append("  newPos: ").Append(NewPos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConflictSectionLineMetaDataDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConflictSectionLineMetaDataDto input)
        {
            if (input == null) return false;
            if (this.OldPos != input.OldPos || (this.OldPos != null && !this.OldPos.Equals(input.OldPos))) return false;
            if (this.NewPos != input.NewPos || (this.NewPos != null && !this.NewPos.Equals(input.NewPos))) return false;

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
                if (this.OldPos != null) hashCode = hashCode * 59 + this.OldPos.GetHashCode();
                if (this.NewPos != null) hashCode = hashCode * 59 + this.NewPos.GetHashCode();
                return hashCode;
            }
        }
    }
}
