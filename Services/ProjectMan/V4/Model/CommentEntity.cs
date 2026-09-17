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
    /// 评论实体对象
    /// </summary>
    public class CommentEntity 
    {

        /// <summary>
        /// **参数解释**： 评论ID。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 评论类型。 **取值范围**： - comment：评论 - reply：回复 - operation：系统操作。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**： 评论元数据类型。 **取值范围**： 固定为comment。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 是否显示在置顶区域。 **取值范围**： - true：显示。 - false： 不显示。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("top", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Top { get; set; }

        /// <summary>
        /// **参数解释**： 置顶时间的unix时间戳，单位：毫秒。当有多条置顶评论时，最后置顶的评论显示在最上层。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("top_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TopTime { get; set; }

        /// <summary>
        /// **参数解释**： 评论内容，表现形式为html标签。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 评论关联的工作项ID。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// **参数解释**： 当前评论是否被置顶。 **取值范围**： - true：置顶。 - false： 不置顶。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("top_flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TopFlag { get; set; }

        /// <summary>
        /// **参数解释**： 评论创建人ID。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// **参数解释**： 评论创建时间。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator_info", NullValueHandling = NullValueHandling.Ignore)]
        public UserVO CreatorInfo { get; set; }

        /// <summary>
        /// **参数解释**： 评论的一些扩展属性，表现为json字符串。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("extend_attribute", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendAttribute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extend_attribute_obj", NullValueHandling = NullValueHandling.Ignore)]
        public CommentExtendAttribute ExtendAttributeObj { get; set; }

        /// <summary>
        /// **参数解释**： 评论的扩展属性对象数组。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("extend_attribute_objs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CommentExtendAttribute> ExtendAttributeObjs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentEntity {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  top: ").Append(Top).Append("\n");
            sb.Append("  topTime: ").Append(TopTime).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  topFlag: ").Append(TopFlag).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  creatorInfo: ").Append(CreatorInfo).Append("\n");
            sb.Append("  extendAttribute: ").Append(ExtendAttribute).Append("\n");
            sb.Append("  extendAttributeObj: ").Append(ExtendAttributeObj).Append("\n");
            sb.Append("  extendAttributeObjs: ").Append(ExtendAttributeObjs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommentEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommentEntity input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Top != input.Top || (this.Top != null && !this.Top.Equals(input.Top))) return false;
            if (this.TopTime != input.TopTime || (this.TopTime != null && !this.TopTime.Equals(input.TopTime))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.TopFlag != input.TopFlag || (this.TopFlag != null && !this.TopFlag.Equals(input.TopFlag))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.CreatorInfo != input.CreatorInfo || (this.CreatorInfo != null && !this.CreatorInfo.Equals(input.CreatorInfo))) return false;
            if (this.ExtendAttribute != input.ExtendAttribute || (this.ExtendAttribute != null && !this.ExtendAttribute.Equals(input.ExtendAttribute))) return false;
            if (this.ExtendAttributeObj != input.ExtendAttributeObj || (this.ExtendAttributeObj != null && !this.ExtendAttributeObj.Equals(input.ExtendAttributeObj))) return false;
            if (this.ExtendAttributeObjs != input.ExtendAttributeObjs || (this.ExtendAttributeObjs != null && input.ExtendAttributeObjs != null && !this.ExtendAttributeObjs.SequenceEqual(input.ExtendAttributeObjs))) return false;

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
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Top != null) hashCode = hashCode * 59 + this.Top.GetHashCode();
                if (this.TopTime != null) hashCode = hashCode * 59 + this.TopTime.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.TopFlag != null) hashCode = hashCode * 59 + this.TopFlag.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.CreatorInfo != null) hashCode = hashCode * 59 + this.CreatorInfo.GetHashCode();
                if (this.ExtendAttribute != null) hashCode = hashCode * 59 + this.ExtendAttribute.GetHashCode();
                if (this.ExtendAttributeObj != null) hashCode = hashCode * 59 + this.ExtendAttributeObj.GetHashCode();
                if (this.ExtendAttributeObjs != null) hashCode = hashCode * 59 + this.ExtendAttributeObjs.GetHashCode();
                return hashCode;
            }
        }
    }
}
