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
    /// 算法输出通道信息。
    /// </summary>
    public class AlgorithmOutput 
    {

        /// <summary>
        /// 数据输出通道名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据输出通道映射的容器本地路径。
        /// </summary>
        [JsonProperty("local_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalDir { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remote", NullValueHandling = NullValueHandling.Ignore)]
        public Remote Remote { get; set; }

        /// <summary>
        /// 数据传输模式，默认为“upload_periodically”。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 数据传输周期，默认为30s。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlgorithmOutput {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  localDir: ").Append(LocalDir).Append("\n");
            sb.Append("  remote: ").Append(Remote).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlgorithmOutput);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlgorithmOutput input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.LocalDir != input.LocalDir || (this.LocalDir != null && !this.LocalDir.Equals(input.LocalDir))) return false;
            if (this.Remote != input.Remote || (this.Remote != null && !this.Remote.Equals(input.Remote))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LocalDir != null) hashCode = hashCode * 59 + this.LocalDir.GetHashCode();
                if (this.Remote != null) hashCode = hashCode * 59 + this.Remote.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                return hashCode;
            }
        }
    }
}
