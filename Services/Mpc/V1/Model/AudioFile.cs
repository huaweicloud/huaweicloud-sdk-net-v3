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
    public class AudioFile 
    {

        /// <summary>
        /// 音轨信息
        /// </summary>
        [JsonProperty("tracks_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<TracksInfo> TracksInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Input { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioFile {\n");
            sb.Append("  tracksInfo: ").Append(TracksInfo).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioFile);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioFile input)
        {
            if (input == null) return false;
            if (this.TracksInfo != input.TracksInfo || (this.TracksInfo != null && input.TracksInfo != null && !this.TracksInfo.SequenceEqual(input.TracksInfo))) return false;
            if (this.Input != input.Input || (this.Input != null && !this.Input.Equals(input.Input))) return false;

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
                if (this.TracksInfo != null) hashCode = hashCode * 59 + this.TracksInfo.GetHashCode();
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                return hashCode;
            }
        }
    }
}
