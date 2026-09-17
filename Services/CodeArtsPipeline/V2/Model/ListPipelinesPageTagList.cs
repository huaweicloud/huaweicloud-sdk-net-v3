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
    /// 
    /// </summary>
    public class ListPipelinesPageTagList 
    {

        /// <summary>
        /// **参数解释**： 标签ID。 **取值范围**： 不涉及。 
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
        /// **参数解释**： 项目ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 租户ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**： 创建人ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// **参数解释**： 更新人ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("updater_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdaterId { get; set; }

        /// <summary>
        /// **参数解释**： 创建时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// **参数解释**： 更新时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPipelinesPageTagList {\n");
            sb.Append("  tagId: ").Append(TagId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  color: ").Append(Color).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  updaterId: ").Append(UpdaterId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPipelinesPageTagList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPipelinesPageTagList input)
        {
            if (input == null) return false;
            if (this.TagId != input.TagId || (this.TagId != null && !this.TagId.Equals(input.TagId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Color != input.Color || (this.Color != null && !this.Color.Equals(input.Color))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.UpdaterId != input.UpdaterId || (this.UpdaterId != null && !this.UpdaterId.Equals(input.UpdaterId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.UpdaterId != null) hashCode = hashCode * 59 + this.UpdaterId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
