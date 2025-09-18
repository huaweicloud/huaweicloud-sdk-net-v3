using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 创建镜像实例请求。
    /// </summary>
    public class CreateImageServerReq 
    {

        /// <summary>
        /// 镜像实例名称，名称需满足如下规则: 1. 由中文，英文大小写，数字，_-组成，不能有空格 2. 长度范围1~64个字符
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 镜像实例描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_volume", NullValueHandling = NullValueHandling.Ignore)]
        public Volume RootVolume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_ref", NullValueHandling = NullValueHandling.Ignore)]
        public ImageRef ImageRef { get; set; }

        /// <summary>
        /// 镜像实例所属虚拟私有云唯一标识。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 镜像实例网卡对应的子网唯一标识。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 镜像实例产品套餐ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 规格ID。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 镜像实例的可用区，空值表示随机选取可用区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 云应用仓库软件唯一标识请求列表。
        /// </summary>
        [JsonProperty("attach_apps", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AttachApps { get; set; }

        /// <summary>
        /// 应用组授权用户， * 限制用户类型：&#39;USER&#39; - 用户
        /// </summary>
        [JsonProperty("authorize_accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageAccountInfo> AuthorizeAccounts { get; set; }

        /// <summary>
        /// 组织名称。
        /// </summary>
        [JsonProperty("ou_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OuName { get; set; }

        /// <summary>
        /// 是否为vdi单会话模式。
        /// </summary>
        [JsonProperty("is_vdi", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVdi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scheduler_hints", NullValueHandling = NullValueHandling.Ignore)]
        public WdhParam SchedulerHints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_session_type", NullValueHandling = NullValueHandling.Ignore)]
        public ExtraSessionTypeEnum? ExtraSessionType { get; set; }

        /// <summary>
        /// 需要付费的会话数，单位/个。
        /// </summary>
        [JsonProperty("extra_session_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExtraSessionSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("route_policy", NullValueHandling = NullValueHandling.Ignore)]
        public RoutePolicy RoutePolicy { get; set; }

        /// <summary>
        /// 标签信息，最多包含20个key,不允许重复。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TmsTag> Tags { get; set; }

        /// <summary>
        /// **⚠ : 此属性是预留字段，不需要传值，目前镜像产物默认属于default企业项目** 镜像所属的企业项目ID，默认属于default企业项目。 关于企业项目ID的获取及企业项目特性的详细信息，请参考“[企业中心总览](https://support.huaweicloud.com/zh-cn/usermanual-em/zh-cn_topic_0123692049.html)”。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateImageServerReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  imageRef: ").Append(ImageRef).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  attachApps: ").Append(AttachApps).Append("\n");
            sb.Append("  authorizeAccounts: ").Append(AuthorizeAccounts).Append("\n");
            sb.Append("  ouName: ").Append(OuName).Append("\n");
            sb.Append("  isVdi: ").Append(IsVdi).Append("\n");
            sb.Append("  schedulerHints: ").Append(SchedulerHints).Append("\n");
            sb.Append("  extraSessionType: ").Append(ExtraSessionType).Append("\n");
            sb.Append("  extraSessionSize: ").Append(ExtraSessionSize).Append("\n");
            sb.Append("  routePolicy: ").Append(RoutePolicy).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateImageServerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateImageServerReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.ImageRef != input.ImageRef || (this.ImageRef != null && !this.ImageRef.Equals(input.ImageRef))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.AttachApps != input.AttachApps || (this.AttachApps != null && input.AttachApps != null && !this.AttachApps.SequenceEqual(input.AttachApps))) return false;
            if (this.AuthorizeAccounts != input.AuthorizeAccounts || (this.AuthorizeAccounts != null && input.AuthorizeAccounts != null && !this.AuthorizeAccounts.SequenceEqual(input.AuthorizeAccounts))) return false;
            if (this.OuName != input.OuName || (this.OuName != null && !this.OuName.Equals(input.OuName))) return false;
            if (this.IsVdi != input.IsVdi || (this.IsVdi != null && !this.IsVdi.Equals(input.IsVdi))) return false;
            if (this.SchedulerHints != input.SchedulerHints || (this.SchedulerHints != null && !this.SchedulerHints.Equals(input.SchedulerHints))) return false;
            if (this.ExtraSessionType != input.ExtraSessionType || (this.ExtraSessionType != null && !this.ExtraSessionType.Equals(input.ExtraSessionType))) return false;
            if (this.ExtraSessionSize != input.ExtraSessionSize || (this.ExtraSessionSize != null && !this.ExtraSessionSize.Equals(input.ExtraSessionSize))) return false;
            if (this.RoutePolicy != input.RoutePolicy || (this.RoutePolicy != null && !this.RoutePolicy.Equals(input.RoutePolicy))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.ImageRef != null) hashCode = hashCode * 59 + this.ImageRef.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.AttachApps != null) hashCode = hashCode * 59 + this.AttachApps.GetHashCode();
                if (this.AuthorizeAccounts != null) hashCode = hashCode * 59 + this.AuthorizeAccounts.GetHashCode();
                if (this.OuName != null) hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.IsVdi != null) hashCode = hashCode * 59 + this.IsVdi.GetHashCode();
                if (this.SchedulerHints != null) hashCode = hashCode * 59 + this.SchedulerHints.GetHashCode();
                if (this.ExtraSessionType != null) hashCode = hashCode * 59 + this.ExtraSessionType.GetHashCode();
                if (this.ExtraSessionSize != null) hashCode = hashCode * 59 + this.ExtraSessionSize.GetHashCode();
                if (this.RoutePolicy != null) hashCode = hashCode * 59 + this.RoutePolicy.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
