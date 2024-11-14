using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateLimitTaskResponse : SdkResponse
    {

        /// <summary>
        /// 限流任务ID。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务限流范围，与请求参数相同。
        /// </summary>
        [JsonProperty("task_scope", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskScope { get; set; }

        /// <summary>
        /// 任务限流类型，与请求参数相同。
        /// </summary>
        [JsonProperty("limit_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitType { get; set; }

        /// <summary>
        /// 任务限流类型值，与请求参数相同。
        /// </summary>
        [JsonProperty("limit_type_value", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitTypeValue { get; set; }

        /// <summary>
        /// CN节点数据库组，每个数据库字符串以逗号形式隔开。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public string Databases { get; set; }

        /// <summary>
        /// 限流任务名。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// SQL模板,仅当任务类型为SQL_ID时，返回该值且与请求参数相同。
        /// </summary>
        [JsonProperty("sql_model", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlModel { get; set; }

        /// <summary>
        /// 关键词，仅当任务类型为SQL_TYPE时，返回该值且与请求参数相同。
        /// </summary>
        [JsonProperty("key_words", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWords { get; set; }

        /// <summary>
        /// 限流任务状态，当前支持：CREATING，UPDATEING，DELETING，WAIT_EXCUTE，EXCUTING，TIME_OVER，DELETED，CREATE_FAILED，UPDATE_FAILED，DELETE_FAILED，EXCEPTION，NODE_SHUT_DOWN。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 实例id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 规则名。
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 并发数，与请求参数相同。
        /// </summary>
        [JsonProperty("parallel_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParallelSize { get; set; }

        /// <summary>
        /// cpu利用率阈值，仅当任务类型为SESSION_ACTIVE_MAX_COUNT时，返回该值且只保留正整数。
        /// </summary>
        [JsonProperty("cpu_utilization", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuUtilization { get; set; }

        /// <summary>
        /// 内存利用率阈值，仅当任务类型为SESSION_ACTIVE_MAX_COUNT时，返回该值且只保留正整数。
        /// </summary>
        [JsonProperty("memory_utilization", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryUtilization { get; set; }

        /// <summary>
        /// 限流任务开始时间，与请求参数相同，格式为yyyy-mm-ddThh:mm:ssZ，当前时间指UTC时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 限流任务结束时间，与请求参数相同，格式为yyyy-mm-ddThh:mm:ssZ，当前时间指UTC时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 创建时间为本地时间，格式为yyyy-mm-ddThh:mm:ssZ。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 更新时间为本地时间，格式为yyyy-mm-ddThh:mm:ssZ。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 创建者。
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// 更新者。
        /// </summary>
        [JsonProperty("modifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Modifier { get; set; }

        /// <summary>
        /// CN节点信息列表，如果类型为SQLID，必返。
        /// </summary>
        [JsonProperty("node_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateLimitTaskNodeResult> NodeInfos { get; set; }

        /// <summary>
        /// 工作流ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLimitTaskResponse {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskScope: ").Append(TaskScope).Append("\n");
            sb.Append("  limitType: ").Append(LimitType).Append("\n");
            sb.Append("  limitTypeValue: ").Append(LimitTypeValue).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  sqlModel: ").Append(SqlModel).Append("\n");
            sb.Append("  keyWords: ").Append(KeyWords).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  parallelSize: ").Append(ParallelSize).Append("\n");
            sb.Append("  cpuUtilization: ").Append(CpuUtilization).Append("\n");
            sb.Append("  memoryUtilization: ").Append(MemoryUtilization).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  modifier: ").Append(Modifier).Append("\n");
            sb.Append("  nodeInfos: ").Append(NodeInfos).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLimitTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLimitTaskResponse input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskScope != input.TaskScope || (this.TaskScope != null && !this.TaskScope.Equals(input.TaskScope))) return false;
            if (this.LimitType != input.LimitType || (this.LimitType != null && !this.LimitType.Equals(input.LimitType))) return false;
            if (this.LimitTypeValue != input.LimitTypeValue || (this.LimitTypeValue != null && !this.LimitTypeValue.Equals(input.LimitTypeValue))) return false;
            if (this.Databases != input.Databases || (this.Databases != null && !this.Databases.Equals(input.Databases))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.SqlModel != input.SqlModel || (this.SqlModel != null && !this.SqlModel.Equals(input.SqlModel))) return false;
            if (this.KeyWords != input.KeyWords || (this.KeyWords != null && !this.KeyWords.Equals(input.KeyWords))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.ParallelSize != input.ParallelSize || (this.ParallelSize != null && !this.ParallelSize.Equals(input.ParallelSize))) return false;
            if (this.CpuUtilization != input.CpuUtilization || (this.CpuUtilization != null && !this.CpuUtilization.Equals(input.CpuUtilization))) return false;
            if (this.MemoryUtilization != input.MemoryUtilization || (this.MemoryUtilization != null && !this.MemoryUtilization.Equals(input.MemoryUtilization))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Modifier != input.Modifier || (this.Modifier != null && !this.Modifier.Equals(input.Modifier))) return false;
            if (this.NodeInfos != input.NodeInfos || (this.NodeInfos != null && input.NodeInfos != null && !this.NodeInfos.SequenceEqual(input.NodeInfos))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskScope != null) hashCode = hashCode * 59 + this.TaskScope.GetHashCode();
                if (this.LimitType != null) hashCode = hashCode * 59 + this.LimitType.GetHashCode();
                if (this.LimitTypeValue != null) hashCode = hashCode * 59 + this.LimitTypeValue.GetHashCode();
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.SqlModel != null) hashCode = hashCode * 59 + this.SqlModel.GetHashCode();
                if (this.KeyWords != null) hashCode = hashCode * 59 + this.KeyWords.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.ParallelSize != null) hashCode = hashCode * 59 + this.ParallelSize.GetHashCode();
                if (this.CpuUtilization != null) hashCode = hashCode * 59 + this.CpuUtilization.GetHashCode();
                if (this.MemoryUtilization != null) hashCode = hashCode * 59 + this.MemoryUtilization.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Modifier != null) hashCode = hashCode * 59 + this.Modifier.GetHashCode();
                if (this.NodeInfos != null) hashCode = hashCode * 59 + this.NodeInfos.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
