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
    /// 
    /// </summary>
    public class TrashArtifactModelForDelete 
    {

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 仓库类型
        /// </summary>
        [JsonProperty("fomat", NullValueHandling = NullValueHandling.Ignore)]
        public string Fomat { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 路径白名单
        /// </summary>
        [JsonProperty("include_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludePattern { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrashArtifactModelForDelete {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  fomat: ").Append(Fomat).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  includePattern: ").Append(IncludePattern).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrashArtifactModelForDelete);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrashArtifactModelForDelete input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Fomat != input.Fomat || (this.Fomat != null && !this.Fomat.Equals(input.Fomat))) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.IncludePattern != input.IncludePattern || (this.IncludePattern != null && !this.IncludePattern.Equals(input.IncludePattern))) return false;

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
                if (this.Fomat != null) hashCode = hashCode * 59 + this.Fomat.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IncludePattern != null) hashCode = hashCode * 59 + this.IncludePattern.GetHashCode();
                return hashCode;
            }
        }
    }
}
