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
        /// 动作（0：只记录日志，1：重置/拦截）
        /// </summary>
        [SDKProperty("action_type", IsQuery = true)]
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionType { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        [SDKProperty("affected_os", IsQuery = true)]
        [JsonProperty("affected_os", NullValueHandling = NullValueHandling.Ignore)]
        public int? AffectedOs { get; set; }

        /// <summary>
        /// 攻击类型
        /// </summary>
        [SDKProperty("attack_type", IsQuery = true)]
        [JsonProperty("attack_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttackType { get; set; }

        /// <summary>
        /// 防火墙ID，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取
        /// </summary>
        [SDKProperty("fw_instance_id", IsQuery = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// ips规则名称
        /// </summary>
        [SDKProperty("ips_name", IsQuery = true)]
        [JsonProperty("ips_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsName { get; set; }

        /// <summary>
        /// 分页查询数据量限制
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 防护对象ID，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得，注意type为0的为互联网边界防护对象id，type为1的为VPC边界防护对象id。此处仅取type为1的防护对象id，可通过data.records.protect_objects.type（.表示各对象之间层级的区分）获得。
        /// </summary>
        [SDKProperty("object_id", IsQuery = true)]
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 查询偏移量
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [SDKProperty("protocol", IsQuery = true)]
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public int? Protocol { get; set; }

        /// <summary>
        /// 严重程度（critical：致命，high：高危，medium:中危，low:低危）
        /// </summary>
        [SDKProperty("severity", IsQuery = true)]
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Severity { get; set; }

        /// <summary>
        /// 影响软件
        /// </summary>
        [SDKProperty("software", IsQuery = true)]
        [JsonProperty("software", NullValueHandling = NullValueHandling.Ignore)]
        public int? Software { get; set; }

        /// <summary>
        /// 企业项目ID，用户根据组织规划企业项目，对应的ID为企业项目ID，可通过[如何获取企业项目ID](cfw_02_0027.xml)获取，用户未开启企业项目时为0
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



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
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  ipsName: ").Append(IpsName).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  software: ").Append(Software).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
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
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.IpsName != input.IpsName || (this.IpsName != null && !this.IpsName.Equals(input.IpsName))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.Software != input.Software || (this.Software != null && !this.Software.Equals(input.Software))) return false;
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
                if (this.ActionType != null) hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.AffectedOs != null) hashCode = hashCode * 59 + this.AffectedOs.GetHashCode();
                if (this.AttackType != null) hashCode = hashCode * 59 + this.AttackType.GetHashCode();
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.IpsName != null) hashCode = hashCode * 59 + this.IpsName.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Software != null) hashCode = hashCode * 59 + this.Software.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
