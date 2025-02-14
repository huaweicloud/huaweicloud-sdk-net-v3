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
    /// 修改任务描述信息、名称，设置异常通知信息、限速等。
    /// </summary>
    public class ModifyJobReq 
    {
        /// <summary>
        /// 任务模式，FULL_TRANS：全量；FULL_INCR_TRANS：全量+增量；INCR_TRANS：增量。
        /// </summary>
        /// <value>任务模式，FULL_TRANS：全量；FULL_INCR_TRANS：全量+增量；INCR_TRANS：增量。</value>
        [JsonConverter(typeof(EnumClassConverter<TaskTypeEnum>))]
        public class TaskTypeEnum
        {
            /// <summary>
            /// Enum FULL_TRANS for value: FULL_TRANS
            /// </summary>
            public static readonly TaskTypeEnum FULL_TRANS = new TaskTypeEnum("FULL_TRANS");

            /// <summary>
            /// Enum INCR_TRANS for value: INCR_TRANS
            /// </summary>
            public static readonly TaskTypeEnum INCR_TRANS = new TaskTypeEnum("INCR_TRANS");

            /// <summary>
            /// Enum FULL_INCR_TRANS for value: FULL_INCR_TRANS
            /// </summary>
            public static readonly TaskTypeEnum FULL_INCR_TRANS = new TaskTypeEnum("FULL_INCR_TRANS");

            private static readonly Dictionary<string, TaskTypeEnum> StaticFields =
            new Dictionary<string, TaskTypeEnum>()
            {
                { "FULL_TRANS", FULL_TRANS },
                { "INCR_TRANS", INCR_TRANS },
                { "FULL_INCR_TRANS", FULL_INCR_TRANS },
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
        /// node规格类型，测试连接之后修改调用时必填。取值： - micro：极小规格。 - small：小规格。 - medium：中规格。 - high：大规格。 - xlarge：超大规格。 - 2xlarge：极大规格。
        /// </summary>
        /// <value>node规格类型，测试连接之后修改调用时必填。取值： - micro：极小规格。 - small：小规格。 - medium：中规格。 - high：大规格。 - xlarge：超大规格。 - 2xlarge：极大规格。</value>
        [JsonConverter(typeof(EnumClassConverter<NodeTypeEnum>))]
        public class NodeTypeEnum
        {
            /// <summary>
            /// Enum MICRO for value: micro
            /// </summary>
            public static readonly NodeTypeEnum MICRO = new NodeTypeEnum("micro");

            /// <summary>
            /// Enum SMALL for value: small
            /// </summary>
            public static readonly NodeTypeEnum SMALL = new NodeTypeEnum("small");

            /// <summary>
            /// Enum MEDIUM for value: medium
            /// </summary>
            public static readonly NodeTypeEnum MEDIUM = new NodeTypeEnum("medium");

            /// <summary>
            /// Enum HIGH for value: high
            /// </summary>
            public static readonly NodeTypeEnum HIGH = new NodeTypeEnum("high");

            /// <summary>
            /// Enum XLARGE for value: xlarge
            /// </summary>
            public static readonly NodeTypeEnum XLARGE = new NodeTypeEnum("xlarge");

            /// <summary>
            /// Enum _2XLARGE for value: 2xlarge
            /// </summary>
            public static readonly NodeTypeEnum _2XLARGE = new NodeTypeEnum("2xlarge");

            private static readonly Dictionary<string, NodeTypeEnum> StaticFields =
            new Dictionary<string, NodeTypeEnum>()
            {
                { "micro", MICRO },
                { "small", SMALL },
                { "medium", MEDIUM },
                { "high", HIGH },
                { "xlarge", XLARGE },
                { "2xlarge", _2XLARGE },
            };

            private string _value;

            public NodeTypeEnum()
            {

            }

            public NodeTypeEnum(string value)
            {
                _value = value;
            }

            public static NodeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NodeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NodeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NodeTypeEnum a, NodeTypeEnum b)
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

            public static bool operator !=(NodeTypeEnum a, NodeTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 引擎类型，测试连接之后修改调用时必填。mysql：迁移，同步使用。mongodb：迁移使用。cloudDataGuard-mysql：灾备使用
        /// </summary>
        /// <value>引擎类型，测试连接之后修改调用时必填。mysql：迁移，同步使用。mongodb：迁移使用。cloudDataGuard-mysql：灾备使用</value>
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
        /// 网络类型，测试连接之后修改调用时必填。
        /// </summary>
        /// <value>网络类型，测试连接之后修改调用时必填。</value>
        [JsonConverter(typeof(EnumClassConverter<NetTypeEnum>))]
        public class NetTypeEnum
        {
            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly NetTypeEnum VPC = new NetTypeEnum("vpc");

            /// <summary>
            /// Enum VPN for value: vpn
            /// </summary>
            public static readonly NetTypeEnum VPN = new NetTypeEnum("vpn");

            /// <summary>
            /// Enum EIP for value: eip
            /// </summary>
            public static readonly NetTypeEnum EIP = new NetTypeEnum("eip");

            private static readonly Dictionary<string, NetTypeEnum> StaticFields =
            new Dictionary<string, NetTypeEnum>()
            {
                { "vpc", VPC },
                { "vpn", VPN },
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
        /// 迁移方向,up 入云 灾备场景时对应本云为备,down 出云 灾备场景时对应本云为主,non-dbs 自建
        /// </summary>
        /// <value>迁移方向,up 入云 灾备场景时对应本云为备,down 出云 灾备场景时对应本云为主,non-dbs 自建</value>
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
        /// 迁移类型，migration-实时迁移,sync-实时同步,cloudDataGuard-实时灾备
        /// </summary>
        /// <value>迁移类型，migration-实时迁移,sync-实时同步,cloudDataGuard-实时灾备</value>
        [JsonConverter(typeof(EnumClassConverter<DbUseTypeEnum>))]
        public class DbUseTypeEnum
        {
            /// <summary>
            /// Enum MIGRATION for value: migration
            /// </summary>
            public static readonly DbUseTypeEnum MIGRATION = new DbUseTypeEnum("migration");

            /// <summary>
            /// Enum SYNC for value: sync
            /// </summary>
            public static readonly DbUseTypeEnum SYNC = new DbUseTypeEnum("sync");

            /// <summary>
            /// Enum CLOUDDATAGUARD for value: cloudDataGuard
            /// </summary>
            public static readonly DbUseTypeEnum CLOUDDATAGUARD = new DbUseTypeEnum("cloudDataGuard");

            private static readonly Dictionary<string, DbUseTypeEnum> StaticFields =
            new Dictionary<string, DbUseTypeEnum>()
            {
                { "migration", MIGRATION },
                { "sync", SYNC },
                { "cloudDataGuard", CLOUDDATAGUARD },
            };

            private string _value;

            public DbUseTypeEnum()
            {

            }

            public DbUseTypeEnum(string value)
            {
                _value = value;
            }

            public static DbUseTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DbUseTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DbUseTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DbUseTypeEnum a, DbUseTypeEnum b)
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

            public static bool operator !=(DbUseTypeEnum a, DbUseTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 任务描述，修改任务描述时必填。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 任务名称，修改任务名称时必填
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alarm_notify", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmNotifyInfo AlarmNotify { get; set; }

        /// <summary>
        /// 任务模式，FULL_TRANS：全量；FULL_INCR_TRANS：全量+增量；INCR_TRANS：增量。
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public TaskTypeEnum TaskType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Endpoint SourceEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Endpoint TargetEndpoint { get; set; }

        /// <summary>
        /// node规格类型，测试连接之后修改调用时必填。取值： - micro：极小规格。 - small：小规格。 - medium：中规格。 - high：大规格。 - xlarge：超大规格。 - 2xlarge：极大规格。
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTypeEnum NodeType { get; set; }
        /// <summary>
        /// 引擎类型，测试连接之后修改调用时必填。mysql：迁移，同步使用。mongodb：迁移使用。cloudDataGuard-mysql：灾备使用
        /// </summary>
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public EngineTypeEnum EngineType { get; set; }
        /// <summary>
        /// 网络类型，测试连接之后修改调用时必填。
        /// </summary>
        [JsonProperty("net_type", NullValueHandling = NullValueHandling.Ignore)]
        public NetTypeEnum NetType { get; set; }
        /// <summary>
        /// 保存数据库信息，测试连接之后修改调用时必填为true。
        /// </summary>
        [JsonProperty("store_db_info", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoreDbInfo { get; set; }

        /// <summary>
        /// 是否为重建任务。
        /// </summary>
        [JsonProperty("is_recreate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRecreate { get; set; }

        /// <summary>
        /// 迁移方向,up 入云 灾备场景时对应本云为备,down 出云 灾备场景时对应本云为主,non-dbs 自建
        /// </summary>
        [JsonProperty("job_direction", NullValueHandling = NullValueHandling.Ignore)]
        public JobDirectionEnum JobDirection { get; set; }
        /// <summary>
        /// 目标实例是否限制为只读。
        /// </summary>
        [JsonProperty("is_target_readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTargetReadonly { get; set; }

        /// <summary>
        /// 所有Definer是否迁移到该用户下，MySQL数据库支持该设置，测试连接之后修改调用时必填。 - true：迁移后，所有源数据库对象的Definer都会迁移至该用户下，其他用户需要授权后才具有数据库对象权限 - false：迁移后，将保持源数据库对象Definer定义不变，选择此选项，需要配合下一步用户权限迁移功能，将源数据库的用户全部迁移，这样才能保持源数据库的权限体系完全不变。
        /// </summary>
        [JsonProperty("replace_definer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReplaceDefiner { get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> Tags { get; set; }

        /// <summary>
        /// 迁移类型，migration-实时迁移,sync-实时同步,cloudDataGuard-实时灾备
        /// </summary>
        [JsonProperty("db_use_type", NullValueHandling = NullValueHandling.Ignore)]
        public DbUseTypeEnum DbUseType { get; set; }
        /// <summary>
        /// 产品ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyJobReq {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  alarmNotify: ").Append(AlarmNotify).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  sourceEndpoint: ").Append(SourceEndpoint).Append("\n");
            sb.Append("  targetEndpoint: ").Append(TargetEndpoint).Append("\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  netType: ").Append(NetType).Append("\n");
            sb.Append("  storeDbInfo: ").Append(StoreDbInfo).Append("\n");
            sb.Append("  isRecreate: ").Append(IsRecreate).Append("\n");
            sb.Append("  jobDirection: ").Append(JobDirection).Append("\n");
            sb.Append("  isTargetReadonly: ").Append(IsTargetReadonly).Append("\n");
            sb.Append("  replaceDefiner: ").Append(ReplaceDefiner).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  dbUseType: ").Append(DbUseType).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyJobReq input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AlarmNotify != input.AlarmNotify || (this.AlarmNotify != null && !this.AlarmNotify.Equals(input.AlarmNotify))) return false;
            if (this.TaskType != input.TaskType) return false;
            if (this.SourceEndpoint != input.SourceEndpoint || (this.SourceEndpoint != null && !this.SourceEndpoint.Equals(input.SourceEndpoint))) return false;
            if (this.TargetEndpoint != input.TargetEndpoint || (this.TargetEndpoint != null && !this.TargetEndpoint.Equals(input.TargetEndpoint))) return false;
            if (this.NodeType != input.NodeType) return false;
            if (this.EngineType != input.EngineType) return false;
            if (this.NetType != input.NetType) return false;
            if (this.StoreDbInfo != input.StoreDbInfo || (this.StoreDbInfo != null && !this.StoreDbInfo.Equals(input.StoreDbInfo))) return false;
            if (this.IsRecreate != input.IsRecreate || (this.IsRecreate != null && !this.IsRecreate.Equals(input.IsRecreate))) return false;
            if (this.JobDirection != input.JobDirection) return false;
            if (this.IsTargetReadonly != input.IsTargetReadonly || (this.IsTargetReadonly != null && !this.IsTargetReadonly.Equals(input.IsTargetReadonly))) return false;
            if (this.ReplaceDefiner != input.ReplaceDefiner || (this.ReplaceDefiner != null && !this.ReplaceDefiner.Equals(input.ReplaceDefiner))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.DbUseType != input.DbUseType) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AlarmNotify != null) hashCode = hashCode * 59 + this.AlarmNotify.GetHashCode();
                hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.SourceEndpoint != null) hashCode = hashCode * 59 + this.SourceEndpoint.GetHashCode();
                if (this.TargetEndpoint != null) hashCode = hashCode * 59 + this.TargetEndpoint.GetHashCode();
                hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                hashCode = hashCode * 59 + this.NetType.GetHashCode();
                if (this.StoreDbInfo != null) hashCode = hashCode * 59 + this.StoreDbInfo.GetHashCode();
                if (this.IsRecreate != null) hashCode = hashCode * 59 + this.IsRecreate.GetHashCode();
                hashCode = hashCode * 59 + this.JobDirection.GetHashCode();
                if (this.IsTargetReadonly != null) hashCode = hashCode * 59 + this.IsTargetReadonly.GetHashCode();
                if (this.ReplaceDefiner != null) hashCode = hashCode * 59 + this.ReplaceDefiner.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.DbUseType.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                return hashCode;
            }
        }
    }
}
