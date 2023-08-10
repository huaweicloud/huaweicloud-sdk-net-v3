using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 代码信息
    /// </summary>
    public class Scm 
    {

        /// <summary>
        /// 代码Tag
        /// </summary>
        [JsonProperty("build_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildTag { get; set; }

        /// <summary>
        /// 代码提交ID
        /// </summary>
        [JsonProperty("build_commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildCommitId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Scm {\n");
            sb.Append("  buildTag: ").Append(BuildTag).Append("\n");
            sb.Append("  buildCommitId: ").Append(BuildCommitId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Scm);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Scm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BuildTag == input.BuildTag ||
                    (this.BuildTag != null &&
                    this.BuildTag.Equals(input.BuildTag))
                ) && 
                (
                    this.BuildCommitId == input.BuildCommitId ||
                    (this.BuildCommitId != null &&
                    this.BuildCommitId.Equals(input.BuildCommitId))
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
                if (this.BuildTag != null)
                    hashCode = hashCode * 59 + this.BuildTag.GetHashCode();
                if (this.BuildCommitId != null)
                    hashCode = hashCode * 59 + this.BuildCommitId.GetHashCode();
                return hashCode;
            }
        }
    }
}
