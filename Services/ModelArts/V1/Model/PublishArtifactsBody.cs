using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 产物发布请求体
    /// </summary>
    public class PublishArtifactsBody 
    {

        /// <summary>
        /// 工作空间ID
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// 产物发布请求列表
        /// </summary>
        [JsonProperty("publish_artifacts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ArtifactsPublish> PublishArtifacts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishArtifactsBody {\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  publishArtifacts: ").Append(PublishArtifacts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublishArtifactsBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublishArtifactsBody input)
        {
            if (input == null) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.PublishArtifacts != input.PublishArtifacts || (this.PublishArtifacts != null && input.PublishArtifacts != null && !this.PublishArtifacts.SequenceEqual(input.PublishArtifacts))) return false;

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
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.PublishArtifacts != null) hashCode = hashCode * 59 + this.PublishArtifacts.GetHashCode();
                return hashCode;
            }
        }
    }
}
