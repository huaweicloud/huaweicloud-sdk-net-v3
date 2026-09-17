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
    /// Request Object
    /// </summary>
    public class ListIpdIssueCommentsRequest 
    {
        /// <summary>
        /// **参数解释**： 评论类型，支持多值，使用英文逗号分隔。 **取值范围**： - comment：评论 - reply：回复 - operation：系统操作。 **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 评论类型，支持多值，使用英文逗号分隔。 **取值范围**： - comment：评论 - reply：回复 - operation：系统操作。 **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum COMMENT for value: comment
            /// </summary>
            public static readonly CategoryEnum COMMENT = new CategoryEnum("comment");

            /// <summary>
            /// Enum REPLY for value: reply
            /// </summary>
            public static readonly CategoryEnum REPLY = new CategoryEnum("reply");

            /// <summary>
            /// Enum OPERATION for value: operation
            /// </summary>
            public static readonly CategoryEnum OPERATION = new CategoryEnum("operation");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "comment", COMMENT },
                { "reply", REPLY },
                { "operation", OPERATION },
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
        /// 项目32位ID，项目唯一标识。通过查询IPD项目列表获取，响应消息体中的id字段的值就是项目ID。
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 工作项唯一ID。可以通过查询工作项列表或者查询树状工作项接口获取，响应消息体中的id字段的值就是工作项ID。
        /// </summary>
        [SDKProperty("issue_id", IsPath = true)]
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// **参数解释**： 是否按创建日期倒序排列。 **取值范围**： - true：按创建时间倒序排列。 - false：按创建时间正序排列。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("date_desc", IsQuery = true)]
        [JsonProperty("date_desc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DateDesc { get; set; }

        /// <summary>
        /// **参数解释**： 分页索引。 **约束限制**： 不涉及 **取值范围**： 最小值1，最大值10000 **默认取值**： 1
        /// </summary>
        [SDKProperty("page_no", IsQuery = true)]
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// **参数解释**： 分页大小。 **约束限制**： 不涉及 **取值范围**： 最小值5，最大值200 **默认取值**： 200
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// **参数解释**： 评论类型，支持多值，使用英文逗号分隔。 **取值范围**： - comment：评论 - reply：回复 - operation：系统操作。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("category", IsQuery = true)]
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIpdIssueCommentsRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  dateDesc: ").Append(DateDesc).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIpdIssueCommentsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIpdIssueCommentsRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.DateDesc != input.DateDesc || (this.DateDesc != null && !this.DateDesc.Equals(input.DateDesc))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Category != input.Category) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.DateDesc != null) hashCode = hashCode * 59 + this.DateDesc.GetHashCode();
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                return hashCode;
            }
        }
    }
}
