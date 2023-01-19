using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowUserInstancesResponse : SdkResponse
    {

        /// <summary>
        /// 非默认用户主密钥个数。
        /// </summary>
        [JsonProperty("instance_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserInstancesResponse {\n");
            sb.Append("  instanceNum: ").Append(InstanceNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserInstancesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceNum == input.InstanceNum ||
                    (this.InstanceNum != null &&
                    this.InstanceNum.Equals(input.InstanceNum))
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
                if (this.InstanceNum != null)
                    hashCode = hashCode * 59 + this.InstanceNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
