using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 跨区域备份实例信息。
    /// </summary>
    public class OffsiteBackupInstance 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 创建的实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 源区域。
        /// </summary>
        [JsonProperty("source_region", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// 租户在源区域下的project ID。
        /// </summary>
        [JsonProperty("source_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public ParaGroupDatastore Datastore { get; set; }

        /// <summary>
        /// 跨区域备份所在区域。
        /// </summary>
        [JsonProperty("destination_region", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// 租户在目标区域下的project ID。
        /// </summary>
        [JsonProperty("destination_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationProjectId { get; set; }

        /// <summary>
        /// 跨区域备份保留天数。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public long? KeepDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OffsiteBackupInstance {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sourceRegion: ").Append(SourceRegion).Append("\n");
            sb.Append("  sourceProjectId: ").Append(SourceProjectId).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  destinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  destinationProjectId: ").Append(DestinationProjectId).Append("\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OffsiteBackupInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OffsiteBackupInstance input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SourceRegion != input.SourceRegion || (this.SourceRegion != null && !this.SourceRegion.Equals(input.SourceRegion))) return false;
            if (this.SourceProjectId != input.SourceProjectId || (this.SourceProjectId != null && !this.SourceProjectId.Equals(input.SourceProjectId))) return false;
            if (this.Datastore != input.Datastore || (this.Datastore != null && !this.Datastore.Equals(input.Datastore))) return false;
            if (this.DestinationRegion != input.DestinationRegion || (this.DestinationRegion != null && !this.DestinationRegion.Equals(input.DestinationRegion))) return false;
            if (this.DestinationProjectId != input.DestinationProjectId || (this.DestinationProjectId != null && !this.DestinationProjectId.Equals(input.DestinationProjectId))) return false;
            if (this.KeepDays != input.KeepDays || (this.KeepDays != null && !this.KeepDays.Equals(input.KeepDays))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SourceRegion != null) hashCode = hashCode * 59 + this.SourceRegion.GetHashCode();
                if (this.SourceProjectId != null) hashCode = hashCode * 59 + this.SourceProjectId.GetHashCode();
                if (this.Datastore != null) hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.DestinationRegion != null) hashCode = hashCode * 59 + this.DestinationRegion.GetHashCode();
                if (this.DestinationProjectId != null) hashCode = hashCode * 59 + this.DestinationProjectId.GetHashCode();
                if (this.KeepDays != null) hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
