using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 配置参数结构
    /// </summary>
    public class PackageOptions 
    {
        /// <summary>
        /// **参数解释**： 参数生效方式 **取值范围**： - static：集群、节点池创建时生效，后续不可修改 - immediately：集群、节点池运行中时可以修改，修改后生效
        /// </summary>
        /// <value>**参数解释**： 参数生效方式 **取值范围**： - static：集群、节点池创建时生效，后续不可修改 - immediately：集群、节点池运行中时可以修改，修改后生效</value>
        [JsonConverter(typeof(EnumClassConverter<ValidAtEnum>))]
        public class ValidAtEnum
        {
            /// <summary>
            /// Enum STATIC for value: static
            /// </summary>
            public static readonly ValidAtEnum STATIC = new ValidAtEnum("static");

            /// <summary>
            /// Enum IMMEDIATELY for value: immediately
            /// </summary>
            public static readonly ValidAtEnum IMMEDIATELY = new ValidAtEnum("immediately");

            private static readonly Dictionary<string, ValidAtEnum> StaticFields =
            new Dictionary<string, ValidAtEnum>()
            {
                { "static", STATIC },
                { "immediately", IMMEDIATELY },
            };

            private string _value;

            public ValidAtEnum()
            {

            }

            public ValidAtEnum(string value)
            {
                _value = value;
            }

            public static ValidAtEnum FromValue(string value)
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

                if (this.Equals(obj as ValidAtEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ValidAtEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ValidAtEnum a, ValidAtEnum b)
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

            public static bool operator !=(ValidAtEnum a, ValidAtEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 参数名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 参数默认值，不指定时按默认值生效, 参数类型以实际返回为准，可能为integer,string或者boolean **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public Object Default { get; set; }

        /// <summary>
        /// **参数解释**： 参数生效方式 **取值范围**： - static：集群、节点池创建时生效，后续不可修改 - immediately：集群、节点池运行中时可以修改，修改后生效
        /// </summary>
        [JsonProperty("validAt", NullValueHandling = NullValueHandling.Ignore)]
        public ValidAtEnum ValidAt { get; set; }
        /// <summary>
        /// **参数解释**： 配置项是否可以为空 **取值范围**： - true：配置项为空时，不使用默认值，为空值 - false：配置项为空时，使用默认值
        /// </summary>
        [JsonProperty("empty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Empty { get; set; }

        /// <summary>
        /// **参数解释**： 参数分类 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }

        /// <summary>
        /// **参数解释**： 参数类型 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageOptions {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  validAt: ").Append(ValidAt).Append("\n");
            sb.Append("  empty: ").Append(Empty).Append("\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PackageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PackageOptions input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Default != input.Default || (this.Default != null && !this.Default.Equals(input.Default))) return false;
            if (this.ValidAt != input.ValidAt) return false;
            if (this.Empty != input.Empty || (this.Empty != null && !this.Empty.Equals(input.Empty))) return false;
            if (this.Schema != input.Schema || (this.Schema != null && !this.Schema.Equals(input.Schema))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Default != null) hashCode = hashCode * 59 + this.Default.GetHashCode();
                hashCode = hashCode * 59 + this.ValidAt.GetHashCode();
                if (this.Empty != null) hashCode = hashCode * 59 + this.Empty.GetHashCode();
                if (this.Schema != null) hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
