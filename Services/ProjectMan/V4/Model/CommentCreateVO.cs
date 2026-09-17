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
    public class CommentCreateVO 
    {
        /// <summary>
        /// **参数解释**： 评论类型。 **取值范围**： - comment：评论 - reply：回复 - operation：系统操作（不支持创建）。 **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 评论类型。 **取值范围**： - comment：评论 - reply：回复 - operation：系统操作（不支持创建）。 **默认取值**： 不涉及。</value>
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

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "comment", COMMENT },
                { "reply", REPLY },
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
        /// **参数解释**： 评论类型。 **取值范围**： - comment：评论 - reply：回复 - operation：系统操作（不支持创建）。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// **参数解释**： 评论关联的工作项类型。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("issue_category", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueCategory { get; set; }

        /// <summary>
        /// **参数解释**： 评论内容，使用html标记语言。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 评论的父ID，取值为需要回复的评论的ID。 **约束限制**： 回复评论时必填。 **取值范围**： 只支持CR。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// **参数解释**： 评论的根ID，取值为需要回复的首层评论的ID。 **约束限制**： 回复评论时必填，创建评论时不能填。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("root_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootId { get; set; }

        /// <summary>
        /// **参数解释**： 评论时@他人的用户ID，填写此参数后会通知被@的用户，通知形式在需求管理-设置-工作项设置-通知设置中配置。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("at", NullValueHandling = NullValueHandling.Ignore)]
        public string At { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentCreateVO {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  issueCategory: ").Append(IssueCategory).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  rootId: ").Append(RootId).Append("\n");
            sb.Append("  at: ").Append(At).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommentCreateVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommentCreateVO input)
        {
            if (input == null) return false;
            if (this.Category != input.Category) return false;
            if (this.IssueCategory != input.IssueCategory || (this.IssueCategory != null && !this.IssueCategory.Equals(input.IssueCategory))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.RootId != input.RootId || (this.RootId != null && !this.RootId.Equals(input.RootId))) return false;
            if (this.At != input.At || (this.At != null && !this.At.Equals(input.At))) return false;

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
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.IssueCategory != null) hashCode = hashCode * 59 + this.IssueCategory.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.RootId != null) hashCode = hashCode * 59 + this.RootId.GetHashCode();
                if (this.At != null) hashCode = hashCode * 59 + this.At.GetHashCode();
                return hashCode;
            }
        }
    }
}
