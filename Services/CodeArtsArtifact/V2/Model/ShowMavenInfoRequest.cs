using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowMavenInfoRequest 
    {

        /// <summary>
        /// 项目id
        /// </summary>
        [SDKProperty("project_id", IsQuery = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// snapshot or releases
        /// </summary>
        [SDKProperty("policy", IsQuery = true)]
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }

        /// <summary>
        /// r or rw
        /// </summary>
        [SDKProperty("access", IsQuery = true)]
        [JsonProperty("access", NullValueHandling = NullValueHandling.Ignore)]
        public string Access { get; set; }

        /// <summary>
        /// 是否返回默认仓库 true or false
        /// </summary>
        [SDKProperty("default", IsQuery = true)]
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public string Default { get; set; }

        /// <summary>
        /// 仓库id 多个仓库id用英文逗号间隔
        /// </summary>
        [SDKProperty("ids", IsQuery = true)]
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public string Ids { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMavenInfoRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  access: ").Append(Access).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMavenInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMavenInfoRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.Access != input.Access || (this.Access != null && !this.Access.Equals(input.Access))) return false;
            if (this.Default != input.Default || (this.Default != null && !this.Default.Equals(input.Default))) return false;
            if (this.Ids != input.Ids || (this.Ids != null && !this.Ids.Equals(input.Ids))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.Access != null) hashCode = hashCode * 59 + this.Access.GetHashCode();
                if (this.Default != null) hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                return hashCode;
            }
        }
    }
}
