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
    /// 创建连接请求体。
    /// </summary>
    public class CreateConnectionReq 
    {
        /// <summary>
        /// 连接类型，包含： - mysql - postgresql - mongodb - oracle
        /// </summary>
        /// <value>连接类型，包含： - mysql - postgresql - mongodb - oracle</value>
        [JsonConverter(typeof(EnumClassConverter<DbTypeEnum>))]
        public class DbTypeEnum
        {
            /// <summary>
            /// Enum MYSQL for value: mysql
            /// </summary>
            public static readonly DbTypeEnum MYSQL = new DbTypeEnum("mysql");

            /// <summary>
            /// Enum POSTGRESQL for value: postgresql
            /// </summary>
            public static readonly DbTypeEnum POSTGRESQL = new DbTypeEnum("postgresql");

            /// <summary>
            /// Enum MONGODB for value: mongodb
            /// </summary>
            public static readonly DbTypeEnum MONGODB = new DbTypeEnum("mongodb");

            /// <summary>
            /// Enum ORACLE for value: oracle
            /// </summary>
            public static readonly DbTypeEnum ORACLE = new DbTypeEnum("oracle");

            private static readonly Dictionary<string, DbTypeEnum> StaticFields =
            new Dictionary<string, DbTypeEnum>()
            {
                { "mysql", MYSQL },
                { "postgresql", POSTGRESQL },
                { "mongodb", MONGODB },
                { "oracle", ORACLE },
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
        /// 连接名称。 约束：连接名称在4位到50位之间，不区分大小写，可以包含字母、数字、中划线或下划线，不能包括其他特殊字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 连接类型，包含： - mysql - postgresql - mongodb - oracle
        /// </summary>
        [JsonProperty("db_type", NullValueHandling = NullValueHandling.Ignore)]
        public DbTypeEnum DbType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public ConnectionConfig Config { get; set; }

        /// <summary>
        /// 描述，长度不能超过255个字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public BaseEndpoint Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vpc", NullValueHandling = NullValueHandling.Ignore)]
        public CloudVpcInfo Vpc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ssl", NullValueHandling = NullValueHandling.Ignore)]
        public EndpointSslConfig Ssl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cloud", NullValueHandling = NullValueHandling.Ignore)]
        public CloudBaseInfo Cloud { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateConnectionReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  dbType: ").Append(DbType).Append("\n");
            sb.Append("  config: ").Append(Config).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  vpc: ").Append(Vpc).Append("\n");
            sb.Append("  ssl: ").Append(Ssl).Append("\n");
            sb.Append("  cloud: ").Append(Cloud).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateConnectionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateConnectionReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DbType == input.DbType ||
                    (this.DbType != null &&
                    this.DbType.Equals(input.DbType))
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Vpc == input.Vpc ||
                    (this.Vpc != null &&
                    this.Vpc.Equals(input.Vpc))
                ) && 
                (
                    this.Ssl == input.Ssl ||
                    (this.Ssl != null &&
                    this.Ssl.Equals(input.Ssl))
                ) && 
                (
                    this.Cloud == input.Cloud ||
                    (this.Cloud != null &&
                    this.Cloud.Equals(input.Cloud))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DbType != null)
                    hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Vpc != null)
                    hashCode = hashCode * 59 + this.Vpc.GetHashCode();
                if (this.Ssl != null)
                    hashCode = hashCode * 59 + this.Ssl.GetHashCode();
                if (this.Cloud != null)
                    hashCode = hashCode * 59 + this.Cloud.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
