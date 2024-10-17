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
    /// 数据库基本信息体。
    /// </summary>
    public class BaseEndpoint 
    {
        /// <summary>
        /// 数据库场景类型。取值： - oracle：云下自建Oracle数据库。 - ecs_oracle：华为云ECS自建Oracle数据库。 - cloud_gaussdbv5：华为云数据库GaussDB分布式。 - mysql：他云/本地自建MySQL数据库。 - ecs_mysql：华为云ECS自建MySQL数据库。 - cloud_mysql：华为云数据库RDS for MySQL。 - redis：云下自建Redis数据。 - ecs_redis：华为云ECS自建Redis数据。 - rediscluster：云下自建Redis集群数据库。 - ecs_rediscluster：华为云ECS自建Redis集群数据库。 - cloud_gaussdb_redis：华为云数据库GeminiDB Redis。 - postgresql: 云下自建PostgreSQL数据库。 - ecs_postgresql: 华为云ECS自建PostgreSQL数据库。 - cloud_postgresql: 华为云数据库RDS for PostgreSQL。 - mongodb: 云下自建MongoDB数据库。 - ecs_mongodb: 华为云ECS自建MongoDB数据库。 - cloud_mongodb: 华为云文档数据库服务DDS。
        /// </summary>
        /// <value>数据库场景类型。取值： - oracle：云下自建Oracle数据库。 - ecs_oracle：华为云ECS自建Oracle数据库。 - cloud_gaussdbv5：华为云数据库GaussDB分布式。 - mysql：他云/本地自建MySQL数据库。 - ecs_mysql：华为云ECS自建MySQL数据库。 - cloud_mysql：华为云数据库RDS for MySQL。 - redis：云下自建Redis数据。 - ecs_redis：华为云ECS自建Redis数据。 - rediscluster：云下自建Redis集群数据库。 - ecs_rediscluster：华为云ECS自建Redis集群数据库。 - cloud_gaussdb_redis：华为云数据库GeminiDB Redis。 - postgresql: 云下自建PostgreSQL数据库。 - ecs_postgresql: 华为云ECS自建PostgreSQL数据库。 - cloud_postgresql: 华为云数据库RDS for PostgreSQL。 - mongodb: 云下自建MongoDB数据库。 - ecs_mongodb: 华为云ECS自建MongoDB数据库。 - cloud_mongodb: 华为云文档数据库服务DDS。</value>
        [JsonConverter(typeof(EnumClassConverter<EndpointNameEnum>))]
        public class EndpointNameEnum
        {
            /// <summary>
            /// Enum ORACLE for value: oracle
            /// </summary>
            public static readonly EndpointNameEnum ORACLE = new EndpointNameEnum("oracle");

            /// <summary>
            /// Enum ECS_ORACLE for value: ecs_oracle
            /// </summary>
            public static readonly EndpointNameEnum ECS_ORACLE = new EndpointNameEnum("ecs_oracle");

            /// <summary>
            /// Enum CLOUD_GAUSSDBV5 for value: cloud_gaussdbv5
            /// </summary>
            public static readonly EndpointNameEnum CLOUD_GAUSSDBV5 = new EndpointNameEnum("cloud_gaussdbv5");

            /// <summary>
            /// Enum MYSQL for value: mysql
            /// </summary>
            public static readonly EndpointNameEnum MYSQL = new EndpointNameEnum("mysql");

            /// <summary>
            /// Enum ECS_MYSQL for value: ecs_mysql
            /// </summary>
            public static readonly EndpointNameEnum ECS_MYSQL = new EndpointNameEnum("ecs_mysql");

            /// <summary>
            /// Enum CLOUD_MYSQL for value: cloud_mysql
            /// </summary>
            public static readonly EndpointNameEnum CLOUD_MYSQL = new EndpointNameEnum("cloud_mysql");

            /// <summary>
            /// Enum REDIS for value: redis
            /// </summary>
            public static readonly EndpointNameEnum REDIS = new EndpointNameEnum("redis");

            /// <summary>
            /// Enum ECS_REDIS for value: ecs_redis
            /// </summary>
            public static readonly EndpointNameEnum ECS_REDIS = new EndpointNameEnum("ecs_redis");

            /// <summary>
            /// Enum REDISCLUSTER for value: rediscluster
            /// </summary>
            public static readonly EndpointNameEnum REDISCLUSTER = new EndpointNameEnum("rediscluster");

            /// <summary>
            /// Enum ECS_REDISCLUSTER for value: ecs_rediscluster
            /// </summary>
            public static readonly EndpointNameEnum ECS_REDISCLUSTER = new EndpointNameEnum("ecs_rediscluster");

            /// <summary>
            /// Enum CLOUD_GAUSSDB_REDIS for value: cloud_gaussdb_redis
            /// </summary>
            public static readonly EndpointNameEnum CLOUD_GAUSSDB_REDIS = new EndpointNameEnum("cloud_gaussdb_redis");

            /// <summary>
            /// Enum POSTGRESQL for value: postgresql
            /// </summary>
            public static readonly EndpointNameEnum POSTGRESQL = new EndpointNameEnum("postgresql");

            /// <summary>
            /// Enum ECS_POSTGRESQL for value: ecs_postgresql
            /// </summary>
            public static readonly EndpointNameEnum ECS_POSTGRESQL = new EndpointNameEnum("ecs_postgresql");

            /// <summary>
            /// Enum CLOUD_POSTGRESQL for value: cloud_postgresql
            /// </summary>
            public static readonly EndpointNameEnum CLOUD_POSTGRESQL = new EndpointNameEnum("cloud_postgresql");

            /// <summary>
            /// Enum MONGODB for value: mongodb
            /// </summary>
            public static readonly EndpointNameEnum MONGODB = new EndpointNameEnum("mongodb");

            /// <summary>
            /// Enum ECS_MONGODB for value: ecs_mongodb
            /// </summary>
            public static readonly EndpointNameEnum ECS_MONGODB = new EndpointNameEnum("ecs_mongodb");

            /// <summary>
            /// Enum CLOUD_MONGODB for value: cloud_mongodb
            /// </summary>
            public static readonly EndpointNameEnum CLOUD_MONGODB = new EndpointNameEnum("cloud_mongodb");

            private static readonly Dictionary<string, EndpointNameEnum> StaticFields =
            new Dictionary<string, EndpointNameEnum>()
            {
                { "oracle", ORACLE },
                { "ecs_oracle", ECS_ORACLE },
                { "cloud_gaussdbv5", CLOUD_GAUSSDBV5 },
                { "mysql", MYSQL },
                { "ecs_mysql", ECS_MYSQL },
                { "cloud_mysql", CLOUD_MYSQL },
                { "redis", REDIS },
                { "ecs_redis", ECS_REDIS },
                { "rediscluster", REDISCLUSTER },
                { "ecs_rediscluster", ECS_REDISCLUSTER },
                { "cloud_gaussdb_redis", CLOUD_GAUSSDB_REDIS },
                { "postgresql", POSTGRESQL },
                { "ecs_postgresql", ECS_POSTGRESQL },
                { "cloud_postgresql", CLOUD_POSTGRESQL },
                { "mongodb", MONGODB },
                { "ecs_mongodb", ECS_MONGODB },
                { "cloud_mongodb", CLOUD_MONGODB },
            };

            private string _value;

            public EndpointNameEnum()
            {

            }

            public EndpointNameEnum(string value)
            {
                _value = value;
            }

            public static EndpointNameEnum FromValue(string value)
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

                if (this.Equals(obj as EndpointNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EndpointNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EndpointNameEnum a, EndpointNameEnum b)
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

            public static bool operator !=(EndpointNameEnum a, EndpointNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库信息ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 数据库场景类型。取值： - oracle：云下自建Oracle数据库。 - ecs_oracle：华为云ECS自建Oracle数据库。 - cloud_gaussdbv5：华为云数据库GaussDB分布式。 - mysql：他云/本地自建MySQL数据库。 - ecs_mysql：华为云ECS自建MySQL数据库。 - cloud_mysql：华为云数据库RDS for MySQL。 - redis：云下自建Redis数据。 - ecs_redis：华为云ECS自建Redis数据。 - rediscluster：云下自建Redis集群数据库。 - ecs_rediscluster：华为云ECS自建Redis集群数据库。 - cloud_gaussdb_redis：华为云数据库GeminiDB Redis。 - postgresql: 云下自建PostgreSQL数据库。 - ecs_postgresql: 华为云ECS自建PostgreSQL数据库。 - cloud_postgresql: 华为云数据库RDS for PostgreSQL。 - mongodb: 云下自建MongoDB数据库。 - ecs_mongodb: 华为云ECS自建MongoDB数据库。 - cloud_mongodb: 华为云文档数据库服务DDS。
        /// </summary>
        [JsonProperty("endpoint_name", NullValueHandling = NullValueHandling.Ignore)]
        public EndpointNameEnum EndpointName { get; set; }
        /// <summary>
        /// 数据库IP。 约束： - 数据库为自建MongoDB时，数据库IP与端口之间用“:”英文冒号拼接，多个值之间请用“,”英文逗号隔开，最多支持填写3个IP地址或域名。 - 数据库为DDS实例时，数据库IP与端口之间用“:”英文冒号拼接，多个IP端口之间请用“,”英文逗号分隔。 - 数据库为Redis集群时，请填写源端Redis集群所有分片的IP地址和对应端口，数据库IP与端口之间用“:”英文冒号拼接，多个IP端口之间请用“,”英文逗号分隔，并且推荐填写集群分片的Slave节点的IP地址。最多支持填写32个IP地址或域名，多个值之间请用英文逗号隔开。 示例： - MySQL：ip - MongoDB：ip:port,ip:port,ip:port - DDS：ip:port,ip:port  - Redis集群：ip:port,ip:port
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 数据库端口。  约束：输入范围为1-65535之间的整数。
        /// </summary>
        [JsonProperty("db_port", NullValueHandling = NullValueHandling.Ignore)]
        public string DbPort { get; set; }

        /// <summary>
        /// 数据库用户名。
        /// </summary>
        [JsonProperty("db_user", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUser { get; set; }

        /// <summary>
        /// 数据库密码。
        /// </summary>
        [JsonProperty("db_password", NullValueHandling = NullValueHandling.Ignore)]
        public string DbPassword { get; set; }

        /// <summary>
        /// 华为云数据库实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 华为云数据库实例名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 指定数据库名称。例如： - oracle：serviceName.orcl。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 物理源库信息。
        /// </summary>
        [JsonProperty("source_sharding", NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseEndpoint> SourceSharding { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseEndpoint {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  endpointName: ").Append(EndpointName).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  dbPort: ").Append(DbPort).Append("\n");
            sb.Append("  dbUser: ").Append(DbUser).Append("\n");
            sb.Append("  dbPassword: ").Append(DbPassword).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  sourceSharding: ").Append(SourceSharding).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseEndpoint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BaseEndpoint input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.EndpointName != input.EndpointName) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.DbPort != input.DbPort || (this.DbPort != null && !this.DbPort.Equals(input.DbPort))) return false;
            if (this.DbUser != input.DbUser || (this.DbUser != null && !this.DbUser.Equals(input.DbUser))) return false;
            if (this.DbPassword != input.DbPassword || (this.DbPassword != null && !this.DbPassword.Equals(input.DbPassword))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.SourceSharding != input.SourceSharding || (this.SourceSharding != null && input.SourceSharding != null && !this.SourceSharding.SequenceEqual(input.SourceSharding))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.EndpointName.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.DbPort != null) hashCode = hashCode * 59 + this.DbPort.GetHashCode();
                if (this.DbUser != null) hashCode = hashCode * 59 + this.DbUser.GetHashCode();
                if (this.DbPassword != null) hashCode = hashCode * 59 + this.DbPassword.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SourceSharding != null) hashCode = hashCode * 59 + this.SourceSharding.GetHashCode();
                return hashCode;
            }
        }
    }
}
