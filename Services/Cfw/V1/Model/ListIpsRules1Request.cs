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
    public class ListIpsRules1Request 
    {

        /// <summary>
        /// 攻击对象
        /// </summary>
        [SDKProperty("affected_application_like", IsQuery = true)]
        [JsonProperty("affected_application_like", NullValueHandling = NullValueHandling.Ignore)]
        public int? AffectedApplicationLike { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [SDKProperty("create_time", IsQuery = true)]
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 防火墙ID，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取
        /// </summary>
        [SDKProperty("fw_instance_id", IsQuery = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// cve
        /// </summary>
        [SDKProperty("ips_cve_like", IsQuery = true)]
        [JsonProperty("ips_cve_like", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpsCveLike { get; set; }

        /// <summary>
        /// ips组
        /// </summary>
        [SDKProperty("ips_group", IsQuery = true)]
        [JsonProperty("ips_group", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpsGroup { get; set; }

        /// <summary>
        /// ips规则id
        /// </summary>
        [SDKProperty("ips_id", IsQuery = true)]
        [JsonProperty("ips_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsId { get; set; }

        /// <summary>
        /// ips等级
        /// </summary>
        [SDKProperty("ips_level", IsQuery = true)]
        [JsonProperty("ips_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpsLevel { get; set; }

        /// <summary>
        /// ips规则名称
        /// </summary>
        [SDKProperty("ips_name_like", IsQuery = true)]
        [JsonProperty("ips_name_like", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsNameLike { get; set; }

        /// <summary>
        /// ips规则类型
        /// </summary>
        [SDKProperty("ips_rules_type_like", IsQuery = true)]
        [JsonProperty("ips_rules_type_like", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpsRulesTypeLike { get; set; }

        /// <summary>
        /// ips规则状态
        /// </summary>
        [SDKProperty("ips_status", IsQuery = true)]
        [JsonProperty("ips_status", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsStatus { get; set; }

        /// <summary>
        /// 是否查新更新规则
        /// </summary>
        [SDKProperty("is_updated_ips_rule_queried", IsQuery = true)]
        [JsonProperty("is_updated_ips_rule_queried", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUpdatedIpsRuleQueried { get; set; }

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
            sb.Append("class ListIpsRules1Request {\n");
            sb.Append("  affectedApplicationLike: ").Append(AffectedApplicationLike).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  ipsCveLike: ").Append(IpsCveLike).Append("\n");
            sb.Append("  ipsGroup: ").Append(IpsGroup).Append("\n");
            sb.Append("  ipsId: ").Append(IpsId).Append("\n");
            sb.Append("  ipsLevel: ").Append(IpsLevel).Append("\n");
            sb.Append("  ipsNameLike: ").Append(IpsNameLike).Append("\n");
            sb.Append("  ipsRulesTypeLike: ").Append(IpsRulesTypeLike).Append("\n");
            sb.Append("  ipsStatus: ").Append(IpsStatus).Append("\n");
            sb.Append("  isUpdatedIpsRuleQueried: ").Append(IsUpdatedIpsRuleQueried).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIpsRules1Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIpsRules1Request input)
        {
            if (input == null) return false;
            if (this.AffectedApplicationLike != input.AffectedApplicationLike || (this.AffectedApplicationLike != null && !this.AffectedApplicationLike.Equals(input.AffectedApplicationLike))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.IpsCveLike != input.IpsCveLike || (this.IpsCveLike != null && !this.IpsCveLike.Equals(input.IpsCveLike))) return false;
            if (this.IpsGroup != input.IpsGroup || (this.IpsGroup != null && !this.IpsGroup.Equals(input.IpsGroup))) return false;
            if (this.IpsId != input.IpsId || (this.IpsId != null && !this.IpsId.Equals(input.IpsId))) return false;
            if (this.IpsLevel != input.IpsLevel || (this.IpsLevel != null && !this.IpsLevel.Equals(input.IpsLevel))) return false;
            if (this.IpsNameLike != input.IpsNameLike || (this.IpsNameLike != null && !this.IpsNameLike.Equals(input.IpsNameLike))) return false;
            if (this.IpsRulesTypeLike != input.IpsRulesTypeLike || (this.IpsRulesTypeLike != null && !this.IpsRulesTypeLike.Equals(input.IpsRulesTypeLike))) return false;
            if (this.IpsStatus != input.IpsStatus || (this.IpsStatus != null && !this.IpsStatus.Equals(input.IpsStatus))) return false;
            if (this.IsUpdatedIpsRuleQueried != input.IsUpdatedIpsRuleQueried || (this.IsUpdatedIpsRuleQueried != null && !this.IsUpdatedIpsRuleQueried.Equals(input.IsUpdatedIpsRuleQueried))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
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
                if (this.AffectedApplicationLike != null) hashCode = hashCode * 59 + this.AffectedApplicationLike.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.IpsCveLike != null) hashCode = hashCode * 59 + this.IpsCveLike.GetHashCode();
                if (this.IpsGroup != null) hashCode = hashCode * 59 + this.IpsGroup.GetHashCode();
                if (this.IpsId != null) hashCode = hashCode * 59 + this.IpsId.GetHashCode();
                if (this.IpsLevel != null) hashCode = hashCode * 59 + this.IpsLevel.GetHashCode();
                if (this.IpsNameLike != null) hashCode = hashCode * 59 + this.IpsNameLike.GetHashCode();
                if (this.IpsRulesTypeLike != null) hashCode = hashCode * 59 + this.IpsRulesTypeLike.GetHashCode();
                if (this.IpsStatus != null) hashCode = hashCode * 59 + this.IpsStatus.GetHashCode();
                if (this.IsUpdatedIpsRuleQueried != null) hashCode = hashCode * 59 + this.IsUpdatedIpsRuleQueried.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
