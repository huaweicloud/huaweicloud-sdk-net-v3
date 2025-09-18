using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 创建服务委托的请求消息体。
    /// </summary>
    public class CreateAgencyRequestBody 
    {
        /// <summary>
        /// 凭据类型。
        /// </summary>
        /// <value>凭据类型。</value>
        [JsonConverter(typeof(EnumClassConverter<SecretTypeEnum>))]
        public class SecretTypeEnum
        {
            /// <summary>
            /// Enum RDS_FG for value: RDS-FG
            /// </summary>
            public static readonly SecretTypeEnum RDS_FG = new SecretTypeEnum("RDS-FG");

            /// <summary>
            /// Enum GAUSSDB_FG for value: GaussDB-FG
            /// </summary>
            public static readonly SecretTypeEnum GAUSSDB_FG = new SecretTypeEnum("GaussDB-FG");

            private static readonly Dictionary<string, SecretTypeEnum> StaticFields =
            new Dictionary<string, SecretTypeEnum>()
            {
                { "RDS-FG", RDS_FG },
                { "GaussDB-FG", GAUSSDB_FG },
            };

            private string _value;

            public SecretTypeEnum()
            {

            }

            public SecretTypeEnum(string value)
            {
                _value = value;
            }

            public static SecretTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SecretTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SecretTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SecretTypeEnum a, SecretTypeEnum b)
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

            public static bool operator !=(SecretTypeEnum a, SecretTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 凭据类型。
        /// </summary>
        [JsonProperty("secret_type", NullValueHandling = NullValueHandling.Ignore)]
        public SecretTypeEnum SecretType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAgencyRequestBody {\n");
            sb.Append("  secretType: ").Append(SecretType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAgencyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAgencyRequestBody input)
        {
            if (input == null) return false;
            if (this.SecretType != input.SecretType) return false;

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
                hashCode = hashCode * 59 + this.SecretType.GetHashCode();
                return hashCode;
            }
        }
    }
}
