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
    /// 
    /// </summary>
    public class ProductInfo 
    {

        /// <summary>
        /// 产品id。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 规格ID。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 产品类型。 - BASE：表示产品基础套餐，套餐镜像中不包括除操作系统之外的其他商业软件，私有镜像场景只能使用此类套餐。 - ADVANCED：表示产品高级套餐，套餐镜像中包括了一些商业软件。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 产品架构，当前仅支持x86。 - x86 - arm
        /// </summary>
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string Architecture { get; set; }

        /// <summary>
        /// CPU。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// CPU描述。
        /// </summary>
        [JsonProperty("cpu_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuDesc { get; set; }

        /// <summary>
        /// 内存大小，单位兆：MB。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public string Memory { get; set; }

        /// <summary>
        /// 是否是GPU类型的规格。
        /// </summary>
        [JsonProperty("is_gpu", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsGpu { get; set; }

        /// <summary>
        /// 系统盘类型。
        /// </summary>
        [JsonProperty("system_disk_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemDiskType { get; set; }

        /// <summary>
        /// 系统盘大小。
        /// </summary>
        [JsonProperty("system_disk_size", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemDiskSize { get; set; }

        /// <summary>
        /// GPU描述。
        /// </summary>
        [JsonProperty("gpu_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string GpuDesc { get; set; }

        /// <summary>
        /// 产品描述。
        /// </summary>
        [JsonProperty("descriptions", NullValueHandling = NullValueHandling.Ignore)]
        public string Descriptions { get; set; }

        /// <summary>
        /// 套餐标识。 - 1：表示包周期。 - 0：表示按需。
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 套餐计费是否包含了数据盘。
        /// </summary>
        [JsonProperty("contain_data_disk", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainDataDisk { get; set; }

        /// <summary>
        /// 资源类型。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 云服务类型。
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 磁盘产品类型： - workspace
        /// </summary>
        [JsonProperty("volume_product_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeProductType { get; set; }

        /// <summary>
        /// 套餐默认支持的最大会话数。
        /// </summary>
        [JsonProperty("sessions", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sessions { get; set; }

        /// <summary>
        /// 产品套餐在销售模式下的状态，取值自ECS的cond:operation:status。 不配置时等同于normal在售状态。 * &#x60;normal&#x60; - 正常商用 * &#x60;abandon&#x60; - 下线（即不显示） * &#x60;sellout&#x60; - 售罄 * &#x60;obt&#x60; - 公测 * &#x60;obt_sellout&#x60; - 公测售罄 * &#x60;promotion&#x60; - 推荐(等同normal，也是商用)
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 产品套餐在可用区的状态，配套status使用。 &gt; - 此参数是AZ级配置，优选取此参数的值，某个AZ没有在此参数中配置时默认使用status参数的取值。 &gt; - 配置格式“az(xx)”。()内为某个AZ的flavor状态，()内必须要填有状态，不填为无效配置。 &gt; - 例如：套餐在某个region的az0正常商用，az1售罄，az2公测，az3正常商用，其他az显示下线，可配置为： &gt;   - “status”设置为：“abandon” 。 &gt;   - “cond_operation_az”设置为：“az0(normal), az1(sellout), az2(obt), az3(normal)”。  &gt; -  说明：如果flavor在某个AZ下的状态与status配置状态不同，必须配置该参数。
        /// </summary>
        [JsonProperty("cond_operation_az", NullValueHandling = NullValueHandling.Ignore)]
        public string CondOperationAz { get; set; }

        /// <summary>
        /// 专属主机的子产品。
        /// </summary>
        [JsonProperty("sub_product_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubProductList { get; set; }

        /// <summary>
        /// 产品属于专有的domainId。
        /// </summary>
        [JsonProperty("domain_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// 套餐类型： - general：表示产品通用套餐。 - dedicated：表示产品专属主机套餐。
        /// </summary>
        [JsonProperty("package_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageType { get; set; }

        /// <summary>
        /// 系列类型： - d7 - c7
        /// </summary>
        [JsonProperty("series_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SeriesType { get; set; }

        /// <summary>
        /// 产品套餐过期时间,产品将在该时间点后逐步下架。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpireTime { get; set; }

        /// <summary>
        /// 产品套餐支持的GPU类型。
        /// </summary>
        [JsonProperty("support_gpu_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportGpuType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductInfo {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  cpuDesc: ").Append(CpuDesc).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  isGpu: ").Append(IsGpu).Append("\n");
            sb.Append("  systemDiskType: ").Append(SystemDiskType).Append("\n");
            sb.Append("  systemDiskSize: ").Append(SystemDiskSize).Append("\n");
            sb.Append("  gpuDesc: ").Append(GpuDesc).Append("\n");
            sb.Append("  descriptions: ").Append(Descriptions).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  containDataDisk: ").Append(ContainDataDisk).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  volumeProductType: ").Append(VolumeProductType).Append("\n");
            sb.Append("  sessions: ").Append(Sessions).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  condOperationAz: ").Append(CondOperationAz).Append("\n");
            sb.Append("  subProductList: ").Append(SubProductList).Append("\n");
            sb.Append("  domainIds: ").Append(DomainIds).Append("\n");
            sb.Append("  packageType: ").Append(PackageType).Append("\n");
            sb.Append("  seriesType: ").Append(SeriesType).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  supportGpuType: ").Append(SupportGpuType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductInfo input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Architecture != input.Architecture || (this.Architecture != null && !this.Architecture.Equals(input.Architecture))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.CpuDesc != input.CpuDesc || (this.CpuDesc != null && !this.CpuDesc.Equals(input.CpuDesc))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.IsGpu != input.IsGpu || (this.IsGpu != null && !this.IsGpu.Equals(input.IsGpu))) return false;
            if (this.SystemDiskType != input.SystemDiskType || (this.SystemDiskType != null && !this.SystemDiskType.Equals(input.SystemDiskType))) return false;
            if (this.SystemDiskSize != input.SystemDiskSize || (this.SystemDiskSize != null && !this.SystemDiskSize.Equals(input.SystemDiskSize))) return false;
            if (this.GpuDesc != input.GpuDesc || (this.GpuDesc != null && !this.GpuDesc.Equals(input.GpuDesc))) return false;
            if (this.Descriptions != input.Descriptions || (this.Descriptions != null && !this.Descriptions.Equals(input.Descriptions))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.ContainDataDisk != input.ContainDataDisk || (this.ContainDataDisk != null && !this.ContainDataDisk.Equals(input.ContainDataDisk))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.VolumeProductType != input.VolumeProductType || (this.VolumeProductType != null && !this.VolumeProductType.Equals(input.VolumeProductType))) return false;
            if (this.Sessions != input.Sessions || (this.Sessions != null && !this.Sessions.Equals(input.Sessions))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CondOperationAz != input.CondOperationAz || (this.CondOperationAz != null && !this.CondOperationAz.Equals(input.CondOperationAz))) return false;
            if (this.SubProductList != input.SubProductList || (this.SubProductList != null && input.SubProductList != null && !this.SubProductList.SequenceEqual(input.SubProductList))) return false;
            if (this.DomainIds != input.DomainIds || (this.DomainIds != null && input.DomainIds != null && !this.DomainIds.SequenceEqual(input.DomainIds))) return false;
            if (this.PackageType != input.PackageType || (this.PackageType != null && !this.PackageType.Equals(input.PackageType))) return false;
            if (this.SeriesType != input.SeriesType || (this.SeriesType != null && !this.SeriesType.Equals(input.SeriesType))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.SupportGpuType != input.SupportGpuType || (this.SupportGpuType != null && !this.SupportGpuType.Equals(input.SupportGpuType))) return false;

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
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Architecture != null) hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.CpuDesc != null) hashCode = hashCode * 59 + this.CpuDesc.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.IsGpu != null) hashCode = hashCode * 59 + this.IsGpu.GetHashCode();
                if (this.SystemDiskType != null) hashCode = hashCode * 59 + this.SystemDiskType.GetHashCode();
                if (this.SystemDiskSize != null) hashCode = hashCode * 59 + this.SystemDiskSize.GetHashCode();
                if (this.GpuDesc != null) hashCode = hashCode * 59 + this.GpuDesc.GetHashCode();
                if (this.Descriptions != null) hashCode = hashCode * 59 + this.Descriptions.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.ContainDataDisk != null) hashCode = hashCode * 59 + this.ContainDataDisk.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.VolumeProductType != null) hashCode = hashCode * 59 + this.VolumeProductType.GetHashCode();
                if (this.Sessions != null) hashCode = hashCode * 59 + this.Sessions.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CondOperationAz != null) hashCode = hashCode * 59 + this.CondOperationAz.GetHashCode();
                if (this.SubProductList != null) hashCode = hashCode * 59 + this.SubProductList.GetHashCode();
                if (this.DomainIds != null) hashCode = hashCode * 59 + this.DomainIds.GetHashCode();
                if (this.PackageType != null) hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.SeriesType != null) hashCode = hashCode * 59 + this.SeriesType.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.SupportGpuType != null) hashCode = hashCode * 59 + this.SupportGpuType.GetHashCode();
                return hashCode;
            }
        }
    }
}
