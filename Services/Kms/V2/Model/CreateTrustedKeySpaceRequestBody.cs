using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// 创建密钥空间请求体
    /// </summary>
    public class CreateTrustedKeySpaceRequestBody 
    {
        /// <summary>
        /// **参数解释：** 密钥空间类型 **约束限制：** 不涉及 **取值范围：** - 1 默认密钥空间 - 2 专属加密集群密钥空间 - 3 外部密钥存储密钥空间 **默认取值：** 1
        /// </summary>
        /// <value>**参数解释：** 密钥空间类型 **约束限制：** 不涉及 **取值范围：** - 1 默认密钥空间 - 2 专属加密集群密钥空间 - 3 外部密钥存储密钥空间 **默认取值：** 1</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly TypeEnum _1 = new TypeEnum("1");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly TypeEnum _2 = new TypeEnum("2");

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            public static readonly TypeEnum _3 = new TypeEnum("3");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "1", _1 },
                { "2", _2 },
                { "3", _3 },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 密钥空间名称 **约束限制：** 不涉及 **取值范围：** 1-255 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("keyspace_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyspaceName { get; set; }

        /// <summary>
        /// **参数解释：** 密钥空间类型 **约束限制：** 不涉及 **取值范围：** - 1 默认密钥空间 - 2 专属加密集群密钥空间 - 3 外部密钥存储密钥空间 **默认取值：** 1
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释：** 密钥空间关联的密钥库ID,仅type为2或3时必填，关联的密钥库ID需要和类型匹配 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("keystore_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreId { get; set; }

        /// <summary>
        /// **参数解释：** 密钥空间描述信息 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrustedKeySpaceRequestBody {\n");
            sb.Append("  keyspaceName: ").Append(KeyspaceName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  keystoreId: ").Append(KeystoreId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrustedKeySpaceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrustedKeySpaceRequestBody input)
        {
            if (input == null) return false;
            if (this.KeyspaceName != input.KeyspaceName || (this.KeyspaceName != null && !this.KeyspaceName.Equals(input.KeyspaceName))) return false;
            if (this.Type != input.Type) return false;
            if (this.KeystoreId != input.KeystoreId || (this.KeystoreId != null && !this.KeystoreId.Equals(input.KeystoreId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.KeyspaceName != null) hashCode = hashCode * 59 + this.KeyspaceName.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.KeystoreId != null) hashCode = hashCode * 59 + this.KeystoreId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
