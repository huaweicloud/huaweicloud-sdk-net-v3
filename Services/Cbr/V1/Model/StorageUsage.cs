using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StorageUsage 
    {

        /// <summary>
        /// 备份数量
        /// </summary>
        [JsonProperty("backup_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? BackupCount { get; set; }

        /// <summary>
        /// 备份容量
        /// </summary>
        [JsonProperty("backup_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? BackupSize { get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 多AZ备份大小
        /// </summary>
        [JsonProperty("backup_size_multiaz", NullValueHandling = NullValueHandling.Ignore)]
        public int? BackupSizeMultiaz { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageUsage {\n");
            sb.Append("  backupCount: ").Append(BackupCount).Append("\n");
            sb.Append("  backupSize: ").Append(BackupSize).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  backupSizeMultiaz: ").Append(BackupSizeMultiaz).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageUsage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StorageUsage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupCount == input.BackupCount ||
                    (this.BackupCount != null &&
                    this.BackupCount.Equals(input.BackupCount))
                ) && 
                (
                    this.BackupSize == input.BackupSize ||
                    (this.BackupSize != null &&
                    this.BackupSize.Equals(input.BackupSize))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.BackupSizeMultiaz == input.BackupSizeMultiaz ||
                    (this.BackupSizeMultiaz != null &&
                    this.BackupSizeMultiaz.Equals(input.BackupSizeMultiaz))
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
                if (this.BackupCount != null)
                    hashCode = hashCode * 59 + this.BackupCount.GetHashCode();
                if (this.BackupSize != null)
                    hashCode = hashCode * 59 + this.BackupSize.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.BackupSizeMultiaz != null)
                    hashCode = hashCode * 59 + this.BackupSizeMultiaz.GetHashCode();
                return hashCode;
            }
        }
    }
}
