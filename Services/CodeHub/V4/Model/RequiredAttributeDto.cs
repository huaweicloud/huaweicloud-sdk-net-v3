using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RequiredAttributeDto 
    {
        /// <summary>
        /// **参数解释：** 必填字段名称。 描述：Body 严重程度：Severity 指派给：AssigneeId 意见分类：ReviewCategories 意见模块：ReviewModules
        /// </summary>
        /// <value>**参数解释：** 必填字段名称。 描述：Body 严重程度：Severity 指派给：AssigneeId 意见分类：ReviewCategories 意见模块：ReviewModules</value>
        [JsonConverter(typeof(EnumClassConverter<NameEnum>))]
        public class NameEnum
        {
            /// <summary>
            /// Enum BODY for value: Body
            /// </summary>
            public static readonly NameEnum BODY = new NameEnum("Body");

            /// <summary>
            /// Enum SEVERITY for value: Severity
            /// </summary>
            public static readonly NameEnum SEVERITY = new NameEnum("Severity");

            /// <summary>
            /// Enum ASSIGNEEID for value: AssigneeId
            /// </summary>
            public static readonly NameEnum ASSIGNEEID = new NameEnum("AssigneeId");

            /// <summary>
            /// Enum REVIEWCATEGORIES for value: ReviewCategories
            /// </summary>
            public static readonly NameEnum REVIEWCATEGORIES = new NameEnum("ReviewCategories");

            /// <summary>
            /// Enum REVIEWMODULES for value: ReviewModules
            /// </summary>
            public static readonly NameEnum REVIEWMODULES = new NameEnum("ReviewModules");

            private static readonly Dictionary<string, NameEnum> StaticFields =
            new Dictionary<string, NameEnum>()
            {
                { "Body", BODY },
                { "Severity", SEVERITY },
                { "AssigneeId", ASSIGNEEID },
                { "ReviewCategories", REVIEWCATEGORIES },
                { "ReviewModules", REVIEWMODULES },
            };

            private string _value;

            public NameEnum()
            {

            }

            public NameEnum(string value)
            {
                _value = value;
            }

            public static NameEnum FromValue(string value)
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

                if (this.Equals(obj as NameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NameEnum a, NameEnum b)
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

            public static bool operator !=(NameEnum a, NameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 必填字段名称。 描述：Body 严重程度：Severity 指派给：AssigneeId 意见分类：ReviewCategories 意见模块：ReviewModules
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// **参数解释：** 是否必填。
        /// </summary>
        [JsonProperty("is_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRequired { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequiredAttributeDto {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  isRequired: ").Append(IsRequired).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequiredAttributeDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RequiredAttributeDto input)
        {
            if (input == null) return false;
            if (this.Name != input.Name) return false;
            if (this.IsRequired != input.IsRequired || (this.IsRequired != null && !this.IsRequired.Equals(input.IsRequired))) return false;

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
                hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsRequired != null) hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                return hashCode;
            }
        }
    }
}
