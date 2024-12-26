using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerIpsListVO 
    {

        /// <summary>
        /// 动作（0：只记录日志，1：重置/拦截）
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public int? Action { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        [JsonProperty("affected_os", NullValueHandling = NullValueHandling.Ignore)]
        public int? AffectedOs { get; set; }

        /// <summary>
        /// 攻击类型
        /// </summary>
        [JsonProperty("attack_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttackType { get; set; }

        /// <summary>
        /// 规则状态（0：初始化，1：配置中，2：配置成功，3：配置失败）
        /// </summary>
        [JsonProperty("config_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfigStatus { get; set; }

        /// <summary>
        /// 内容json存储
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 目的端口类型
        /// </summary>
        [JsonProperty("dst_port_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DstPortType { get; set; }

        /// <summary>
        /// 目的端口
        /// </summary>
        [JsonProperty("dst_ports", NullValueHandling = NullValueHandling.Ignore)]
        public string DstPorts { get; set; }

        /// <summary>
        /// 防火墙集群id
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// cfw侧自定义ips规则id
        /// </summary>
        [JsonProperty("ips_cfw_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsCfwId { get; set; }

        /// <summary>
        /// 山石侧规则id
        /// </summary>
        [JsonProperty("ips_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsId { get; set; }

        /// <summary>
        /// ips规则名称
        /// </summary>
        [JsonProperty("ips_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsName { get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public int? Protocol { get; set; }

        /// <summary>
        /// 严重程度（critical：致命，high：高危，medium:中危，low:低危）
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Severity { get; set; }

        /// <summary>
        /// 影响软件
        /// </summary>
        [JsonProperty("software", NullValueHandling = NullValueHandling.Ignore)]
        public int? Software { get; set; }

        /// <summary>
        /// 源端口类型
        /// </summary>
        [JsonProperty("src_port_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SrcPortType { get; set; }

        /// <summary>
        /// 源端口
        /// </summary>
        [JsonProperty("src_ports", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcPorts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerIpsListVO {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  affectedOs: ").Append(AffectedOs).Append("\n");
            sb.Append("  attackType: ").Append(AttackType).Append("\n");
            sb.Append("  configStatus: ").Append(ConfigStatus).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  dstPortType: ").Append(DstPortType).Append("\n");
            sb.Append("  dstPorts: ").Append(DstPorts).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  ipsCfwId: ").Append(IpsCfwId).Append("\n");
            sb.Append("  ipsId: ").Append(IpsId).Append("\n");
            sb.Append("  ipsName: ").Append(IpsName).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  software: ").Append(Software).Append("\n");
            sb.Append("  srcPortType: ").Append(SrcPortType).Append("\n");
            sb.Append("  srcPorts: ").Append(SrcPorts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomerIpsListVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomerIpsListVO input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.AffectedOs != input.AffectedOs || (this.AffectedOs != null && !this.AffectedOs.Equals(input.AffectedOs))) return false;
            if (this.AttackType != input.AttackType || (this.AttackType != null && !this.AttackType.Equals(input.AttackType))) return false;
            if (this.ConfigStatus != input.ConfigStatus || (this.ConfigStatus != null && !this.ConfigStatus.Equals(input.ConfigStatus))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.DstPortType != input.DstPortType || (this.DstPortType != null && !this.DstPortType.Equals(input.DstPortType))) return false;
            if (this.DstPorts != input.DstPorts || (this.DstPorts != null && !this.DstPorts.Equals(input.DstPorts))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.IpsCfwId != input.IpsCfwId || (this.IpsCfwId != null && !this.IpsCfwId.Equals(input.IpsCfwId))) return false;
            if (this.IpsId != input.IpsId || (this.IpsId != null && !this.IpsId.Equals(input.IpsId))) return false;
            if (this.IpsName != input.IpsName || (this.IpsName != null && !this.IpsName.Equals(input.IpsName))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.Software != input.Software || (this.Software != null && !this.Software.Equals(input.Software))) return false;
            if (this.SrcPortType != input.SrcPortType || (this.SrcPortType != null && !this.SrcPortType.Equals(input.SrcPortType))) return false;
            if (this.SrcPorts != input.SrcPorts || (this.SrcPorts != null && !this.SrcPorts.Equals(input.SrcPorts))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.AffectedOs != null) hashCode = hashCode * 59 + this.AffectedOs.GetHashCode();
                if (this.AttackType != null) hashCode = hashCode * 59 + this.AttackType.GetHashCode();
                if (this.ConfigStatus != null) hashCode = hashCode * 59 + this.ConfigStatus.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.DstPortType != null) hashCode = hashCode * 59 + this.DstPortType.GetHashCode();
                if (this.DstPorts != null) hashCode = hashCode * 59 + this.DstPorts.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.IpsCfwId != null) hashCode = hashCode * 59 + this.IpsCfwId.GetHashCode();
                if (this.IpsId != null) hashCode = hashCode * 59 + this.IpsId.GetHashCode();
                if (this.IpsName != null) hashCode = hashCode * 59 + this.IpsName.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Software != null) hashCode = hashCode * 59 + this.Software.GetHashCode();
                if (this.SrcPortType != null) hashCode = hashCode * 59 + this.SrcPortType.GetHashCode();
                if (this.SrcPorts != null) hashCode = hashCode * 59 + this.SrcPorts.GetHashCode();
                return hashCode;
            }
        }
    }
}
