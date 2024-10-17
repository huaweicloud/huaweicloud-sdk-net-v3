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
    /// 任务详情响应体。
    /// </summary>
    public class JobDetailResp 
    {
        /// <summary>
        /// 任务状态。 - CREATING：创建中 - CREATE_FAILED：创建失败 - CONFIGURATION：配置中 - STARTJOBING：启动中 - WAITING_FOR_START：等待启动中 - START_JOB_FAILED：启动失败 - PAUSING：已暂停 - FULL_TRANSFER_STARTED：全量开始，灾备场景下为初始化 - FULL_TRANSFER_FAILED：全量失败，灾备场景下为初始化失败 - FULL_TRANSFER_COMPLETE：全量完成，灾备场景下为初始化完成 - INCRE_TRANSFER_STARTED：增量开始，灾备场景下为灾备中 - INCRE_TRANSFER_FAILED：增量失败，灾备场景下为灾备异常 - RELEASE_RESOURCE_STARTED：结束任务中 - RELEASE_RESOURCE_FAILED：结束任务失败 - RELEASE_RESOURCE_COMPLETE：已结束 - REBUILD_NODE_STARTED：故障恢复中 - REBUILD_NODE_FAILED：故障恢复失败 - CHANGE_JOB_STARTED：任务变更中 - CHANGE_JOB_FAILED：任务变更失败 - DELETED：已删除 - CHILD_TRANSFER_STARTING：再编辑子任务启动中 - CHILD_TRANSFER_STARTED：再编辑子任务迁移中 - CHILD_TRANSFER_COMPLETE：再编辑子任务迁移完成 - CHILD_TRANSFER_FAILED：再编辑子任务迁移失败 - RELEASE_CHILD_TRANSFER_STARTED：再编辑子任务结束中 - RELEASE_CHILD_TRANSFER_COMPLETE：再编辑子任务已结束 - NODE_UPGRADE_START：升级开始 - NODE_UPGRADE_COMPLETE：升级完成 - NODE_UPGRADE_FAILED：升级失败
        /// </summary>
        /// <value>任务状态。 - CREATING：创建中 - CREATE_FAILED：创建失败 - CONFIGURATION：配置中 - STARTJOBING：启动中 - WAITING_FOR_START：等待启动中 - START_JOB_FAILED：启动失败 - PAUSING：已暂停 - FULL_TRANSFER_STARTED：全量开始，灾备场景下为初始化 - FULL_TRANSFER_FAILED：全量失败，灾备场景下为初始化失败 - FULL_TRANSFER_COMPLETE：全量完成，灾备场景下为初始化完成 - INCRE_TRANSFER_STARTED：增量开始，灾备场景下为灾备中 - INCRE_TRANSFER_FAILED：增量失败，灾备场景下为灾备异常 - RELEASE_RESOURCE_STARTED：结束任务中 - RELEASE_RESOURCE_FAILED：结束任务失败 - RELEASE_RESOURCE_COMPLETE：已结束 - REBUILD_NODE_STARTED：故障恢复中 - REBUILD_NODE_FAILED：故障恢复失败 - CHANGE_JOB_STARTED：任务变更中 - CHANGE_JOB_FAILED：任务变更失败 - DELETED：已删除 - CHILD_TRANSFER_STARTING：再编辑子任务启动中 - CHILD_TRANSFER_STARTED：再编辑子任务迁移中 - CHILD_TRANSFER_COMPLETE：再编辑子任务迁移完成 - CHILD_TRANSFER_FAILED：再编辑子任务迁移失败 - RELEASE_CHILD_TRANSFER_STARTED：再编辑子任务结束中 - RELEASE_CHILD_TRANSFER_COMPLETE：再编辑子任务已结束 - NODE_UPGRADE_START：升级开始 - NODE_UPGRADE_COMPLETE：升级完成 - NODE_UPGRADE_FAILED：升级失败</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("CREATING");

            /// <summary>
            /// Enum CREATE_FAILED for value: CREATE_FAILED
            /// </summary>
            public static readonly StatusEnum CREATE_FAILED = new StatusEnum("CREATE_FAILED");

            /// <summary>
            /// Enum CONFIGURATION for value: CONFIGURATION
            /// </summary>
            public static readonly StatusEnum CONFIGURATION = new StatusEnum("CONFIGURATION");

            /// <summary>
            /// Enum STARTJOBING for value: STARTJOBING
            /// </summary>
            public static readonly StatusEnum STARTJOBING = new StatusEnum("STARTJOBING");

            /// <summary>
            /// Enum WAITING_FOR_START for value: WAITING_FOR_START
            /// </summary>
            public static readonly StatusEnum WAITING_FOR_START = new StatusEnum("WAITING_FOR_START");

            /// <summary>
            /// Enum START_JOB_FAILED for value: START_JOB_FAILED
            /// </summary>
            public static readonly StatusEnum START_JOB_FAILED = new StatusEnum("START_JOB_FAILED");

            /// <summary>
            /// Enum PAUSING for value: PAUSING
            /// </summary>
            public static readonly StatusEnum PAUSING = new StatusEnum("PAUSING");

            /// <summary>
            /// Enum FULL_TRANSFER_STARTED for value: FULL_TRANSFER_STARTED
            /// </summary>
            public static readonly StatusEnum FULL_TRANSFER_STARTED = new StatusEnum("FULL_TRANSFER_STARTED");

            /// <summary>
            /// Enum FULL_TRANSFER_FAILED for value: FULL_TRANSFER_FAILED
            /// </summary>
            public static readonly StatusEnum FULL_TRANSFER_FAILED = new StatusEnum("FULL_TRANSFER_FAILED");

            /// <summary>
            /// Enum FULL_TRANSFER_COMPLETE for value: FULL_TRANSFER_COMPLETE
            /// </summary>
            public static readonly StatusEnum FULL_TRANSFER_COMPLETE = new StatusEnum("FULL_TRANSFER_COMPLETE");

            /// <summary>
            /// Enum INCRE_TRANSFER_STARTED for value: INCRE_TRANSFER_STARTED
            /// </summary>
            public static readonly StatusEnum INCRE_TRANSFER_STARTED = new StatusEnum("INCRE_TRANSFER_STARTED");

            /// <summary>
            /// Enum INCRE_TRANSFER_FAILED for value: INCRE_TRANSFER_FAILED
            /// </summary>
            public static readonly StatusEnum INCRE_TRANSFER_FAILED = new StatusEnum("INCRE_TRANSFER_FAILED");

            /// <summary>
            /// Enum RELEASE_RESOURCE_STARTED for value: RELEASE_RESOURCE_STARTED
            /// </summary>
            public static readonly StatusEnum RELEASE_RESOURCE_STARTED = new StatusEnum("RELEASE_RESOURCE_STARTED");

            /// <summary>
            /// Enum RELEASE_RESOURCE_FAILED for value: RELEASE_RESOURCE_FAILED
            /// </summary>
            public static readonly StatusEnum RELEASE_RESOURCE_FAILED = new StatusEnum("RELEASE_RESOURCE_FAILED");

            /// <summary>
            /// Enum RELEASE_RESOURCE_COMPLETE for value: RELEASE_RESOURCE_COMPLETE
            /// </summary>
            public static readonly StatusEnum RELEASE_RESOURCE_COMPLETE = new StatusEnum("RELEASE_RESOURCE_COMPLETE");

            /// <summary>
            /// Enum REBUILD_NODE_STARTED for value: REBUILD_NODE_STARTED
            /// </summary>
            public static readonly StatusEnum REBUILD_NODE_STARTED = new StatusEnum("REBUILD_NODE_STARTED");

            /// <summary>
            /// Enum REBUILD_NODE_FAILED for value: REBUILD_NODE_FAILED
            /// </summary>
            public static readonly StatusEnum REBUILD_NODE_FAILED = new StatusEnum("REBUILD_NODE_FAILED");

            /// <summary>
            /// Enum CHANGE_JOB_STARTED for value: CHANGE_JOB_STARTED
            /// </summary>
            public static readonly StatusEnum CHANGE_JOB_STARTED = new StatusEnum("CHANGE_JOB_STARTED");

            /// <summary>
            /// Enum CHANGE_JOB_FAILED for value: CHANGE_JOB_FAILED
            /// </summary>
            public static readonly StatusEnum CHANGE_JOB_FAILED = new StatusEnum("CHANGE_JOB_FAILED");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            /// <summary>
            /// Enum CHILD_TRANSFER_STARTING for value: CHILD_TRANSFER_STARTING
            /// </summary>
            public static readonly StatusEnum CHILD_TRANSFER_STARTING = new StatusEnum("CHILD_TRANSFER_STARTING");

            /// <summary>
            /// Enum CHILD_TRANSFER_STARTED for value: CHILD_TRANSFER_STARTED
            /// </summary>
            public static readonly StatusEnum CHILD_TRANSFER_STARTED = new StatusEnum("CHILD_TRANSFER_STARTED");

            /// <summary>
            /// Enum CHILD_TRANSFER_COMPLETE for value: CHILD_TRANSFER_COMPLETE
            /// </summary>
            public static readonly StatusEnum CHILD_TRANSFER_COMPLETE = new StatusEnum("CHILD_TRANSFER_COMPLETE");

            /// <summary>
            /// Enum CHILD_TRANSFER_FAILED for value: CHILD_TRANSFER_FAILED
            /// </summary>
            public static readonly StatusEnum CHILD_TRANSFER_FAILED = new StatusEnum("CHILD_TRANSFER_FAILED");

            /// <summary>
            /// Enum RELEASE_CHILD_TRANSFER_STARTED for value: RELEASE_CHILD_TRANSFER_STARTED
            /// </summary>
            public static readonly StatusEnum RELEASE_CHILD_TRANSFER_STARTED = new StatusEnum("RELEASE_CHILD_TRANSFER_STARTED");

            /// <summary>
            /// Enum RELEASE_CHILD_TRANSFER_COMPLETE for value: RELEASE_CHILD_TRANSFER_COMPLETE
            /// </summary>
            public static readonly StatusEnum RELEASE_CHILD_TRANSFER_COMPLETE = new StatusEnum("RELEASE_CHILD_TRANSFER_COMPLETE");

            /// <summary>
            /// Enum NODE_UPGRADE_START for value: NODE_UPGRADE_START
            /// </summary>
            public static readonly StatusEnum NODE_UPGRADE_START = new StatusEnum("NODE_UPGRADE_START");

            /// <summary>
            /// Enum NODE_UPGRADE_COMPLETE for value: NODE_UPGRADE_COMPLETE
            /// </summary>
            public static readonly StatusEnum NODE_UPGRADE_COMPLETE = new StatusEnum("NODE_UPGRADE_COMPLETE");

            /// <summary>
            /// Enum NODE_UPGRADE_FAILED for value: NODE_UPGRADE_FAILED
            /// </summary>
            public static readonly StatusEnum NODE_UPGRADE_FAILED = new StatusEnum("NODE_UPGRADE_FAILED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATING", CREATING },
                { "CREATE_FAILED", CREATE_FAILED },
                { "CONFIGURATION", CONFIGURATION },
                { "STARTJOBING", STARTJOBING },
                { "WAITING_FOR_START", WAITING_FOR_START },
                { "START_JOB_FAILED", START_JOB_FAILED },
                { "PAUSING", PAUSING },
                { "FULL_TRANSFER_STARTED", FULL_TRANSFER_STARTED },
                { "FULL_TRANSFER_FAILED", FULL_TRANSFER_FAILED },
                { "FULL_TRANSFER_COMPLETE", FULL_TRANSFER_COMPLETE },
                { "INCRE_TRANSFER_STARTED", INCRE_TRANSFER_STARTED },
                { "INCRE_TRANSFER_FAILED", INCRE_TRANSFER_FAILED },
                { "RELEASE_RESOURCE_STARTED", RELEASE_RESOURCE_STARTED },
                { "RELEASE_RESOURCE_FAILED", RELEASE_RESOURCE_FAILED },
                { "RELEASE_RESOURCE_COMPLETE", RELEASE_RESOURCE_COMPLETE },
                { "REBUILD_NODE_STARTED", REBUILD_NODE_STARTED },
                { "REBUILD_NODE_FAILED", REBUILD_NODE_FAILED },
                { "CHANGE_JOB_STARTED", CHANGE_JOB_STARTED },
                { "CHANGE_JOB_FAILED", CHANGE_JOB_FAILED },
                { "DELETED", DELETED },
                { "CHILD_TRANSFER_STARTING", CHILD_TRANSFER_STARTING },
                { "CHILD_TRANSFER_STARTED", CHILD_TRANSFER_STARTED },
                { "CHILD_TRANSFER_COMPLETE", CHILD_TRANSFER_COMPLETE },
                { "CHILD_TRANSFER_FAILED", CHILD_TRANSFER_FAILED },
                { "RELEASE_CHILD_TRANSFER_STARTED", RELEASE_CHILD_TRANSFER_STARTED },
                { "RELEASE_CHILD_TRANSFER_COMPLETE", RELEASE_CHILD_TRANSFER_COMPLETE },
                { "NODE_UPGRADE_START", NODE_UPGRADE_START },
                { "NODE_UPGRADE_COMPLETE", NODE_UPGRADE_COMPLETE },
                { "NODE_UPGRADE_FAILED", NODE_UPGRADE_FAILED },
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
        /// 解除目标库只读操作后，目标库解除只读是否成功。 - pending：目标库解除操作进行中。 - success：目标库解除只读操作成功。
        /// </summary>
        /// <value>解除目标库只读操作后，目标库解除只读是否成功。 - pending：目标库解除操作进行中。 - success：目标库解除只读操作成功。</value>
        [JsonConverter(typeof(EnumClassConverter<IsWritableEnum>))]
        public class IsWritableEnum
        {
            /// <summary>
            /// Enum PENDING for value: pending
            /// </summary>
            public static readonly IsWritableEnum PENDING = new IsWritableEnum("pending");

            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly IsWritableEnum SUCCESS = new IsWritableEnum("success");

            private static readonly Dictionary<string, IsWritableEnum> StaticFields =
            new Dictionary<string, IsWritableEnum>()
            {
                { "pending", PENDING },
                { "success", SUCCESS },
            };

            private string _value;

            public IsWritableEnum()
            {

            }

            public IsWritableEnum(string value)
            {
                _value = value;
            }

            public static IsWritableEnum FromValue(string value)
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

                if (this.Equals(obj as IsWritableEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IsWritableEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IsWritableEnum a, IsWritableEnum b)
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

            public static bool operator !=(IsWritableEnum a, IsWritableEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务状态。 - CREATING：创建中 - CREATE_FAILED：创建失败 - CONFIGURATION：配置中 - STARTJOBING：启动中 - WAITING_FOR_START：等待启动中 - START_JOB_FAILED：启动失败 - PAUSING：已暂停 - FULL_TRANSFER_STARTED：全量开始，灾备场景下为初始化 - FULL_TRANSFER_FAILED：全量失败，灾备场景下为初始化失败 - FULL_TRANSFER_COMPLETE：全量完成，灾备场景下为初始化完成 - INCRE_TRANSFER_STARTED：增量开始，灾备场景下为灾备中 - INCRE_TRANSFER_FAILED：增量失败，灾备场景下为灾备异常 - RELEASE_RESOURCE_STARTED：结束任务中 - RELEASE_RESOURCE_FAILED：结束任务失败 - RELEASE_RESOURCE_COMPLETE：已结束 - REBUILD_NODE_STARTED：故障恢复中 - REBUILD_NODE_FAILED：故障恢复失败 - CHANGE_JOB_STARTED：任务变更中 - CHANGE_JOB_FAILED：任务变更失败 - DELETED：已删除 - CHILD_TRANSFER_STARTING：再编辑子任务启动中 - CHILD_TRANSFER_STARTED：再编辑子任务迁移中 - CHILD_TRANSFER_COMPLETE：再编辑子任务迁移完成 - CHILD_TRANSFER_FAILED：再编辑子任务迁移失败 - RELEASE_CHILD_TRANSFER_STARTED：再编辑子任务结束中 - RELEASE_CHILD_TRANSFER_COMPLETE：再编辑子任务已结束 - NODE_UPGRADE_START：升级开始 - NODE_UPGRADE_COMPLETE：升级完成 - NODE_UPGRADE_FAILED：升级失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 列表中的项目总数，与分页无关。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 多任务主节点的任务ID。
        /// </summary>
        [JsonProperty("master_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterJobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("base_info", NullValueHandling = NullValueHandling.Ignore)]
        public JobBaseInfo BaseInfo { get; set; }

        /// <summary>
        /// 任务源数据库信息体。
        /// </summary>
        [JsonProperty("source_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobEndpointInfo> SourceEndpoint { get; set; }

        /// <summary>
        /// 任务目标数据库信息体。
        /// </summary>
        [JsonProperty("target_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobEndpointInfo> TargetEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alarm_notify", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmNotifyConfig AlarmNotify { get; set; }

        /// <summary>
        /// 限速信息体。 - 限速：自定义的最大迁移速度，迁移过程中的迁移速度将不会超过该速度。  - 不限速：对迁移速度不进行限制，通常会最大化使用源数据库的出口带宽。该流速模式同时会对源数据库造成读消耗，消耗取决于源数据库的出口带宽。比如：源数据库的出口带宽为100MB/s，假设高速模式使用了80%带宽，则迁移对源数据库将造成80MB/s的读操作IO消耗。
        /// </summary>
        [JsonProperty("speed_limit", NullValueHandling = NullValueHandling.Ignore)]
        public List<SpeedLimitInfo> SpeedLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_migration", NullValueHandling = NullValueHandling.Ignore)]
        public UserMigrationInfo UserMigration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_config", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyConfig PolicyConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("db_param", NullValueHandling = NullValueHandling.Ignore)]
        public DbParamInfo DbParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tuning_params", NullValueHandling = NullValueHandling.Ignore)]
        public TuningParamInfo TuningParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("period_order", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodOrderInfo PeriodOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("node_info", NullValueHandling = NullValueHandling.Ignore)]
        public JobNodeInfo NodeInfo { get; set; }

        /// <summary>
        /// 日志查询结果信息体。
        /// </summary>
        [JsonProperty("logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskLogInfo> Logs { get; set; }

        /// <summary>
        /// 网络打通测试结果信息体。
        /// </summary>
        [JsonProperty("network_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryNetworkResult> NetworkResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("precheck_result", NullValueHandling = NullValueHandling.Ignore)]
        public QueryPreCheckResult PrecheckResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("progress_info", NullValueHandling = NullValueHandling.Ignore)]
        public JobProgressInfo ProgressInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("migration_object_progress_info", NullValueHandling = NullValueHandling.Ignore)]
        public QueryMigrationObjectProgressInfo MigrationObjectProgressInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public QueryMetricResult Metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public CompareResultInfo CompareResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("support_import_file_resp", NullValueHandling = NullValueHandling.Ignore)]
        public SupportImportFileResult SupportImportFileResp { get; set; }

        /// <summary>
        /// 由开关和版本共同控制的任务级别的功能列表。
        /// </summary>
        [JsonProperty("instance_features", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> InstanceFeatures { get; set; }

        /// <summary>
        /// 任务版本。
        /// </summary>
        [JsonProperty("task_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("connection_management", NullValueHandling = NullValueHandling.Ignore)]
        public ConnectionManagement ConnectionManagement { get; set; }

        /// <summary>
        /// 指定公网IP的信息
        /// </summary>
        [JsonProperty("public_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicIpConfig> PublicIpList { get; set; }

        /// <summary>
        /// 是否成功绑定公网IP
        /// </summary>
        [JsonProperty("bind_public_ip_state", NullValueHandling = NullValueHandling.Ignore)]
        public string BindPublicIpState { get; set; }

        /// <summary>
        /// 多任务时，存在子任务绑定失败时，返回子任务的信息
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<FailedToBindEipChildInfo> Children { get; set; }

        /// <summary>
        /// 解除目标库只读操作后，目标库解除只读是否成功。 - pending：目标库解除操作进行中。 - success：目标库解除只读操作成功。
        /// </summary>
        [JsonProperty("is_writable", NullValueHandling = NullValueHandling.Ignore)]
        public IsWritableEnum IsWritable { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobDetailResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  masterJobId: ").Append(MasterJobId).Append("\n");
            sb.Append("  baseInfo: ").Append(BaseInfo).Append("\n");
            sb.Append("  sourceEndpoint: ").Append(SourceEndpoint).Append("\n");
            sb.Append("  targetEndpoint: ").Append(TargetEndpoint).Append("\n");
            sb.Append("  alarmNotify: ").Append(AlarmNotify).Append("\n");
            sb.Append("  speedLimit: ").Append(SpeedLimit).Append("\n");
            sb.Append("  userMigration: ").Append(UserMigration).Append("\n");
            sb.Append("  policyConfig: ").Append(PolicyConfig).Append("\n");
            sb.Append("  dbParam: ").Append(DbParam).Append("\n");
            sb.Append("  tuningParams: ").Append(TuningParams).Append("\n");
            sb.Append("  periodOrder: ").Append(PeriodOrder).Append("\n");
            sb.Append("  nodeInfo: ").Append(NodeInfo).Append("\n");
            sb.Append("  logs: ").Append(Logs).Append("\n");
            sb.Append("  networkResults: ").Append(NetworkResults).Append("\n");
            sb.Append("  precheckResult: ").Append(PrecheckResult).Append("\n");
            sb.Append("  progressInfo: ").Append(ProgressInfo).Append("\n");
            sb.Append("  migrationObjectProgressInfo: ").Append(MigrationObjectProgressInfo).Append("\n");
            sb.Append("  metrics: ").Append(Metrics).Append("\n");
            sb.Append("  compareResult: ").Append(CompareResult).Append("\n");
            sb.Append("  supportImportFileResp: ").Append(SupportImportFileResp).Append("\n");
            sb.Append("  instanceFeatures: ").Append(InstanceFeatures).Append("\n");
            sb.Append("  taskVersion: ").Append(TaskVersion).Append("\n");
            sb.Append("  connectionManagement: ").Append(ConnectionManagement).Append("\n");
            sb.Append("  publicIpList: ").Append(PublicIpList).Append("\n");
            sb.Append("  bindPublicIpState: ").Append(BindPublicIpState).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("  isWritable: ").Append(IsWritable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobDetailResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobDetailResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.MasterJobId != input.MasterJobId || (this.MasterJobId != null && !this.MasterJobId.Equals(input.MasterJobId))) return false;
            if (this.BaseInfo != input.BaseInfo || (this.BaseInfo != null && !this.BaseInfo.Equals(input.BaseInfo))) return false;
            if (this.SourceEndpoint != input.SourceEndpoint || (this.SourceEndpoint != null && input.SourceEndpoint != null && !this.SourceEndpoint.SequenceEqual(input.SourceEndpoint))) return false;
            if (this.TargetEndpoint != input.TargetEndpoint || (this.TargetEndpoint != null && input.TargetEndpoint != null && !this.TargetEndpoint.SequenceEqual(input.TargetEndpoint))) return false;
            if (this.AlarmNotify != input.AlarmNotify || (this.AlarmNotify != null && !this.AlarmNotify.Equals(input.AlarmNotify))) return false;
            if (this.SpeedLimit != input.SpeedLimit || (this.SpeedLimit != null && input.SpeedLimit != null && !this.SpeedLimit.SequenceEqual(input.SpeedLimit))) return false;
            if (this.UserMigration != input.UserMigration || (this.UserMigration != null && !this.UserMigration.Equals(input.UserMigration))) return false;
            if (this.PolicyConfig != input.PolicyConfig || (this.PolicyConfig != null && !this.PolicyConfig.Equals(input.PolicyConfig))) return false;
            if (this.DbParam != input.DbParam || (this.DbParam != null && !this.DbParam.Equals(input.DbParam))) return false;
            if (this.TuningParams != input.TuningParams || (this.TuningParams != null && !this.TuningParams.Equals(input.TuningParams))) return false;
            if (this.PeriodOrder != input.PeriodOrder || (this.PeriodOrder != null && !this.PeriodOrder.Equals(input.PeriodOrder))) return false;
            if (this.NodeInfo != input.NodeInfo || (this.NodeInfo != null && !this.NodeInfo.Equals(input.NodeInfo))) return false;
            if (this.Logs != input.Logs || (this.Logs != null && input.Logs != null && !this.Logs.SequenceEqual(input.Logs))) return false;
            if (this.NetworkResults != input.NetworkResults || (this.NetworkResults != null && input.NetworkResults != null && !this.NetworkResults.SequenceEqual(input.NetworkResults))) return false;
            if (this.PrecheckResult != input.PrecheckResult || (this.PrecheckResult != null && !this.PrecheckResult.Equals(input.PrecheckResult))) return false;
            if (this.ProgressInfo != input.ProgressInfo || (this.ProgressInfo != null && !this.ProgressInfo.Equals(input.ProgressInfo))) return false;
            if (this.MigrationObjectProgressInfo != input.MigrationObjectProgressInfo || (this.MigrationObjectProgressInfo != null && !this.MigrationObjectProgressInfo.Equals(input.MigrationObjectProgressInfo))) return false;
            if (this.Metrics != input.Metrics || (this.Metrics != null && !this.Metrics.Equals(input.Metrics))) return false;
            if (this.CompareResult != input.CompareResult || (this.CompareResult != null && !this.CompareResult.Equals(input.CompareResult))) return false;
            if (this.SupportImportFileResp != input.SupportImportFileResp || (this.SupportImportFileResp != null && !this.SupportImportFileResp.Equals(input.SupportImportFileResp))) return false;
            if (this.InstanceFeatures != input.InstanceFeatures || (this.InstanceFeatures != null && input.InstanceFeatures != null && !this.InstanceFeatures.SequenceEqual(input.InstanceFeatures))) return false;
            if (this.TaskVersion != input.TaskVersion || (this.TaskVersion != null && !this.TaskVersion.Equals(input.TaskVersion))) return false;
            if (this.ConnectionManagement != input.ConnectionManagement || (this.ConnectionManagement != null && !this.ConnectionManagement.Equals(input.ConnectionManagement))) return false;
            if (this.PublicIpList != input.PublicIpList || (this.PublicIpList != null && input.PublicIpList != null && !this.PublicIpList.SequenceEqual(input.PublicIpList))) return false;
            if (this.BindPublicIpState != input.BindPublicIpState || (this.BindPublicIpState != null && !this.BindPublicIpState.Equals(input.BindPublicIpState))) return false;
            if (this.Children != input.Children || (this.Children != null && input.Children != null && !this.Children.SequenceEqual(input.Children))) return false;
            if (this.IsWritable != input.IsWritable) return false;

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
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.MasterJobId != null) hashCode = hashCode * 59 + this.MasterJobId.GetHashCode();
                if (this.BaseInfo != null) hashCode = hashCode * 59 + this.BaseInfo.GetHashCode();
                if (this.SourceEndpoint != null) hashCode = hashCode * 59 + this.SourceEndpoint.GetHashCode();
                if (this.TargetEndpoint != null) hashCode = hashCode * 59 + this.TargetEndpoint.GetHashCode();
                if (this.AlarmNotify != null) hashCode = hashCode * 59 + this.AlarmNotify.GetHashCode();
                if (this.SpeedLimit != null) hashCode = hashCode * 59 + this.SpeedLimit.GetHashCode();
                if (this.UserMigration != null) hashCode = hashCode * 59 + this.UserMigration.GetHashCode();
                if (this.PolicyConfig != null) hashCode = hashCode * 59 + this.PolicyConfig.GetHashCode();
                if (this.DbParam != null) hashCode = hashCode * 59 + this.DbParam.GetHashCode();
                if (this.TuningParams != null) hashCode = hashCode * 59 + this.TuningParams.GetHashCode();
                if (this.PeriodOrder != null) hashCode = hashCode * 59 + this.PeriodOrder.GetHashCode();
                if (this.NodeInfo != null) hashCode = hashCode * 59 + this.NodeInfo.GetHashCode();
                if (this.Logs != null) hashCode = hashCode * 59 + this.Logs.GetHashCode();
                if (this.NetworkResults != null) hashCode = hashCode * 59 + this.NetworkResults.GetHashCode();
                if (this.PrecheckResult != null) hashCode = hashCode * 59 + this.PrecheckResult.GetHashCode();
                if (this.ProgressInfo != null) hashCode = hashCode * 59 + this.ProgressInfo.GetHashCode();
                if (this.MigrationObjectProgressInfo != null) hashCode = hashCode * 59 + this.MigrationObjectProgressInfo.GetHashCode();
                if (this.Metrics != null) hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.CompareResult != null) hashCode = hashCode * 59 + this.CompareResult.GetHashCode();
                if (this.SupportImportFileResp != null) hashCode = hashCode * 59 + this.SupportImportFileResp.GetHashCode();
                if (this.InstanceFeatures != null) hashCode = hashCode * 59 + this.InstanceFeatures.GetHashCode();
                if (this.TaskVersion != null) hashCode = hashCode * 59 + this.TaskVersion.GetHashCode();
                if (this.ConnectionManagement != null) hashCode = hashCode * 59 + this.ConnectionManagement.GetHashCode();
                if (this.PublicIpList != null) hashCode = hashCode * 59 + this.PublicIpList.GetHashCode();
                if (this.BindPublicIpState != null) hashCode = hashCode * 59 + this.BindPublicIpState.GetHashCode();
                if (this.Children != null) hashCode = hashCode * 59 + this.Children.GetHashCode();
                hashCode = hashCode * 59 + this.IsWritable.GetHashCode();
                return hashCode;
            }
        }
    }
}
