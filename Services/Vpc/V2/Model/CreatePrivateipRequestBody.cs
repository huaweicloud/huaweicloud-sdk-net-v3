using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreatePrivateipRequestBody 
    {

        /// <summary>
        /// 私有IP列表对象
        /// </summary>
        [JsonProperty("privateips", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreatePrivateipOption> Privateips { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePrivateipRequestBody {\n");
            sb.Append("  privateips: ").Append(Privateips).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePrivateipRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePrivateipRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Privateips == input.Privateips ||
                    this.Privateips != null &&
                    input.Privateips != null &&
                    this.Privateips.SequenceEqual(input.Privateips)
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
                if (this.Privateips != null)
                    hashCode = hashCode * 59 + this.Privateips.GetHashCode();
                return hashCode;
            }
        }
    }
}
