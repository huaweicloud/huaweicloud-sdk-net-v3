using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 创建clouddcn子网对象
    /// </summary>
    public class CreateClouddcnSubnetRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clouddcn_subnet", NullValueHandling = NullValueHandling.Ignore)]
        public CreateClouddcnSubnetOption ClouddcnSubnet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateClouddcnSubnetRequestBody {\n");
            sb.Append("  clouddcnSubnet: ").Append(ClouddcnSubnet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateClouddcnSubnetRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateClouddcnSubnetRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClouddcnSubnet == input.ClouddcnSubnet ||
                    (this.ClouddcnSubnet != null &&
                    this.ClouddcnSubnet.Equals(input.ClouddcnSubnet))
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
                if (this.ClouddcnSubnet != null)
                    hashCode = hashCode * 59 + this.ClouddcnSubnet.GetHashCode();
                return hashCode;
            }
        }
    }
}
