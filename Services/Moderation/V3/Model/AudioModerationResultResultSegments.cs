using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioModerationResultResultSegments 
    {

        /// <summary>
        /// 命中的风险片段
        /// </summary>
        [JsonProperty("segment", NullValueHandling = NullValueHandling.Ignore)]
        public string Segment { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioModerationResultResultSegments {\n");
            sb.Append("  segment: ").Append(Segment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioModerationResultResultSegments);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioModerationResultResultSegments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Segment == input.Segment ||
                    (this.Segment != null &&
                    this.Segment.Equals(input.Segment))
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
                if (this.Segment != null)
                    hashCode = hashCode * 59 + this.Segment.GetHashCode();
                return hashCode;
            }
        }
    }
}
