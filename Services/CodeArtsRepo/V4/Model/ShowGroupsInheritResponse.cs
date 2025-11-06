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
    public class ShowGroupsInheritResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 代码组id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释：** 资源类型设置。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("source_setting", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceSetting { get; set; }

        /// <summary>
        /// **参数解释：** 项目id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 向上继承是否可编辑。
        /// </summary>
        [JsonProperty("upward_inherit_editable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpwardInheritEditable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGroupsInheritResponse {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  sourceSetting: ").Append(SourceSetting).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  upwardInheritEditable: ").Append(UpwardInheritEditable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGroupsInheritResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGroupsInheritResponse input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.SourceSetting != input.SourceSetting || (this.SourceSetting != null && !this.SourceSetting.Equals(input.SourceSetting))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.UpwardInheritEditable != input.UpwardInheritEditable || (this.UpwardInheritEditable != null && !this.UpwardInheritEditable.Equals(input.UpwardInheritEditable))) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.SourceSetting != null) hashCode = hashCode * 59 + this.SourceSetting.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.UpwardInheritEditable != null) hashCode = hashCode * 59 + this.UpwardInheritEditable.GetHashCode();
                return hashCode;
            }
        }
    }
}
