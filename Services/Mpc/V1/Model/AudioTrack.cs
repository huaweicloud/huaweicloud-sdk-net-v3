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
    public class AudioTrack 
    {

        /// <summary>
        /// 音轨选取方式。 - 0：默认选取 - 1：手动选择 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// 选取左声道所在的音轨编号。 
        /// </summary>
        [JsonProperty("left", NullValueHandling = NullValueHandling.Ignore)]
        public int? Left { get; set; }

        /// <summary>
        /// 选取右声道所在的音轨编号。 
        /// </summary>
        [JsonProperty("right", NullValueHandling = NullValueHandling.Ignore)]
        public int? Right { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioTrack {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  left: ").Append(Left).Append("\n");
            sb.Append("  right: ").Append(Right).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioTrack);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioTrack input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
                ) && 
                (
                    this.Right == input.Right ||
                    (this.Right != null &&
                    this.Right.Equals(input.Right))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Left != null)
                    hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Right != null)
                    hashCode = hashCode * 59 + this.Right.GetHashCode();
                return hashCode;
            }
        }
    }
}
