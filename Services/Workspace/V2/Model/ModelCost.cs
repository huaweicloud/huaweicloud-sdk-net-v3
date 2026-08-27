using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 模型费用信息。
    /// </summary>
    public class ModelCost 
    {

        /// <summary>
        /// 每百万输入Token费用。
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public double? Input { get; set; }

        /// <summary>
        /// 每百万输出Token费用。
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public double? Output { get; set; }

        /// <summary>
        /// 每百万缓存读取Token费用。
        /// </summary>
        [JsonProperty("cache_read", NullValueHandling = NullValueHandling.Ignore)]
        public double? CacheRead { get; set; }

        /// <summary>
        /// 每百万缓存写入Token费用。
        /// </summary>
        [JsonProperty("cache_write", NullValueHandling = NullValueHandling.Ignore)]
        public double? CacheWrite { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelCost {\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  cacheRead: ").Append(CacheRead).Append("\n");
            sb.Append("  cacheWrite: ").Append(CacheWrite).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelCost);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModelCost input)
        {
            if (input == null) return false;
            if (this.Input != input.Input || (this.Input != null && !this.Input.Equals(input.Input))) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;
            if (this.CacheRead != input.CacheRead || (this.CacheRead != null && !this.CacheRead.Equals(input.CacheRead))) return false;
            if (this.CacheWrite != input.CacheWrite || (this.CacheWrite != null && !this.CacheWrite.Equals(input.CacheWrite))) return false;

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
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.CacheRead != null) hashCode = hashCode * 59 + this.CacheRead.GetHashCode();
                if (this.CacheWrite != null) hashCode = hashCode * 59 + this.CacheWrite.GetHashCode();
                return hashCode;
            }
        }
    }
}
