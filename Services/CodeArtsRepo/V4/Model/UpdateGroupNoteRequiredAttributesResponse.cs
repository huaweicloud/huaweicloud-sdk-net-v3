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
    /// Response Object
    /// </summary>
    public class UpdateGroupNoteRequiredAttributesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 检视意见必填项。
        /// </summary>
        [JsonProperty("note_required_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<RequiredAttributeDto> NoteRequiredAttributes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateGroupNoteRequiredAttributesResponse {\n");
            sb.Append("  noteRequiredAttributes: ").Append(NoteRequiredAttributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateGroupNoteRequiredAttributesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateGroupNoteRequiredAttributesResponse input)
        {
            if (input == null) return false;
            if (this.NoteRequiredAttributes != input.NoteRequiredAttributes || (this.NoteRequiredAttributes != null && input.NoteRequiredAttributes != null && !this.NoteRequiredAttributes.SequenceEqual(input.NoteRequiredAttributes))) return false;

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
                if (this.NoteRequiredAttributes != null) hashCode = hashCode * 59 + this.NoteRequiredAttributes.GetHashCode();
                return hashCode;
            }
        }
    }
}
