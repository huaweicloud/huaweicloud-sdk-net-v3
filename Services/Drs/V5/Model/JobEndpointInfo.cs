using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 创建任务数据库信息体。
    /// </summary>
    public class JobEndpointInfo 
    {
        /// <summary>
        /// 数据库类型。取值： - oracle：Oracle。 - gaussdbv5：GaussDB分布式版。
        /// </summary>
        /// <value>数据库类型。取值： - oracle：Oracle。 - gaussdbv5：GaussDB分布式版。</value>
        [JsonConverter(typeof(EnumClassConverter<DbTypeEnum>))]
        public class DbTypeEnum
        {
            /// <summary>
            /// Enum ORACLE for value: oracle
            /// </summary>
            public static readonly DbTypeEnum ORACLE = new DbTypeEnum("oracle");

            /// <summary>
            /// Enum GAUSSDBV5 for value: gaussdbv5
            /// </summary>
            public static readonly DbTypeEnum GAUSSDBV5 = new DbTypeEnum("gaussdbv5");

            private static readonly Dictionary<string, DbTypeEnum> StaticFields =
            new Dictionary<string, DbTypeEnum>()
            {
                { "oracle", ORACLE },
                { "gaussdbv5", GAUSSDBV5 },
            };

            private string _value;

            public DbTypeEnum()
            {

            }

            public DbTypeEnum(string value)
            {
                _value = value;
            }

            public static DbTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DbTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DbTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DbTypeEnum a, DbTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DbTypeEnum a, DbTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 数据库实例类型。取值： - offline：自建数据库。 - ecs：华为云ECS自建数据库。 - cloud：华为云数据库。
        /// </summary>
        /// <value>数据库实例类型。取值： - offline：自建数据库。 - ecs：华为云ECS自建数据库。 - cloud：华为云数据库。</value>
        [JsonConverter(typeof(EnumClassConverter<EndpointTypeEnum>))]
        public class EndpointTypeEnum
        {
            /// <summary>
            /// Enum OFFLINE for value: offline
            /// </summary>
            public static readonly EndpointTypeEnum OFFLINE = new EndpointTypeEnum("offline");

            /// <summary>
            /// Enum ECS for value: ecs
            /// </summary>
            public static readonly EndpointTypeEnum ECS = new EndpointTypeEnum("ecs");

            /// <summary>
            /// Enum CLOUD for value: cloud
            /// </summary>
            public static readonly EndpointTypeEnum CLOUD = new EndpointTypeEnum("cloud");

            private static readonly Dictionary<string, EndpointTypeEnum> StaticFields =
            new Dictionary<string, EndpointTypeEnum>()
            {
                { "offline", OFFLINE },
                { "ecs", ECS },
                { "cloud", CLOUD },
            };

            private string _value;

            public EndpointTypeEnum()
            {

            }

            public EndpointTypeEnum(string value)
            {
                _value = value;
            }

            public static EndpointTypeEnum FromValue(string value)
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

                if (this.Equals(obj as EndpointTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EndpointTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EndpointTypeEnum a, EndpointTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(EndpointTypeEnum a, EndpointTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 数据库实例角色。取值： - so：源库。 - ta：目标库。
        /// </summary>
        /// <value>数据库实例角色。取值： - so：源库。 - ta：目标库。</value>
        [JsonConverter(typeof(EnumClassConverter<EndpointRoleEnum>))]
        public class EndpointRoleEnum
        {
            /// <summary>
            /// Enum SO for value: so
            /// </summary>
            public static readonly EndpointRoleEnum SO = new EndpointRoleEnum("so");

            /// <summary>
            /// Enum TA for value: ta
            /// </summary>
            public static readonly EndpointRoleEnum TA = new EndpointRoleEnum("ta");

            private static readonly Dictionary<string, EndpointRoleEnum> StaticFields =
            new Dictionary<string, EndpointRoleEnum>()
            {
                { "so", SO },
                { "ta", TA },
            };

            private string _value;

            public EndpointRoleEnum()
            {

            }

            public EndpointRoleEnum(string value)
            {
                _value = value;
            }

            public static EndpointRoleEnum FromValue(string value)
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

                if (this.Equals(obj as EndpointRoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EndpointRoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EndpointRoleEnum a, EndpointRoleEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(EndpointRoleEnum a, EndpointRoleEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库类型。取值： - oracle：Oracle。 - gaussdbv5：GaussDB分布式版。
        /// </summary>
        [JsonProperty("db_type", NullValueHandling = NullValueHandling.Ignore)]
        public DbTypeEnum DbType { get; set; }
        /// <summary>
        /// 数据库实例类型。取值： - offline：自建数据库。 - ecs：华为云ECS自建数据库。 - cloud：华为云数据库。
        /// </summary>
        [JsonProperty("endpoint_type", NullValueHandling = NullValueHandling.Ignore)]
        public EndpointTypeEnum EndpointType { get; set; }
        /// <summary>
        /// 数据库实例角色。取值： - so：源库。 - ta：目标库。
        /// </summary>
        [JsonProperty("endpoint_role", NullValueHandling = NullValueHandling.Ignore)]
        public EndpointRoleEnum EndpointRole { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public BaseEndpoint Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cloud", NullValueHandling = NullValueHandling.Ignore)]
        public CloudBaseInfo Cloud { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vpc", NullValueHandling = NullValueHandling.Ignore)]
        public CloudVpcInfo Vpc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public BaseEndpointConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ssl", NullValueHandling = NullValueHandling.Ignore)]
        public EndpointSslConfig Ssl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobEndpointInfo {\n");
            sb.Append("  dbType: ").Append(DbType).Append("\n");
            sb.Append("  endpointType: ").Append(EndpointType).Append("\n");
            sb.Append("  endpointRole: ").Append(EndpointRole).Append("\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  cloud: ").Append(Cloud).Append("\n");
            sb.Append("  vpc: ").Append(Vpc).Append("\n");
            sb.Append("  config: ").Append(Config).Append("\n");
            sb.Append("  ssl: ").Append(Ssl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobEndpointInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobEndpointInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbType == input.DbType ||
                    (this.DbType != null &&
                    this.DbType.Equals(input.DbType))
                ) && 
                (
                    this.EndpointType == input.EndpointType ||
                    (this.EndpointType != null &&
                    this.EndpointType.Equals(input.EndpointType))
                ) && 
                (
                    this.EndpointRole == input.EndpointRole ||
                    (this.EndpointRole != null &&
                    this.EndpointRole.Equals(input.EndpointRole))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Cloud == input.Cloud ||
                    (this.Cloud != null &&
                    this.Cloud.Equals(input.Cloud))
                ) && 
                (
                    this.Vpc == input.Vpc ||
                    (this.Vpc != null &&
                    this.Vpc.Equals(input.Vpc))
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.Ssl == input.Ssl ||
                    (this.Ssl != null &&
                    this.Ssl.Equals(input.Ssl))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DbType != null)
                    hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.EndpointType != null)
                    hashCode = hashCode * 59 + this.EndpointType.GetHashCode();
                if (this.EndpointRole != null)
                    hashCode = hashCode * 59 + this.EndpointRole.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Cloud != null)
                    hashCode = hashCode * 59 + this.Cloud.GetHashCode();
                if (this.Vpc != null)
                    hashCode = hashCode * 59 + this.Vpc.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Ssl != null)
                    hashCode = hashCode * 59 + this.Ssl.GetHashCode();
                return hashCode;
            }
        }
    }
}
