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
    public class JobStatusResultResponseBodyResult 
    {

        /// <summary>
        /// 是否构建中
        /// </summary>
        [JsonProperty("building", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Building { get; set; }

        /// <summary>
        /// 构建结果
        /// </summary>
        [JsonProperty("build_result", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildResult { get; set; }

        /// <summary>
        /// region
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobStatusResultResponseBodyResult {\n");
            sb.Append("  building: ").Append(Building).Append("\n");
            sb.Append("  buildResult: ").Append(BuildResult).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobStatusResultResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobStatusResultResponseBodyResult input)
        {
            if (input == null) return false;
            if (this.Building != input.Building || (this.Building != null && !this.Building.Equals(input.Building))) return false;
            if (this.BuildResult != input.BuildResult || (this.BuildResult != null && !this.BuildResult.Equals(input.BuildResult))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;

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
                if (this.Building != null) hashCode = hashCode * 59 + this.Building.GetHashCode();
                if (this.BuildResult != null) hashCode = hashCode * 59 + this.BuildResult.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                return hashCode;
            }
        }
    }
}
