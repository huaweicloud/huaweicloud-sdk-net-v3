using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AddRelationsInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("relations", NullValueHandling = NullValueHandling.Ignore)]
        public List<RelationInfo> Relations { get; set; }

        /// <summary>
        /// 工作项类型id
        /// </summary>
        [JsonProperty("tracker_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerId { get; set; }

        /// <summary>
        /// 版本uri
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 测试套id
        /// </summary>
        [JsonProperty("task_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskUri { get; set; }

        /// <summary>
        /// 是否将需求添加到迭代
        /// </summary>
        [JsonProperty("add_to_iterator", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddToIterator { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddRelationsInfo {\n");
            sb.Append("  relations: ").Append(Relations).Append("\n");
            sb.Append("  trackerId: ").Append(TrackerId).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  taskUri: ").Append(TaskUri).Append("\n");
            sb.Append("  addToIterator: ").Append(AddToIterator).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddRelationsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddRelationsInfo input)
        {
            if (input == null) return false;
            if (this.Relations != input.Relations || (this.Relations != null && input.Relations != null && !this.Relations.SequenceEqual(input.Relations))) return false;
            if (this.TrackerId != input.TrackerId || (this.TrackerId != null && !this.TrackerId.Equals(input.TrackerId))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.TaskUri != input.TaskUri || (this.TaskUri != null && !this.TaskUri.Equals(input.TaskUri))) return false;
            if (this.AddToIterator != input.AddToIterator || (this.AddToIterator != null && !this.AddToIterator.Equals(input.AddToIterator))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;

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
                if (this.Relations != null) hashCode = hashCode * 59 + this.Relations.GetHashCode();
                if (this.TrackerId != null) hashCode = hashCode * 59 + this.TrackerId.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.TaskUri != null) hashCode = hashCode * 59 + this.TaskUri.GetHashCode();
                if (this.AddToIterator != null) hashCode = hashCode * 59 + this.AddToIterator.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                return hashCode;
            }
        }
    }
}
