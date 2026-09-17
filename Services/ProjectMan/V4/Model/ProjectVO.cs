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
    /// 项目信息。
    /// </summary>
    public class ProjectVO 
    {

        /// <summary>
        /// **参数解释：** 项目uuid **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// **参数解释：** 项目名称 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 项目数字id **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 项目类型 **取值范围：** scrum。
        /// </summary>
        [JsonProperty("project_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectVO {\n");
            sb.Append("  identifier: ").Append(Identifier).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectType: ").Append(ProjectType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProjectVO input)
        {
            if (input == null) return false;
            if (this.Identifier != input.Identifier || (this.Identifier != null && !this.Identifier.Equals(input.Identifier))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProjectType != input.ProjectType || (this.ProjectType != null && !this.ProjectType.Equals(input.ProjectType))) return false;

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
                if (this.Identifier != null) hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProjectType != null) hashCode = hashCode * 59 + this.ProjectType.GetHashCode();
                return hashCode;
            }
        }
    }
}
