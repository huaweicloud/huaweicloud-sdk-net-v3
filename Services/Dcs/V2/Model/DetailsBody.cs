using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 详细信息结构体
    /// </summary>
    public class DetailsBody 
    {

        /// <summary>
        /// 变更前的容量，仅在变更规格时有值
        /// </summary>
        [JsonProperty("old_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string OldCapacity { get; set; }

        /// <summary>
        /// 变更后的容量，仅在变更规格时有值
        /// </summary>
        [JsonProperty("new_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string NewCapacity { get; set; }

        /// <summary>
        /// 是否开启公网访问，仅在开启公网访问时有值
        /// </summary>
        [JsonProperty("enable_public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicIp { get; set; }

        /// <summary>
        /// 公网IP的ID，仅在开启公网访问时有值
        /// </summary>
        [JsonProperty("public_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpId { get; set; }

        /// <summary>
        /// 公网IP地址，仅在开启公网访问时有值
        /// </summary>
        [JsonProperty("public_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpAddress { get; set; }

        /// <summary>
        /// 是否开启ssl，仅在开启ssl时有值
        /// </summary>
        [JsonProperty("enable_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// 变更前的缓存类型，仅在变更规格时有值
        /// </summary>
        [JsonProperty("old_cache_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string OldCacheMode { get; set; }

        /// <summary>
        /// 变更后的缓存类型，仅在变更规格时有值
        /// </summary>
        [JsonProperty("new_cache_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string NewCacheMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailsBody {\n");
            sb.Append("  oldCapacity: ").Append(OldCapacity).Append("\n");
            sb.Append("  newCapacity: ").Append(NewCapacity).Append("\n");
            sb.Append("  enablePublicIp: ").Append(EnablePublicIp).Append("\n");
            sb.Append("  publicIpId: ").Append(PublicIpId).Append("\n");
            sb.Append("  publicIpAddress: ").Append(PublicIpAddress).Append("\n");
            sb.Append("  enableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("  oldCacheMode: ").Append(OldCacheMode).Append("\n");
            sb.Append("  newCacheMode: ").Append(NewCacheMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetailsBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetailsBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OldCapacity == input.OldCapacity ||
                    (this.OldCapacity != null &&
                    this.OldCapacity.Equals(input.OldCapacity))
                ) && 
                (
                    this.NewCapacity == input.NewCapacity ||
                    (this.NewCapacity != null &&
                    this.NewCapacity.Equals(input.NewCapacity))
                ) && 
                (
                    this.EnablePublicIp == input.EnablePublicIp ||
                    (this.EnablePublicIp != null &&
                    this.EnablePublicIp.Equals(input.EnablePublicIp))
                ) && 
                (
                    this.PublicIpId == input.PublicIpId ||
                    (this.PublicIpId != null &&
                    this.PublicIpId.Equals(input.PublicIpId))
                ) && 
                (
                    this.PublicIpAddress == input.PublicIpAddress ||
                    (this.PublicIpAddress != null &&
                    this.PublicIpAddress.Equals(input.PublicIpAddress))
                ) && 
                (
                    this.EnableSsl == input.EnableSsl ||
                    (this.EnableSsl != null &&
                    this.EnableSsl.Equals(input.EnableSsl))
                ) && 
                (
                    this.OldCacheMode == input.OldCacheMode ||
                    (this.OldCacheMode != null &&
                    this.OldCacheMode.Equals(input.OldCacheMode))
                ) && 
                (
                    this.NewCacheMode == input.NewCacheMode ||
                    (this.NewCacheMode != null &&
                    this.NewCacheMode.Equals(input.NewCacheMode))
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
                if (this.OldCapacity != null)
                    hashCode = hashCode * 59 + this.OldCapacity.GetHashCode();
                if (this.NewCapacity != null)
                    hashCode = hashCode * 59 + this.NewCapacity.GetHashCode();
                if (this.EnablePublicIp != null)
                    hashCode = hashCode * 59 + this.EnablePublicIp.GetHashCode();
                if (this.PublicIpId != null)
                    hashCode = hashCode * 59 + this.PublicIpId.GetHashCode();
                if (this.PublicIpAddress != null)
                    hashCode = hashCode * 59 + this.PublicIpAddress.GetHashCode();
                if (this.EnableSsl != null)
                    hashCode = hashCode * 59 + this.EnableSsl.GetHashCode();
                if (this.OldCacheMode != null)
                    hashCode = hashCode * 59 + this.OldCacheMode.GetHashCode();
                if (this.NewCacheMode != null)
                    hashCode = hashCode * 59 + this.NewCacheMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
