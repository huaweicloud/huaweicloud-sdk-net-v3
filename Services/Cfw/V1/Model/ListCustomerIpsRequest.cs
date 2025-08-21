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
    /// Request Object
    /// </summary>
    public class ListCustomerIpsRequest 
    {

        /// <summary>
        /// **参数解释**： 动作 **约束限制**： 不涉及 **取值范围**： 0 仅记录日志 1 拦截session 2 拦截ip **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("action_type", IsQuery = true)]
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionType { get; set; }

        /// <summary>
        /// **参数解释**： 影响操作系统 **约束限制**： 不涉及 **取值范围**： 0 any、1 Windows、2 Linux、3 FreeBSD、4 Solaris、5 other Unix、6 网络设备、7 Mac OS、8 ios、9 android、10 others **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("affected_os", IsQuery = true)]
        [JsonProperty("affected_os", NullValueHandling = NullValueHandling.Ignore)]
        public int? AffectedOs { get; set; }

        /// <summary>
        /// **参数解释**： 攻击类型 **约束限制**： 不涉及 **取值范围**： 1：访问控制、2：漏洞扫描、3：邮件攻击、4：漏洞攻击、5：Web攻击、6：密码攻击、7：劫持攻击、8：协议异常、9：特洛伊木马、10：蠕虫、11：缓冲区溢出、12：黑客工具、13：间谍软件、14：DDos泛洪、15：应用层DDos攻击、16：其他可疑行为、17：可疑DNS活动、18：网络钓鱼、19：垃圾邮件、20：其他攻击 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("attack_type", IsQuery = true)]
        [JsonProperty("attack_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttackType { get; set; }

        /// <summary>
        /// **参数解释**： ips规则名称 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("ips_name", IsQuery = true)]
        [JsonProperty("ips_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsName { get; set; }

        /// <summary>
        /// **参数解释**： ips规则的id **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("ips_id", IsQuery = true)]
        [JsonProperty("ips_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsId { get; set; }

        /// <summary>
        /// **参数解释**： 协议类型 **约束限制**： 不涉及 **取值范围**： 1 FTP、2 TELNET、3 SMTP、4 DNS_TCP、5 DNS_UDP、6 DHCP、7 TFTP、8 FINGER、9 HTTP、10 POP3、11 SUNRPC_TCP、12 SUNRPC_UDP、13 NNTP、14 MSRPC_TCP、15 MSRPC_UDP、16 NETBIOS_NAME_TCP、17 NETBIOS_NAME_UDP、18 NETBIOS_SMB、19 NETBIOS_DATAGRAM、20 IMAP4、21 SNMP、22 LDAP、23 MSSQL、24 ORACLE **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("protocol", IsQuery = true)]
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public int? Protocol { get; set; }

        /// <summary>
        /// **参数解释**： 严重程度 **约束限制**： 不涉及 **取值范围**： critical：致命，high：高危，medium:中危，low:低危 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("severity", IsQuery = true)]
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Severity { get; set; }

        /// <summary>
        /// **参数解释**： 影响软件 **约束限制**： 不涉及 **取值范围**： 0 ANY、1 ADOBE、2 APACHE、3 APPLE、4 CA、5 CISCO、6 GOOGLE_CHROME、7 HP、8 IBM、9 IE、10 IIS、11 MC_AFEE、12 MEDIA_PLAYER、13 MICROSOFT_NET、14 MICROSOFT_EDGE、15 MICROSOFT_EXCHANGE、16 MICROSOFT_OFFICE、17 MICROSOFT_OUTLOOK、18 MICROSOFT_SHARE_POINT、19 MICROSOFT_WINDOWS、20 MOZILLA、21 MSSQL、22 MYSQL、23 NOVELL、24 ORACLE、25 SAMBA、26 SAMSUNG、27 SAP、28 SCADA、29 SQUID、30 SUN、31 SYMANTEC、32 TREND_MICRO、33 VMWARE、34 WORD_PRESS、35 Others **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("software", IsQuery = true)]
        [JsonProperty("software", NullValueHandling = NullValueHandling.Ignore)]
        public int? Software { get; set; }

        /// <summary>
        /// 防护对象ID，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得，注意type为0的为互联网边界防护对象id，type为1的为VPC边界防护对象id。此处仅取type为1的防护对象id，可通过data.records.protect_objects.type（.表示各对象之间层级的区分）获得。
        /// </summary>
        [SDKProperty("object_id", IsQuery = true)]
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 企业项目ID，用户根据组织规划企业项目，对应的ID为企业项目ID，可通过[如何获取企业项目ID](cfw_02_0027.xml)获取，用户未开启企业项目时为0
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙ID，用户创建防火墙实例后产生的唯一ID，配置后可区分不同防火墙，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("fw_instance_id", IsQuery = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 查询返回记录的数量限制 **约束限制**： 不涉及 **取值范围**： 1-1024 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 偏移量，表示查询该偏移量后面的记录 **约束限制**： 不涉及 **取值范围**： 0 - 1024 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCustomerIpsRequest {\n");
            sb.Append("  actionType: ").Append(ActionType).Append("\n");
            sb.Append("  affectedOs: ").Append(AffectedOs).Append("\n");
            sb.Append("  attackType: ").Append(AttackType).Append("\n");
            sb.Append("  ipsName: ").Append(IpsName).Append("\n");
            sb.Append("  ipsId: ").Append(IpsId).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  software: ").Append(Software).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCustomerIpsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCustomerIpsRequest input)
        {
            if (input == null) return false;
            if (this.ActionType != input.ActionType || (this.ActionType != null && !this.ActionType.Equals(input.ActionType))) return false;
            if (this.AffectedOs != input.AffectedOs || (this.AffectedOs != null && !this.AffectedOs.Equals(input.AffectedOs))) return false;
            if (this.AttackType != input.AttackType || (this.AttackType != null && !this.AttackType.Equals(input.AttackType))) return false;
            if (this.IpsName != input.IpsName || (this.IpsName != null && !this.IpsName.Equals(input.IpsName))) return false;
            if (this.IpsId != input.IpsId || (this.IpsId != null && !this.IpsId.Equals(input.IpsId))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.Software != input.Software || (this.Software != null && !this.Software.Equals(input.Software))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.ActionType != null) hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.AffectedOs != null) hashCode = hashCode * 59 + this.AffectedOs.GetHashCode();
                if (this.AttackType != null) hashCode = hashCode * 59 + this.AttackType.GetHashCode();
                if (this.IpsName != null) hashCode = hashCode * 59 + this.IpsName.GetHashCode();
                if (this.IpsId != null) hashCode = hashCode * 59 + this.IpsId.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Software != null) hashCode = hashCode * 59 + this.Software.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
