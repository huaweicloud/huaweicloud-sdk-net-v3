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
    /// 快照详情。
    /// </summary>
    public class SnapshotDetails 
    {

        /// <summary>
        /// 云硬盘快照ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 云硬盘快照状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 云硬盘快照名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 云硬盘快照描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 云硬盘快照创建时间。 时间格式：UTC YYYY-MM-DDTHH:MM:SS.XXXXXX
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 快照更新时间。 时间格式：UTC YYYY-MM-DDTHH:MM:SS.XXXXXX
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 云硬盘快照的元数据信息。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Object Metadata { get; set; }

        /// <summary>
        /// 快照所属的云硬盘ID。
        /// </summary>
        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }

        /// <summary>
        /// 云硬盘快照大小，单位为GB。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("os-extended-snapshot-attributes:project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsExtendedSnapshotAttributesprojectId { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("os-extended-snapshot-attributes:progress", NullValueHandling = NullValueHandling.Ignore)]
        public string OsExtendedSnapshotAttributesprogress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnapshotDetails {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  osExtendedSnapshotAttributesprojectId: ").Append(OsExtendedSnapshotAttributesprojectId).Append("\n");
            sb.Append("  osExtendedSnapshotAttributesprogress: ").Append(OsExtendedSnapshotAttributesprogress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SnapshotDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SnapshotDetails input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.VolumeId != input.VolumeId || (this.VolumeId != null && !this.VolumeId.Equals(input.VolumeId))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.OsExtendedSnapshotAttributesprojectId != input.OsExtendedSnapshotAttributesprojectId || (this.OsExtendedSnapshotAttributesprojectId != null && !this.OsExtendedSnapshotAttributesprojectId.Equals(input.OsExtendedSnapshotAttributesprojectId))) return false;
            if (this.OsExtendedSnapshotAttributesprogress != input.OsExtendedSnapshotAttributesprogress || (this.OsExtendedSnapshotAttributesprogress != null && !this.OsExtendedSnapshotAttributesprogress.Equals(input.OsExtendedSnapshotAttributesprogress))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.VolumeId != null) hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.OsExtendedSnapshotAttributesprojectId != null) hashCode = hashCode * 59 + this.OsExtendedSnapshotAttributesprojectId.GetHashCode();
                if (this.OsExtendedSnapshotAttributesprogress != null) hashCode = hashCode * 59 + this.OsExtendedSnapshotAttributesprogress.GetHashCode();
                return hashCode;
            }
        }
    }
}
