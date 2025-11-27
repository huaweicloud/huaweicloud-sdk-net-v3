using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 更新私网NAT网关实例的请求体。
    /// </summary>
    public class UpdatePrivateNatOption 
    {
        /// <summary>
        /// 私网NAT网关实例的规格。 取值为： \&quot;Small\&quot;：小型 \&quot;Medium\&quot;：中型 \&quot;Large\&quot;：大型 \&quot;Extra-large\&quot;：超大型 \&quot;Extra-xlarge\&quot;：企业型
        /// </summary>
        /// <value>私网NAT网关实例的规格。 取值为： \&quot;Small\&quot;：小型 \&quot;Medium\&quot;：中型 \&quot;Large\&quot;：大型 \&quot;Extra-large\&quot;：超大型 \&quot;Extra-xlarge\&quot;：企业型</value>
        [JsonConverter(typeof(EnumClassConverter<SpecEnum>))]
        public class SpecEnum
        {
            /// <summary>
            /// Enum SMALL for value: Small
            /// </summary>
            public static readonly SpecEnum SMALL = new SpecEnum("Small");

            /// <summary>
            /// Enum MEDIUM for value: Medium
            /// </summary>
            public static readonly SpecEnum MEDIUM = new SpecEnum("Medium");

            /// <summary>
            /// Enum LARGE for value: Large
            /// </summary>
            public static readonly SpecEnum LARGE = new SpecEnum("Large");

            /// <summary>
            /// Enum EXTRA_LARGE for value: Extra-large
            /// </summary>
            public static readonly SpecEnum EXTRA_LARGE = new SpecEnum("Extra-large");

            /// <summary>
            /// Enum EXTRA_XLARGE for value: Extra-xlarge
            /// </summary>
            public static readonly SpecEnum EXTRA_XLARGE = new SpecEnum("Extra-xlarge");

            private static readonly Dictionary<string, SpecEnum> StaticFields =
            new Dictionary<string, SpecEnum>()
            {
                { "Small", SMALL },
                { "Medium", MEDIUM },
                { "Large", LARGE },
                { "Extra-large", EXTRA_LARGE },
                { "Extra-xlarge", EXTRA_XLARGE },
            };

            private string _value;

            public SpecEnum()
            {

            }

            public SpecEnum(string value)
            {
                _value = value;
            }

            public static SpecEnum FromValue(string value)
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

                if (this.Equals(obj as SpecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SpecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SpecEnum a, SpecEnum b)
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

            public static bool operator !=(SpecEnum a, SpecEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 私网NAT网关实例的名字。 私网NAT网关实例的名字仅支持数字、字母、_（下划线）、-（中划线）、中文。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 私网NAT网关的描述。长度范围小于等于255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 私网NAT网关实例的规格。 取值为： \&quot;Small\&quot;：小型 \&quot;Medium\&quot;：中型 \&quot;Large\&quot;：大型 \&quot;Extra-large\&quot;：超大型 \&quot;Extra-xlarge\&quot;：企业型
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public SpecEnum Spec { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePrivateNatOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePrivateNatOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePrivateNatOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Spec != input.Spec) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Spec.GetHashCode();
                return hashCode;
            }
        }
    }
}
