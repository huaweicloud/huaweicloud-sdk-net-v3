using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Product 
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
        /// 产品类型。取值为： BASE：表示产品基础套餐，套餐镜像中不包括除操作系统之外的其他商业软件，私有镜像场景只能使用此类套餐。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 产品架构，当前支持：arm、x86。
        /// </summary>
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string Architecture { get; set; }

        /// <summary>
        /// cpu。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// cpu描述。
        /// </summary>
        [JsonProperty("cpu_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuDesc { get; set; }

        /// <summary>
        /// 内存。
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
        /// 系统盘大小，单位GB。
        /// </summary>
        [JsonProperty("system_disk_size", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemDiskSize { get; set; }

        /// <summary>
        /// 数据盘大小，单位GB。
        /// </summary>
        [JsonProperty("data_disk_size", NullValueHandling = NullValueHandling.Ignore)]
        public string DataDiskSize { get; set; }

        /// <summary>
        /// GPU描述。
        /// </summary>
        [JsonProperty("gpu_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string GpuDesc { get; set; }

        /// <summary>
        /// 话单开关，默认on,on-出话单模式,off-关话单模式,只支持反序列化，不支持序列化，不在接口中展示。
        /// </summary>
        [JsonProperty("bill_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string BillSwitch { get; set; }

        /// <summary>
        /// 产品描述。
        /// </summary>
        [JsonProperty("descriptions", NullValueHandling = NullValueHandling.Ignore)]
        public string Descriptions { get; set; }

        /// <summary>
        /// 产品名称&lt;语言，各语言对应的产品描述&gt;。
        /// </summary>
        [JsonProperty("product_desc", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ProductDesc { get; set; }

        /// <summary>
        /// 周期套餐标识。0表示包周期，1表示按需。
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 套餐计费是否包含了数据盘,off-不包含。
        /// </summary>
        [JsonProperty("contain_data_disk", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainDataDisk { get; set; }

        /// <summary>
        /// 资源规格。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 云服务编码。
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 磁盘产品类型。
        /// </summary>
        [JsonProperty("volume_product_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeProductType { get; set; }

        /// <summary>
        /// 该产品套餐支持的专有域id（domainId）。
        /// </summary>
        [JsonProperty("domain_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// 产品状态，normal：正常、sellout：售空、abandon：下线。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 套餐类型。 - ultimate：尊享版 - enterprise：企业版 - general: 通用办公版 - workstation: 云工作站 - dedicated: 专属办公版 - solver: 解算版 - agile: 敏捷办公版
        /// </summary>
        [JsonProperty("package_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageType { get; set; }

        /// <summary>
        /// 产品名称&lt;语言，各语言对应的产品名&gt;。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// 协同方数。该套餐支持的最大协同人数。
        /// </summary>
        [JsonProperty("share_space_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShareSpaceSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
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
            sb.Append("  dataDiskSize: ").Append(DataDiskSize).Append("\n");
            sb.Append("  gpuDesc: ").Append(GpuDesc).Append("\n");
            sb.Append("  billSwitch: ").Append(BillSwitch).Append("\n");
            sb.Append("  descriptions: ").Append(Descriptions).Append("\n");
            sb.Append("  productDesc: ").Append(ProductDesc).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  containDataDisk: ").Append(ContainDataDisk).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  volumeProductType: ").Append(VolumeProductType).Append("\n");
            sb.Append("  domainIds: ").Append(DomainIds).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  packageType: ").Append(PackageType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  shareSpaceSize: ").Append(ShareSpaceSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Product);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Product input)
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
            if (this.DataDiskSize != input.DataDiskSize || (this.DataDiskSize != null && !this.DataDiskSize.Equals(input.DataDiskSize))) return false;
            if (this.GpuDesc != input.GpuDesc || (this.GpuDesc != null && !this.GpuDesc.Equals(input.GpuDesc))) return false;
            if (this.BillSwitch != input.BillSwitch || (this.BillSwitch != null && !this.BillSwitch.Equals(input.BillSwitch))) return false;
            if (this.Descriptions != input.Descriptions || (this.Descriptions != null && !this.Descriptions.Equals(input.Descriptions))) return false;
            if (this.ProductDesc != input.ProductDesc || (this.ProductDesc != null && input.ProductDesc != null && !this.ProductDesc.SequenceEqual(input.ProductDesc))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.ContainDataDisk != input.ContainDataDisk || (this.ContainDataDisk != null && !this.ContainDataDisk.Equals(input.ContainDataDisk))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.VolumeProductType != input.VolumeProductType || (this.VolumeProductType != null && !this.VolumeProductType.Equals(input.VolumeProductType))) return false;
            if (this.DomainIds != input.DomainIds || (this.DomainIds != null && input.DomainIds != null && !this.DomainIds.SequenceEqual(input.DomainIds))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PackageType != input.PackageType || (this.PackageType != null && !this.PackageType.Equals(input.PackageType))) return false;
            if (this.Name != input.Name || (this.Name != null && input.Name != null && !this.Name.SequenceEqual(input.Name))) return false;
            if (this.ShareSpaceSize != input.ShareSpaceSize || (this.ShareSpaceSize != null && !this.ShareSpaceSize.Equals(input.ShareSpaceSize))) return false;

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
                if (this.DataDiskSize != null) hashCode = hashCode * 59 + this.DataDiskSize.GetHashCode();
                if (this.GpuDesc != null) hashCode = hashCode * 59 + this.GpuDesc.GetHashCode();
                if (this.BillSwitch != null) hashCode = hashCode * 59 + this.BillSwitch.GetHashCode();
                if (this.Descriptions != null) hashCode = hashCode * 59 + this.Descriptions.GetHashCode();
                if (this.ProductDesc != null) hashCode = hashCode * 59 + this.ProductDesc.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.ContainDataDisk != null) hashCode = hashCode * 59 + this.ContainDataDisk.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.VolumeProductType != null) hashCode = hashCode * 59 + this.VolumeProductType.GetHashCode();
                if (this.DomainIds != null) hashCode = hashCode * 59 + this.DomainIds.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PackageType != null) hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ShareSpaceSize != null) hashCode = hashCode * 59 + this.ShareSpaceSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
