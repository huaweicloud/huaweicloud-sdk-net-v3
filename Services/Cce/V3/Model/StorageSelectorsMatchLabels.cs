using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// evs盘的匹配字段，支持DataVolume中的size、volumeType、metadataEncrypted、metadataCmkid、count五个字段。
    /// </summary>
    public class StorageSelectorsMatchLabels 
    {

        /// <summary>
        /// 匹配的磁盘大小，不填则无磁盘大小限制。例如：100.
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// 云硬盘类型，目前支持SSD\\GPSSD\\SAS三种。
        /// </summary>
        [JsonProperty("volumeType", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }

        /// <summary>
        /// 磁盘加密标识符，0代表不加密，1代表加密。
        /// </summary>
        [JsonProperty("metadataEncrypted", NullValueHandling = NullValueHandling.Ignore)]
        public string MetadataEncrypted { get; set; }

        /// <summary>
        /// 加密磁盘的用户主密钥ID，长度为36字节的字符串。
        /// </summary>
        [JsonProperty("metadataCmkid", NullValueHandling = NullValueHandling.Ignore)]
        public string MetadataCmkid { get; set; }

        /// <summary>
        /// 磁盘选择个数，不填则选择所有此类磁盘。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public string Count { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageSelectorsMatchLabels {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  metadataEncrypted: ").Append(MetadataEncrypted).Append("\n");
            sb.Append("  metadataCmkid: ").Append(MetadataCmkid).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageSelectorsMatchLabels);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StorageSelectorsMatchLabels input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.VolumeType == input.VolumeType ||
                    (this.VolumeType != null &&
                    this.VolumeType.Equals(input.VolumeType))
                ) && 
                (
                    this.MetadataEncrypted == input.MetadataEncrypted ||
                    (this.MetadataEncrypted != null &&
                    this.MetadataEncrypted.Equals(input.MetadataEncrypted))
                ) && 
                (
                    this.MetadataCmkid == input.MetadataCmkid ||
                    (this.MetadataCmkid != null &&
                    this.MetadataCmkid.Equals(input.MetadataCmkid))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.VolumeType != null)
                    hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.MetadataEncrypted != null)
                    hashCode = hashCode * 59 + this.MetadataEncrypted.GetHashCode();
                if (this.MetadataCmkid != null)
                    hashCode = hashCode * 59 + this.MetadataCmkid.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
