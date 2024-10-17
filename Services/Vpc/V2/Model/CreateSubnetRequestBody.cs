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
    /// 创建子网对象
    /// </summary>
    public class CreateSubnetRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subnet", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubnetOption Subnet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubnetRequestBody {\n");
            sb.Append("  subnet: ").Append(Subnet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubnetRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubnetRequestBody input)
        {
            if (input == null) return false;
            if (this.Subnet != input.Subnet || (this.Subnet != null && !this.Subnet.Equals(input.Subnet))) return false;

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
                if (this.Subnet != null) hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                return hashCode;
            }
        }
    }
}
