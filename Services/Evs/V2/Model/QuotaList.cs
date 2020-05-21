using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 配额详情。
    /// </summary>
    public class QuotaList 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_gigabytes", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail BackupGigabytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backups", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail Backups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gigabytes", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail Gigabytes { get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("snapshots", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail Snapshots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail Volumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volumes_SSD", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail VolumesSSD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volumes_SAS", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail VolumesSAS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volumes_SATA", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail VolumesSATA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gigabytes_SSD", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail GigabytesSSD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gigabytes_SAS", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail GigabytesSAS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gigabytes_SATA", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail GigabytesSATA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("snapshots_SSD", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail SnapshotsSSD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("snapshots_SAS", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail SnapshotsSAS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("snapshots_SATA", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaDetail SnapshotsSATA { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaList {\n");
            sb.Append("  backupGigabytes: ").Append(BackupGigabytes).Append("\n");
            sb.Append("  backups: ").Append(Backups).Append("\n");
            sb.Append("  gigabytes: ").Append(Gigabytes).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  snapshots: ").Append(Snapshots).Append("\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("  volumesSSD: ").Append(VolumesSSD).Append("\n");
            sb.Append("  volumesSAS: ").Append(VolumesSAS).Append("\n");
            sb.Append("  volumesSATA: ").Append(VolumesSATA).Append("\n");
            sb.Append("  gigabytesSSD: ").Append(GigabytesSSD).Append("\n");
            sb.Append("  gigabytesSAS: ").Append(GigabytesSAS).Append("\n");
            sb.Append("  gigabytesSATA: ").Append(GigabytesSATA).Append("\n");
            sb.Append("  snapshotsSSD: ").Append(SnapshotsSSD).Append("\n");
            sb.Append("  snapshotsSAS: ").Append(SnapshotsSAS).Append("\n");
            sb.Append("  snapshotsSATA: ").Append(SnapshotsSATA).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotaList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuotaList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupGigabytes == input.BackupGigabytes ||
                    (this.BackupGigabytes != null &&
                    this.BackupGigabytes.Equals(input.BackupGigabytes))
                ) && 
                (
                    this.Backups == input.Backups ||
                    (this.Backups != null &&
                    this.Backups.Equals(input.Backups))
                ) && 
                (
                    this.Gigabytes == input.Gigabytes ||
                    (this.Gigabytes != null &&
                    this.Gigabytes.Equals(input.Gigabytes))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Snapshots == input.Snapshots ||
                    (this.Snapshots != null &&
                    this.Snapshots.Equals(input.Snapshots))
                ) && 
                (
                    this.Volumes == input.Volumes ||
                    (this.Volumes != null &&
                    this.Volumes.Equals(input.Volumes))
                ) && 
                (
                    this.VolumesSSD == input.VolumesSSD ||
                    (this.VolumesSSD != null &&
                    this.VolumesSSD.Equals(input.VolumesSSD))
                ) && 
                (
                    this.VolumesSAS == input.VolumesSAS ||
                    (this.VolumesSAS != null &&
                    this.VolumesSAS.Equals(input.VolumesSAS))
                ) && 
                (
                    this.VolumesSATA == input.VolumesSATA ||
                    (this.VolumesSATA != null &&
                    this.VolumesSATA.Equals(input.VolumesSATA))
                ) && 
                (
                    this.GigabytesSSD == input.GigabytesSSD ||
                    (this.GigabytesSSD != null &&
                    this.GigabytesSSD.Equals(input.GigabytesSSD))
                ) && 
                (
                    this.GigabytesSAS == input.GigabytesSAS ||
                    (this.GigabytesSAS != null &&
                    this.GigabytesSAS.Equals(input.GigabytesSAS))
                ) && 
                (
                    this.GigabytesSATA == input.GigabytesSATA ||
                    (this.GigabytesSATA != null &&
                    this.GigabytesSATA.Equals(input.GigabytesSATA))
                ) && 
                (
                    this.SnapshotsSSD == input.SnapshotsSSD ||
                    (this.SnapshotsSSD != null &&
                    this.SnapshotsSSD.Equals(input.SnapshotsSSD))
                ) && 
                (
                    this.SnapshotsSAS == input.SnapshotsSAS ||
                    (this.SnapshotsSAS != null &&
                    this.SnapshotsSAS.Equals(input.SnapshotsSAS))
                ) && 
                (
                    this.SnapshotsSATA == input.SnapshotsSATA ||
                    (this.SnapshotsSATA != null &&
                    this.SnapshotsSATA.Equals(input.SnapshotsSATA))
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
                if (this.BackupGigabytes != null)
                    hashCode = hashCode * 59 + this.BackupGigabytes.GetHashCode();
                if (this.Backups != null)
                    hashCode = hashCode * 59 + this.Backups.GetHashCode();
                if (this.Gigabytes != null)
                    hashCode = hashCode * 59 + this.Gigabytes.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Snapshots != null)
                    hashCode = hashCode * 59 + this.Snapshots.GetHashCode();
                if (this.Volumes != null)
                    hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                if (this.VolumesSSD != null)
                    hashCode = hashCode * 59 + this.VolumesSSD.GetHashCode();
                if (this.VolumesSAS != null)
                    hashCode = hashCode * 59 + this.VolumesSAS.GetHashCode();
                if (this.VolumesSATA != null)
                    hashCode = hashCode * 59 + this.VolumesSATA.GetHashCode();
                if (this.GigabytesSSD != null)
                    hashCode = hashCode * 59 + this.GigabytesSSD.GetHashCode();
                if (this.GigabytesSAS != null)
                    hashCode = hashCode * 59 + this.GigabytesSAS.GetHashCode();
                if (this.GigabytesSATA != null)
                    hashCode = hashCode * 59 + this.GigabytesSATA.GetHashCode();
                if (this.SnapshotsSSD != null)
                    hashCode = hashCode * 59 + this.SnapshotsSSD.GetHashCode();
                if (this.SnapshotsSAS != null)
                    hashCode = hashCode * 59 + this.SnapshotsSAS.GetHashCode();
                if (this.SnapshotsSATA != null)
                    hashCode = hashCode * 59 + this.SnapshotsSATA.GetHashCode();
                return hashCode;
            }
        }
    }
}
