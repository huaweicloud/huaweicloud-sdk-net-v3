using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 创建项目配置关联。
    /// </summary>
    public class CreateCloudStorageReq 
    {

        /// <summary>
        /// project_config_id,数量区间 [1, 50]。
        /// </summary>
        [JsonProperty("project_config_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProjectConfigIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCloudStorageReq {\n");
            sb.Append("  projectConfigIds: ").Append(ProjectConfigIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCloudStorageReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCloudStorageReq input)
        {
            if (input == null) return false;
            if (this.ProjectConfigIds != input.ProjectConfigIds || (this.ProjectConfigIds != null && input.ProjectConfigIds != null && !this.ProjectConfigIds.SequenceEqual(input.ProjectConfigIds))) return false;

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
                if (this.ProjectConfigIds != null) hashCode = hashCode * 59 + this.ProjectConfigIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
