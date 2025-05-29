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
    public class BuildParamsBodyResult 
    {

        /// <summary>
        /// 构建参数约束列表
        /// </summary>
        [JsonProperty("build_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<BuildParams> BuildParameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildParamsBodyResult {\n");
            sb.Append("  buildParameters: ").Append(BuildParameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BuildParamsBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BuildParamsBodyResult input)
        {
            if (input == null) return false;
            if (this.BuildParameters != input.BuildParameters || (this.BuildParameters != null && input.BuildParameters != null && !this.BuildParameters.SequenceEqual(input.BuildParameters))) return false;

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
                if (this.BuildParameters != null) hashCode = hashCode * 59 + this.BuildParameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
