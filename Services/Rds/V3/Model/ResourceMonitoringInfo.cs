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
    /// 资源监控信息
    /// </summary>
    public class ResourceMonitoringInfo 
    {
        /// <summary>
        /// 实例类型
        /// </summary>
        /// <value>实例类型</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SINGLE for value: Single
            /// </summary>
            public static readonly TypeEnum SINGLE = new TypeEnum("Single");

            /// <summary>
            /// Enum HA for value: Ha
            /// </summary>
            public static readonly TypeEnum HA = new TypeEnum("Ha");

            /// <summary>
            /// Enum REPLICA for value: Replica
            /// </summary>
            public static readonly TypeEnum REPLICA = new TypeEnum("Replica");

            /// <summary>
            /// Enum ENTERPRISE for value: Enterprise
            /// </summary>
            public static readonly TypeEnum ENTERPRISE = new TypeEnum("Enterprise");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "Single", SINGLE },
                { "Ha", HA },
                { "Replica", REPLICA },
                { "Enterprise", ENTERPRISE },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 引擎名称
        /// </summary>
        /// <value>引擎名称</value>
        [JsonConverter(typeof(EnumClassConverter<EngineNameEnum>))]
        public class EngineNameEnum
        {
            /// <summary>
            /// Enum MYSQL for value: mysql
            /// </summary>
            public static readonly EngineNameEnum MYSQL = new EngineNameEnum("mysql");

            /// <summary>
            /// Enum POSTGRESQL for value: postgresql
            /// </summary>
            public static readonly EngineNameEnum POSTGRESQL = new EngineNameEnum("postgresql");

            /// <summary>
            /// Enum SQLSERVER for value: sqlserver
            /// </summary>
            public static readonly EngineNameEnum SQLSERVER = new EngineNameEnum("sqlserver");

            private static readonly Dictionary<string, EngineNameEnum> StaticFields =
            new Dictionary<string, EngineNameEnum>()
            {
                { "mysql", MYSQL },
                { "postgresql", POSTGRESQL },
                { "sqlserver", SQLSERVER },
            };

            private string _value;

            public EngineNameEnum()
            {

            }

            public EngineNameEnum(string value)
            {
                _value = value;
            }

            public static EngineNameEnum FromValue(string value)
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

                if (this.Equals(obj as EngineNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EngineNameEnum a, EngineNameEnum b)
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

            public static bool operator !=(EngineNameEnum a, EngineNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance_state", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceState InstanceState { get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// cpu大小
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// 内存大小（单位：GB）
        /// </summary>
        [JsonProperty("mem", NullValueHandling = NullValueHandling.Ignore)]
        public string Mem { get; set; }

        /// <summary>
        /// 引擎名称
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public EngineNameEnum EngineName { get; set; }
        /// <summary>
        /// 引擎版本
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// cpu使用率
        /// </summary>
        [JsonProperty("cpu_usage", NullValueHandling = NullValueHandling.Ignore)]
        public double? CpuUsage { get; set; }

        /// <summary>
        /// 内存使用率
        /// </summary>
        [JsonProperty("memory_usage", NullValueHandling = NullValueHandling.Ignore)]
        public double? MemoryUsage { get; set; }

        /// <summary>
        /// 磁盘使用率
        /// </summary>
        [JsonProperty("disk_usage", NullValueHandling = NullValueHandling.Ignore)]
        public double? DiskUsage { get; set; }

        /// <summary>
        /// tps
        /// </summary>
        [JsonProperty("tps", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tps { get; set; }

        /// <summary>
        /// qps
        /// </summary>
        [JsonProperty("qps", NullValueHandling = NullValueHandling.Ignore)]
        public double? Qps { get; set; }

        /// <summary>
        /// iops
        /// </summary>
        [JsonProperty("iops", NullValueHandling = NullValueHandling.Ignore)]
        public double? Iops { get; set; }

        /// <summary>
        /// 活跃连接数
        /// </summary>
        [JsonProperty("active_connections", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActiveConnections { get; set; }

        /// <summary>
        /// 慢SQL
        /// </summary>
        [JsonProperty("slow_sql", NullValueHandling = NullValueHandling.Ignore)]
        public double? SlowSql { get; set; }

        /// <summary>
        /// 只读实例资源监控指标
        /// </summary>
        [JsonProperty("readonly_instance_resource_monitoring_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceMonitoringInfo> ReadonlyInstanceResourceMonitoringInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceMonitoringInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  instanceState: ").Append(InstanceState).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  mem: ").Append(Mem).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  cpuUsage: ").Append(CpuUsage).Append("\n");
            sb.Append("  memoryUsage: ").Append(MemoryUsage).Append("\n");
            sb.Append("  diskUsage: ").Append(DiskUsage).Append("\n");
            sb.Append("  tps: ").Append(Tps).Append("\n");
            sb.Append("  qps: ").Append(Qps).Append("\n");
            sb.Append("  iops: ").Append(Iops).Append("\n");
            sb.Append("  activeConnections: ").Append(ActiveConnections).Append("\n");
            sb.Append("  slowSql: ").Append(SlowSql).Append("\n");
            sb.Append("  readonlyInstanceResourceMonitoringInfo: ").Append(ReadonlyInstanceResourceMonitoringInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceMonitoringInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceMonitoringInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.InstanceState == input.InstanceState ||
                    (this.InstanceState != null &&
                    this.InstanceState.Equals(input.InstanceState))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.Mem == input.Mem ||
                    (this.Mem != null &&
                    this.Mem.Equals(input.Mem))
                ) && 
                (
                    this.EngineName == input.EngineName ||
                    (this.EngineName != null &&
                    this.EngineName.Equals(input.EngineName))
                ) && 
                (
                    this.EngineVersion == input.EngineVersion ||
                    (this.EngineVersion != null &&
                    this.EngineVersion.Equals(input.EngineVersion))
                ) && 
                (
                    this.CpuUsage == input.CpuUsage ||
                    (this.CpuUsage != null &&
                    this.CpuUsage.Equals(input.CpuUsage))
                ) && 
                (
                    this.MemoryUsage == input.MemoryUsage ||
                    (this.MemoryUsage != null &&
                    this.MemoryUsage.Equals(input.MemoryUsage))
                ) && 
                (
                    this.DiskUsage == input.DiskUsage ||
                    (this.DiskUsage != null &&
                    this.DiskUsage.Equals(input.DiskUsage))
                ) && 
                (
                    this.Tps == input.Tps ||
                    (this.Tps != null &&
                    this.Tps.Equals(input.Tps))
                ) && 
                (
                    this.Qps == input.Qps ||
                    (this.Qps != null &&
                    this.Qps.Equals(input.Qps))
                ) && 
                (
                    this.Iops == input.Iops ||
                    (this.Iops != null &&
                    this.Iops.Equals(input.Iops))
                ) && 
                (
                    this.ActiveConnections == input.ActiveConnections ||
                    (this.ActiveConnections != null &&
                    this.ActiveConnections.Equals(input.ActiveConnections))
                ) && 
                (
                    this.SlowSql == input.SlowSql ||
                    (this.SlowSql != null &&
                    this.SlowSql.Equals(input.SlowSql))
                ) && 
                (
                    this.ReadonlyInstanceResourceMonitoringInfo == input.ReadonlyInstanceResourceMonitoringInfo ||
                    this.ReadonlyInstanceResourceMonitoringInfo != null &&
                    input.ReadonlyInstanceResourceMonitoringInfo != null &&
                    this.ReadonlyInstanceResourceMonitoringInfo.SequenceEqual(input.ReadonlyInstanceResourceMonitoringInfo)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InstanceState != null)
                    hashCode = hashCode * 59 + this.InstanceState.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Mem != null)
                    hashCode = hashCode * 59 + this.Mem.GetHashCode();
                if (this.EngineName != null)
                    hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.EngineVersion != null)
                    hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.CpuUsage != null)
                    hashCode = hashCode * 59 + this.CpuUsage.GetHashCode();
                if (this.MemoryUsage != null)
                    hashCode = hashCode * 59 + this.MemoryUsage.GetHashCode();
                if (this.DiskUsage != null)
                    hashCode = hashCode * 59 + this.DiskUsage.GetHashCode();
                if (this.Tps != null)
                    hashCode = hashCode * 59 + this.Tps.GetHashCode();
                if (this.Qps != null)
                    hashCode = hashCode * 59 + this.Qps.GetHashCode();
                if (this.Iops != null)
                    hashCode = hashCode * 59 + this.Iops.GetHashCode();
                if (this.ActiveConnections != null)
                    hashCode = hashCode * 59 + this.ActiveConnections.GetHashCode();
                if (this.SlowSql != null)
                    hashCode = hashCode * 59 + this.SlowSql.GetHashCode();
                if (this.ReadonlyInstanceResourceMonitoringInfo != null)
                    hashCode = hashCode * 59 + this.ReadonlyInstanceResourceMonitoringInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
