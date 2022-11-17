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
    /// Response Object
    /// </summary>
    public class ShowServerBlockDeviceResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volumeAttachment", NullValueHandling = NullValueHandling.Ignore)]
        public ServerBlockDevice VolumeAttachment { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerBlockDeviceResponse {\n");
            sb.Append("  volumeAttachment: ").Append(VolumeAttachment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerBlockDeviceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerBlockDeviceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VolumeAttachment == input.VolumeAttachment ||
                    (this.VolumeAttachment != null &&
                    this.VolumeAttachment.Equals(input.VolumeAttachment))
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
                if (this.VolumeAttachment != null)
                    hashCode = hashCode * 59 + this.VolumeAttachment.GetHashCode();
                return hashCode;
            }
        }
    }
}
