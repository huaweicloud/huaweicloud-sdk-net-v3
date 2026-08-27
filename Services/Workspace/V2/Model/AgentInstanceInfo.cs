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
    /// Agent 实例信息
    /// </summary>
    public class AgentInstanceInfo 
    {

        /// <summary>
        /// 主键 ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Agent 实例 ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 关联云桌面 ID
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 区域 ID
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// Agent 类型
        /// </summary>
        [JsonProperty("ai_agent_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AiAgentType { get; set; }

        /// <summary>
        /// Agent 运行状态： - UNREACHABLE：连续3次心跳丢失（90秒无上报），触发告警 - ERROR：Agent进程健康检查连续失败3次或进程异常退出，尝试自动重启 - OFFLINE：桌面关机或重建中，停止心跳检测 - RUNNING：心跳正常且Agent进程健康检查通过
        /// </summary>
        [JsonProperty("agent_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentStatus { get; set; }

        /// <summary>
        /// 桌面运行状态： - ACTIVE：运行中 - SHUTOFF：已关机 - HIBERNATED：已休眠 - ERROR：故障
        /// </summary>
        [JsonProperty("desktop_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopStatus { get; set; }

        /// <summary>
        /// 桌面连接状态： - UNREGISTER：桌面未注册（关机后也会出现） - REGISTERED：桌面已注册，等待用户连接 - CONNECTED：用户已连接，正在使用桌面 - DISCONNECTED：桌面与客户端断开会话
        /// </summary>
        [JsonProperty("desktop_connection", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopConnection { get; set; }

        /// <summary>
        /// 模型配置状态
        /// </summary>
        [JsonProperty("model_config_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelConfigStatus { get; set; }

        /// <summary>
        /// 通道配置状态： - UNCONFIGURED：未配置 - APPLYING：配置中 - CONFIGURED：已配置 - FAILED：配置失败
        /// </summary>
        [JsonProperty("channel_config_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelConfigStatus { get; set; }

        /// <summary>
        /// IM 通道配置 ID 列表
        /// </summary>
        [JsonProperty("im_channel_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ImChannelConfigs { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 产品 ID
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// 镜像 ID
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageName { get; set; }

        /// <summary>
        /// 桌面池 ID
        /// </summary>
        [JsonProperty("desktop_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 风险列表
        /// </summary>
        [JsonProperty("risks", NullValueHandling = NullValueHandling.Ignore)]
        public List<AgentRisk> Risks { get; set; }

        /// <summary>
        /// Agent 版本号
        /// </summary>
        [JsonProperty("agent_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 企业项目 ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentInstanceInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  aiAgentType: ").Append(AiAgentType).Append("\n");
            sb.Append("  agentStatus: ").Append(AgentStatus).Append("\n");
            sb.Append("  desktopStatus: ").Append(DesktopStatus).Append("\n");
            sb.Append("  desktopConnection: ").Append(DesktopConnection).Append("\n");
            sb.Append("  modelConfigStatus: ").Append(ModelConfigStatus).Append("\n");
            sb.Append("  channelConfigStatus: ").Append(ChannelConfigStatus).Append("\n");
            sb.Append("  imChannelConfigs: ").Append(ImChannelConfigs).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  desktopPoolId: ").Append(DesktopPoolId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  risks: ").Append(Risks).Append("\n");
            sb.Append("  agentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentInstanceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentInstanceInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.AiAgentType != input.AiAgentType || (this.AiAgentType != null && !this.AiAgentType.Equals(input.AiAgentType))) return false;
            if (this.AgentStatus != input.AgentStatus || (this.AgentStatus != null && !this.AgentStatus.Equals(input.AgentStatus))) return false;
            if (this.DesktopStatus != input.DesktopStatus || (this.DesktopStatus != null && !this.DesktopStatus.Equals(input.DesktopStatus))) return false;
            if (this.DesktopConnection != input.DesktopConnection || (this.DesktopConnection != null && !this.DesktopConnection.Equals(input.DesktopConnection))) return false;
            if (this.ModelConfigStatus != input.ModelConfigStatus || (this.ModelConfigStatus != null && !this.ModelConfigStatus.Equals(input.ModelConfigStatus))) return false;
            if (this.ChannelConfigStatus != input.ChannelConfigStatus || (this.ChannelConfigStatus != null && !this.ChannelConfigStatus.Equals(input.ChannelConfigStatus))) return false;
            if (this.ImChannelConfigs != input.ImChannelConfigs || (this.ImChannelConfigs != null && input.ImChannelConfigs != null && !this.ImChannelConfigs.SequenceEqual(input.ImChannelConfigs))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.ImageName != input.ImageName || (this.ImageName != null && !this.ImageName.Equals(input.ImageName))) return false;
            if (this.DesktopPoolId != input.DesktopPoolId || (this.DesktopPoolId != null && !this.DesktopPoolId.Equals(input.DesktopPoolId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Risks != input.Risks || (this.Risks != null && input.Risks != null && !this.Risks.SequenceEqual(input.Risks))) return false;
            if (this.AgentVersion != input.AgentVersion || (this.AgentVersion != null && !this.AgentVersion.Equals(input.AgentVersion))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.AiAgentType != null) hashCode = hashCode * 59 + this.AiAgentType.GetHashCode();
                if (this.AgentStatus != null) hashCode = hashCode * 59 + this.AgentStatus.GetHashCode();
                if (this.DesktopStatus != null) hashCode = hashCode * 59 + this.DesktopStatus.GetHashCode();
                if (this.DesktopConnection != null) hashCode = hashCode * 59 + this.DesktopConnection.GetHashCode();
                if (this.ModelConfigStatus != null) hashCode = hashCode * 59 + this.ModelConfigStatus.GetHashCode();
                if (this.ChannelConfigStatus != null) hashCode = hashCode * 59 + this.ChannelConfigStatus.GetHashCode();
                if (this.ImChannelConfigs != null) hashCode = hashCode * 59 + this.ImChannelConfigs.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.ImageName != null) hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.DesktopPoolId != null) hashCode = hashCode * 59 + this.DesktopPoolId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Risks != null) hashCode = hashCode * 59 + this.Risks.GetHashCode();
                if (this.AgentVersion != null) hashCode = hashCode * 59 + this.AgentVersion.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
