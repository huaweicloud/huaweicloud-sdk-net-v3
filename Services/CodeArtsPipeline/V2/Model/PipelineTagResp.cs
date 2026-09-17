using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// **参数解释**： 标签响应体。 **取值范围**： 不涉及。 
    /// </summary>
    public class PipelineTagResp 
    {

        /// <summary>
        /// **参数解释**： 标签ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("tag_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TagId { get; set; }

        /// <summary>
        /// **参数解释**： 标签名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 标签颜色。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// **参数解释**： 项目ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 项目名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineTagResp {\n");
            sb.Append("  tagId: ").Append(TagId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  color: ").Append(Color).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineTagResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineTagResp input)
        {
            if (input == null) return false;
            if (this.TagId != input.TagId || (this.TagId != null && !this.TagId.Equals(input.TagId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Color != input.Color || (this.Color != null && !this.Color.Equals(input.Color))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;

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
                if (this.TagId != null) hashCode = hashCode * 59 + this.TagId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Color != null) hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                return hashCode;
            }
        }
    }
}
