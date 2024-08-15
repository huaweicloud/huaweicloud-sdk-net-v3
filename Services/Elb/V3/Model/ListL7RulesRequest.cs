using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListL7RulesRequest 
    {

        /// <summary>
        /// 策略ID。
        /// </summary>
        [SDKProperty("l7policy_id", IsPath = true)]
        [JsonProperty("l7policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7policyId { get; set; }

        /// <summary>
        /// 参数解释：每页返回的个数。  取值范围：0-2000  默认取值：2000
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 上一页最后一条记录的ID。  使用说明： - 必须与limit一起使用。 - 不指定时表示查询第一页。 - 该字段不允许为空或无效的ID。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 是否反向查询。  取值： - true：查询上一页。 - false：查询下一页，默认。  使用说明： - 必须与limit一起使用。 - 当page_reverse&#x3D;true时，若要查询上一页，marker取值为当前页返回值的previous_marker。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 转发规则ID。  支持多值查询，查询条件格式：*id&#x3D;xxx&amp;id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 转发匹配方式。  取值： - EQUAL_TO 表示精确匹配。 - REGEX 表示正则匹配。 - STARTS_WITH 表示前缀匹配。  支持多值查询，查询条件格式：*compare_type&#x3D;xxx&amp;compare_type&#x3D;xxx*。
        /// </summary>
        [SDKProperty("compare_type", IsQuery = true)]
        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CompareType { get; set; }

        /// <summary>
        /// 转发规则的配置状态。  取值：ACTIVE 表示正常。  支持多值查询，查询条件格式：*provisioning_status&#x3D;xxx&amp;provisioning_status&#x3D;xxx*。
        /// </summary>
        [SDKProperty("provisioning_status", IsQuery = true)]
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProvisioningStatus { get; set; }

        /// <summary>
        /// 是否反向匹配。使用说明：固定为false。该字段能更新但不会生效。
        /// </summary>
        [SDKProperty("invert", IsQuery = true)]
        [JsonProperty("invert", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invert { get; set; }

        /// <summary>
        /// 转发规则的管理状态。  不支持该字段，请勿使用。
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 匹配内容的值。  支持多值查询，查询条件格式：*value&#x3D;xxx&amp;value&#x3D;xxx*。
        /// </summary>
        [SDKProperty("value", IsQuery = true)]
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Value { get; set; }

        /// <summary>
        /// 匹配内容的键值，用于标识规则。  支持多值查询，查询条件格式：*key&#x3D;xxx&amp;key&#x3D;xxx*。  不支持该字段，请勿使用。
        /// </summary>
        [SDKProperty("key", IsQuery = true)]
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Key { get; set; }

        /// <summary>
        /// 匹配类别，可以为HOST_NAME，PATH。  一个l7policy下创建的l7rule的type不能重复。  支持多值查询，查询条件格式：*type&#x3D;xxx&amp;type&#x3D;xxx*。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Type { get; set; }

        /// <summary>
        /// 企业项目ID。不传时查询default企业项目\&quot;0\&quot;下的资源，鉴权按照default企业项目鉴权； 如果传值，则传已存在的企业项目ID或all_granted_eps（表示查询所有企业项目）进行查询。  支持多值查询，查询条件格式：*enterprise_project_id&#x3D;xxx&amp;enterprise_project_id&#x3D;xxx*。  [不支持该字段，请勿使用。](tag:dt,dt_test,hcso_dt)
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListL7RulesRequest {\n");
            sb.Append("  l7policyId: ").Append(L7policyId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  invert: ").Append(Invert).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListL7RulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListL7RulesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.L7policyId == input.L7policyId ||
                    (this.L7policyId != null &&
                    this.L7policyId.Equals(input.L7policyId))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.CompareType == input.CompareType ||
                    this.CompareType != null &&
                    input.CompareType != null &&
                    this.CompareType.SequenceEqual(input.CompareType)
                ) && 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    this.ProvisioningStatus != null &&
                    input.ProvisioningStatus != null &&
                    this.ProvisioningStatus.SequenceEqual(input.ProvisioningStatus)
                ) && 
                (
                    this.Invert == input.Invert ||
                    (this.Invert != null &&
                    this.Invert.Equals(input.Invert))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) && 
                (
                    this.Key == input.Key ||
                    this.Key != null &&
                    input.Key != null &&
                    this.Key.SequenceEqual(input.Key)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    input.Type != null &&
                    this.Type.SequenceEqual(input.Type)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    this.EnterpriseProjectId != null &&
                    input.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.L7policyId != null)
                    hashCode = hashCode * 59 + this.L7policyId.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CompareType != null)
                    hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.Invert != null)
                    hashCode = hashCode * 59 + this.Invert.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
