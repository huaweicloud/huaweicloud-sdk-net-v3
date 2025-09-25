using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DiffRefsParamDto 
    {

        /// <summary>
        /// 合并请求中原分支与目标分支的共同基准点
        /// </summary>
        [JsonProperty("base_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseSha { get; set; }

        /// <summary>
        /// 合并请求中，从共同基准点开始到原分支方向的第一个提交点
        /// </summary>
        [JsonProperty("start_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string StartSha { get; set; }

        /// <summary>
        /// 合并请求中原分支指向的提交点
        /// </summary>
        [JsonProperty("head_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string HeadSha { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiffRefsParamDto {\n");
            sb.Append("  baseSha: ").Append(BaseSha).Append("\n");
            sb.Append("  startSha: ").Append(StartSha).Append("\n");
            sb.Append("  headSha: ").Append(HeadSha).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiffRefsParamDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiffRefsParamDto input)
        {
            if (input == null) return false;
            if (this.BaseSha != input.BaseSha || (this.BaseSha != null && !this.BaseSha.Equals(input.BaseSha))) return false;
            if (this.StartSha != input.StartSha || (this.StartSha != null && !this.StartSha.Equals(input.StartSha))) return false;
            if (this.HeadSha != input.HeadSha || (this.HeadSha != null && !this.HeadSha.Equals(input.HeadSha))) return false;

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
                if (this.BaseSha != null) hashCode = hashCode * 59 + this.BaseSha.GetHashCode();
                if (this.StartSha != null) hashCode = hashCode * 59 + this.StartSha.GetHashCode();
                if (this.HeadSha != null) hashCode = hashCode * 59 + this.HeadSha.GetHashCode();
                return hashCode;
            }
        }
    }
}
