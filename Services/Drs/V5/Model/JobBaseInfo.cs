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
    /// 创建任务基本信息体。
    /// </summary>
    public class JobBaseInfo 
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
        /// 引擎类型。取值： - oracle-to-gaussdbv5：Oracle同步到GaussDB分布式版，实时同步场景使用。 - redis-to-gaussredis：Redis同步到GeminiDB Redis，实时迁移场景使用。 - rediscluster-to-gaussredis：Redis集群同步到GeminiDB Redis，实时迁移场景使用。
        /// </summary>
        /// <value>引擎类型。取值： - oracle-to-gaussdbv5：Oracle同步到GaussDB分布式版，实时同步场景使用。 - redis-to-gaussredis：Redis同步到GeminiDB Redis，实时迁移场景使用。 - rediscluster-to-gaussredis：Redis集群同步到GeminiDB Redis，实时迁移场景使用。</value>
        [JsonConverter(typeof(EnumClassConverter<EngineTypeEnum>))]
        public class EngineTypeEnum
        {
            /// <summary>
            /// Enum ORACLE_TO_GAUSSDBV5 for value: oracle-to-gaussdbv5
            /// </summary>
            public static readonly EngineTypeEnum ORACLE_TO_GAUSSDBV5 = new EngineTypeEnum("oracle-to-gaussdbv5");

            /// <summary>
            /// Enum REDIS_TO_GAUSSREDIS for value: redis-to-gaussredis
            /// </summary>
            public static readonly EngineTypeEnum REDIS_TO_GAUSSREDIS = new EngineTypeEnum("redis-to-gaussredis");

            /// <summary>
            /// Enum REDISCLUSTER_TO_GAUSSREDIS for value: rediscluster-to-gaussredis
            /// </summary>
            public static readonly EngineTypeEnum REDISCLUSTER_TO_GAUSSREDIS = new EngineTypeEnum("rediscluster-to-gaussredis");

            private static readonly Dictionary<string, EngineTypeEnum> StaticFields =
            new Dictionary<string, EngineTypeEnum>()
            {
                { "oracle-to-gaussdbv5", ORACLE_TO_GAUSSDBV5 },
                { "redis-to-gaussredis", REDIS_TO_GAUSSREDIS },
                { "rediscluster-to-gaussredis", REDISCLUSTER_TO_GAUSSREDIS },
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
        /// 迁移模式。取值： - FULL_TRANS ：全量。 - FULL_INCR_TRANS：全量+增量。 - INCR_TRANS：增量。
        /// </summary>
        /// <value>迁移模式。取值： - FULL_TRANS ：全量。 - FULL_INCR_TRANS：全量+增量。 - INCR_TRANS：增量。</value>
        [JsonConverter(typeof(EnumClassConverter<TaskTypeEnum>))]
        public class TaskTypeEnum
        {
            /// <summary>
            /// Enum FULL_TRANS for value: FULL_TRANS
            /// </summary>
            public static readonly TaskTypeEnum FULL_TRANS = new TaskTypeEnum("FULL_TRANS");

            /// <summary>
            /// Enum FULL_INCR_TRANS for value: FULL_INCR_TRANS
            /// </summary>
            public static readonly TaskTypeEnum FULL_INCR_TRANS = new TaskTypeEnum("FULL_INCR_TRANS");

            /// <summary>
            /// Enum INCR_TRANS for value: INCR_TRANS
            /// </summary>
            public static readonly TaskTypeEnum INCR_TRANS = new TaskTypeEnum("INCR_TRANS");

            private static readonly Dictionary<string, TaskTypeEnum> StaticFields =
            new Dictionary<string, TaskTypeEnum>()
            {
                { "FULL_TRANS", FULL_TRANS },
                { "FULL_INCR_TRANS", FULL_INCR_TRANS },
                { "INCR_TRANS", INCR_TRANS },
            };

            private string _value;

            public TaskTypeEnum()
            {

            }

            public TaskTypeEnum(string value)
            {
                _value = value;
            }

            public static TaskTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TaskTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TaskTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TaskTypeEnum a, TaskTypeEnum b)
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

            public static bool operator !=(TaskTypeEnum a, TaskTypeEnum b)
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
        /// 计费模式，默认按需。取值： - period：包周期。 - on_demand：按需。
        /// </summary>
        /// <value>计费模式，默认按需。取值： - period：包周期。 - on_demand：按需。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargingModeEnum>))]
        public class ChargingModeEnum
        {
            /// <summary>
            /// Enum PERIOD for value: period
            /// </summary>
            public static readonly ChargingModeEnum PERIOD = new ChargingModeEnum("period");

            /// <summary>
            /// Enum ON_DEMAND for value: on_demand
            /// </summary>
            public static readonly ChargingModeEnum ON_DEMAND = new ChargingModeEnum("on_demand");

            private static readonly Dictionary<string, ChargingModeEnum> StaticFields =
            new Dictionary<string, ChargingModeEnum>()
            {
                { "period", PERIOD },
                { "on_demand", ON_DEMAND },
            };

            private string _value;

            public ChargingModeEnum()
            {

            }

            public ChargingModeEnum(string value)
            {
                _value = value;
            }

            public static ChargingModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargingModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargingModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargingModeEnum a, ChargingModeEnum b)
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

            public static bool operator !=(ChargingModeEnum a, ChargingModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务名称。 约束：任务名称在4位到50位之间，不区分大小写，可以包含字母、数字、中划线或下划线，不能包括其他特殊字符。 - 最小长度：4 - 最大长度：50
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 任务场景。取值： - migration：实时迁移。 - sync：实时同步。 - cloudDataGuard：实时灾备。
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public JobTypeEnum JobType { get; set; }
        /// <summary>
        /// 灾备类型是否双主灾备。说明： - job_type 是cloudDataGuard时，必填，灾备类型是双主灾备时，multi_write取值true, 否则为false。 - job_type 是其他类型时，multi_write是非必选参数。
        /// </summary>
        [JsonProperty("multi_write", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MultiWrite { get; set; }

        /// <summary>
        /// 引擎类型。取值： - oracle-to-gaussdbv5：Oracle同步到GaussDB分布式版，实时同步场景使用。 - redis-to-gaussredis：Redis同步到GeminiDB Redis，实时迁移场景使用。 - rediscluster-to-gaussredis：Redis集群同步到GeminiDB Redis，实时迁移场景使用。
        /// </summary>
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public EngineTypeEnum EngineType { get; set; }
        /// <summary>
        /// 迁移方向。取值： - up：入云 ，灾备场景时对应本云为备。 - down：出云，灾备场景时对应本云为主。 - non-dbs：自建。
        /// </summary>
        [JsonProperty("job_direction", NullValueHandling = NullValueHandling.Ignore)]
        public JobDirectionEnum JobDirection { get; set; }
        /// <summary>
        /// 迁移模式。取值： - FULL_TRANS ：全量。 - FULL_INCR_TRANS：全量+增量。 - INCR_TRANS：增量。
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public TaskTypeEnum TaskType { get; set; }
        /// <summary>
        /// 网络类型。取值： - eip：公网网络。 - vpc：VPC网络，灾备场景不支持选择VPC网络。 - vpn：VPN、专线网络。
        /// </summary>
        [JsonProperty("net_type", NullValueHandling = NullValueHandling.Ignore)]
        public NetTypeEnum NetType { get; set; }
        /// <summary>
        /// 计费模式，默认按需。取值： - period：包周期。 - on_demand：按需。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingModeEnum ChargingMode { get; set; }
        /// <summary>
        /// 企业项目ID。 缺省值：\&quot;0\&quot;，表示\&quot;default\&quot;企业项目。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 任务描述。 约束：任务描述不能超过256位，且不能包含!&lt;&gt;&amp;&#39;\&quot;\\特殊字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 任务定时启动时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务处于异常状态一段时间后，将会自动结束。单位为天。(范围14-100)，不传默认为14天。
        /// </summary>
        [JsonProperty("expired_days", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiredDays { get; set; }

        /// <summary>
        /// 标签信息，最多添加10个标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobBaseInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  multiWrite: ").Append(MultiWrite).Append("\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  jobDirection: ").Append(JobDirection).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  netType: ").Append(NetType).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  expiredDays: ").Append(ExpiredDays).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobBaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobBaseInfo input)
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
                    this.JobType == input.JobType ||
                    (this.JobType != null &&
                    this.JobType.Equals(input.JobType))
                ) && 
                (
                    this.MultiWrite == input.MultiWrite ||
                    (this.MultiWrite != null &&
                    this.MultiWrite.Equals(input.MultiWrite))
                ) && 
                (
                    this.EngineType == input.EngineType ||
                    (this.EngineType != null &&
                    this.EngineType.Equals(input.EngineType))
                ) && 
                (
                    this.JobDirection == input.JobDirection ||
                    (this.JobDirection != null &&
                    this.JobDirection.Equals(input.JobDirection))
                ) && 
                (
                    this.TaskType == input.TaskType ||
                    (this.TaskType != null &&
                    this.TaskType.Equals(input.TaskType))
                ) && 
                (
                    this.NetType == input.NetType ||
                    (this.NetType != null &&
                    this.NetType.Equals(input.NetType))
                ) && 
                (
                    this.ChargingMode == input.ChargingMode ||
                    (this.ChargingMode != null &&
                    this.ChargingMode.Equals(input.ChargingMode))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.ExpiredDays == input.ExpiredDays ||
                    (this.ExpiredDays != null &&
                    this.ExpiredDays.Equals(input.ExpiredDays))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.JobType != null)
                    hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.MultiWrite != null)
                    hashCode = hashCode * 59 + this.MultiWrite.GetHashCode();
                if (this.EngineType != null)
                    hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                if (this.JobDirection != null)
                    hashCode = hashCode * 59 + this.JobDirection.GetHashCode();
                if (this.TaskType != null)
                    hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.NetType != null)
                    hashCode = hashCode * 59 + this.NetType.GetHashCode();
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.ExpiredDays != null)
                    hashCode = hashCode * 59 + this.ExpiredDays.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
