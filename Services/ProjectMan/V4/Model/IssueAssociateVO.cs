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
    /// 工作项关联请求数据对象
    /// </summary>
    public class IssueAssociateVO 
    {

        /// <summary>
        /// 关联的工作项ID，多个ID使用逗号分割。可以通过查询工作项列表或者查询树状工作项接口获取，响应消息体中的id字段的值就是工作项ID。 当link_field_code&#x3D;link时，最多支持关联500个工作项ID，其他场景最多支持50个工作项ID。
        /// </summary>
        [JsonProperty("associated_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociatedIds { get; set; }

        /// <summary>
        /// 操作类型标记位。
        /// </summary>
        [JsonProperty("operation_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? OperationFlag { get; set; }

        /// <summary>
        /// 关联项类型编码。
        /// </summary>
        [JsonProperty("associate_issue_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateIssueType { get; set; }

        /// <summary>
        /// 当前工作项类型编码。
        /// </summary>
        [JsonProperty("source_issue_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIssueType { get; set; }

        /// <summary>
        /// 是否使用替换模式。默认为false，追加关联项。如果为true，则会删除原有的关联项，替换为本次关联的工作项。
        /// </summary>
        [JsonProperty("is_replace", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReplace { get; set; }

        /// <summary>
        /// 关联字段的字段编码。
        /// </summary>
        [JsonProperty("link_field_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkFieldCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueAssociateVO {\n");
            sb.Append("  associatedIds: ").Append(AssociatedIds).Append("\n");
            sb.Append("  operationFlag: ").Append(OperationFlag).Append("\n");
            sb.Append("  associateIssueType: ").Append(AssociateIssueType).Append("\n");
            sb.Append("  sourceIssueType: ").Append(SourceIssueType).Append("\n");
            sb.Append("  isReplace: ").Append(IsReplace).Append("\n");
            sb.Append("  linkFieldCode: ").Append(LinkFieldCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueAssociateVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueAssociateVO input)
        {
            if (input == null) return false;
            if (this.AssociatedIds != input.AssociatedIds || (this.AssociatedIds != null && !this.AssociatedIds.Equals(input.AssociatedIds))) return false;
            if (this.OperationFlag != input.OperationFlag || (this.OperationFlag != null && !this.OperationFlag.Equals(input.OperationFlag))) return false;
            if (this.AssociateIssueType != input.AssociateIssueType || (this.AssociateIssueType != null && !this.AssociateIssueType.Equals(input.AssociateIssueType))) return false;
            if (this.SourceIssueType != input.SourceIssueType || (this.SourceIssueType != null && !this.SourceIssueType.Equals(input.SourceIssueType))) return false;
            if (this.IsReplace != input.IsReplace || (this.IsReplace != null && !this.IsReplace.Equals(input.IsReplace))) return false;
            if (this.LinkFieldCode != input.LinkFieldCode || (this.LinkFieldCode != null && !this.LinkFieldCode.Equals(input.LinkFieldCode))) return false;

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
                if (this.AssociatedIds != null) hashCode = hashCode * 59 + this.AssociatedIds.GetHashCode();
                if (this.OperationFlag != null) hashCode = hashCode * 59 + this.OperationFlag.GetHashCode();
                if (this.AssociateIssueType != null) hashCode = hashCode * 59 + this.AssociateIssueType.GetHashCode();
                if (this.SourceIssueType != null) hashCode = hashCode * 59 + this.SourceIssueType.GetHashCode();
                if (this.IsReplace != null) hashCode = hashCode * 59 + this.IsReplace.GetHashCode();
                if (this.LinkFieldCode != null) hashCode = hashCode * 59 + this.LinkFieldCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
