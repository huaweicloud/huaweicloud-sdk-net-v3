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
    /// 结果
    /// </summary>
    public class RepositoriesResult 
    {

        /// <summary>
        /// 最后一次仓库名称
        /// </summary>
        [JsonProperty("latest", NullValueHandling = NullValueHandling.Ignore)]
        public string Latest { get; set; }

        /// <summary>
        /// 本次任务的构建步骤详情，返回的步骤为页面可见步骤
        /// </summary>
        [JsonProperty("repositories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Repositories { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoriesResult {\n");
            sb.Append("  latest: ").Append(Latest).Append("\n");
            sb.Append("  repositories: ").Append(Repositories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoriesResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoriesResult input)
        {
            if (input == null) return false;
            if (this.Latest != input.Latest || (this.Latest != null && !this.Latest.Equals(input.Latest))) return false;
            if (this.Repositories != input.Repositories || (this.Repositories != null && input.Repositories != null && !this.Repositories.SequenceEqual(input.Repositories))) return false;

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
                if (this.Latest != null) hashCode = hashCode * 59 + this.Latest.GetHashCode();
                if (this.Repositories != null) hashCode = hashCode * 59 + this.Repositories.GetHashCode();
                return hashCode;
            }
        }
    }
}
