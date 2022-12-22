using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 重试策略
    /// </summary>
    public class Retry 
    {

        /// <summary>
        /// 重试策略名称，在单个流程中，名称需要唯一
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 重试间隔，单位：秒。若不传，默认为1
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? Delay { get; set; }

        /// <summary>
        /// 最大重试次数，。若不传，默认为3
        /// </summary>
        [JsonProperty("max_attempts", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxAttempts { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Retry {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  maxAttempts: ").Append(MaxAttempts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Retry);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Retry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Delay == input.Delay ||
                    (this.Delay != null &&
                    this.Delay.Equals(input.Delay))
                ) && 
                (
                    this.MaxAttempts == input.MaxAttempts ||
                    (this.MaxAttempts != null &&
                    this.MaxAttempts.Equals(input.MaxAttempts))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Delay != null)
                    hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.MaxAttempts != null)
                    hashCode = hashCode * 59 + this.MaxAttempts.GetHashCode();
                return hashCode;
            }
        }
    }
}
