using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// flavors数据结构说明
    /// </summary>
    public class FlavorsResp 
    {

        /// <summary>
        /// 裸金属服务器规格的ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 裸金属服务器规格的名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 该裸金属服务器规格对应的CPU核数。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string Vcpus { get; set; }

        /// <summary>
        /// 该裸金属服务器规格对应的内存大小，单位为MB。
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ram { get; set; }

        /// <summary>
        /// 该裸金属服务器规格对应要求系统盘大小，0为不限制。
        /// </summary>
        [JsonProperty("disk", NullValueHandling = NullValueHandling.Ignore)]
        public string Disk { get; set; }

        /// <summary>
        /// 未使用
        /// </summary>
        [JsonProperty("swap", NullValueHandling = NullValueHandling.Ignore)]
        public string Swap { get; set; }

        /// <summary>
        /// 未使用
        /// </summary>
        [JsonProperty("OS-FLV-EXT-DATA:ephemeral", NullValueHandling = NullValueHandling.Ignore)]
        public int? OSFLVEXTDATAephemeral { get; set; }

        /// <summary>
        /// 未使用
        /// </summary>
        [JsonProperty("OS-FLV-DISABLED:disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OSFLVDISABLEDdisabled { get; set; }

        /// <summary>
        /// 未使用
        /// </summary>
        [JsonProperty("rxtx_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int? RxtxFactor { get; set; }

        /// <summary>
        /// 未使用
        /// </summary>
        [JsonProperty("rxtx_quota", NullValueHandling = NullValueHandling.Ignore)]
        public string RxtxQuota { get; set; }

        /// <summary>
        /// 未使用
        /// </summary>
        [JsonProperty("rxtx_cap", NullValueHandling = NullValueHandling.Ignore)]
        public string RxtxCap { get; set; }

        /// <summary>
        /// 是否是公共规格。false：私有规格；true：公共规格
        /// </summary>
        [JsonProperty("os-flavor-access:is_public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OsFlavorAccessisPublic { get; set; }

        /// <summary>
        /// 规格相关快捷链接地址，详情请参见表3 links字段数据结构说明。
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<LinksInfo> Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os_extra_specs", NullValueHandling = NullValueHandling.Ignore)]
        public OsExtraSpecs OsExtraSpecs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorsResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  disk: ").Append(Disk).Append("\n");
            sb.Append("  swap: ").Append(Swap).Append("\n");
            sb.Append("  oSFLVEXTDATAephemeral: ").Append(OSFLVEXTDATAephemeral).Append("\n");
            sb.Append("  oSFLVDISABLEDdisabled: ").Append(OSFLVDISABLEDdisabled).Append("\n");
            sb.Append("  rxtxFactor: ").Append(RxtxFactor).Append("\n");
            sb.Append("  rxtxQuota: ").Append(RxtxQuota).Append("\n");
            sb.Append("  rxtxCap: ").Append(RxtxCap).Append("\n");
            sb.Append("  osFlavorAccessisPublic: ").Append(OsFlavorAccessisPublic).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  osExtraSpecs: ").Append(OsExtraSpecs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorsResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorsResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Vcpus == input.Vcpus ||
                    (this.Vcpus != null &&
                    this.Vcpus.Equals(input.Vcpus))
                ) && 
                (
                    this.Ram == input.Ram ||
                    (this.Ram != null &&
                    this.Ram.Equals(input.Ram))
                ) && 
                (
                    this.Disk == input.Disk ||
                    (this.Disk != null &&
                    this.Disk.Equals(input.Disk))
                ) && 
                (
                    this.Swap == input.Swap ||
                    (this.Swap != null &&
                    this.Swap.Equals(input.Swap))
                ) && 
                (
                    this.OSFLVEXTDATAephemeral == input.OSFLVEXTDATAephemeral ||
                    (this.OSFLVEXTDATAephemeral != null &&
                    this.OSFLVEXTDATAephemeral.Equals(input.OSFLVEXTDATAephemeral))
                ) && 
                (
                    this.OSFLVDISABLEDdisabled == input.OSFLVDISABLEDdisabled ||
                    (this.OSFLVDISABLEDdisabled != null &&
                    this.OSFLVDISABLEDdisabled.Equals(input.OSFLVDISABLEDdisabled))
                ) && 
                (
                    this.RxtxFactor == input.RxtxFactor ||
                    (this.RxtxFactor != null &&
                    this.RxtxFactor.Equals(input.RxtxFactor))
                ) && 
                (
                    this.RxtxQuota == input.RxtxQuota ||
                    (this.RxtxQuota != null &&
                    this.RxtxQuota.Equals(input.RxtxQuota))
                ) && 
                (
                    this.RxtxCap == input.RxtxCap ||
                    (this.RxtxCap != null &&
                    this.RxtxCap.Equals(input.RxtxCap))
                ) && 
                (
                    this.OsFlavorAccessisPublic == input.OsFlavorAccessisPublic ||
                    (this.OsFlavorAccessisPublic != null &&
                    this.OsFlavorAccessisPublic.Equals(input.OsFlavorAccessisPublic))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.OsExtraSpecs == input.OsExtraSpecs ||
                    (this.OsExtraSpecs != null &&
                    this.OsExtraSpecs.Equals(input.OsExtraSpecs))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Vcpus != null)
                    hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Ram != null)
                    hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.Disk != null)
                    hashCode = hashCode * 59 + this.Disk.GetHashCode();
                if (this.Swap != null)
                    hashCode = hashCode * 59 + this.Swap.GetHashCode();
                if (this.OSFLVEXTDATAephemeral != null)
                    hashCode = hashCode * 59 + this.OSFLVEXTDATAephemeral.GetHashCode();
                if (this.OSFLVDISABLEDdisabled != null)
                    hashCode = hashCode * 59 + this.OSFLVDISABLEDdisabled.GetHashCode();
                if (this.RxtxFactor != null)
                    hashCode = hashCode * 59 + this.RxtxFactor.GetHashCode();
                if (this.RxtxQuota != null)
                    hashCode = hashCode * 59 + this.RxtxQuota.GetHashCode();
                if (this.RxtxCap != null)
                    hashCode = hashCode * 59 + this.RxtxCap.GetHashCode();
                if (this.OsFlavorAccessisPublic != null)
                    hashCode = hashCode * 59 + this.OsFlavorAccessisPublic.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.OsExtraSpecs != null)
                    hashCode = hashCode * 59 + this.OsExtraSpecs.GetHashCode();
                return hashCode;
            }
        }
    }
}
