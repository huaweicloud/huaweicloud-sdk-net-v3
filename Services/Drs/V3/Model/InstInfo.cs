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
    /// 迁移实例信息体
    /// </summary>
    public class InstInfo 
    {
        /// <summary>
        /// 引擎类型
        /// </summary>
        /// <value>引擎类型</value>
        [JsonConverter(typeof(EnumClassConverter<EngineTypeEnum>))]
        public class EngineTypeEnum
        {
            /// <summary>
            /// Enum MYSQL for value: mysql
            /// </summary>
            public static readonly EngineTypeEnum MYSQL = new EngineTypeEnum("mysql");

            /// <summary>
            /// Enum MONGODB for value: mongodb
            /// </summary>
            public static readonly EngineTypeEnum MONGODB = new EngineTypeEnum("mongodb");

            /// <summary>
            /// Enum CLOUDDATAGUARD_MYSQL for value: cloudDataGuard-mysql
            /// </summary>
            public static readonly EngineTypeEnum CLOUDDATAGUARD_MYSQL = new EngineTypeEnum("cloudDataGuard-mysql");

            /// <summary>
            /// Enum GAUSSDBV5 for value: gaussdbv5
            /// </summary>
            public static readonly EngineTypeEnum GAUSSDBV5 = new EngineTypeEnum("gaussdbv5");

            /// <summary>
            /// Enum POSTGRESQL for value: postgresql
            /// </summary>
            public static readonly EngineTypeEnum POSTGRESQL = new EngineTypeEnum("postgresql");

            /// <summary>
            /// Enum MYSQL_TO_KAFKA for value: mysql-to-kafka
            /// </summary>
            public static readonly EngineTypeEnum MYSQL_TO_KAFKA = new EngineTypeEnum("mysql-to-kafka");

            /// <summary>
            /// Enum TAURUS_TO_KAFKA for value: taurus-to-kafka
            /// </summary>
            public static readonly EngineTypeEnum TAURUS_TO_KAFKA = new EngineTypeEnum("taurus-to-kafka");

            /// <summary>
            /// Enum GAUSSDBV5HA_TO_KAFKA for value: gaussdbv5ha-to-kafka
            /// </summary>
            public static readonly EngineTypeEnum GAUSSDBV5HA_TO_KAFKA = new EngineTypeEnum("gaussdbv5ha-to-kafka");

            private static readonly Dictionary<string, EngineTypeEnum> StaticFields =
            new Dictionary<string, EngineTypeEnum>()
            {
                { "mysql", MYSQL },
                { "mongodb", MONGODB },
                { "cloudDataGuard-mysql", CLOUDDATAGUARD_MYSQL },
                { "gaussdbv5", GAUSSDBV5 },
                { "postgresql", POSTGRESQL },
                { "mysql-to-kafka", MYSQL_TO_KAFKA },
                { "taurus-to-kafka", TAURUS_TO_KAFKA },
                { "gaussdbv5ha-to-kafka", GAUSSDBV5HA_TO_KAFKA },
            };

            private string _value;

            public EngineTypeEnum()
            {

            }

            public EngineTypeEnum(string value)
            {
                _value = value;
            }

            public static EngineTypeEnum FromValue(string value)
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

                if (this.Equals(obj as EngineTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EngineTypeEnum a, EngineTypeEnum b)
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

            public static bool operator !=(EngineTypeEnum a, EngineTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 实例类型
        /// </summary>
        /// <value>实例类型</value>
        [JsonConverter(typeof(EnumClassConverter<InstTypeEnum>))]
        public class InstTypeEnum
        {
            /// <summary>
            /// Enum HIGH for value: high
            /// </summary>
            public static readonly InstTypeEnum HIGH = new InstTypeEnum("high");

            private static readonly Dictionary<string, InstTypeEnum> StaticFields =
            new Dictionary<string, InstTypeEnum>()
            {
                { "high", HIGH },
            };

            private string _value;

            public InstTypeEnum()
            {

            }

            public InstTypeEnum(string value)
            {
                _value = value;
            }

            public static InstTypeEnum FromValue(string value)
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

                if (this.Equals(obj as InstTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstTypeEnum a, InstTypeEnum b)
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

            public static bool operator !=(InstTypeEnum a, InstTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 迁移实例的状态
        /// </summary>
        /// <value>迁移实例的状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: active
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("active");

            /// <summary>
            /// Enum DELETED for value: deleted
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("deleted");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "active", ACTIVE },
                { "deleted", DELETED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 引擎类型
        /// </summary>
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public EngineTypeEnum EngineType { get; set; }
        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("inst_type", NullValueHandling = NullValueHandling.Ignore)]
        public InstTypeEnum InstType { get; set; }
        /// <summary>
        /// 迁移实例所在的私有IP
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 迁移实例所在的公网IP
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 迁移实例任务定时启动时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 迁移实例的状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 迁移实例的磁盘大小
        /// </summary>
        [JsonProperty("volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? VolumeSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstInfo {\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  instType: ").Append(InstType).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  volumeSize: ").Append(VolumeSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstInfo input)
        {
            if (input == null) return false;
            if (this.EngineType != input.EngineType) return false;
            if (this.InstType != input.InstType) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Status != input.Status) return false;
            if (this.VolumeSize != input.VolumeSize || (this.VolumeSize != null && !this.VolumeSize.Equals(input.VolumeSize))) return false;

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
                hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                hashCode = hashCode * 59 + this.InstType.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VolumeSize != null) hashCode = hashCode * 59 + this.VolumeSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
