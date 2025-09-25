using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowRepositoryArchiveRequest 
    {

        /// <summary>
        /// 仓库的uuid
        /// </summary>
        [SDKProperty("repository_uuid", IsPath = true)]
        [JsonProperty("repository_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryUuid { get; set; }

        /// <summary>
        /// 分支名称
        /// </summary>
        [SDKProperty("sha", IsQuery = true)]
        [JsonProperty("sha", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha { get; set; }

        /// <summary>
        /// 下载的压缩包格式
        /// </summary>
        [SDKProperty("format", IsQuery = true)]
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepositoryArchiveRequest {\n");
            sb.Append("  repositoryUuid: ").Append(RepositoryUuid).Append("\n");
            sb.Append("  sha: ").Append(Sha).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepositoryArchiveRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepositoryArchiveRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryUuid != input.RepositoryUuid || (this.RepositoryUuid != null && !this.RepositoryUuid.Equals(input.RepositoryUuid))) return false;
            if (this.Sha != input.Sha || (this.Sha != null && !this.Sha.Equals(input.Sha))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;

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
                if (this.RepositoryUuid != null) hashCode = hashCode * 59 + this.RepositoryUuid.GetHashCode();
                if (this.Sha != null) hashCode = hashCode * 59 + this.Sha.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                return hashCode;
            }
        }
    }
}
