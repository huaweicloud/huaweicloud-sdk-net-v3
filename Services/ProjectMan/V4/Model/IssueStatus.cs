using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IssueStatus 
    {

        /// <summary>
        /// 状态uuid
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 状态数字id
        /// </summary>
        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; }

        /// <summary>
        /// 状态名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 关联的工作项类型列表
        /// </summary>
        [JsonProperty("tracker_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> TrackerIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status_attribute", NullValueHandling = NullValueHandling.Ignore)]
        public StatusAttribute StatusAttribute { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueStatus {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  statusId: ").Append(StatusId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  trackerIds: ").Append(TrackerIds).Append("\n");
            sb.Append("  statusAttribute: ").Append(StatusAttribute).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueStatus input)
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
                    this.StatusId == input.StatusId ||
                    (this.StatusId != null &&
                    this.StatusId.Equals(input.StatusId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TrackerIds == input.TrackerIds ||
                    this.TrackerIds != null &&
                    input.TrackerIds != null &&
                    this.TrackerIds.SequenceEqual(input.TrackerIds)
                ) && 
                (
                    this.StatusAttribute == input.StatusAttribute ||
                    (this.StatusAttribute != null &&
                    this.StatusAttribute.Equals(input.StatusAttribute))
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
                if (this.StatusId != null)
                    hashCode = hashCode * 59 + this.StatusId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TrackerIds != null)
                    hashCode = hashCode * 59 + this.TrackerIds.GetHashCode();
                if (this.StatusAttribute != null)
                    hashCode = hashCode * 59 + this.StatusAttribute.GetHashCode();
                return hashCode;
            }
        }
    }
}
