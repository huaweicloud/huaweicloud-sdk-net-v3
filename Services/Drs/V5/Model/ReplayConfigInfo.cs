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
    /// 仿真参数信息。
    /// </summary>
    public class ReplayConfigInfo 
    {
        /// <summary>
        /// 云类型： - AWSCloud：亚马逊云。 - TencentCloud：腾讯云。 - AliCloud：阿里云。
        /// </summary>
        /// <value>云类型： - AWSCloud：亚马逊云。 - TencentCloud：腾讯云。 - AliCloud：阿里云。</value>
        [JsonConverter(typeof(EnumClassConverter<CloudTypeEnum>))]
        public class CloudTypeEnum
        {
            /// <summary>
            /// Enum AWSCLOUD for value: AWSCloud
            /// </summary>
            public static readonly CloudTypeEnum AWSCLOUD = new CloudTypeEnum("AWSCloud");

            /// <summary>
            /// Enum TENCENTCLOUD for value: TencentCloud
            /// </summary>
            public static readonly CloudTypeEnum TENCENTCLOUD = new CloudTypeEnum("TencentCloud");

            /// <summary>
            /// Enum ALICLOUD for value: AliCloud
            /// </summary>
            public static readonly CloudTypeEnum ALICLOUD = new CloudTypeEnum("AliCloud");

            private static readonly Dictionary<string, CloudTypeEnum> StaticFields =
            new Dictionary<string, CloudTypeEnum>()
            {
                { "AWSCloud", AWSCLOUD },
                { "TencentCloud", TENCENTCLOUD },
                { "AliCloud", ALICLOUD },
            };

            private string _value;

            public CloudTypeEnum()
            {

            }

            public CloudTypeEnum(string value)
            {
                _value = value;
            }

            public static CloudTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CloudTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CloudTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CloudTypeEnum a, CloudTypeEnum b)
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

            public static bool operator !=(CloudTypeEnum a, CloudTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 源数据库来源。取值： - aws_aurora_mysql：Amazon Aurora MySQL。 - tencent_tdsql_c：腾讯云TDSQL-C MySQL。 - ali_rds_mysql：阿里云RDS MySQL。
        /// </summary>
        /// <value>源数据库来源。取值： - aws_aurora_mysql：Amazon Aurora MySQL。 - tencent_tdsql_c：腾讯云TDSQL-C MySQL。 - ali_rds_mysql：阿里云RDS MySQL。</value>
        [JsonConverter(typeof(EnumClassConverter<DbSourceEnum>))]
        public class DbSourceEnum
        {
            /// <summary>
            /// Enum AWS_AURORA_MYSQL for value: aws_aurora_mysql
            /// </summary>
            public static readonly DbSourceEnum AWS_AURORA_MYSQL = new DbSourceEnum("aws_aurora_mysql");

            /// <summary>
            /// Enum TENCENT_TDSQL_C for value: tencent_tdsql_c
            /// </summary>
            public static readonly DbSourceEnum TENCENT_TDSQL_C = new DbSourceEnum("tencent_tdsql_c");

            /// <summary>
            /// Enum ALI_RDS_MYSQL for value: ali_rds_mysql
            /// </summary>
            public static readonly DbSourceEnum ALI_RDS_MYSQL = new DbSourceEnum("ali_rds_mysql");

            private static readonly Dictionary<string, DbSourceEnum> StaticFields =
            new Dictionary<string, DbSourceEnum>()
            {
                { "aws_aurora_mysql", AWS_AURORA_MYSQL },
                { "tencent_tdsql_c", TENCENT_TDSQL_C },
                { "ali_rds_mysql", ALI_RDS_MYSQL },
            };

            private string _value;

            public DbSourceEnum()
            {

            }

            public DbSourceEnum(string value)
            {
                _value = value;
            }

            public static DbSourceEnum FromValue(string value)
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

                if (this.Equals(obj as DbSourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DbSourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DbSourceEnum a, DbSourceEnum b)
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

            public static bool operator !=(DbSourceEnum a, DbSourceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 源实例ID。
        /// </summary>
        [JsonProperty("db_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// 云类型： - AWSCloud：亚马逊云。 - TencentCloud：腾讯云。 - AliCloud：阿里云。
        /// </summary>
        [JsonProperty("cloud_type", NullValueHandling = NullValueHandling.Ignore)]
        public CloudTypeEnum CloudType { get; set; }
        /// <summary>
        /// 其他云AK信息。
        /// </summary>
        [JsonProperty("ak", NullValueHandling = NullValueHandling.Ignore)]
        public string Ak { get; set; }

        /// <summary>
        /// 其他云SK信息。
        /// </summary>
        [JsonProperty("sk", NullValueHandling = NullValueHandling.Ignore)]
        public string Sk { get; set; }

        /// <summary>
        /// 源数据库来源。取值： - aws_aurora_mysql：Amazon Aurora MySQL。 - tencent_tdsql_c：腾讯云TDSQL-C MySQL。 - ali_rds_mysql：阿里云RDS MySQL。
        /// </summary>
        [JsonProperty("db_source", NullValueHandling = NullValueHandling.Ignore)]
        public DbSourceEnum DbSource { get; set; }
        /// <summary>
        /// 其他云Region名称。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 流量文件来源。 - sdk：通过三方云API接口方式下载审计日志。
        /// </summary>
        [JsonProperty("traffic_source", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficSource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplayConfigInfo {\n");
            sb.Append("  dbInstanceId: ").Append(DbInstanceId).Append("\n");
            sb.Append("  cloudType: ").Append(CloudType).Append("\n");
            sb.Append("  ak: ").Append(Ak).Append("\n");
            sb.Append("  sk: ").Append(Sk).Append("\n");
            sb.Append("  dbSource: ").Append(DbSource).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  trafficSource: ").Append(TrafficSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplayConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplayConfigInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbInstanceId == input.DbInstanceId ||
                    (this.DbInstanceId != null &&
                    this.DbInstanceId.Equals(input.DbInstanceId))
                ) && 
                (
                    this.CloudType == input.CloudType ||
                    (this.CloudType != null &&
                    this.CloudType.Equals(input.CloudType))
                ) && 
                (
                    this.Ak == input.Ak ||
                    (this.Ak != null &&
                    this.Ak.Equals(input.Ak))
                ) && 
                (
                    this.Sk == input.Sk ||
                    (this.Sk != null &&
                    this.Sk.Equals(input.Sk))
                ) && 
                (
                    this.DbSource == input.DbSource ||
                    (this.DbSource != null &&
                    this.DbSource.Equals(input.DbSource))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.TrafficSource == input.TrafficSource ||
                    (this.TrafficSource != null &&
                    this.TrafficSource.Equals(input.TrafficSource))
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
                if (this.DbInstanceId != null)
                    hashCode = hashCode * 59 + this.DbInstanceId.GetHashCode();
                if (this.CloudType != null)
                    hashCode = hashCode * 59 + this.CloudType.GetHashCode();
                if (this.Ak != null)
                    hashCode = hashCode * 59 + this.Ak.GetHashCode();
                if (this.Sk != null)
                    hashCode = hashCode * 59 + this.Sk.GetHashCode();
                if (this.DbSource != null)
                    hashCode = hashCode * 59 + this.DbSource.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.TrafficSource != null)
                    hashCode = hashCode * 59 + this.TrafficSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
