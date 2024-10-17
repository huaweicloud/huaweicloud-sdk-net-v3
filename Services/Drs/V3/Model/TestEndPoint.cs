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
    /// 测试连接信息体
    /// </summary>
    public class TestEndPoint 
    {
        /// <summary>
        /// 网络类型
        /// </summary>
        /// <value>网络类型</value>
        [JsonConverter(typeof(EnumClassConverter<NetTypeEnum>))]
        public class NetTypeEnum
        {
            /// <summary>
            /// Enum VPN for value: vpn
            /// </summary>
            public static readonly NetTypeEnum VPN = new NetTypeEnum("vpn");

            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly NetTypeEnum VPC = new NetTypeEnum("vpc");

            /// <summary>
            /// Enum EIP for value: eip
            /// </summary>
            public static readonly NetTypeEnum EIP = new NetTypeEnum("eip");

            private static readonly Dictionary<string, NetTypeEnum> StaticFields =
            new Dictionary<string, NetTypeEnum>()
            {
                { "vpn", VPN },
                { "vpc", VPC },
                { "eip", EIP },
            };

            private string _value;

            public NetTypeEnum()
            {

            }

            public NetTypeEnum(string value)
            {
                _value = value;
            }

            public static NetTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NetTypeEnum a, NetTypeEnum b)
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

            public static bool operator !=(NetTypeEnum a, NetTypeEnum b)
            {
                return !(a == b);
            }
        }

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

            /// <summary>
            /// Enum TAURUS for value: taurus
            /// </summary>
            public static readonly DbTypeEnum TAURUS = new DbTypeEnum("taurus");

            private static readonly Dictionary<string, DbTypeEnum> StaticFields =
            new Dictionary<string, DbTypeEnum>()
            {
                { "mysql", MYSQL },
                { "mongodb", MONGODB },
                { "gaussdbv5", GAUSSDBV5 },
                { "postgresql", POSTGRESQL },
                { "kafka", KAFKA },
                { "gaussdbv5ha", GAUSSDBV5HA },
                { "taurus", TAURUS },
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
        /// 源库：so,目标库：ta
        /// </summary>
        /// <value>源库：so,目标库：ta</value>
        [JsonConverter(typeof(EnumClassConverter<EndPointTypeEnum>))]
        public class EndPointTypeEnum
        {
            /// <summary>
            /// Enum SO for value: so
            /// </summary>
            public static readonly EndPointTypeEnum SO = new EndPointTypeEnum("so");

            /// <summary>
            /// Enum TA for value: ta
            /// </summary>
            public static readonly EndPointTypeEnum TA = new EndPointTypeEnum("ta");

            private static readonly Dictionary<string, EndPointTypeEnum> StaticFields =
            new Dictionary<string, EndPointTypeEnum>()
            {
                { "so", SO },
                { "ta", TA },
            };

            private string _value;

            public EndPointTypeEnum()
            {

            }

            public EndPointTypeEnum(string value)
            {
                _value = value;
            }

            public static EndPointTypeEnum FromValue(string value)
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

                if (this.Equals(obj as EndPointTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EndPointTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EndPointTypeEnum a, EndPointTypeEnum b)
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

            public static bool operator !=(EndPointTypeEnum a, EndPointTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 网络类型
        /// </summary>
        [JsonProperty("net_type", NullValueHandling = NullValueHandling.Ignore)]
        public NetTypeEnum NetType { get; set; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        [JsonProperty("db_type", NullValueHandling = NullValueHandling.Ignore)]
        public DbTypeEnum DbType { get; set; }
        /// <summary>
        /// 数据库IP
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 数据库端口，Mongo、DDS必填为0。
        /// </summary>
        [JsonProperty("db_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DbPort { get; set; }

        /// <summary>
        /// RDS实例id，RDS实例必填。
        /// </summary>
        [JsonProperty("inst_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstId { get; set; }

        /// <summary>
        /// 数据库帐号。
        /// </summary>
        [JsonProperty("db_user", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUser { get; set; }

        /// <summary>
        /// 数据库密码。
        /// </summary>
        [JsonProperty("db_password", NullValueHandling = NullValueHandling.Ignore)]
        public string DbPassword { get; set; }

        /// <summary>
        /// 是否SSL安全连接。
        /// </summary>
        [JsonProperty("ssl_link", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslLink { get; set; }

        /// <summary>
        /// SSL证书内容，base64加密后的值，源库安全连接必选。
        /// </summary>
        [JsonProperty("ssl_cert_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertKey { get; set; }

        /// <summary>
        /// SSL证书名字，源库安全连接必选。
        /// </summary>
        [JsonProperty("ssl_cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertName { get; set; }

        /// <summary>
        /// SSL证书内容checksum值，证书经过sha256加密后的值，后端校验，源库安全连接必选。
        /// </summary>
        [JsonProperty("ssl_cert_check_sum", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertCheckSum { get; set; }

        /// <summary>
        /// SSL证书密码，证书文件后缀为.p12，需要密码。
        /// </summary>
        [JsonProperty("ssl_cert_password", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertPassword { get; set; }

        /// <summary>
        /// vpcid，数据库为RDS时必选。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// subnetid，数据库为RDS必选。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 源库：so,目标库：ta
        /// </summary>
        [JsonProperty("end_point_type", NullValueHandling = NullValueHandling.Ignore)]
        public EndPointTypeEnum EndPointType { get; set; }
        /// <summary>
        /// rds实例region，数据库为RDS时必填。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 用户所处region的projectId。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 数据库用户名，DDS的账号认证数据库，Oracle的serviceName。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kafka_security_config", NullValueHandling = NullValueHandling.Ignore)]
        public KafkaSecurity KafkaSecurityConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("customized_dns", NullValueHandling = NullValueHandling.Ignore)]
        public CustomizedDns CustomizedDns { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestEndPoint {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  netType: ").Append(NetType).Append("\n");
            sb.Append("  dbType: ").Append(DbType).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  dbPort: ").Append(DbPort).Append("\n");
            sb.Append("  instId: ").Append(InstId).Append("\n");
            sb.Append("  dbUser: ").Append(DbUser).Append("\n");
            sb.Append("  dbPassword: ").Append(DbPassword).Append("\n");
            sb.Append("  sslLink: ").Append(SslLink).Append("\n");
            sb.Append("  sslCertKey: ").Append(SslCertKey).Append("\n");
            sb.Append("  sslCertName: ").Append(SslCertName).Append("\n");
            sb.Append("  sslCertCheckSum: ").Append(SslCertCheckSum).Append("\n");
            sb.Append("  sslCertPassword: ").Append(SslCertPassword).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  endPointType: ").Append(EndPointType).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  kafkaSecurityConfig: ").Append(KafkaSecurityConfig).Append("\n");
            sb.Append("  customizedDns: ").Append(CustomizedDns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestEndPoint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestEndPoint input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.NetType != input.NetType) return false;
            if (this.DbType != input.DbType) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.DbPort != input.DbPort || (this.DbPort != null && !this.DbPort.Equals(input.DbPort))) return false;
            if (this.InstId != input.InstId || (this.InstId != null && !this.InstId.Equals(input.InstId))) return false;
            if (this.DbUser != input.DbUser || (this.DbUser != null && !this.DbUser.Equals(input.DbUser))) return false;
            if (this.DbPassword != input.DbPassword || (this.DbPassword != null && !this.DbPassword.Equals(input.DbPassword))) return false;
            if (this.SslLink != input.SslLink || (this.SslLink != null && !this.SslLink.Equals(input.SslLink))) return false;
            if (this.SslCertKey != input.SslCertKey || (this.SslCertKey != null && !this.SslCertKey.Equals(input.SslCertKey))) return false;
            if (this.SslCertName != input.SslCertName || (this.SslCertName != null && !this.SslCertName.Equals(input.SslCertName))) return false;
            if (this.SslCertCheckSum != input.SslCertCheckSum || (this.SslCertCheckSum != null && !this.SslCertCheckSum.Equals(input.SslCertCheckSum))) return false;
            if (this.SslCertPassword != input.SslCertPassword || (this.SslCertPassword != null && !this.SslCertPassword.Equals(input.SslCertPassword))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.EndPointType != input.EndPointType) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.KafkaSecurityConfig != input.KafkaSecurityConfig || (this.KafkaSecurityConfig != null && !this.KafkaSecurityConfig.Equals(input.KafkaSecurityConfig))) return false;
            if (this.CustomizedDns != input.CustomizedDns || (this.CustomizedDns != null && !this.CustomizedDns.Equals(input.CustomizedDns))) return false;

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
                hashCode = hashCode * 59 + this.NetType.GetHashCode();
                hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.DbPort != null) hashCode = hashCode * 59 + this.DbPort.GetHashCode();
                if (this.InstId != null) hashCode = hashCode * 59 + this.InstId.GetHashCode();
                if (this.DbUser != null) hashCode = hashCode * 59 + this.DbUser.GetHashCode();
                if (this.DbPassword != null) hashCode = hashCode * 59 + this.DbPassword.GetHashCode();
                if (this.SslLink != null) hashCode = hashCode * 59 + this.SslLink.GetHashCode();
                if (this.SslCertKey != null) hashCode = hashCode * 59 + this.SslCertKey.GetHashCode();
                if (this.SslCertName != null) hashCode = hashCode * 59 + this.SslCertName.GetHashCode();
                if (this.SslCertCheckSum != null) hashCode = hashCode * 59 + this.SslCertCheckSum.GetHashCode();
                if (this.SslCertPassword != null) hashCode = hashCode * 59 + this.SslCertPassword.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                hashCode = hashCode * 59 + this.EndPointType.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.KafkaSecurityConfig != null) hashCode = hashCode * 59 + this.KafkaSecurityConfig.GetHashCode();
                if (this.CustomizedDns != null) hashCode = hashCode * 59 + this.CustomizedDns.GetHashCode();
                return hashCode;
            }
        }
    }
}
