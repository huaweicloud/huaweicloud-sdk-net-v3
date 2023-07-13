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
    public class VideoDenoise 
    {

        /// <summary>
        /// 降噪算法名称\&quot;hw-denoise\&quot;、\&quot;waifu2x\&quot;。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 1 表示视频处理时第一个执行，2表示第二个执行，以此类推；除不执行，各视频处理算法的执行次序不可相同。 
        /// </summary>
        [JsonProperty("execution_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutionOrder { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoDenoise {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  executionOrder: ").Append(ExecutionOrder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoDenoise);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoDenoise input)
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
                    this.ExecutionOrder == input.ExecutionOrder ||
                    (this.ExecutionOrder != null &&
                    this.ExecutionOrder.Equals(input.ExecutionOrder))
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
                if (this.ExecutionOrder != null)
                    hashCode = hashCode * 59 + this.ExecutionOrder.GetHashCode();
                return hashCode;
            }
        }
    }
}
