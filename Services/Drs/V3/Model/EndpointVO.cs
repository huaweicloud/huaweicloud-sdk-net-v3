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
    /// 数据库信息
    /// </summary>
    public class EndpointVO 
    {
        /// <summary>
        /// 数据库类型
        /// </summary>
        /// <value>数据库类型</value>
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

            private static readonly Dictionary<string, DbTypeEnum> StaticFields =
            new Dictionary<string, DbTypeEnum>()
            {
                { "mysql", MYSQL },
                { "mongodb", MONGODB },
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
        /// mongoHa模式。 - Sharding 集群 - ReplicaSet 副本集 - ReplicaSingle 单节点
        /// </summary>
        /// <value>mongoHa模式。 - Sharding 集群 - ReplicaSet 副本集 - ReplicaSingle 单节点</value>
        [JsonConverter(typeof(EnumClassConverter<MongoHaModeEnum>))]
        public class MongoHaModeEnum
        {
            /// <summary>
            /// Enum SHARDING for value: Sharding
            /// </summary>
            public static readonly MongoHaModeEnum SHARDING = new MongoHaModeEnum("Sharding");

            /// <summary>
            /// Enum REPLICASET for value: ReplicaSet
            /// </summary>
            public static readonly MongoHaModeEnum REPLICASET = new MongoHaModeEnum("ReplicaSet");

            /// <summary>
            /// Enum REPLICASINGLE for value: ReplicaSingle
            /// </summary>
            public static readonly MongoHaModeEnum REPLICASINGLE = new MongoHaModeEnum("ReplicaSingle");

            private static readonly Dictionary<string, MongoHaModeEnum> StaticFields =
            new Dictionary<string, MongoHaModeEnum>()
            {
                { "Sharding", SHARDING },
                { "ReplicaSet", REPLICASET },
                { "ReplicaSingle", REPLICASINGLE },
            };

            private string _value;

            public MongoHaModeEnum()
            {

            }

            public MongoHaModeEnum(string value)
            {
                _value = value;
            }

            public static MongoHaModeEnum FromValue(string value)
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

                if (this.Equals(obj as MongoHaModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MongoHaModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MongoHaModeEnum a, MongoHaModeEnum b)
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

            public static bool operator !=(MongoHaModeEnum a, MongoHaModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 集群模式。 - Single：单节点RDS - Ha：主备RDS - GR：金融版RDS - Sharding：mongodb 集群或DDM的模式，均默认为分片 - Sharding4.0+：mongodb 集群版本4.0+，默认为不分片 - ReplicaSet：mongodb 副本集,Replica RDS只读副本 - ReplicaSingle：mongodb 单节点 - Cluster：集群 - Independent：gaussdbv5 independent模式 - Combined：gaussdbv5 Combined模式 - Distributed ：分布式taurus - NoSharding：非集群模式
        /// </summary>
        /// <value>集群模式。 - Single：单节点RDS - Ha：主备RDS - GR：金融版RDS - Sharding：mongodb 集群或DDM的模式，均默认为分片 - Sharding4.0+：mongodb 集群版本4.0+，默认为不分片 - ReplicaSet：mongodb 副本集,Replica RDS只读副本 - ReplicaSingle：mongodb 单节点 - Cluster：集群 - Independent：gaussdbv5 independent模式 - Combined：gaussdbv5 Combined模式 - Distributed ：分布式taurus - NoSharding：非集群模式</value>
        [JsonConverter(typeof(EnumClassConverter<ClusterModeEnum>))]
        public class ClusterModeEnum
        {
            /// <summary>
            /// Enum SINGLE for value: Single
            /// </summary>
            public static readonly ClusterModeEnum SINGLE = new ClusterModeEnum("Single");

            /// <summary>
            /// Enum HA for value: Ha
            /// </summary>
            public static readonly ClusterModeEnum HA = new ClusterModeEnum("Ha");

            /// <summary>
            /// Enum GR for value: GR
            /// </summary>
            public static readonly ClusterModeEnum GR = new ClusterModeEnum("GR");

            /// <summary>
            /// Enum SHARDING for value: Sharding
            /// </summary>
            public static readonly ClusterModeEnum SHARDING = new ClusterModeEnum("Sharding");

            /// <summary>
            /// Enum SHARDING4_0_ for value: Sharding4.0+
            /// </summary>
            public static readonly ClusterModeEnum SHARDING4_0_ = new ClusterModeEnum("Sharding4.0+");

            /// <summary>
            /// Enum REPLICASET for value: ReplicaSet
            /// </summary>
            public static readonly ClusterModeEnum REPLICASET = new ClusterModeEnum("ReplicaSet");

            /// <summary>
            /// Enum REPLICA for value: Replica
            /// </summary>
            public static readonly ClusterModeEnum REPLICA = new ClusterModeEnum("Replica");

            /// <summary>
            /// Enum REPLICASINGLE for value: ReplicaSingle
            /// </summary>
            public static readonly ClusterModeEnum REPLICASINGLE = new ClusterModeEnum("ReplicaSingle");

            /// <summary>
            /// Enum CLUSTER for value: Cluster
            /// </summary>
            public static readonly ClusterModeEnum CLUSTER = new ClusterModeEnum("Cluster");

            /// <summary>
            /// Enum INDEPENDENT for value: Independent
            /// </summary>
            public static readonly ClusterModeEnum INDEPENDENT = new ClusterModeEnum("Independent");

            /// <summary>
            /// Enum COMBINED for value: Combined
            /// </summary>
            public static readonly ClusterModeEnum COMBINED = new ClusterModeEnum("Combined");

            /// <summary>
            /// Enum DISTRIBUTED for value: Distributed
            /// </summary>
            public static readonly ClusterModeEnum DISTRIBUTED = new ClusterModeEnum("Distributed");

            /// <summary>
            /// Enum NOSHARDING for value: NoSharding
            /// </summary>
            public static readonly ClusterModeEnum NOSHARDING = new ClusterModeEnum("NoSharding");

            private static readonly Dictionary<string, ClusterModeEnum> StaticFields =
            new Dictionary<string, ClusterModeEnum>()
            {
                { "Single", SINGLE },
                { "Ha", HA },
                { "GR", GR },
                { "Sharding", SHARDING },
                { "Sharding4.0+", SHARDING4_0_ },
                { "ReplicaSet", REPLICASET },
                { "Replica", REPLICA },
                { "ReplicaSingle", REPLICASINGLE },
                { "Cluster", CLUSTER },
                { "Independent", INDEPENDENT },
                { "Combined", COMBINED },
                { "Distributed", DISTRIBUTED },
                { "NoSharding", NOSHARDING },
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
        /// 数据库id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 对象id。
        /// </summary>
        [JsonProperty("obj_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjId { get; set; }

        /// <summary>
        /// RDS实例名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        [JsonProperty("db_type", NullValueHandling = NullValueHandling.Ignore)]
        public DbTypeEnum DbType { get; set; }
        /// <summary>
        /// 数据库用户。
        /// </summary>
        [JsonProperty("db_user", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUser { get; set; }

        /// <summary>
        /// 数据库密码。
        /// </summary>
        [JsonProperty("db_password", NullValueHandling = NullValueHandling.Ignore)]
        public string DbPassword { get; set; }

        /// <summary>
        /// 管理IP。
        /// </summary>
        [JsonProperty("manage_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ManageIp { get; set; }

        /// <summary>
        /// 流量IP。
        /// </summary>
        [JsonProperty("traffic_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficIp { get; set; }

        /// <summary>
        /// 数据库端口。
        /// </summary>
        [JsonProperty("db_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DbPort { get; set; }

        /// <summary>
        /// RDS实例所在region。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 创建日期，格式yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 修改日期，格式yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 迁移实例所在的私有IP。
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 迁移实例所在的公网IP。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 可用区azCode。
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }

        /// <summary>
        /// 源库所在的安全组id。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 源库所在的子网id。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 源库所在的虚拟私有云id。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 迁移实例的磁盘大小。
        /// </summary>
        [JsonProperty("volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? VolumeSize { get; set; }

        /// <summary>
        /// 全量迁移用户密码，密文。
        /// </summary>
        [JsonProperty("full_trans_user_pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string FullTransUserPwd { get; set; }

        /// <summary>
        /// 增量迁移用户密码，密文。
        /// </summary>
        [JsonProperty("increment_trans_user_pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string IncrementTransUserPwd { get; set; }

        /// <summary>
        /// 是否SSL安全连接。
        /// </summary>
        [JsonProperty("ssl_link", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslLink { get; set; }

        /// <summary>
        /// SSL证书内容。
        /// </summary>
        [JsonProperty("ssl_cert_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertKey { get; set; }

        /// <summary>
        /// SSL证书名字。
        /// </summary>
        [JsonProperty("ssl_cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertName { get; set; }

        /// <summary>
        /// SSL证书内容checksum值。
        /// </summary>
        [JsonProperty("ssl_cert_check_sum", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertCheckSum { get; set; }

        /// <summary>
        /// SSL证书密码，密文。
        /// </summary>
        [JsonProperty("ssl_cert_password", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertPassword { get; set; }

        /// <summary>
        /// 数据库版本。
        /// </summary>
        [JsonProperty("db_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DbVersion { get; set; }

        /// <summary>
        /// mongoHa模式。 - Sharding 集群 - ReplicaSet 副本集 - ReplicaSingle 单节点
        /// </summary>
        [JsonProperty("mongo_ha_mode", NullValueHandling = NullValueHandling.Ignore)]
        public MongoHaModeEnum MongoHaMode { get; set; }
        /// <summary>
        /// RDS实例projectId。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 集群模式。 - Single：单节点RDS - Ha：主备RDS - GR：金融版RDS - Sharding：mongodb 集群或DDM的模式，均默认为分片 - Sharding4.0+：mongodb 集群版本4.0+，默认为不分片 - ReplicaSet：mongodb 副本集,Replica RDS只读副本 - ReplicaSingle：mongodb 单节点 - Cluster：集群 - Independent：gaussdbv5 independent模式 - Combined：gaussdbv5 Combined模式 - Distributed ：分布式taurus - NoSharding：非集群模式
        /// </summary>
        [JsonProperty("cluster_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterModeEnum ClusterMode { get; set; }
        /// <summary>
        /// RDS实例id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Oracle服务名serviceName。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// mrskafka topic名称。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// MRSkafka是否开启kerberos认证 - 0非安全认证 - 1安全认证
        /// </summary>
        [JsonProperty("safe_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? SafeMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kerberos_vo", NullValueHandling = NullValueHandling.Ignore)]
        public KerberosVO KerberosVo { get; set; }

        /// <summary>
        /// 多写数据库Id。
        /// </summary>
        [JsonProperty("multi_write_db_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MultiWriteDbId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  objId: ").Append(ObjId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  dbType: ").Append(DbType).Append("\n");
            sb.Append("  dbUser: ").Append(DbUser).Append("\n");
            sb.Append("  dbPassword: ").Append(DbPassword).Append("\n");
            sb.Append("  manageIp: ").Append(ManageIp).Append("\n");
            sb.Append("  trafficIp: ").Append(TrafficIp).Append("\n");
            sb.Append("  dbPort: ").Append(DbPort).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  volumeSize: ").Append(VolumeSize).Append("\n");
            sb.Append("  fullTransUserPwd: ").Append(FullTransUserPwd).Append("\n");
            sb.Append("  incrementTransUserPwd: ").Append(IncrementTransUserPwd).Append("\n");
            sb.Append("  sslLink: ").Append(SslLink).Append("\n");
            sb.Append("  sslCertKey: ").Append(SslCertKey).Append("\n");
            sb.Append("  sslCertName: ").Append(SslCertName).Append("\n");
            sb.Append("  sslCertCheckSum: ").Append(SslCertCheckSum).Append("\n");
            sb.Append("  sslCertPassword: ").Append(SslCertPassword).Append("\n");
            sb.Append("  dbVersion: ").Append(DbVersion).Append("\n");
            sb.Append("  mongoHaMode: ").Append(MongoHaMode).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  clusterMode: ").Append(ClusterMode).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  safeMode: ").Append(SafeMode).Append("\n");
            sb.Append("  kerberosVo: ").Append(KerberosVo).Append("\n");
            sb.Append("  multiWriteDbId: ").Append(MultiWriteDbId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EndpointVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EndpointVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ObjId != input.ObjId || (this.ObjId != null && !this.ObjId.Equals(input.ObjId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.DbType != input.DbType) return false;
            if (this.DbUser != input.DbUser || (this.DbUser != null && !this.DbUser.Equals(input.DbUser))) return false;
            if (this.DbPassword != input.DbPassword || (this.DbPassword != null && !this.DbPassword.Equals(input.DbPassword))) return false;
            if (this.ManageIp != input.ManageIp || (this.ManageIp != null && !this.ManageIp.Equals(input.ManageIp))) return false;
            if (this.TrafficIp != input.TrafficIp || (this.TrafficIp != null && !this.TrafficIp.Equals(input.TrafficIp))) return false;
            if (this.DbPort != input.DbPort || (this.DbPort != null && !this.DbPort.Equals(input.DbPort))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.AzCode != input.AzCode || (this.AzCode != null && !this.AzCode.Equals(input.AzCode))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.VolumeSize != input.VolumeSize || (this.VolumeSize != null && !this.VolumeSize.Equals(input.VolumeSize))) return false;
            if (this.FullTransUserPwd != input.FullTransUserPwd || (this.FullTransUserPwd != null && !this.FullTransUserPwd.Equals(input.FullTransUserPwd))) return false;
            if (this.IncrementTransUserPwd != input.IncrementTransUserPwd || (this.IncrementTransUserPwd != null && !this.IncrementTransUserPwd.Equals(input.IncrementTransUserPwd))) return false;
            if (this.SslLink != input.SslLink || (this.SslLink != null && !this.SslLink.Equals(input.SslLink))) return false;
            if (this.SslCertKey != input.SslCertKey || (this.SslCertKey != null && !this.SslCertKey.Equals(input.SslCertKey))) return false;
            if (this.SslCertName != input.SslCertName || (this.SslCertName != null && !this.SslCertName.Equals(input.SslCertName))) return false;
            if (this.SslCertCheckSum != input.SslCertCheckSum || (this.SslCertCheckSum != null && !this.SslCertCheckSum.Equals(input.SslCertCheckSum))) return false;
            if (this.SslCertPassword != input.SslCertPassword || (this.SslCertPassword != null && !this.SslCertPassword.Equals(input.SslCertPassword))) return false;
            if (this.DbVersion != input.DbVersion || (this.DbVersion != null && !this.DbVersion.Equals(input.DbVersion))) return false;
            if (this.MongoHaMode != input.MongoHaMode) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ClusterMode != input.ClusterMode) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.SafeMode != input.SafeMode || (this.SafeMode != null && !this.SafeMode.Equals(input.SafeMode))) return false;
            if (this.KerberosVo != input.KerberosVo || (this.KerberosVo != null && !this.KerberosVo.Equals(input.KerberosVo))) return false;
            if (this.MultiWriteDbId != input.MultiWriteDbId || (this.MultiWriteDbId != null && !this.MultiWriteDbId.Equals(input.MultiWriteDbId))) return false;

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
                if (this.ObjId != null) hashCode = hashCode * 59 + this.ObjId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.DbUser != null) hashCode = hashCode * 59 + this.DbUser.GetHashCode();
                if (this.DbPassword != null) hashCode = hashCode * 59 + this.DbPassword.GetHashCode();
                if (this.ManageIp != null) hashCode = hashCode * 59 + this.ManageIp.GetHashCode();
                if (this.TrafficIp != null) hashCode = hashCode * 59 + this.TrafficIp.GetHashCode();
                if (this.DbPort != null) hashCode = hashCode * 59 + this.DbPort.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.AzCode != null) hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.VolumeSize != null) hashCode = hashCode * 59 + this.VolumeSize.GetHashCode();
                if (this.FullTransUserPwd != null) hashCode = hashCode * 59 + this.FullTransUserPwd.GetHashCode();
                if (this.IncrementTransUserPwd != null) hashCode = hashCode * 59 + this.IncrementTransUserPwd.GetHashCode();
                if (this.SslLink != null) hashCode = hashCode * 59 + this.SslLink.GetHashCode();
                if (this.SslCertKey != null) hashCode = hashCode * 59 + this.SslCertKey.GetHashCode();
                if (this.SslCertName != null) hashCode = hashCode * 59 + this.SslCertName.GetHashCode();
                if (this.SslCertCheckSum != null) hashCode = hashCode * 59 + this.SslCertCheckSum.GetHashCode();
                if (this.SslCertPassword != null) hashCode = hashCode * 59 + this.SslCertPassword.GetHashCode();
                if (this.DbVersion != null) hashCode = hashCode * 59 + this.DbVersion.GetHashCode();
                hashCode = hashCode * 59 + this.MongoHaMode.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.ClusterMode.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.SafeMode != null) hashCode = hashCode * 59 + this.SafeMode.GetHashCode();
                if (this.KerberosVo != null) hashCode = hashCode * 59 + this.KerberosVo.GetHashCode();
                if (this.MultiWriteDbId != null) hashCode = hashCode * 59 + this.MultiWriteDbId.GetHashCode();
                return hashCode;
            }
        }
    }
}
