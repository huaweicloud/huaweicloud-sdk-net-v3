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
    /// 工作项流转数据对象
    /// </summary>
    public class WorkItemStatusFlowVo 
    {

        /// <summary>
        ///  父状态的名称
        /// </summary>
        [JsonProperty("parent_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentName { get; set; }

        /// <summary>
        /// 父状态的类型
        /// </summary>
        [JsonProperty("parent_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentType { get; set; }

        /// <summary>
        /// 状态id
        /// </summary>
        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusId { get; set; }

        /// <summary>
        /// 状态名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 状态类型
        /// </summary>
        [JsonProperty("status_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusType { get; set; }

        /// <summary>
        /// 流转到的数据
        /// </summary>
        [JsonProperty("direct_to", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusFlowDirectToVo> DirectTo { get; set; }

        /// <summary>
        /// 处理人的uuid
        /// </summary>
        [JsonProperty("assign_to", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignTo { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 处理人是否必填
        /// </summary>
        [JsonProperty("required_assign", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequiredAssign { get; set; }

        /// <summary>
        /// 评论是否必填
        /// </summary>
        [JsonProperty("required_notes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequiredNotes { get; set; }

        /// <summary>
        /// 是否是字段值，true 处理人的信息是字段值， false 处理人的值是用户的信息,固定值
        /// </summary>
        [JsonProperty("field_type", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FieldType { get; set; }

        /// <summary>
        /// 父状态的uuid
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemStatusFlowVo {\n");
            sb.Append("  parentName: ").Append(ParentName).Append("\n");
            sb.Append("  parentType: ").Append(ParentType).Append("\n");
            sb.Append("  statusId: ").Append(StatusId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  statusType: ").Append(StatusType).Append("\n");
            sb.Append("  directTo: ").Append(DirectTo).Append("\n");
            sb.Append("  assignTo: ").Append(AssignTo).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  requiredAssign: ").Append(RequiredAssign).Append("\n");
            sb.Append("  requiredNotes: ").Append(RequiredNotes).Append("\n");
            sb.Append("  fieldType: ").Append(FieldType).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemStatusFlowVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemStatusFlowVo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParentName == input.ParentName ||
                    (this.ParentName != null &&
                    this.ParentName.Equals(input.ParentName))
                ) && 
                (
                    this.ParentType == input.ParentType ||
                    (this.ParentType != null &&
                    this.ParentType.Equals(input.ParentType))
                ) && 
                (
                    this.StatusId == input.StatusId ||
                    (this.StatusId != null &&
                    this.StatusId.Equals(input.StatusId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StatusType == input.StatusType ||
                    (this.StatusType != null &&
                    this.StatusType.Equals(input.StatusType))
                ) && 
                (
                    this.DirectTo == input.DirectTo ||
                    this.DirectTo != null &&
                    input.DirectTo != null &&
                    this.DirectTo.SequenceEqual(input.DirectTo)
                ) && 
                (
                    this.AssignTo == input.AssignTo ||
                    (this.AssignTo != null &&
                    this.AssignTo.Equals(input.AssignTo))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.RequiredAssign == input.RequiredAssign ||
                    (this.RequiredAssign != null &&
                    this.RequiredAssign.Equals(input.RequiredAssign))
                ) && 
                (
                    this.RequiredNotes == input.RequiredNotes ||
                    (this.RequiredNotes != null &&
                    this.RequiredNotes.Equals(input.RequiredNotes))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ParentName != null)
                    hashCode = hashCode * 59 + this.ParentName.GetHashCode();
                if (this.ParentType != null)
                    hashCode = hashCode * 59 + this.ParentType.GetHashCode();
                if (this.StatusId != null)
                    hashCode = hashCode * 59 + this.StatusId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StatusType != null)
                    hashCode = hashCode * 59 + this.StatusType.GetHashCode();
                if (this.DirectTo != null)
                    hashCode = hashCode * 59 + this.DirectTo.GetHashCode();
                if (this.AssignTo != null)
                    hashCode = hashCode * 59 + this.AssignTo.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.RequiredAssign != null)
                    hashCode = hashCode * 59 + this.RequiredAssign.GetHashCode();
                if (this.RequiredNotes != null)
                    hashCode = hashCode * 59 + this.RequiredNotes.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
