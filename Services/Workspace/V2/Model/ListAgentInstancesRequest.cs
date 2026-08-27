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
    /// Request Object
    /// </summary>
    public class ListAgentInstancesRequest 
    {

        /// <summary>
        /// Agent 类型，支持多选（OR 逻辑）：OpenClaw / OfficeClaw / HermesAgent
        /// </summary>
        [SDKProperty("ai_agent_type", IsQuery = true)]
        [JsonProperty("ai_agent_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AiAgentType { get; set; }

        /// <summary>
        /// 区域 ID，支持多选（OR 逻辑）
        /// </summary>
        [SDKProperty("region_id", IsQuery = true)]
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RegionId { get; set; }

        /// <summary>
        /// Agent 运行状态，支持多选（OR 逻辑）： - UNREACHABLE：连续3次心跳丢失（90秒无上报），触发告警 - ERROR：Agent进程健康检查连续失败3次或进程异常退出，尝试自动重启 - OFFLINE：桌面关机或重建中，停止心跳检测 - RUNNING：心跳正常且Agent进程健康检查通过
        /// </summary>
        [SDKProperty("agent_status", IsQuery = true)]
        [JsonProperty("agent_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AgentStatus { get; set; }

        /// <summary>
        /// 桌面运行状态，支持多选（OR 逻辑）： - ACTIVE：运行中 - SHUTOFF：已关机 - HIBERNATED：已休眠 - ERROR：故障
        /// </summary>
        [SDKProperty("desktop_status", IsQuery = true)]
        [JsonProperty("desktop_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopStatus { get; set; }

        /// <summary>
        /// 桌面连接状态，支持多选（OR 逻辑）： - UNREGISTER：桌面未注册（关机后也会出现） - REGISTERED：桌面已注册，等待用户连接 - CONNECTED：用户已连接，正在使用桌面 - DISCONNECTED：桌面与客户端断开会话
        /// </summary>
        [SDKProperty("desktop_connection", IsQuery = true)]
        [JsonProperty("desktop_connection", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopConnection { get; set; }

        /// <summary>
        /// 已授权的模型分组 ID（单选）
        /// </summary>
        [SDKProperty("model_group_id", IsQuery = true)]
        [JsonProperty("model_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelGroupId { get; set; }

        /// <summary>
        /// 通道配置状态，支持多选（OR 逻辑）： - UNCONFIGURED：未配置 - APPLYING：配置中 - CONFIGURED：已配置 - FAILED：配置失败
        /// </summary>
        [SDKProperty("channel_config_status", IsQuery = true)]
        [JsonProperty("channel_config_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChannelConfigStatus { get; set; }

        /// <summary>
        /// 实例名称（模糊搜索）
        /// </summary>
        [SDKProperty("instance_name", IsQuery = true)]
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 实例 ID（精确搜索）
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 云桌面 ID（精确搜索）
        /// </summary>
        [SDKProperty("desktop_id", IsQuery = true)]
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 创建时间范围-开始
        /// </summary>
        [SDKProperty("create_time_start", IsQuery = true)]
        [JsonProperty("create_time_start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTimeStart { get; set; }

        /// <summary>
        /// 创建时间范围-结束
        /// </summary>
        [SDKProperty("create_time_end", IsQuery = true)]
        [JsonProperty("create_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTimeEnd { get; set; }

        /// <summary>
        /// 标签过滤，格式：key1&#x3D;val1,key2&#x3D;val2，多个键值对用逗号分隔
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 风险类型过滤，支持多选（OR 逻辑）： - MODEL_CONFIG_INCONSISTENT：模型配置不一致 - IM_CHANNEL_CONFIG_INCONSISTENT：IM通道配置不一致
        /// </summary>
        [SDKProperty("risk_type", IsQuery = true)]
        [JsonProperty("risk_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RiskType { get; set; }

        /// <summary>
        /// 模型配置状态，支持多选（OR 逻辑）： - UNCONFIGURED：未配置 - APPLYING：配置中 - CONFIGURED：已配置 - FAILED：配置失败
        /// </summary>
        [SDKProperty("model_config_status", IsQuery = true)]
        [JsonProperty("model_config_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ModelConfigStatus { get; set; }

        /// <summary>
        /// Agent 版本号（精确搜索）
        /// </summary>
        [SDKProperty("agent_version", IsQuery = true)]
        [JsonProperty("agent_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 排序字段：create_time（默认）/ instance_name / agent_status / heartbeat_time
        /// </summary>
        [SDKProperty("sort_field", IsQuery = true)]
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SortField { get; set; }

        /// <summary>
        /// 排序方向：DESC（默认）/ ASC
        /// </summary>
        [SDKProperty("sort_order", IsQuery = true)]
        [JsonProperty("sort_order", NullValueHandling = NullValueHandling.Ignore)]
        public string SortOrder { get; set; }

        /// <summary>
        /// 偏移量，从0开始
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页条数
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
            sb.Append("class ListAgentInstancesRequest {\n");
            sb.Append("  aiAgentType: ").Append(AiAgentType).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  agentStatus: ").Append(AgentStatus).Append("\n");
            sb.Append("  desktopStatus: ").Append(DesktopStatus).Append("\n");
            sb.Append("  desktopConnection: ").Append(DesktopConnection).Append("\n");
            sb.Append("  modelGroupId: ").Append(ModelGroupId).Append("\n");
            sb.Append("  channelConfigStatus: ").Append(ChannelConfigStatus).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  createTimeStart: ").Append(CreateTimeStart).Append("\n");
            sb.Append("  createTimeEnd: ").Append(CreateTimeEnd).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  riskType: ").Append(RiskType).Append("\n");
            sb.Append("  modelConfigStatus: ").Append(ModelConfigStatus).Append("\n");
            sb.Append("  agentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as ListAgentInstancesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAgentInstancesRequest input)
        {
            if (input == null) return false;
            if (this.AiAgentType != input.AiAgentType || (this.AiAgentType != null && input.AiAgentType != null && !this.AiAgentType.SequenceEqual(input.AiAgentType))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && input.RegionId != null && !this.RegionId.SequenceEqual(input.RegionId))) return false;
            if (this.AgentStatus != input.AgentStatus || (this.AgentStatus != null && input.AgentStatus != null && !this.AgentStatus.SequenceEqual(input.AgentStatus))) return false;
            if (this.DesktopStatus != input.DesktopStatus || (this.DesktopStatus != null && input.DesktopStatus != null && !this.DesktopStatus.SequenceEqual(input.DesktopStatus))) return false;
            if (this.DesktopConnection != input.DesktopConnection || (this.DesktopConnection != null && input.DesktopConnection != null && !this.DesktopConnection.SequenceEqual(input.DesktopConnection))) return false;
            if (this.ModelGroupId != input.ModelGroupId || (this.ModelGroupId != null && !this.ModelGroupId.Equals(input.ModelGroupId))) return false;
            if (this.ChannelConfigStatus != input.ChannelConfigStatus || (this.ChannelConfigStatus != null && input.ChannelConfigStatus != null && !this.ChannelConfigStatus.SequenceEqual(input.ChannelConfigStatus))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.CreateTimeStart != input.CreateTimeStart || (this.CreateTimeStart != null && !this.CreateTimeStart.Equals(input.CreateTimeStart))) return false;
            if (this.CreateTimeEnd != input.CreateTimeEnd || (this.CreateTimeEnd != null && !this.CreateTimeEnd.Equals(input.CreateTimeEnd))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;
            if (this.RiskType != input.RiskType || (this.RiskType != null && input.RiskType != null && !this.RiskType.SequenceEqual(input.RiskType))) return false;
            if (this.ModelConfigStatus != input.ModelConfigStatus || (this.ModelConfigStatus != null && input.ModelConfigStatus != null && !this.ModelConfigStatus.SequenceEqual(input.ModelConfigStatus))) return false;
            if (this.AgentVersion != input.AgentVersion || (this.AgentVersion != null && !this.AgentVersion.Equals(input.AgentVersion))) return false;
            if (this.SortField != input.SortField || (this.SortField != null && !this.SortField.Equals(input.SortField))) return false;
            if (this.SortOrder != input.SortOrder || (this.SortOrder != null && !this.SortOrder.Equals(input.SortOrder))) return false;
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
                if (this.AiAgentType != null) hashCode = hashCode * 59 + this.AiAgentType.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.AgentStatus != null) hashCode = hashCode * 59 + this.AgentStatus.GetHashCode();
                if (this.DesktopStatus != null) hashCode = hashCode * 59 + this.DesktopStatus.GetHashCode();
                if (this.DesktopConnection != null) hashCode = hashCode * 59 + this.DesktopConnection.GetHashCode();
                if (this.ModelGroupId != null) hashCode = hashCode * 59 + this.ModelGroupId.GetHashCode();
                if (this.ChannelConfigStatus != null) hashCode = hashCode * 59 + this.ChannelConfigStatus.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.CreateTimeStart != null) hashCode = hashCode * 59 + this.CreateTimeStart.GetHashCode();
                if (this.CreateTimeEnd != null) hashCode = hashCode * 59 + this.CreateTimeEnd.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.RiskType != null) hashCode = hashCode * 59 + this.RiskType.GetHashCode();
                if (this.ModelConfigStatus != null) hashCode = hashCode * 59 + this.ModelConfigStatus.GetHashCode();
                if (this.AgentVersion != null) hashCode = hashCode * 59 + this.AgentVersion.GetHashCode();
                if (this.SortField != null) hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.SortOrder != null) hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
