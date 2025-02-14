using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateInstancePeriodRequest 
    {

        /// <summary>
        /// 实例名称。取值范围： - 只能由中文字符、英文字母、数字、下划线、中划线组成，且长度小于等于64个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 云服务器使用的规格ID
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 虚拟私有云的ID
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 云服务器对应可用分区信息。(两个主备分区，中间用“,”分割，例如az1.dc1,az2.dc2)。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 企业项目ID。对接EPS必输。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 云服务器对应的网卡信息
        /// </summary>
        [JsonProperty("nics", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateInstancePeriodRequestNics> Nics { get; set; }

        /// <summary>
        /// 云服务器对应安全组信息
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateInstancePeriodRequestSecurityGroups> SecurityGroups { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 云服务器所在区域ID
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 服务类型： - hws.service.type.dbss
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 计费模式： - 0: 包周期计费 - 1: 按需计费
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// -订购周期类型 - 0: 天 - 1：周 - 2：月 - 3：年 - 4: 小时 - 5: 绝对时间
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodType { get; set; }

        /// <summary>
        /// 订购周期数
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 订购数量： DBSS只支持订购1套，不支持多套
        /// </summary>
        [JsonProperty("subscription_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionNum { get; set; }

        /// <summary>
        /// 产品信息列表
        /// </summary>
        [JsonProperty("product_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateInstancePeriodRequestProductInfos> ProductInfos { get; set; }

        /// <summary>
        /// 资源标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<KeyValueBean> Tags { get; set; }

        /// <summary>
        /// 折扣信息
        /// </summary>
        [JsonProperty("promotion_info", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionInfo { get; set; }

        /// <summary>
        /// 自动续费 - 1: 自动续费 - 0: 不自动续费
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoRenew { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInstancePeriodRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  nics: ").Append(Nics).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  subscriptionNum: ").Append(SubscriptionNum).Append("\n");
            sb.Append("  productInfos: ").Append(ProductInfos).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  promotionInfo: ").Append(PromotionInfo).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInstancePeriodRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstancePeriodRequest input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Nics != input.Nics || (this.Nics != null && input.Nics != null && !this.Nics.SequenceEqual(input.Nics))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.SubscriptionNum != input.SubscriptionNum || (this.SubscriptionNum != null && !this.SubscriptionNum.Equals(input.SubscriptionNum))) return false;
            if (this.ProductInfos != input.ProductInfos || (this.ProductInfos != null && input.ProductInfos != null && !this.ProductInfos.SequenceEqual(input.ProductInfos))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.PromotionInfo != input.PromotionInfo || (this.PromotionInfo != null && !this.PromotionInfo.Equals(input.PromotionInfo))) return false;
            if (this.IsAutoRenew != input.IsAutoRenew || (this.IsAutoRenew != null && !this.IsAutoRenew.Equals(input.IsAutoRenew))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FlavorRef != null) hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Nics != null) hashCode = hashCode * 59 + this.Nics.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.SubscriptionNum != null) hashCode = hashCode * 59 + this.SubscriptionNum.GetHashCode();
                if (this.ProductInfos != null) hashCode = hashCode * 59 + this.ProductInfos.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.PromotionInfo != null) hashCode = hashCode * 59 + this.PromotionInfo.GetHashCode();
                if (this.IsAutoRenew != null) hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                return hashCode;
            }
        }
    }
}
