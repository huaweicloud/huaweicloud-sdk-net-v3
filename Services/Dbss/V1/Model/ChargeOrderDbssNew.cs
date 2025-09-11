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
    public class ChargeOrderDbssNew 
    {

        /// <summary>
        /// 资源标签列表
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTagInfoBean> Tags { get; set; }

        /// <summary>
        /// 资产数量
        /// </summary>
        [JsonProperty("asset_nums", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetNums { get; set; }

        /// <summary>
        /// 可用分区
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 计费模式
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 组合套餐
        /// </summary>
        [JsonProperty("composite_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompositeProductId { get; set; }

        /// <summary>
        /// 实例部署方式，默认为云上 - CLOUD： 云上 - OUTSIDE：云外
        /// </summary>
        [JsonProperty("deploy_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeployMode { get; set; }

        /// <summary>
        /// 折扣ID
        /// </summary>
        [JsonProperty("discount_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountId { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// ECS规格ID
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 前端登录密码
        /// </summary>
        [JsonProperty("hx_password", NullValueHandling = NullValueHandling.Ignore)]
        public string HxPassword { get; set; }

        /// <summary>
        /// 镜像业务类型
        /// </summary>
        [JsonProperty("image_business_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImageBusinessType { get; set; }

        /// <summary>
        /// 自费续费  - 1：自动  - 0：不自动
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoRenew { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 网卡信息
        /// </summary>
        [JsonProperty("nics", NullValueHandling = NullValueHandling.Ignore)]
        public List<Nic> Nics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("outside_ins_config", NullValueHandling = NullValueHandling.Ignore)]
        public OutsideInsConfig OutsideInsConfig { get; set; }

        /// <summary>
        /// 订购周期数目
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 订购周期类型
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodType { get; set; }

        /// <summary>
        /// 产品列表
        /// </summary>
        [JsonProperty("product_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductInfoBeanNew> ProductInfos { get; set; }

        /// <summary>
        /// 促销ID
        /// </summary>
        [JsonProperty("promotion_activity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionActivityId { get; set; }

        /// <summary>
        /// 折扣信息
        /// </summary>
        [JsonProperty("promotion_info", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public PublicIp PublicIp { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 安全组信息
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        /// 订购数量，当前仅支持1台
        /// </summary>
        [JsonProperty("subscription_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionNum { get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeOrderDbssNew {\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  assetNums: ").Append(AssetNums).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  compositeProductId: ").Append(CompositeProductId).Append("\n");
            sb.Append("  deployMode: ").Append(DeployMode).Append("\n");
            sb.Append("  discountId: ").Append(DiscountId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  hxPassword: ").Append(HxPassword).Append("\n");
            sb.Append("  imageBusinessType: ").Append(ImageBusinessType).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nics: ").Append(Nics).Append("\n");
            sb.Append("  outsideInsConfig: ").Append(OutsideInsConfig).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  productInfos: ").Append(ProductInfos).Append("\n");
            sb.Append("  promotionActivityId: ").Append(PromotionActivityId).Append("\n");
            sb.Append("  promotionInfo: ").Append(PromotionInfo).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  subscriptionNum: ").Append(SubscriptionNum).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChargeOrderDbssNew);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChargeOrderDbssNew input)
        {
            if (input == null) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.AssetNums != input.AssetNums || (this.AssetNums != null && !this.AssetNums.Equals(input.AssetNums))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;
            if (this.CompositeProductId != input.CompositeProductId || (this.CompositeProductId != null && !this.CompositeProductId.Equals(input.CompositeProductId))) return false;
            if (this.DeployMode != input.DeployMode || (this.DeployMode != null && !this.DeployMode.Equals(input.DeployMode))) return false;
            if (this.DiscountId != input.DiscountId || (this.DiscountId != null && !this.DiscountId.Equals(input.DiscountId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.HxPassword != input.HxPassword || (this.HxPassword != null && !this.HxPassword.Equals(input.HxPassword))) return false;
            if (this.ImageBusinessType != input.ImageBusinessType || (this.ImageBusinessType != null && !this.ImageBusinessType.Equals(input.ImageBusinessType))) return false;
            if (this.IsAutoRenew != input.IsAutoRenew || (this.IsAutoRenew != null && !this.IsAutoRenew.Equals(input.IsAutoRenew))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Nics != input.Nics || (this.Nics != null && input.Nics != null && !this.Nics.SequenceEqual(input.Nics))) return false;
            if (this.OutsideInsConfig != input.OutsideInsConfig || (this.OutsideInsConfig != null && !this.OutsideInsConfig.Equals(input.OutsideInsConfig))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.ProductInfos != input.ProductInfos || (this.ProductInfos != null && input.ProductInfos != null && !this.ProductInfos.SequenceEqual(input.ProductInfos))) return false;
            if (this.PromotionActivityId != input.PromotionActivityId || (this.PromotionActivityId != null && !this.PromotionActivityId.Equals(input.PromotionActivityId))) return false;
            if (this.PromotionInfo != input.PromotionInfo || (this.PromotionInfo != null && !this.PromotionInfo.Equals(input.PromotionInfo))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.SubscriptionNum != input.SubscriptionNum || (this.SubscriptionNum != null && !this.SubscriptionNum.Equals(input.SubscriptionNum))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;

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
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.AssetNums != null) hashCode = hashCode * 59 + this.AssetNums.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.CompositeProductId != null) hashCode = hashCode * 59 + this.CompositeProductId.GetHashCode();
                if (this.DeployMode != null) hashCode = hashCode * 59 + this.DeployMode.GetHashCode();
                if (this.DiscountId != null) hashCode = hashCode * 59 + this.DiscountId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.FlavorRef != null) hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.HxPassword != null) hashCode = hashCode * 59 + this.HxPassword.GetHashCode();
                if (this.ImageBusinessType != null) hashCode = hashCode * 59 + this.ImageBusinessType.GetHashCode();
                if (this.IsAutoRenew != null) hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Nics != null) hashCode = hashCode * 59 + this.Nics.GetHashCode();
                if (this.OutsideInsConfig != null) hashCode = hashCode * 59 + this.OutsideInsConfig.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.ProductInfos != null) hashCode = hashCode * 59 + this.ProductInfos.GetHashCode();
                if (this.PromotionActivityId != null) hashCode = hashCode * 59 + this.PromotionActivityId.GetHashCode();
                if (this.PromotionInfo != null) hashCode = hashCode * 59 + this.PromotionInfo.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.SubscriptionNum != null) hashCode = hashCode * 59 + this.SubscriptionNum.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                return hashCode;
            }
        }
    }
}
