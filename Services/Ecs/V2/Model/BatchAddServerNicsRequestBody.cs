using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class BatchAddServerNicsRequestBody 
    {

        /// <summary>
        /// 需要添加的网卡参数列表。
        /// </summary>
        [JsonProperty("nics", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchAddServerNicOption> Nics { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAddServerNicsRequestBody {\n");
            sb.Append("  nics: ").Append(Nics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAddServerNicsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAddServerNicsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nics == input.Nics ||
                    this.Nics != null &&
                    input.Nics != null &&
                    this.Nics.SequenceEqual(input.Nics)
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
                if (this.Nics != null)
                    hashCode = hashCode * 59 + this.Nics.GetHashCode();
                return hashCode;
            }
        }
    }
}
