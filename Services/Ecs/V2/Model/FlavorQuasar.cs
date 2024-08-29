using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 云服务器规格信息。
    /// </summary>
    public class FlavorQuasar 
    {

        /// <summary>
        /// 云服务器类型ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 云服务器规格名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 该云服务器规格对应的CPU核数。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vcpus { get; set; }

        /// <summary>
        /// 该云服务器规格对应的内存大小，单位为MB.
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ram { get; set; }

        /// <summary>
        /// 该云服务器规格对应要求系统盘大小，0为不限制。
        /// </summary>
        [JsonProperty("disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? Disk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_gb", NullValueHandling = NullValueHandling.Ignore)]
        public int? RootGb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ephemeral_gb", NullValueHandling = NullValueHandling.Ignore)]
        public int? EphemeralGb { get; set; }

        /// <summary>
        /// flavor扩展字段。
        /// </summary>
        [JsonProperty("extra_specs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExtraSpecs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorQuasar {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  disk: ").Append(Disk).Append("\n");
            sb.Append("  rootGb: ").Append(RootGb).Append("\n");
            sb.Append("  ephemeralGb: ").Append(EphemeralGb).Append("\n");
            sb.Append("  extraSpecs: ").Append(ExtraSpecs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorQuasar);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorQuasar input)
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
                    this.RootGb == input.RootGb ||
                    (this.RootGb != null &&
                    this.RootGb.Equals(input.RootGb))
                ) && 
                (
                    this.EphemeralGb == input.EphemeralGb ||
                    (this.EphemeralGb != null &&
                    this.EphemeralGb.Equals(input.EphemeralGb))
                ) && 
                (
                    this.ExtraSpecs == input.ExtraSpecs ||
                    this.ExtraSpecs != null &&
                    input.ExtraSpecs != null &&
                    this.ExtraSpecs.SequenceEqual(input.ExtraSpecs)
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
                if (this.RootGb != null)
                    hashCode = hashCode * 59 + this.RootGb.GetHashCode();
                if (this.EphemeralGb != null)
                    hashCode = hashCode * 59 + this.EphemeralGb.GetHashCode();
                if (this.ExtraSpecs != null)
                    hashCode = hashCode * 59 + this.ExtraSpecs.GetHashCode();
                return hashCode;
            }
        }
    }
}
