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
    /// 训练作业可视化日志输出，log_type非空时必填。
    /// </summary>
    public class LogDirResp 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pfs", NullValueHandling = NullValueHandling.Ignore)]
        public PFSSummaryResp Pfs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogDirResp {\n");
            sb.Append("  pfs: ").Append(Pfs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogDirResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogDirResp input)
        {
            if (input == null) return false;
            if (this.Pfs != input.Pfs || (this.Pfs != null && !this.Pfs.Equals(input.Pfs))) return false;

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
                if (this.Pfs != null) hashCode = hashCode * 59 + this.Pfs.GetHashCode();
                return hashCode;
            }
        }
    }
}
