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
    public class SegmentResult 
    {

        /// <summary>
        /// 命中的风险片段。
        /// </summary>
        [JsonProperty("segment", NullValueHandling = NullValueHandling.Ignore)]
        public string Segment { get; set; }

        /// <summary>
        /// 命中的自定义词库名称。  命中自定义词库时，才会返回当前字段。
        /// </summary>
        [JsonProperty("glossary_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GlossaryName { get; set; }

        /// <summary>
        /// 命中的风险片段在文本中的位置，起始位置从0开始
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Position { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SegmentResult {\n");
            sb.Append("  segment: ").Append(Segment).Append("\n");
            sb.Append("  glossaryName: ").Append(GlossaryName).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SegmentResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SegmentResult input)
        {
            if (input == null) return false;
            if (this.Segment != input.Segment || (this.Segment != null && !this.Segment.Equals(input.Segment))) return false;
            if (this.GlossaryName != input.GlossaryName || (this.GlossaryName != null && !this.GlossaryName.Equals(input.GlossaryName))) return false;
            if (this.Position != input.Position || (this.Position != null && input.Position != null && !this.Position.SequenceEqual(input.Position))) return false;

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
                if (this.Segment != null) hashCode = hashCode * 59 + this.Segment.GetHashCode();
                if (this.GlossaryName != null) hashCode = hashCode * 59 + this.GlossaryName.GetHashCode();
                if (this.Position != null) hashCode = hashCode * 59 + this.Position.GetHashCode();
                return hashCode;
            }
        }
    }
}
