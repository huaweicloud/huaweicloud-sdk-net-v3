using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 数据库信息体
    /// </summary>
    public class Endpoint 
    {
        /// <summary>
        /// 数据库类型，测试连接之后修改调用时必填。
        /// </summary>
        /// <value>数据库类型，测试连接之后修改调用时必填。</value>
        [JsonConverter(typeof(EnumClassConverter<DbTypeEnum>))]
        public class DbTypeEnum
        {
            /// <summary>
            /// Enum MYSQL for value: mysql
            /// </summary>
            public static readonly DbTypeEnum MYSQL = new DbTypeEnum("mysql");

            /// <summary>
            /// Enum MONGODB for value: mongodb
            /// </summary>
            public static readonly DbTypeEnum MONGODB = new DbTypeEnum("mongodb");

            /// <summary>
            /// Enum GAUSSDBV5 for value: gaussdbv5
            /// </summary>
            public static readonly DbTypeEnum GAUSSDBV5 = new DbTypeEnum("gaussdbv5");

            /// <summary>
            /// Enum POSTGRESQL for value: postgresql
            /// </summary>
            public static readonly DbTypeEnum POSTGRESQL = new DbTypeEnum("postgresql");

            /// <summary>
            /// Enum KAFKA for value: kafka
            /// </summary>
            public static readonly DbTypeEnum KAFKA = new DbTypeEnum("kafka");

            /// <summary>
            /// Enum GAUSSDBV5HA for value: gaussdbv5ha
            /// </summary>
            public static readonly DbTypeEnum GAUSSDBV5HA = new DbTypeEnum("gaussdbv5ha");

            private static readonly Dictionary<string, DbTypeEnum> StaticFields =
            new Dictionary<string, DbTypeEnum>()
            {
                { "mysql", MYSQL },
                { "mongodb", MONGODB },
                { "gaussdbv5", GAUSSDBV5 },
                { "postgresql", POSTGRESQL },
                { "kafka", KAFKA },
                { "gaussdbv5ha", GAUSSDBV5HA },
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
        /// MongDB集群4.0及以上版本，当集群实例无法获取到分片节点的IP时，source_endpoint中需要填写，值为：Sharding4.0+。
        /// </summary>
        /// <value>MongDB集群4.0及以上版本，当集群实例无法获取到分片节点的IP时，source_endpoint中需要填写，值为：Sharding4.0+。</value>
        [JsonConverter(typeof(EnumClassConverter<ClusterModeEnum>))]
        public class ClusterModeEnum
        {
            /// <summary>
            /// Enum SHARDING4_0_ for value: Sharding4.0+
            /// </summary>
            public static readonly ClusterModeEnum SHARDING4_0_ = new ClusterModeEnum("Sharding4.0+");

            private static readonly Dictionary<string, ClusterModeEnum> StaticFields =
            new Dictionary<string, ClusterModeEnum>()
            {
                { "Sharding4.0+", SHARDING4_0_ },
            };

            private string _value;

            public ClusterModeEnum()
            {

            }

            public ClusterModeEnum(string value)
            {
                _value = value;
            }

            public static ClusterModeEnum FromValue(string value)
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

                if (this.Equals(obj as ClusterModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ClusterModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ClusterModeEnum a, ClusterModeEnum b)
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

            public static bool operator !=(ClusterModeEnum a, ClusterModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库类型，测试连接之后修改调用时必填。
        /// </summary>
        [JsonProperty("db_type", NullValueHandling = NullValueHandling.Ignore)]
        public DbTypeEnum DbType { get; set; }
        /// <summary>
        /// 数据库所在可用区azCode
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }

        /// <summary>
        /// RDS实例所在Region，数据库为RDS实例时必填（灾备场景下job_direction为down时source_endpoint中该值为必填，job_direction为up时target_endpoint中该值为必填）。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// RDS实例ID，数据库为RDS实例必填（灾备场景下job_direction为down时source_endpoint中该值为必填，job_direction为up时target_endpoint中该值为必填）。
        /// </summary>
        [JsonProperty("inst_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstId { get; set; }

        /// <summary>
        /// 数据库所在的虚拟私有云id
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 数据库所在的子网id
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 数据库所在的安全组id。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// RDS实例projectId
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 服务名serviceName，源库为oracle场景时必填。约束：不能超过128位，不能包含!&lt;&gt;&amp;&#39;\&quot;\\特殊字符。待还原数据库名称是指备份文件中包含的数据库名称，当您选择部分数据库恢复时，需要选择恢复一个或者多个数据库。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 数据库密码。
        /// </summary>
        [JsonProperty("db_password", NullValueHandling = NullValueHandling.Ignore)]
        public string DbPassword { get; set; }

        /// <summary>
        /// 数据库端口。约束：输入范围为1-65535之间的整数。
        /// </summary>
        [JsonProperty("db_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DbPort { get; set; }

        /// <summary>
        /// 数据库用户。
        /// </summary>
        [JsonProperty("db_user", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUser { get; set; }

        /// <summary>
        /// RDS实例名称。
        /// </summary>
        [JsonProperty("inst_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstName { get; set; }

        /// <summary>
        /// 数据库ip
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// mongo ha模式。
        /// </summary>
        [JsonProperty("mongo_ha_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string MongoHaMode { get; set; }

        /// <summary>
        /// MRS集群运行模式，取值： - 0普通集群 - 1安全集群
        /// </summary>
        [JsonProperty("safe_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? SafeMode { get; set; }

        /// <summary>
        /// SSL证书密码，证书文件后缀为.p12
        /// </summary>
        [JsonProperty("ssl_cert_password", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertPassword { get; set; }

        /// <summary>
        /// SSL证书内容checksum值，后端校验，源库安全连接必选。
        /// </summary>
        [JsonProperty("ssl_cert_check_sum", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertCheckSum { get; set; }

        /// <summary>
        /// SSL证书内容，用base64加密
        /// </summary>
        [JsonProperty("ssl_cert_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertKey { get; set; }

        /// <summary>
        /// SSL证书名字
        /// </summary>
        [JsonProperty("ssl_cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertName { get; set; }

        /// <summary>
        /// 是否SSL安全连接。
        /// </summary>
        [JsonProperty("ssl_link", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslLink { get; set; }

        /// <summary>
        /// kafka topic名称
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// MongDB集群4.0及以上版本，当集群实例无法获取到分片节点的IP时，source_endpoint中需要填写，值为：Sharding4.0+。
        /// </summary>
        [JsonProperty("cluster_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterModeEnum ClusterMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Endpoint {\n");
            sb.Append("  dbType: ").Append(DbType).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  instId: ").Append(InstId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  dbPassword: ").Append(DbPassword).Append("\n");
            sb.Append("  dbPort: ").Append(DbPort).Append("\n");
            sb.Append("  dbUser: ").Append(DbUser).Append("\n");
            sb.Append("  instName: ").Append(InstName).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  mongoHaMode: ").Append(MongoHaMode).Append("\n");
            sb.Append("  safeMode: ").Append(SafeMode).Append("\n");
            sb.Append("  sslCertPassword: ").Append(SslCertPassword).Append("\n");
            sb.Append("  sslCertCheckSum: ").Append(SslCertCheckSum).Append("\n");
            sb.Append("  sslCertKey: ").Append(SslCertKey).Append("\n");
            sb.Append("  sslCertName: ").Append(SslCertName).Append("\n");
            sb.Append("  sslLink: ").Append(SslLink).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  clusterMode: ").Append(ClusterMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Endpoint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Endpoint input)
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
                    this.AzCode == input.AzCode ||
                    (this.AzCode != null &&
                    this.AzCode.Equals(input.AzCode))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.InstId == input.InstId ||
                    (this.InstId != null &&
                    this.InstId.Equals(input.InstId))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.DbName == input.DbName ||
                    (this.DbName != null &&
                    this.DbName.Equals(input.DbName))
                ) && 
                (
                    this.DbPassword == input.DbPassword ||
                    (this.DbPassword != null &&
                    this.DbPassword.Equals(input.DbPassword))
                ) && 
                (
                    this.DbPort == input.DbPort ||
                    (this.DbPort != null &&
                    this.DbPort.Equals(input.DbPort))
                ) && 
                (
                    this.DbUser == input.DbUser ||
                    (this.DbUser != null &&
                    this.DbUser.Equals(input.DbUser))
                ) && 
                (
                    this.InstName == input.InstName ||
                    (this.InstName != null &&
                    this.InstName.Equals(input.InstName))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.MongoHaMode == input.MongoHaMode ||
                    (this.MongoHaMode != null &&
                    this.MongoHaMode.Equals(input.MongoHaMode))
                ) && 
                (
                    this.SafeMode == input.SafeMode ||
                    (this.SafeMode != null &&
                    this.SafeMode.Equals(input.SafeMode))
                ) && 
                (
                    this.SslCertPassword == input.SslCertPassword ||
                    (this.SslCertPassword != null &&
                    this.SslCertPassword.Equals(input.SslCertPassword))
                ) && 
                (
                    this.SslCertCheckSum == input.SslCertCheckSum ||
                    (this.SslCertCheckSum != null &&
                    this.SslCertCheckSum.Equals(input.SslCertCheckSum))
                ) && 
                (
                    this.SslCertKey == input.SslCertKey ||
                    (this.SslCertKey != null &&
                    this.SslCertKey.Equals(input.SslCertKey))
                ) && 
                (
                    this.SslCertName == input.SslCertName ||
                    (this.SslCertName != null &&
                    this.SslCertName.Equals(input.SslCertName))
                ) && 
                (
                    this.SslLink == input.SslLink ||
                    (this.SslLink != null &&
                    this.SslLink.Equals(input.SslLink))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.ClusterMode == input.ClusterMode ||
                    (this.ClusterMode != null &&
                    this.ClusterMode.Equals(input.ClusterMode))
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
                if (this.AzCode != null)
                    hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.InstId != null)
                    hashCode = hashCode * 59 + this.InstId.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.DbName != null)
                    hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.DbPassword != null)
                    hashCode = hashCode * 59 + this.DbPassword.GetHashCode();
                if (this.DbPort != null)
                    hashCode = hashCode * 59 + this.DbPort.GetHashCode();
                if (this.DbUser != null)
                    hashCode = hashCode * 59 + this.DbUser.GetHashCode();
                if (this.InstName != null)
                    hashCode = hashCode * 59 + this.InstName.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.MongoHaMode != null)
                    hashCode = hashCode * 59 + this.MongoHaMode.GetHashCode();
                if (this.SafeMode != null)
                    hashCode = hashCode * 59 + this.SafeMode.GetHashCode();
                if (this.SslCertPassword != null)
                    hashCode = hashCode * 59 + this.SslCertPassword.GetHashCode();
                if (this.SslCertCheckSum != null)
                    hashCode = hashCode * 59 + this.SslCertCheckSum.GetHashCode();
                if (this.SslCertKey != null)
                    hashCode = hashCode * 59 + this.SslCertKey.GetHashCode();
                if (this.SslCertName != null)
                    hashCode = hashCode * 59 + this.SslCertName.GetHashCode();
                if (this.SslLink != null)
                    hashCode = hashCode * 59 + this.SslLink.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.ClusterMode != null)
                    hashCode = hashCode * 59 + this.ClusterMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
