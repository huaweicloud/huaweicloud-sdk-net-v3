using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoSaturation 
    {

        /// <summary>
        /// 饱和度算法名称\&quot;“hw-saturation\&quot;。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 1 表示视频处理时第一个执行，2表示第二个执行，以此类推；除不执行，各视频处理算法的执行次序不可相同。 
        /// </summary>
        [JsonProperty("execution_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutionOrder { get; set; }

        /// <summary>
        /// 饱和度调节的程度， 值越大， 饱和度越高。 
        /// </summary>
        [JsonProperty("saturation", NullValueHandling = NullValueHandling.Ignore)]
        public string Saturation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoSaturation {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  executionOrder: ").Append(ExecutionOrder).Append("\n");
            sb.Append("  saturation: ").Append(Saturation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoSaturation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoSaturation input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ExecutionOrder != input.ExecutionOrder || (this.ExecutionOrder != null && !this.ExecutionOrder.Equals(input.ExecutionOrder))) return false;
            if (this.Saturation != input.Saturation || (this.Saturation != null && !this.Saturation.Equals(input.Saturation))) return false;

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
                if (this.ExecutionOrder != null) hashCode = hashCode * 59 + this.ExecutionOrder.GetHashCode();
                if (this.Saturation != null) hashCode = hashCode * 59 + this.Saturation.GetHashCode();
                return hashCode;
            }
        }
    }
}
