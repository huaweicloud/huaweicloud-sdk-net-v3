using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExecutorPrimitiveTypeHolder 
    {

        /// <summary>
        /// 执行操作者的名字，将用做未来的审计工作
        /// </summary>
        [JsonProperty("executor", NullValueHandling = NullValueHandling.Ignore)]
        public string Executor { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutorPrimitiveTypeHolder {\n");
            sb.Append("  executor: ").Append(Executor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecutorPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecutorPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Executor == input.Executor ||
                    (this.Executor != null &&
                    this.Executor.Equals(input.Executor))
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
                if (this.Executor != null)
                    hashCode = hashCode * 59 + this.Executor.GetHashCode();
                return hashCode;
            }
        }
    }
}
