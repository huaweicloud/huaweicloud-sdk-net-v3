using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 桌面agent安装情况。
    /// </summary>
    public class AgentsCondition 
    {

        /// <summary>
        /// 桌面的desktopId。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 桌面名称。
        /// </summary>
        [JsonProperty("desktop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopName { get; set; }

        /// <summary>
        /// 桌面池id。
        /// </summary>
        [JsonProperty("desktop_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolId { get; set; }

        /// <summary>
        /// 桌面运行状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 桌面的任务状态。
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// ip地址。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 桌面任务进度， 取值范围0-100以及null，null表示该桌面无任务，0-100表明该任务进度的百分比。
        /// </summary>
        [JsonProperty("process", NullValueHandling = NullValueHandling.Ignore)]
        public int? Process { get; set; }

        /// <summary>
        /// 单个桌面内的agent安装情况。
        /// </summary>
        [JsonProperty("agent_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<AgentInfo> AgentInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentsCondition {\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  desktopName: ").Append(DesktopName).Append("\n");
            sb.Append("  desktopPoolId: ").Append(DesktopPoolId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  process: ").Append(Process).Append("\n");
            sb.Append("  agentInfo: ").Append(AgentInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentsCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentsCondition input)
        {
            if (input == null) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.DesktopName != input.DesktopName || (this.DesktopName != null && !this.DesktopName.Equals(input.DesktopName))) return false;
            if (this.DesktopPoolId != input.DesktopPoolId || (this.DesktopPoolId != null && !this.DesktopPoolId.Equals(input.DesktopPoolId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TaskStatus != input.TaskStatus || (this.TaskStatus != null && !this.TaskStatus.Equals(input.TaskStatus))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Process != input.Process || (this.Process != null && !this.Process.Equals(input.Process))) return false;
            if (this.AgentInfo != input.AgentInfo || (this.AgentInfo != null && input.AgentInfo != null && !this.AgentInfo.SequenceEqual(input.AgentInfo))) return false;

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
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.DesktopName != null) hashCode = hashCode * 59 + this.DesktopName.GetHashCode();
                if (this.DesktopPoolId != null) hashCode = hashCode * 59 + this.DesktopPoolId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskStatus != null) hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Process != null) hashCode = hashCode * 59 + this.Process.GetHashCode();
                if (this.AgentInfo != null) hashCode = hashCode * 59 + this.AgentInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
