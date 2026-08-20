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
    /// 
    /// </summary>
    public class COEntity 
    {
        /// <summary>
        /// 变更对象工作项类型，此处固定为CO。
        /// </summary>
        /// <value>变更对象工作项类型，此处固定为CO。</value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum CO for value: CO
            /// </summary>
            public static readonly CategoryEnum CO = new CategoryEnum("CO");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "CO", CO },
            };

            private string _value;

            public CategoryEnum()
            {

            }

            public CategoryEnum(string value)
            {
                _value = value;
            }

            public static CategoryEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as CategoryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategoryEnum a, CategoryEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(CategoryEnum a, CategoryEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 变更对象修改后内容。
        /// </summary>
        [JsonProperty("after_change", NullValueHandling = NullValueHandling.Ignore)]
        public string AfterChange { get; set; }

        /// <summary>
        /// 变更对象评审完成时间。
        /// </summary>
        [JsonProperty("review_complete_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewCompleteTime { get; set; }

        /// <summary>
        /// 变更对象评审阶段结果。
        /// </summary>
        [JsonProperty("review_phase_result", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewPhaseResult { get; set; }

        /// <summary>
        /// 变更对象评审时间。
        /// </summary>
        [JsonProperty("review_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewTime { get; set; }

        /// <summary>
        /// 变更对象工作项修改前内容。
        /// </summary>
        [JsonProperty("before_change", NullValueHandling = NullValueHandling.Ignore)]
        public string BeforeChange { get; set; }

        /// <summary>
        /// 变更对象工作项类型，此处固定为CO。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ccb_info", NullValueHandling = NullValueHandling.Ignore)]
        public CcbEntity CcbInfo { get; set; }

        /// <summary>
        /// 变更对象决策人列表，列表中只有一个元素。
        /// </summary>
        [JsonProperty("ccbs", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserEntity> Ccbs { get; set; }

        /// <summary>
        /// 变更类型。
        /// </summary>
        [JsonProperty("change_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangeType { get; set; }

        /// <summary>
        /// 变更对象关联的评审单ID。
        /// </summary>
        [JsonProperty("co2review", NullValueHandling = NullValueHandling.Ignore)]
        public string Co2review { get; set; }

        /// <summary>
        /// 变更对象的创建人ID。
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 变更对象创建时间。
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// 变更对象描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 变更对象ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 变更对象关联的工作项ID。
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// 变更对象关联的工作项编号。
        /// </summary>
        [JsonProperty("issue_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueNumber { get; set; }

        /// <summary>
        /// 变更对象关联的工作项类型。
        /// </summary>
        [JsonProperty("issue_category", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueCategory { get; set; }

        /// <summary>
        /// 变更对象最后修改人ID。
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// 变更对象最后修改时间。
        /// </summary>
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// 变更对象评审专家Id列表（创建变更评审时使用）。
        /// </summary>
        [JsonProperty("opinions", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserEntity> Opinions { get; set; }

        /// <summary>
        /// 变更对象评审意见。
        /// </summary>
        [JsonProperty("opinion_comments", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReviewOpinionEntity> OpinionComments { get; set; }

        /// <summary>
        /// 变更对象评审意见（评审更新时使用）。
        /// </summary>
        [JsonProperty("review_comments", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReviewCommentEntity> ReviewComments { get; set; }

        /// <summary>
        /// 变更对象决策意见（决策更新时使用）。
        /// </summary>
        [JsonProperty("approval_comments", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReviewCommentEntity> ApprovalComments { get; set; }

        /// <summary>
        /// 变更对象评审专家Id列表。
        /// </summary>
        [JsonProperty("reviewer", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Reviewer { get; set; }

        /// <summary>
        /// 变更对象决策人ID数组。
        /// </summary>
        [JsonProperty("approver", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Approver { get; set; }

        /// <summary>
        /// 变更对象状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class COEntity {\n");
            sb.Append("  afterChange: ").Append(AfterChange).Append("\n");
            sb.Append("  reviewCompleteTime: ").Append(ReviewCompleteTime).Append("\n");
            sb.Append("  reviewPhaseResult: ").Append(ReviewPhaseResult).Append("\n");
            sb.Append("  reviewTime: ").Append(ReviewTime).Append("\n");
            sb.Append("  beforeChange: ").Append(BeforeChange).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  ccbInfo: ").Append(CcbInfo).Append("\n");
            sb.Append("  ccbs: ").Append(Ccbs).Append("\n");
            sb.Append("  changeType: ").Append(ChangeType).Append("\n");
            sb.Append("  co2review: ").Append(Co2review).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  issueNumber: ").Append(IssueNumber).Append("\n");
            sb.Append("  issueCategory: ").Append(IssueCategory).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  modifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  opinions: ").Append(Opinions).Append("\n");
            sb.Append("  opinionComments: ").Append(OpinionComments).Append("\n");
            sb.Append("  reviewComments: ").Append(ReviewComments).Append("\n");
            sb.Append("  approvalComments: ").Append(ApprovalComments).Append("\n");
            sb.Append("  reviewer: ").Append(Reviewer).Append("\n");
            sb.Append("  approver: ").Append(Approver).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as COEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(COEntity input)
        {
            if (input == null) return false;
            if (this.AfterChange != input.AfterChange || (this.AfterChange != null && !this.AfterChange.Equals(input.AfterChange))) return false;
            if (this.ReviewCompleteTime != input.ReviewCompleteTime || (this.ReviewCompleteTime != null && !this.ReviewCompleteTime.Equals(input.ReviewCompleteTime))) return false;
            if (this.ReviewPhaseResult != input.ReviewPhaseResult || (this.ReviewPhaseResult != null && !this.ReviewPhaseResult.Equals(input.ReviewPhaseResult))) return false;
            if (this.ReviewTime != input.ReviewTime || (this.ReviewTime != null && !this.ReviewTime.Equals(input.ReviewTime))) return false;
            if (this.BeforeChange != input.BeforeChange || (this.BeforeChange != null && !this.BeforeChange.Equals(input.BeforeChange))) return false;
            if (this.Category != input.Category) return false;
            if (this.CcbInfo != input.CcbInfo || (this.CcbInfo != null && !this.CcbInfo.Equals(input.CcbInfo))) return false;
            if (this.Ccbs != input.Ccbs || (this.Ccbs != null && input.Ccbs != null && !this.Ccbs.SequenceEqual(input.Ccbs))) return false;
            if (this.ChangeType != input.ChangeType || (this.ChangeType != null && !this.ChangeType.Equals(input.ChangeType))) return false;
            if (this.Co2review != input.Co2review || (this.Co2review != null && !this.Co2review.Equals(input.Co2review))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.IssueNumber != input.IssueNumber || (this.IssueNumber != null && !this.IssueNumber.Equals(input.IssueNumber))) return false;
            if (this.IssueCategory != input.IssueCategory || (this.IssueCategory != null && !this.IssueCategory.Equals(input.IssueCategory))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.ModifiedDate != input.ModifiedDate || (this.ModifiedDate != null && !this.ModifiedDate.Equals(input.ModifiedDate))) return false;
            if (this.Opinions != input.Opinions || (this.Opinions != null && input.Opinions != null && !this.Opinions.SequenceEqual(input.Opinions))) return false;
            if (this.OpinionComments != input.OpinionComments || (this.OpinionComments != null && input.OpinionComments != null && !this.OpinionComments.SequenceEqual(input.OpinionComments))) return false;
            if (this.ReviewComments != input.ReviewComments || (this.ReviewComments != null && input.ReviewComments != null && !this.ReviewComments.SequenceEqual(input.ReviewComments))) return false;
            if (this.ApprovalComments != input.ApprovalComments || (this.ApprovalComments != null && input.ApprovalComments != null && !this.ApprovalComments.SequenceEqual(input.ApprovalComments))) return false;
            if (this.Reviewer != input.Reviewer || (this.Reviewer != null && input.Reviewer != null && !this.Reviewer.SequenceEqual(input.Reviewer))) return false;
            if (this.Approver != input.Approver || (this.Approver != null && input.Approver != null && !this.Approver.SequenceEqual(input.Approver))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.AfterChange != null) hashCode = hashCode * 59 + this.AfterChange.GetHashCode();
                if (this.ReviewCompleteTime != null) hashCode = hashCode * 59 + this.ReviewCompleteTime.GetHashCode();
                if (this.ReviewPhaseResult != null) hashCode = hashCode * 59 + this.ReviewPhaseResult.GetHashCode();
                if (this.ReviewTime != null) hashCode = hashCode * 59 + this.ReviewTime.GetHashCode();
                if (this.BeforeChange != null) hashCode = hashCode * 59 + this.BeforeChange.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CcbInfo != null) hashCode = hashCode * 59 + this.CcbInfo.GetHashCode();
                if (this.Ccbs != null) hashCode = hashCode * 59 + this.Ccbs.GetHashCode();
                if (this.ChangeType != null) hashCode = hashCode * 59 + this.ChangeType.GetHashCode();
                if (this.Co2review != null) hashCode = hashCode * 59 + this.Co2review.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.IssueNumber != null) hashCode = hashCode * 59 + this.IssueNumber.GetHashCode();
                if (this.IssueCategory != null) hashCode = hashCode * 59 + this.IssueCategory.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.ModifiedDate != null) hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.Opinions != null) hashCode = hashCode * 59 + this.Opinions.GetHashCode();
                if (this.OpinionComments != null) hashCode = hashCode * 59 + this.OpinionComments.GetHashCode();
                if (this.ReviewComments != null) hashCode = hashCode * 59 + this.ReviewComments.GetHashCode();
                if (this.ApprovalComments != null) hashCode = hashCode * 59 + this.ApprovalComments.GetHashCode();
                if (this.Reviewer != null) hashCode = hashCode * 59 + this.Reviewer.GetHashCode();
                if (this.Approver != null) hashCode = hashCode * 59 + this.Approver.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
