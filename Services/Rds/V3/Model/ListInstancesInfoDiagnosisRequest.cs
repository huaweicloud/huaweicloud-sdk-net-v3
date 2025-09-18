using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListInstancesInfoDiagnosisRequest 
    {
        /// <summary>
        /// 引擎类型
        /// </summary>
        /// <value>引擎类型</value>
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
        /// 诊断项
        /// </summary>
        /// <value>诊断项</value>
        [JsonConverter(typeof(EnumClassConverter<DiagnosisEnum>))]
        public class DiagnosisEnum
        {
            /// <summary>
            /// Enum HIGH_PRESSURE for value: high_pressure
            /// </summary>
            public static readonly DiagnosisEnum HIGH_PRESSURE = new DiagnosisEnum("high_pressure");

            /// <summary>
            /// Enum LOCK_WAIT for value: lock_wait
            /// </summary>
            public static readonly DiagnosisEnum LOCK_WAIT = new DiagnosisEnum("lock_wait");

            /// <summary>
            /// Enum INSUFFICIENT_CAPACITY for value: insufficient_capacity
            /// </summary>
            public static readonly DiagnosisEnum INSUFFICIENT_CAPACITY = new DiagnosisEnum("insufficient_capacity");

            /// <summary>
            /// Enum SLOW_SQL_FREQUENCY for value: slow_sql_frequency
            /// </summary>
            public static readonly DiagnosisEnum SLOW_SQL_FREQUENCY = new DiagnosisEnum("slow_sql_frequency");

            /// <summary>
            /// Enum DISK_PERFORMANCE_CAP for value: disk_performance_cap
            /// </summary>
            public static readonly DiagnosisEnum DISK_PERFORMANCE_CAP = new DiagnosisEnum("disk_performance_cap");

            /// <summary>
            /// Enum MEM_OVERRUN for value: mem_overrun
            /// </summary>
            public static readonly DiagnosisEnum MEM_OVERRUN = new DiagnosisEnum("mem_overrun");

            /// <summary>
            /// Enum AGE_EXCEED for value: age_exceed
            /// </summary>
            public static readonly DiagnosisEnum AGE_EXCEED = new DiagnosisEnum("age_exceed");

            /// <summary>
            /// Enum CONNECTIONS_EXCEED for value: connections_exceed
            /// </summary>
            public static readonly DiagnosisEnum CONNECTIONS_EXCEED = new DiagnosisEnum("connections_exceed");

            private static readonly Dictionary<string, DiagnosisEnum> StaticFields =
            new Dictionary<string, DiagnosisEnum>()
            {
                { "high_pressure", HIGH_PRESSURE },
                { "lock_wait", LOCK_WAIT },
                { "insufficient_capacity", INSUFFICIENT_CAPACITY },
                { "slow_sql_frequency", SLOW_SQL_FREQUENCY },
                { "disk_performance_cap", DISK_PERFORMANCE_CAP },
                { "mem_overrun", MEM_OVERRUN },
                { "age_exceed", AGE_EXCEED },
                { "connections_exceed", CONNECTIONS_EXCEED },
            };

            private string _value;

            public DiagnosisEnum()
            {

            }

            public DiagnosisEnum(string value)
            {
                _value = value;
            }

            public static DiagnosisEnum FromValue(string value)
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

                if (this.Equals(obj as DiagnosisEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DiagnosisEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DiagnosisEnum a, DiagnosisEnum b)
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

            public static bool operator !=(DiagnosisEnum a, DiagnosisEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 引擎类型
        /// </summary>
        [SDKProperty("engine", IsQuery = true)]
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public EngineEnum Engine { get; set; }
        /// <summary>
        /// 诊断项
        /// </summary>
        [SDKProperty("diagnosis", IsQuery = true)]
        [JsonProperty("diagnosis", NullValueHandling = NullValueHandling.Ignore)]
        public DiagnosisEnum Diagnosis { get; set; }
        /// <summary>
        /// offset
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// limit
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesInfoDiagnosisRequest {\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  diagnosis: ").Append(Diagnosis).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesInfoDiagnosisRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesInfoDiagnosisRequest input)
        {
            if (input == null) return false;
            if (this.Engine != input.Engine) return false;
            if (this.Diagnosis != input.Diagnosis) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                hashCode = hashCode * 59 + this.Engine.GetHashCode();
                hashCode = hashCode * 59 + this.Diagnosis.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
