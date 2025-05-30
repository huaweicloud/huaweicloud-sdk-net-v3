using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class CreateMasterSlavePoolRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pool", NullValueHandling = NullValueHandling.Ignore)]
        public CreateMasterSlavePoolOption Pool { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMasterSlavePoolRequestBody {\n");
            sb.Append("  pool: ").Append(Pool).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateMasterSlavePoolRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateMasterSlavePoolRequestBody input)
        {
            if (input == null) return false;
            if (this.Pool != input.Pool || (this.Pool != null && !this.Pool.Equals(input.Pool))) return false;

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
                if (this.Pool != null) hashCode = hashCode * 59 + this.Pool.GetHashCode();
                return hashCode;
            }
        }
    }
}
