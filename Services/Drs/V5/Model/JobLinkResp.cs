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
    /// 可用链路返回体。
    /// </summary>
    public class JobLinkResp 
    {
        /// <summary>
        /// 任务场景。取值： - migration：实时迁移。 - sync：实时同步。 - cloudDataGuard：实时灾备。
        /// </summary>
        /// <value>任务场景。取值： - migration：实时迁移。 - sync：实时同步。 - cloudDataGuard：实时灾备。</value>
        [JsonConverter(typeof(EnumClassConverter<JobTypeEnum>))]
        public class JobTypeEnum
        {
            /// <summary>
            /// Enum MIGRATION for value: migration
            /// </summary>
            public static readonly JobTypeEnum MIGRATION = new JobTypeEnum("migration");

            /// <summary>
            /// Enum SYNC for value: sync
            /// </summary>
            public static readonly JobTypeEnum SYNC = new JobTypeEnum("sync");

            /// <summary>
            /// Enum CLOUDDATAGUARD for value: cloudDataGuard
            /// </summary>
            public static readonly JobTypeEnum CLOUDDATAGUARD = new JobTypeEnum("cloudDataGuard");

            private static readonly Dictionary<string, JobTypeEnum> StaticFields =
            new Dictionary<string, JobTypeEnum>()
            {
                { "migration", MIGRATION },
                { "sync", SYNC },
                { "cloudDataGuard", CLOUDDATAGUARD },
            };

            private string _value;

            public JobTypeEnum()
            {

            }

            public JobTypeEnum(string value)
            {
                _value = value;
            }

            public static JobTypeEnum FromValue(string value)
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

                if (this.Equals(obj as JobTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobTypeEnum a, JobTypeEnum b)
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

            public static bool operator !=(JobTypeEnum a, JobTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 引擎类型。取值： - oracle-to-gaussdbv5：Oracle同步到GaussDB分布式版，实时同步场景使用。
        /// </summary>
        /// <value>引擎类型。取值： - oracle-to-gaussdbv5：Oracle同步到GaussDB分布式版，实时同步场景使用。</value>
        [JsonConverter(typeof(EnumClassConverter<EngineTypeEnum>))]
        public class EngineTypeEnum
        {
            /// <summary>
            /// Enum ORACLE_TO_GAUSSDBV5 for value: oracle-to-gaussdbv5
            /// </summary>
            public static readonly EngineTypeEnum ORACLE_TO_GAUSSDBV5 = new EngineTypeEnum("oracle-to-gaussdbv5");

            private static readonly Dictionary<string, EngineTypeEnum> StaticFields =
            new Dictionary<string, EngineTypeEnum>()
            {
                { "oracle-to-gaussdbv5", ORACLE_TO_GAUSSDBV5 },
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
        /// 源数据库实例类型。取值： - offline：自建数据库。 - ecs：华为云ECS自建数据库。 - cloud：华为云数据库。
        /// </summary>
        /// <value>源数据库实例类型。取值： - offline：自建数据库。 - ecs：华为云ECS自建数据库。 - cloud：华为云数据库。</value>
        [JsonConverter(typeof(EnumClassConverter<SourceEndpointTypeEnum>))]
        public class SourceEndpointTypeEnum
        {
            /// <summary>
            /// Enum OFFLINE for value: offline
            /// </summary>
            public static readonly SourceEndpointTypeEnum OFFLINE = new SourceEndpointTypeEnum("offline");

            /// <summary>
            /// Enum ECS for value: ecs
            /// </summary>
            public static readonly SourceEndpointTypeEnum ECS = new SourceEndpointTypeEnum("ecs");

            /// <summary>
            /// Enum CLOUD for value: cloud
            /// </summary>
            public static readonly SourceEndpointTypeEnum CLOUD = new SourceEndpointTypeEnum("cloud");

            private static readonly Dictionary<string, SourceEndpointTypeEnum> StaticFields =
            new Dictionary<string, SourceEndpointTypeEnum>()
            {
                { "offline", OFFLINE },
                { "ecs", ECS },
                { "cloud", CLOUD },
            };

            private string _value;

            public SourceEndpointTypeEnum()
            {

            }

            public SourceEndpointTypeEnum(string value)
            {
                _value = value;
            }

            public static SourceEndpointTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SourceEndpointTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SourceEndpointTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SourceEndpointTypeEnum a, SourceEndpointTypeEnum b)
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

            public static bool operator !=(SourceEndpointTypeEnum a, SourceEndpointTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 目标数据库实例类型。取值： - offline：自建数据库。 - ecs：华为云ECS自建数据库。 - cloud：华为云数据库。
        /// </summary>
        /// <value>目标数据库实例类型。取值： - offline：自建数据库。 - ecs：华为云ECS自建数据库。 - cloud：华为云数据库。</value>
        [JsonConverter(typeof(EnumClassConverter<TargetEndpointTypeEnum>))]
        public class TargetEndpointTypeEnum
        {
            /// <summary>
            /// Enum OFFLINE for value: offline
            /// </summary>
            public static readonly TargetEndpointTypeEnum OFFLINE = new TargetEndpointTypeEnum("offline");

            /// <summary>
            /// Enum ECS for value: ecs
            /// </summary>
            public static readonly TargetEndpointTypeEnum ECS = new TargetEndpointTypeEnum("ecs");

            /// <summary>
            /// Enum CLOUD for value: cloud
            /// </summary>
            public static readonly TargetEndpointTypeEnum CLOUD = new TargetEndpointTypeEnum("cloud");

            private static readonly Dictionary<string, TargetEndpointTypeEnum> StaticFields =
            new Dictionary<string, TargetEndpointTypeEnum>()
            {
                { "offline", OFFLINE },
                { "ecs", ECS },
                { "cloud", CLOUD },
            };

            private string _value;

            public TargetEndpointTypeEnum()
            {

            }

            public TargetEndpointTypeEnum(string value)
            {
                _value = value;
            }

            public static TargetEndpointTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TargetEndpointTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TargetEndpointTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TargetEndpointTypeEnum a, TargetEndpointTypeEnum b)
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

            public static bool operator !=(TargetEndpointTypeEnum a, TargetEndpointTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 迁移方向。取值： - up：入云 ，灾备场景时对应本云为备。 - down：出云，灾备场景时对应本云为主。 - non-dbs：自建。
        /// </summary>
        /// <value>迁移方向。取值： - up：入云 ，灾备场景时对应本云为备。 - down：出云，灾备场景时对应本云为主。 - non-dbs：自建。</value>
        [JsonConverter(typeof(EnumClassConverter<JobDirectionEnum>))]
        public class JobDirectionEnum
        {
            /// <summary>
            /// Enum UP for value: up
            /// </summary>
            public static readonly JobDirectionEnum UP = new JobDirectionEnum("up");

            /// <summary>
            /// Enum DOWN for value: down
            /// </summary>
            public static readonly JobDirectionEnum DOWN = new JobDirectionEnum("down");

            /// <summary>
            /// Enum NON_DBS for value: non-dbs
            /// </summary>
            public static readonly JobDirectionEnum NON_DBS = new JobDirectionEnum("non-dbs");

            private static readonly Dictionary<string, JobDirectionEnum> StaticFields =
            new Dictionary<string, JobDirectionEnum>()
            {
                { "up", UP },
                { "down", DOWN },
                { "non-dbs", NON_DBS },
            };

            private string _value;

            public JobDirectionEnum()
            {

            }

            public JobDirectionEnum(string value)
            {
                _value = value;
            }

            public static JobDirectionEnum FromValue(string value)
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

                if (this.Equals(obj as JobDirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobDirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobDirectionEnum a, JobDirectionEnum b)
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

            public static bool operator !=(JobDirectionEnum a, JobDirectionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 网络类型。取值： - eip：公网网络。 - vpc：VPC网络，灾备场景不支持选择VPC网络。 - vpn：VPN、专线网络。
        /// </summary>
        /// <value>网络类型。取值： - eip：公网网络。 - vpc：VPC网络，灾备场景不支持选择VPC网络。 - vpn：VPN、专线网络。</value>
        [JsonConverter(typeof(EnumClassConverter<NetTypeEnum>))]
        public class NetTypeEnum
        {
            /// <summary>
            /// Enum EIP for value: eip
            /// </summary>
            public static readonly NetTypeEnum EIP = new NetTypeEnum("eip");

            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly NetTypeEnum VPC = new NetTypeEnum("vpc");

            /// <summary>
            /// Enum VPN for value: vpn
            /// </summary>
            public static readonly NetTypeEnum VPN = new NetTypeEnum("vpn");

            private static readonly Dictionary<string, NetTypeEnum> StaticFields =
            new Dictionary<string, NetTypeEnum>()
            {
                { "eip", EIP },
                { "vpc", VPC },
                { "vpn", VPN },
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
        /// Defines taskTypes
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<TaskTypesEnum>))]
        public class TaskTypesEnum
        {
            /// <summary>
            /// Enum FULL_TRANS for value: FULL_TRANS
            /// </summary>
            public static readonly TaskTypesEnum FULL_TRANS = new TaskTypesEnum("FULL_TRANS");

            /// <summary>
            /// Enum FULL_INCR_TRANS for value: FULL_INCR_TRANS
            /// </summary>
            public static readonly TaskTypesEnum FULL_INCR_TRANS = new TaskTypesEnum("FULL_INCR_TRANS");

            /// <summary>
            /// Enum INCR_TRANS for value: INCR_TRANS
            /// </summary>
            public static readonly TaskTypesEnum INCR_TRANS = new TaskTypesEnum("INCR_TRANS");

            private static readonly Dictionary<string, TaskTypesEnum> StaticFields =
            new Dictionary<string, TaskTypesEnum>()
            {
                { "FULL_TRANS", FULL_TRANS },
                { "FULL_INCR_TRANS", FULL_INCR_TRANS },
                { "INCR_TRANS", INCR_TRANS },
            };

            private string _value;

            public TaskTypesEnum()
            {

            }

            public TaskTypesEnum(string value)
            {
                _value = value;
            }

            public static TaskTypesEnum FromValue(string value)
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

                if (this.Equals(obj as TaskTypesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TaskTypesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TaskTypesEnum a, TaskTypesEnum b)
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

            public static bool operator !=(TaskTypesEnum a, TaskTypesEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines clusterModes
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ClusterModesEnum>))]
        public class ClusterModesEnum
        {
            /// <summary>
            /// Enum SINGLE for value: Single
            /// </summary>
            public static readonly ClusterModesEnum SINGLE = new ClusterModesEnum("Single");

            /// <summary>
            /// Enum HA for value: Ha
            /// </summary>
            public static readonly ClusterModesEnum HA = new ClusterModesEnum("Ha");

            /// <summary>
            /// Enum CLUSTER for value: Cluster
            /// </summary>
            public static readonly ClusterModesEnum CLUSTER = new ClusterModesEnum("Cluster");

            /// <summary>
            /// Enum SHARDING for value: Sharding
            /// </summary>
            public static readonly ClusterModesEnum SHARDING = new ClusterModesEnum("Sharding");

            /// <summary>
            /// Enum INDEPENDENT for value: Independent
            /// </summary>
            public static readonly ClusterModesEnum INDEPENDENT = new ClusterModesEnum("Independent");

            private static readonly Dictionary<string, ClusterModesEnum> StaticFields =
            new Dictionary<string, ClusterModesEnum>()
            {
                { "Single", SINGLE },
                { "Ha", HA },
                { "Cluster", CLUSTER },
                { "Sharding", SHARDING },
                { "Independent", INDEPENDENT },
            };

            private string _value;

            public ClusterModesEnum()
            {

            }

            public ClusterModesEnum(string value)
            {
                _value = value;
            }

            public static ClusterModesEnum FromValue(string value)
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

                if (this.Equals(obj as ClusterModesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ClusterModesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ClusterModesEnum a, ClusterModesEnum b)
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

            public static bool operator !=(ClusterModesEnum a, ClusterModesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 任务场景。取值： - migration：实时迁移。 - sync：实时同步。 - cloudDataGuard：实时灾备。
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public JobTypeEnum JobType { get; set; }
        /// <summary>
        /// 引擎类型。取值： - oracle-to-gaussdbv5：Oracle同步到GaussDB分布式版，实时同步场景使用。
        /// </summary>
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public EngineTypeEnum EngineType { get; set; }
        /// <summary>
        /// 源数据库实例类型。取值： - offline：自建数据库。 - ecs：华为云ECS自建数据库。 - cloud：华为云数据库。
        /// </summary>
        [JsonProperty("source_endpoint_type", NullValueHandling = NullValueHandling.Ignore)]
        public SourceEndpointTypeEnum SourceEndpointType { get; set; }
        /// <summary>
        /// 目标数据库实例类型。取值： - offline：自建数据库。 - ecs：华为云ECS自建数据库。 - cloud：华为云数据库。
        /// </summary>
        [JsonProperty("target_endpoint_type", NullValueHandling = NullValueHandling.Ignore)]
        public TargetEndpointTypeEnum TargetEndpointType { get; set; }
        /// <summary>
        /// 迁移方向。取值： - up：入云 ，灾备场景时对应本云为备。 - down：出云，灾备场景时对应本云为主。 - non-dbs：自建。
        /// </summary>
        [JsonProperty("job_direction", NullValueHandling = NullValueHandling.Ignore)]
        public JobDirectionEnum JobDirection { get; set; }
        /// <summary>
        /// 网络类型。取值： - eip：公网网络。 - vpc：VPC网络，灾备场景不支持选择VPC网络。 - vpn：VPN、专线网络。
        /// </summary>
        [JsonProperty("net_type", NullValueHandling = NullValueHandling.Ignore)]
        public NetTypeEnum NetType { get; set; }
        /// <summary>
        /// 迁移模式。取值： - FULL_TRANS ：全量。 - FULL_INCR_TRANS：全量+增量。 - INCR_TRANS：增量。
        /// </summary>
        [JsonProperty("task_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskTypesEnum> TaskTypes { get; set; }
        /// <summary>
        /// 引擎实例模式。取值： - Single：单机模式。 - Ha：主备模式。 - Cluster：集群模式。 - Sharding：分片模式。 - Independent：GaussDB独立部署模式。
        /// </summary>
        [JsonProperty("cluster_modes", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClusterModesEnum> ClusterModes { get; set; }
        /// <summary>
        /// 链路描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobLinkResp {\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  sourceEndpointType: ").Append(SourceEndpointType).Append("\n");
            sb.Append("  targetEndpointType: ").Append(TargetEndpointType).Append("\n");
            sb.Append("  jobDirection: ").Append(JobDirection).Append("\n");
            sb.Append("  netType: ").Append(NetType).Append("\n");
            sb.Append("  taskTypes: ").Append(TaskTypes).Append("\n");
            sb.Append("  clusterModes: ").Append(ClusterModes).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobLinkResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobLinkResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobType == input.JobType ||
                    (this.JobType != null &&
                    this.JobType.Equals(input.JobType))
                ) && 
                (
                    this.EngineType == input.EngineType ||
                    (this.EngineType != null &&
                    this.EngineType.Equals(input.EngineType))
                ) && 
                (
                    this.SourceEndpointType == input.SourceEndpointType ||
                    (this.SourceEndpointType != null &&
                    this.SourceEndpointType.Equals(input.SourceEndpointType))
                ) && 
                (
                    this.TargetEndpointType == input.TargetEndpointType ||
                    (this.TargetEndpointType != null &&
                    this.TargetEndpointType.Equals(input.TargetEndpointType))
                ) && 
                (
                    this.JobDirection == input.JobDirection ||
                    (this.JobDirection != null &&
                    this.JobDirection.Equals(input.JobDirection))
                ) && 
                (
                    this.NetType == input.NetType ||
                    (this.NetType != null &&
                    this.NetType.Equals(input.NetType))
                ) && 
                (
                    this.TaskTypes == input.TaskTypes ||
                    this.TaskTypes != null &&
                    input.TaskTypes != null &&
                    this.TaskTypes.SequenceEqual(input.TaskTypes)
                ) && 
                (
                    this.ClusterModes == input.ClusterModes ||
                    this.ClusterModes != null &&
                    input.ClusterModes != null &&
                    this.ClusterModes.SequenceEqual(input.ClusterModes)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.JobType != null)
                    hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.EngineType != null)
                    hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                if (this.SourceEndpointType != null)
                    hashCode = hashCode * 59 + this.SourceEndpointType.GetHashCode();
                if (this.TargetEndpointType != null)
                    hashCode = hashCode * 59 + this.TargetEndpointType.GetHashCode();
                if (this.JobDirection != null)
                    hashCode = hashCode * 59 + this.JobDirection.GetHashCode();
                if (this.NetType != null)
                    hashCode = hashCode * 59 + this.NetType.GetHashCode();
                if (this.TaskTypes != null)
                    hashCode = hashCode * 59 + this.TaskTypes.GetHashCode();
                if (this.ClusterModes != null)
                    hashCode = hashCode * 59 + this.ClusterModes.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
