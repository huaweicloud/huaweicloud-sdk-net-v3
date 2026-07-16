using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Flavor 
    {

        /// <summary>
        /// **参数解释**：硬件架构类型。 **取值范围**：枚举类型，取值如下： - x86_64：X86架构。 - aarch64：ARM架构。
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public string Arch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public BillingInfo Billing { get; set; }

        /// <summary>
        /// **参数解释**：处理器类型。 **取值范围**：枚举类型，取值如下： - CPU - GPU - ASCEND
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**：规格描述信息。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：规格包含EVS时，EVS存储创建的最大上限(单位：GB)。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("evs_max_size", NullValueHandling = NullValueHandling.Ignore)]
        public string EvsMaxSize { get; set; }

        /// <summary>
        /// **参数解释**：规格包含EVS时，EVS存储的sku编码。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("evs_sku_code", NullValueHandling = NullValueHandling.Ignore)]
        public string EvsSkuCode { get; set; }

        /// <summary>
        /// **参数解释**：规格类别。 **取值范围**：枚举类型，取值如下： - DEFAULT：CodeLab规格。 - NOTEBOOK：Notebook规格。
        /// </summary>
        [JsonProperty("feature", NullValueHandling = NullValueHandling.Ignore)]
        public string Feature { get; set; }

        /// <summary>
        /// **参数解释**：是否为免费规格。 **取值范围**：布尔类型： - true：免费规格。 - false：非免费规格。
        /// </summary>
        [JsonProperty("free", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Free { get; set; }

        /// <summary>
        /// **参数解释**：支持站点类型。 **取值范围**：枚举类型，取值如下： - COMMON：国内与国际站都支持。 - NATIONAL：仅在国内站支持。 - INTERNATIONAL：仅在国际站支持。 - NONE：国内与国际站都不支持。
        /// </summary>
        [JsonProperty("grow_support_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GrowSupportType { get; set; }

        /// <summary>
        /// **参数解释**：规格ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：内存大小。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public string Memory { get; set; }

        /// <summary>
        /// **参数解释**：规格名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：是否告罄。 **取值范围**：布尔类型： - true：告罄。 - false：未告罄。
        /// </summary>
        [JsonProperty("sold_out", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SoldOut { get; set; }

        /// <summary>
        /// **参数解释**：规格支持的存储类型。 **取值范围**：枚举类型，取值如下： - EVS：云硬盘。 - OBS：对象存储服务。 - OBSFS：并行文件系统。 - EFS：弹性文件服务（SFS Turbo）
        /// </summary>
        [JsonProperty("storages", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Storages { get; set; }

        /// <summary>
        /// **参数解释**：CPU核数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vcpus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gpu", NullValueHandling = NullValueHandling.Ignore)]
        public GPUsInfo Gpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ascend", NullValueHandling = NullValueHandling.Ignore)]
        public AscendInfo Ascend { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Flavor {\n");
            sb.Append("  arch: ").Append(Arch).Append("\n");
            sb.Append("  billing: ").Append(Billing).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  evsMaxSize: ").Append(EvsMaxSize).Append("\n");
            sb.Append("  evsSkuCode: ").Append(EvsSkuCode).Append("\n");
            sb.Append("  feature: ").Append(Feature).Append("\n");
            sb.Append("  free: ").Append(Free).Append("\n");
            sb.Append("  growSupportType: ").Append(GrowSupportType).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  soldOut: ").Append(SoldOut).Append("\n");
            sb.Append("  storages: ").Append(Storages).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  gpu: ").Append(Gpu).Append("\n");
            sb.Append("  ascend: ").Append(Ascend).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Flavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Flavor input)
        {
            if (input == null) return false;
            if (this.Arch != input.Arch || (this.Arch != null && !this.Arch.Equals(input.Arch))) return false;
            if (this.Billing != input.Billing || (this.Billing != null && !this.Billing.Equals(input.Billing))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.EvsMaxSize != input.EvsMaxSize || (this.EvsMaxSize != null && !this.EvsMaxSize.Equals(input.EvsMaxSize))) return false;
            if (this.EvsSkuCode != input.EvsSkuCode || (this.EvsSkuCode != null && !this.EvsSkuCode.Equals(input.EvsSkuCode))) return false;
            if (this.Feature != input.Feature || (this.Feature != null && !this.Feature.Equals(input.Feature))) return false;
            if (this.Free != input.Free || (this.Free != null && !this.Free.Equals(input.Free))) return false;
            if (this.GrowSupportType != input.GrowSupportType || (this.GrowSupportType != null && !this.GrowSupportType.Equals(input.GrowSupportType))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SoldOut != input.SoldOut || (this.SoldOut != null && !this.SoldOut.Equals(input.SoldOut))) return false;
            if (this.Storages != input.Storages || (this.Storages != null && input.Storages != null && !this.Storages.SequenceEqual(input.Storages))) return false;
            if (this.Vcpus != input.Vcpus || (this.Vcpus != null && !this.Vcpus.Equals(input.Vcpus))) return false;
            if (this.Gpu != input.Gpu || (this.Gpu != null && !this.Gpu.Equals(input.Gpu))) return false;
            if (this.Ascend != input.Ascend || (this.Ascend != null && !this.Ascend.Equals(input.Ascend))) return false;

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
                if (this.Arch != null) hashCode = hashCode * 59 + this.Arch.GetHashCode();
                if (this.Billing != null) hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EvsMaxSize != null) hashCode = hashCode * 59 + this.EvsMaxSize.GetHashCode();
                if (this.EvsSkuCode != null) hashCode = hashCode * 59 + this.EvsSkuCode.GetHashCode();
                if (this.Feature != null) hashCode = hashCode * 59 + this.Feature.GetHashCode();
                if (this.Free != null) hashCode = hashCode * 59 + this.Free.GetHashCode();
                if (this.GrowSupportType != null) hashCode = hashCode * 59 + this.GrowSupportType.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SoldOut != null) hashCode = hashCode * 59 + this.SoldOut.GetHashCode();
                if (this.Storages != null) hashCode = hashCode * 59 + this.Storages.GetHashCode();
                if (this.Vcpus != null) hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Gpu != null) hashCode = hashCode * 59 + this.Gpu.GetHashCode();
                if (this.Ascend != null) hashCode = hashCode * 59 + this.Ascend.GetHashCode();
                return hashCode;
            }
        }
    }
}
