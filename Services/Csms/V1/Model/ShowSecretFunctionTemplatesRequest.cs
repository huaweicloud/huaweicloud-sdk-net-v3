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
    /// Request Object
    /// </summary>
    public class ShowSecretFunctionTemplatesRequest 
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
        /// 凭据轮转账号类型。 - SingleUser：单用户模式轮转 - MultiUser：双用户模式轮转
        /// </summary>
        /// <value>凭据轮转账号类型。 - SingleUser：单用户模式轮转 - MultiUser：双用户模式轮转</value>
        [JsonConverter(typeof(EnumClassConverter<SecretSubTypeEnum>))]
        public class SecretSubTypeEnum
        {
            /// <summary>
            /// Enum SINGLEUSER for value: SingleUser
            /// </summary>
            public static readonly SecretSubTypeEnum SINGLEUSER = new SecretSubTypeEnum("SingleUser");

            /// <summary>
            /// Enum MULTIUSER for value: MultiUser
            /// </summary>
            public static readonly SecretSubTypeEnum MULTIUSER = new SecretSubTypeEnum("MultiUser");

            private static readonly Dictionary<string, SecretSubTypeEnum> StaticFields =
            new Dictionary<string, SecretSubTypeEnum>()
            {
                { "SingleUser", SINGLEUSER },
                { "MultiUser", MULTIUSER },
            };

            private string _value;

            public SecretSubTypeEnum()
            {

            }

            public SecretSubTypeEnum(string value)
            {
                _value = value;
            }

            public static SecretSubTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SecretSubTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SecretSubTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SecretSubTypeEnum a, SecretSubTypeEnum b)
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

            public static bool operator !=(SecretSubTypeEnum a, SecretSubTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 数据库类型。凭据类型为RDS-FG时为必填参数，可传入mysql、postgresql、sqlserver。其余凭据类型不支持。
        /// </summary>
        /// <value>数据库类型。凭据类型为RDS-FG时为必填参数，可传入mysql、postgresql、sqlserver。其余凭据类型不支持。</value>
        [JsonConverter(typeof(EnumClassConverter<EngineEnum>))]
        public class EngineEnum
        {
            /// <summary>
            /// Enum MYSQL for value: mysql
            /// </summary>
            public static readonly EngineEnum MYSQL = new EngineEnum("mysql");

            /// <summary>
            /// Enum POSTGRESQL for value: postgresql
            /// </summary>
            public static readonly EngineEnum POSTGRESQL = new EngineEnum("postgresql");

            /// <summary>
            /// Enum SQLSERVER for value: sqlserver
            /// </summary>
            public static readonly EngineEnum SQLSERVER = new EngineEnum("sqlserver");

            private static readonly Dictionary<string, EngineEnum> StaticFields =
            new Dictionary<string, EngineEnum>()
            {
                { "mysql", MYSQL },
                { "postgresql", POSTGRESQL },
                { "sqlserver", SQLSERVER },
            };

            private string _value;

            public EngineEnum()
            {

            }

            public EngineEnum(string value)
            {
                _value = value;
            }

            public static EngineEnum FromValue(string value)
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

                if (this.Equals(obj as EngineEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EngineEnum a, EngineEnum b)
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

            public static bool operator !=(EngineEnum a, EngineEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 凭据类型。
        /// </summary>
        [SDKProperty("secret_type", IsQuery = true)]
        [JsonProperty("secret_type", NullValueHandling = NullValueHandling.Ignore)]
        public SecretTypeEnum SecretType { get; set; }
        /// <summary>
        /// 凭据轮转账号类型。 - SingleUser：单用户模式轮转 - MultiUser：双用户模式轮转
        /// </summary>
        [SDKProperty("secret_sub_type", IsQuery = true)]
        [JsonProperty("secret_sub_type", NullValueHandling = NullValueHandling.Ignore)]
        public SecretSubTypeEnum SecretSubType { get; set; }
        /// <summary>
        /// 数据库类型。凭据类型为RDS-FG时为必填参数，可传入mysql、postgresql、sqlserver。其余凭据类型不支持。
        /// </summary>
        [SDKProperty("engine", IsQuery = true)]
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public EngineEnum Engine { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSecretFunctionTemplatesRequest {\n");
            sb.Append("  secretType: ").Append(SecretType).Append("\n");
            sb.Append("  secretSubType: ").Append(SecretSubType).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSecretFunctionTemplatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSecretFunctionTemplatesRequest input)
        {
            if (input == null) return false;
            if (this.SecretType != input.SecretType) return false;
            if (this.SecretSubType != input.SecretSubType) return false;
            if (this.Engine != input.Engine) return false;

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
                hashCode = hashCode * 59 + this.SecretSubType.GetHashCode();
                hashCode = hashCode * 59 + this.Engine.GetHashCode();
                return hashCode;
            }
        }
    }
}
