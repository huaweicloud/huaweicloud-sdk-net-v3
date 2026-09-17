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
    /// 工作项更新评论的请求参数。
    /// </summary>
    public class UpdateCommentsRequest 
    {

        /// <summary>
        /// **参数解释：** 工作项id，可通过[高级查询工作项](ListIssuesV4.xml)接口获取，响应消息体中的**id**字段的值就是工作项id。 **约束限制：** 长度在1位到10位之间的纯数字。 **取值范围：** 最小长度：1，最大长度：10。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的评论URL编码内容。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的评论内容。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("innerText", NullValueHandling = NullValueHandling.Ignore)]
        public string InnerText { get; set; }

        /// <summary>
        /// **参数解释**： 项目的32位uuid，项目唯一标识。 **约束限制**： 由数字和英文组成的32字符串。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("projectUUId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUUId { get; set; }

        /// <summary>
        /// **参数解释**： 工作项所属项目类型。 **约束限制**： 不涉及。 **取值范围**： scrum。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 工作项的评论id。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("noteId", NullValueHandling = NullValueHandling.Ignore)]
        public int? NoteId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCommentsRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  notes: ").Append(Notes).Append("\n");
            sb.Append("  innerText: ").Append(InnerText).Append("\n");
            sb.Append("  projectUUId: ").Append(ProjectUUId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  noteId: ").Append(NoteId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCommentsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCommentsRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Notes != input.Notes || (this.Notes != null && !this.Notes.Equals(input.Notes))) return false;
            if (this.InnerText != input.InnerText || (this.InnerText != null && !this.InnerText.Equals(input.InnerText))) return false;
            if (this.ProjectUUId != input.ProjectUUId || (this.ProjectUUId != null && !this.ProjectUUId.Equals(input.ProjectUUId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.NoteId != input.NoteId || (this.NoteId != null && !this.NoteId.Equals(input.NoteId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Notes != null) hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.InnerText != null) hashCode = hashCode * 59 + this.InnerText.GetHashCode();
                if (this.ProjectUUId != null) hashCode = hashCode * 59 + this.ProjectUUId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.NoteId != null) hashCode = hashCode * 59 + this.NoteId.GetHashCode();
                return hashCode;
            }
        }
    }
}
