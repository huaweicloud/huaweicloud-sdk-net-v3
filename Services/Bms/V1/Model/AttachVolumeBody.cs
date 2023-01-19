using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// 裸金属服务器挂载云硬盘接口请求结构体
    /// </summary>
    public class AttachVolumeBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volumeAttachment", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeAttachment VolumeAttachment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachVolumeBody {\n");
            sb.Append("  volumeAttachment: ").Append(VolumeAttachment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachVolumeBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachVolumeBody input)
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
