using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgentAddPathReq 
    {

        /// <summary>
        /// 增加备份路径详情
        /// </summary>
        [JsonProperty("add_path", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AddPath { get; set; }

        /// <summary>
        /// 增加排除目录 &gt; 该特性目前处于公测阶段，部分region可能无法使用。
        /// </summary>
        [JsonProperty("exclude_path", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExcludePath> ExcludePath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentAddPathReq {\n");
            sb.Append("  addPath: ").Append(AddPath).Append("\n");
            sb.Append("  excludePath: ").Append(ExcludePath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentAddPathReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentAddPathReq input)
        {
            if (input == null) return false;
            if (this.AddPath != input.AddPath || (this.AddPath != null && input.AddPath != null && !this.AddPath.SequenceEqual(input.AddPath))) return false;
            if (this.ExcludePath != input.ExcludePath || (this.ExcludePath != null && input.ExcludePath != null && !this.ExcludePath.SequenceEqual(input.ExcludePath))) return false;

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
                if (this.AddPath != null) hashCode = hashCode * 59 + this.AddPath.GetHashCode();
                if (this.ExcludePath != null) hashCode = hashCode * 59 + this.ExcludePath.GetHashCode();
                return hashCode;
            }
        }
    }
}
