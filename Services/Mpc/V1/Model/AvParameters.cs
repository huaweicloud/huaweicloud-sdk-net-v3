using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AvParameters 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public VideoParameters Video { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public Audio Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("common", NullValueHandling = NullValueHandling.Ignore)]
        public Common Common { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvParameters {\n");
            sb.Append("  video: ").Append(Video).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("  common: ").Append(Common).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AvParameters);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AvParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Video == input.Video ||
                    (this.Video != null &&
                    this.Video.Equals(input.Video))
                ) && 
                (
                    this.Audio == input.Audio ||
                    (this.Audio != null &&
                    this.Audio.Equals(input.Audio))
                ) && 
                (
                    this.Common == input.Common ||
                    (this.Common != null &&
                    this.Common.Equals(input.Common))
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
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.Common != null)
                    hashCode = hashCode * 59 + this.Common.GetHashCode();
                return hashCode;
            }
        }
    }
}
