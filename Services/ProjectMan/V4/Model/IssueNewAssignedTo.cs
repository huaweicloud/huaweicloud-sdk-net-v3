using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// **参数解释：** 工作项责任人。 **取值范围：** 不涉及。
    /// </summary>
    public class IssueNewAssignedTo 
    {

        /// <summary>
        /// **参数解释：** 用户名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// **参数解释：** 用户姓名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// **参数解释：** 用户32位uuid。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// **参数解释：** 用户头像id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// **参数解释：** 用户昵称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("assignedNickName", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignedNickName { get; set; }

        /// <summary>
        /// **参数解释：** 用户名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 用户数字id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueNewAssignedTo {\n");
            sb.Append("  firstName: ").Append(FirstName).Append("\n");
            sb.Append("  lastName: ").Append(LastName).Append("\n");
            sb.Append("  identifier: ").Append(Identifier).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  assignedNickName: ").Append(AssignedNickName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueNewAssignedTo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueNewAssignedTo input)
        {
            if (input == null) return false;
            if (this.FirstName != input.FirstName || (this.FirstName != null && !this.FirstName.Equals(input.FirstName))) return false;
            if (this.LastName != input.LastName || (this.LastName != null && !this.LastName.Equals(input.LastName))) return false;
            if (this.Identifier != input.Identifier || (this.Identifier != null && !this.Identifier.Equals(input.Identifier))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.AssignedNickName != input.AssignedNickName || (this.AssignedNickName != null && !this.AssignedNickName.Equals(input.AssignedNickName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
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
                if (this.FirstName != null) hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null) hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Identifier != null) hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.AssignedNickName != null) hashCode = hashCode * 59 + this.AssignedNickName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
