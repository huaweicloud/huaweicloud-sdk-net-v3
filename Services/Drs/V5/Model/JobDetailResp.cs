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
        /// 任务ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

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
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.MasterJobId == input.MasterJobId ||
                    (this.MasterJobId != null &&
                    this.MasterJobId.Equals(input.MasterJobId))
                ) && 
                (
                    this.BaseInfo == input.BaseInfo ||
                    (this.BaseInfo != null &&
                    this.BaseInfo.Equals(input.BaseInfo))
                ) && 
                (
                    this.SourceEndpoint == input.SourceEndpoint ||
                    this.SourceEndpoint != null &&
                    input.SourceEndpoint != null &&
                    this.SourceEndpoint.SequenceEqual(input.SourceEndpoint)
                ) && 
                (
                    this.TargetEndpoint == input.TargetEndpoint ||
                    this.TargetEndpoint != null &&
                    input.TargetEndpoint != null &&
                    this.TargetEndpoint.SequenceEqual(input.TargetEndpoint)
                ) && 
                (
                    this.AlarmNotify == input.AlarmNotify ||
                    (this.AlarmNotify != null &&
                    this.AlarmNotify.Equals(input.AlarmNotify))
                ) && 
                (
                    this.SpeedLimit == input.SpeedLimit ||
                    this.SpeedLimit != null &&
                    input.SpeedLimit != null &&
                    this.SpeedLimit.SequenceEqual(input.SpeedLimit)
                ) && 
                (
                    this.UserMigration == input.UserMigration ||
                    (this.UserMigration != null &&
                    this.UserMigration.Equals(input.UserMigration))
                ) && 
                (
                    this.PolicyConfig == input.PolicyConfig ||
                    (this.PolicyConfig != null &&
                    this.PolicyConfig.Equals(input.PolicyConfig))
                ) && 
                (
                    this.DbParam == input.DbParam ||
                    (this.DbParam != null &&
                    this.DbParam.Equals(input.DbParam))
                ) && 
                (
                    this.TuningParams == input.TuningParams ||
                    (this.TuningParams != null &&
                    this.TuningParams.Equals(input.TuningParams))
                ) && 
                (
                    this.PeriodOrder == input.PeriodOrder ||
                    (this.PeriodOrder != null &&
                    this.PeriodOrder.Equals(input.PeriodOrder))
                ) && 
                (
                    this.NodeInfo == input.NodeInfo ||
                    (this.NodeInfo != null &&
                    this.NodeInfo.Equals(input.NodeInfo))
                ) && 
                (
                    this.Logs == input.Logs ||
                    this.Logs != null &&
                    input.Logs != null &&
                    this.Logs.SequenceEqual(input.Logs)
                ) && 
                (
                    this.NetworkResults == input.NetworkResults ||
                    this.NetworkResults != null &&
                    input.NetworkResults != null &&
                    this.NetworkResults.SequenceEqual(input.NetworkResults)
                ) && 
                (
                    this.PrecheckResult == input.PrecheckResult ||
                    (this.PrecheckResult != null &&
                    this.PrecheckResult.Equals(input.PrecheckResult))
                ) && 
                (
                    this.ProgressInfo == input.ProgressInfo ||
                    (this.ProgressInfo != null &&
                    this.ProgressInfo.Equals(input.ProgressInfo))
                ) && 
                (
                    this.MigrationObjectProgressInfo == input.MigrationObjectProgressInfo ||
                    (this.MigrationObjectProgressInfo != null &&
                    this.MigrationObjectProgressInfo.Equals(input.MigrationObjectProgressInfo))
                ) && 
                (
                    this.Metrics == input.Metrics ||
                    (this.Metrics != null &&
                    this.Metrics.Equals(input.Metrics))
                ) && 
                (
                    this.CompareResult == input.CompareResult ||
                    (this.CompareResult != null &&
                    this.CompareResult.Equals(input.CompareResult))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.MasterJobId != null)
                    hashCode = hashCode * 59 + this.MasterJobId.GetHashCode();
                if (this.BaseInfo != null)
                    hashCode = hashCode * 59 + this.BaseInfo.GetHashCode();
                if (this.SourceEndpoint != null)
                    hashCode = hashCode * 59 + this.SourceEndpoint.GetHashCode();
                if (this.TargetEndpoint != null)
                    hashCode = hashCode * 59 + this.TargetEndpoint.GetHashCode();
                if (this.AlarmNotify != null)
                    hashCode = hashCode * 59 + this.AlarmNotify.GetHashCode();
                if (this.SpeedLimit != null)
                    hashCode = hashCode * 59 + this.SpeedLimit.GetHashCode();
                if (this.UserMigration != null)
                    hashCode = hashCode * 59 + this.UserMigration.GetHashCode();
                if (this.PolicyConfig != null)
                    hashCode = hashCode * 59 + this.PolicyConfig.GetHashCode();
                if (this.DbParam != null)
                    hashCode = hashCode * 59 + this.DbParam.GetHashCode();
                if (this.TuningParams != null)
                    hashCode = hashCode * 59 + this.TuningParams.GetHashCode();
                if (this.PeriodOrder != null)
                    hashCode = hashCode * 59 + this.PeriodOrder.GetHashCode();
                if (this.NodeInfo != null)
                    hashCode = hashCode * 59 + this.NodeInfo.GetHashCode();
                if (this.Logs != null)
                    hashCode = hashCode * 59 + this.Logs.GetHashCode();
                if (this.NetworkResults != null)
                    hashCode = hashCode * 59 + this.NetworkResults.GetHashCode();
                if (this.PrecheckResult != null)
                    hashCode = hashCode * 59 + this.PrecheckResult.GetHashCode();
                if (this.ProgressInfo != null)
                    hashCode = hashCode * 59 + this.ProgressInfo.GetHashCode();
                if (this.MigrationObjectProgressInfo != null)
                    hashCode = hashCode * 59 + this.MigrationObjectProgressInfo.GetHashCode();
                if (this.Metrics != null)
                    hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.CompareResult != null)
                    hashCode = hashCode * 59 + this.CompareResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
