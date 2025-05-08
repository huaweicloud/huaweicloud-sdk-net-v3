using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EditMediaTaskInput 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo Input { get; set; }

        /// <summary>
        /// 剪切开始时间
        /// </summary>
        [JsonProperty("timeline_start", NullValueHandling = NullValueHandling.Ignore)]
        public string TimelineStart { get; set; }

        /// <summary>
        /// 剪切结束时间
        /// </summary>
        [JsonProperty("timeline_end", NullValueHandling = NullValueHandling.Ignore)]
        public string TimelineEnd { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditMediaTaskInput {\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  timelineStart: ").Append(TimelineStart).Append("\n");
            sb.Append("  timelineEnd: ").Append(TimelineEnd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EditMediaTaskInput);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EditMediaTaskInput input)
        {
            if (input == null) return false;
            if (this.Input != input.Input || (this.Input != null && !this.Input.Equals(input.Input))) return false;
            if (this.TimelineStart != input.TimelineStart || (this.TimelineStart != null && !this.TimelineStart.Equals(input.TimelineStart))) return false;
            if (this.TimelineEnd != input.TimelineEnd || (this.TimelineEnd != null && !this.TimelineEnd.Equals(input.TimelineEnd))) return false;

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
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.TimelineStart != null) hashCode = hashCode * 59 + this.TimelineStart.GetHashCode();
                if (this.TimelineEnd != null) hashCode = hashCode * 59 + this.TimelineEnd.GetHashCode();
                return hashCode;
            }
        }
    }
}
