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
    public class VideoSharp 
    {

        /// <summary>
        /// 锐化算法名称\&quot;hw-sharp\&quot;。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 1 表示视频处理时第一个执行，2表示第二个执行，以此类推；除不执行，各视频处理算法的执行次序不可相同。 
        /// </summary>
        [JsonProperty("execution_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutionOrder { get; set; }

        /// <summary>
        /// 锐化的程度， 值越大，锐化越强。 
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoSharp {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  executionOrder: ").Append(ExecutionOrder).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoSharp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoSharp input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ExecutionOrder != input.ExecutionOrder || (this.ExecutionOrder != null && !this.ExecutionOrder.Equals(input.ExecutionOrder))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;

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
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                return hashCode;
            }
        }
    }
}
