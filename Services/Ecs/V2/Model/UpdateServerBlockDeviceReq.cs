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
    public class UpdateServerBlockDeviceReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("block_device", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateServerBlockDeviceOption BlockDevice { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateServerBlockDeviceReq {\n");
            sb.Append("  blockDevice: ").Append(BlockDevice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateServerBlockDeviceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateServerBlockDeviceReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlockDevice == input.BlockDevice ||
                    (this.BlockDevice != null &&
                    this.BlockDevice.Equals(input.BlockDevice))
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
                if (this.BlockDevice != null)
                    hashCode = hashCode * 59 + this.BlockDevice.GetHashCode();
                return hashCode;
            }
        }
    }
}
