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
    /// **参数解释**： 自定义IPS规则返回数据 **取值范围**： 不涉及
    /// </summary>
    public class CustomerIpsVO 
    {

        /// <summary>
        /// **参数解释**： 动作 **取值范围**： 0：只记录日志，1：重置/拦截
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public int? Action { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙集群id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释**： 影响操作系统 **取值范围**： 0 any、1 Windows、2 Linux、3 FreeBSD、4 Solaris、5 other Unix、6 网络设备、7 Mac OS、8 ios、9 android、10 others
        /// </summary>
        [JsonProperty("affected_os", NullValueHandling = NullValueHandling.Ignore)]
        public int? AffectedOs { get; set; }

        /// <summary>
        /// **参数解释**： 攻击类型 **取值范围**： 1：访问控制、2：漏洞扫描、3：邮件攻击、4：漏洞攻击、5：Web攻击、6：密码攻击、7：劫持攻击、8：协议异常、9：特洛伊木马、10：蠕虫、11：缓冲区溢出、12：黑客工具、13：间谍软件、14：DDos泛洪、15：应用层DDos攻击、16：其他可疑行为、17：可疑DNS活动、18：网络钓鱼、19：垃圾邮件、20：其他攻击
        /// </summary>
        [JsonProperty("attack_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttackType { get; set; }

        /// <summary>
        /// **参数解释**： 规则状态 **取值范围**： 0：初始化，1：配置中，2：配置成功，3：配置失败
        /// </summary>
        [JsonProperty("config_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfigStatus { get; set; }

        /// <summary>
        /// **参数解释**： 匹配IPS攻击的内容 **取值范围**：
        /// </summary>
        [JsonProperty("contents", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpsContent> Contents { get; set; }

        /// <summary>
        /// **参数解释**： 默认：null，0：客户端到服务端，1：服务端到客户端 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public int? Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dst_port", NullValueHandling = NullValueHandling.Ignore)]
        public Port DstPort { get; set; }

        /// <summary>
        /// **参数解释**： cfw侧自定义IPS规则id **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("ips_cfw_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsCfwId { get; set; }

        /// <summary>
        /// **参数解释**： ips规则id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("ips_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsId { get; set; }

        /// <summary>
        /// **参数解释**： ips规则名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("ips_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsName { get; set; }

        /// <summary>
        /// **参数解释**： 协议类型 **取值范围**： 1 FTP、2 TELNET、3 SMTP、4 DNS_TCP、5 DNS_UDP、6 DHCP、7 TFTP、8 FINGER、9 HTTP、10 POP3、11 SUNRPC_TCP、12 SUNRPC_UDP、13 NNTP、14 MSRPC_TCP、15 MSRPC_UDP、16 NETBIOS_NAME_TCP、17 NETBIOS_NAME_UDP、18 NETBIOS_SMB、19 NETBIOS_DATAGRAM、20 IMAP4、21 SNMP、22 LDAP、23 MSSQL、24 ORACLE
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public int? Protocol { get; set; }

        /// <summary>
        /// **参数解释**： 严重程度 **取值范围**： critical：致命，high：高危，medium:中危，low:低危
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Severity { get; set; }

        /// <summary>
        /// **参数解释**： 影响软件 **取值范围**： 0 ANY、1 ADOBE、2 APACHE、3 APPLE、4 CA、5 CISCO、6 GOOGLE_CHROME、7 HP、8 IBM、9 IE、10 IIS、11 MC_AFEE、12 MEDIA_PLAYER、13 MICROSOFT_NET、14 MICROSOFT_EDGE、15 MICROSOFT_EXCHANGE、16 MICROSOFT_OFFICE、17 MICROSOFT_OUTLOOK、18 MICROSOFT_SHARE_POINT、19 MICROSOFT_WINDOWS、20 MOZILLA、21 MSSQL、22 MYSQL、23 NOVELL、24 ORACLE、25 SAMBA、26 SAMSUNG、27 SAP、28 SCADA、29 SQUID、30 SUN、31 SYMANTEC、32 TREND_MICRO、33 VMWARE、34 WORD_PRESS、35 Others
        /// </summary>
        [JsonProperty("software", NullValueHandling = NullValueHandling.Ignore)]
        public int? Software { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("src_port", NullValueHandling = NullValueHandling.Ignore)]
        public Port SrcPort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerIpsVO {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  affectedOs: ").Append(AffectedOs).Append("\n");
            sb.Append("  attackType: ").Append(AttackType).Append("\n");
            sb.Append("  configStatus: ").Append(ConfigStatus).Append("\n");
            sb.Append("  contents: ").Append(Contents).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  dstPort: ").Append(DstPort).Append("\n");
            sb.Append("  ipsCfwId: ").Append(IpsCfwId).Append("\n");
            sb.Append("  ipsId: ").Append(IpsId).Append("\n");
            sb.Append("  ipsName: ").Append(IpsName).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  software: ").Append(Software).Append("\n");
            sb.Append("  srcPort: ").Append(SrcPort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomerIpsVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomerIpsVO input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.AffectedOs != input.AffectedOs || (this.AffectedOs != null && !this.AffectedOs.Equals(input.AffectedOs))) return false;
            if (this.AttackType != input.AttackType || (this.AttackType != null && !this.AttackType.Equals(input.AttackType))) return false;
            if (this.ConfigStatus != input.ConfigStatus || (this.ConfigStatus != null && !this.ConfigStatus.Equals(input.ConfigStatus))) return false;
            if (this.Contents != input.Contents || (this.Contents != null && input.Contents != null && !this.Contents.SequenceEqual(input.Contents))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.DstPort != input.DstPort || (this.DstPort != null && !this.DstPort.Equals(input.DstPort))) return false;
            if (this.IpsCfwId != input.IpsCfwId || (this.IpsCfwId != null && !this.IpsCfwId.Equals(input.IpsCfwId))) return false;
            if (this.IpsId != input.IpsId || (this.IpsId != null && !this.IpsId.Equals(input.IpsId))) return false;
            if (this.IpsName != input.IpsName || (this.IpsName != null && !this.IpsName.Equals(input.IpsName))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.Software != input.Software || (this.Software != null && !this.Software.Equals(input.Software))) return false;
            if (this.SrcPort != input.SrcPort || (this.SrcPort != null && !this.SrcPort.Equals(input.SrcPort))) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.AffectedOs != null) hashCode = hashCode * 59 + this.AffectedOs.GetHashCode();
                if (this.AttackType != null) hashCode = hashCode * 59 + this.AttackType.GetHashCode();
                if (this.ConfigStatus != null) hashCode = hashCode * 59 + this.ConfigStatus.GetHashCode();
                if (this.Contents != null) hashCode = hashCode * 59 + this.Contents.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.DstPort != null) hashCode = hashCode * 59 + this.DstPort.GetHashCode();
                if (this.IpsCfwId != null) hashCode = hashCode * 59 + this.IpsCfwId.GetHashCode();
                if (this.IpsId != null) hashCode = hashCode * 59 + this.IpsId.GetHashCode();
                if (this.IpsName != null) hashCode = hashCode * 59 + this.IpsName.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Software != null) hashCode = hashCode * 59 + this.Software.GetHashCode();
                if (this.SrcPort != null) hashCode = hashCode * 59 + this.SrcPort.GetHashCode();
                return hashCode;
            }
        }
    }
}
