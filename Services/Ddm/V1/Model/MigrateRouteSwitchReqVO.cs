using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MigrateRouteSwitchReqVO 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("iam_account", NullValueHandling = NullValueHandling.Ignore)]
        public IamAccount IamAccount { get; set; }

        /// <summary>
        /// 项目id。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 自动切换路由开始时间。
        /// </summary>
        [JsonProperty("switch_route_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchRouteBeginTime { get; set; }

        /// <summary>
        /// 自动切换路由结束时间。
        /// </summary>
        [JsonProperty("switch_route_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchRouteEndTime { get; set; }

        /// <summary>
        /// 是否openapi。
        /// </summary>
        [JsonProperty("is_open_api", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOpenApi { get; set; }

        /// <summary>
        /// 逻辑库名称。
        /// </summary>
        [JsonProperty("logic_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogicDbName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateRouteSwitchReqVO {\n");
            sb.Append("  iamAccount: ").Append(IamAccount).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  switchRouteBeginTime: ").Append(SwitchRouteBeginTime).Append("\n");
            sb.Append("  switchRouteEndTime: ").Append(SwitchRouteEndTime).Append("\n");
            sb.Append("  isOpenApi: ").Append(IsOpenApi).Append("\n");
            sb.Append("  logicDbName: ").Append(LogicDbName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateRouteSwitchReqVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateRouteSwitchReqVO input)
        {
            if (input == null) return false;
            if (this.IamAccount != input.IamAccount || (this.IamAccount != null && !this.IamAccount.Equals(input.IamAccount))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.SwitchRouteBeginTime != input.SwitchRouteBeginTime || (this.SwitchRouteBeginTime != null && !this.SwitchRouteBeginTime.Equals(input.SwitchRouteBeginTime))) return false;
            if (this.SwitchRouteEndTime != input.SwitchRouteEndTime || (this.SwitchRouteEndTime != null && !this.SwitchRouteEndTime.Equals(input.SwitchRouteEndTime))) return false;
            if (this.IsOpenApi != input.IsOpenApi || (this.IsOpenApi != null && !this.IsOpenApi.Equals(input.IsOpenApi))) return false;
            if (this.LogicDbName != input.LogicDbName || (this.LogicDbName != null && !this.LogicDbName.Equals(input.LogicDbName))) return false;

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
                if (this.IamAccount != null) hashCode = hashCode * 59 + this.IamAccount.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.SwitchRouteBeginTime != null) hashCode = hashCode * 59 + this.SwitchRouteBeginTime.GetHashCode();
                if (this.SwitchRouteEndTime != null) hashCode = hashCode * 59 + this.SwitchRouteEndTime.GetHashCode();
                if (this.IsOpenApi != null) hashCode = hashCode * 59 + this.IsOpenApi.GetHashCode();
                if (this.LogicDbName != null) hashCode = hashCode * 59 + this.LogicDbName.GetHashCode();
                return hashCode;
            }
        }
    }
}
