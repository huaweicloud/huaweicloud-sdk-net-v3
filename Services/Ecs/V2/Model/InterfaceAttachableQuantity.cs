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
    /// 
    /// </summary>
    public class InterfaceAttachableQuantity 
    {

        /// <summary>
        /// 云服务器剩余可挂载网卡数量
        /// </summary>
        [JsonProperty("free_nic", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeNic { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterfaceAttachableQuantity {\n");
            sb.Append("  freeNic: ").Append(FreeNic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InterfaceAttachableQuantity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InterfaceAttachableQuantity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FreeNic == input.FreeNic ||
                    (this.FreeNic != null &&
                    this.FreeNic.Equals(input.FreeNic))
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
                if (this.FreeNic != null)
                    hashCode = hashCode * 59 + this.FreeNic.GetHashCode();
                return hashCode;
            }
        }
    }
}
