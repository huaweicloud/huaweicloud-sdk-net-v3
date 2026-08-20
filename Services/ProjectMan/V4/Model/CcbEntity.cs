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
    public class CcbEntity 
    {
        /// <summary>
        /// 工作项类型，审批对象固定为CCB。
        /// </summary>
        /// <value>工作项类型，审批对象固定为CCB。</value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum CCB for value: CCB
            /// </summary>
            public static readonly CategoryEnum CCB = new CategoryEnum("CCB");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "CCB", CCB },
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
        /// 审批时间。
        /// </summary>
        [JsonProperty("approval_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ApprovalTime { get; set; }

        /// <summary>
        /// 工作项类型，审批对象固定为CCB。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// 审批对象关联的评审单ID。
        /// </summary>
        [JsonProperty("ccb2review", NullValueHandling = NullValueHandling.Ignore)]
        public string Ccb2review { get; set; }

        /// <summary>
        /// 关联的变更对象ID。
        /// </summary>
        [JsonProperty("co_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CoId { get; set; }

        /// <summary>
        /// 审批对象ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity Owner { get; set; }

        /// <summary>
        /// 审批意见。
        /// </summary>
        [JsonProperty("approval_comments", NullValueHandling = NullValueHandling.Ignore)]
        public string ApprovalComments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CcbEntity {\n");
            sb.Append("  approvalTime: ").Append(ApprovalTime).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  ccb2review: ").Append(Ccb2review).Append("\n");
            sb.Append("  coId: ").Append(CoId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  approvalComments: ").Append(ApprovalComments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CcbEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CcbEntity input)
        {
            if (input == null) return false;
            if (this.ApprovalTime != input.ApprovalTime || (this.ApprovalTime != null && !this.ApprovalTime.Equals(input.ApprovalTime))) return false;
            if (this.Category != input.Category) return false;
            if (this.Ccb2review != input.Ccb2review || (this.Ccb2review != null && !this.Ccb2review.Equals(input.Ccb2review))) return false;
            if (this.CoId != input.CoId || (this.CoId != null && !this.CoId.Equals(input.CoId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.ApprovalComments != input.ApprovalComments || (this.ApprovalComments != null && !this.ApprovalComments.Equals(input.ApprovalComments))) return false;

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
                if (this.ApprovalTime != null) hashCode = hashCode * 59 + this.ApprovalTime.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Ccb2review != null) hashCode = hashCode * 59 + this.Ccb2review.GetHashCode();
                if (this.CoId != null) hashCode = hashCode * 59 + this.CoId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.ApprovalComments != null) hashCode = hashCode * 59 + this.ApprovalComments.GetHashCode();
                return hashCode;
            }
        }
    }
}
