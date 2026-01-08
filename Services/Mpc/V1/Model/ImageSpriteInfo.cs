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
    public class ImageSpriteInfo 
    {

        /// <summary>
        /// 雪碧图中小图的行数。
        /// </summary>
        [JsonProperty("row_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RowCount { get; set; }

        /// <summary>
        /// 雪碧图中小图的列数。
        /// </summary>
        [JsonProperty("column_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColumnCount { get; set; }

        /// <summary>
        /// 雪碧图中小图数量。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 雪碧图小图宽度 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 雪碧图小图高度 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 每一张雪碧图大图的路径。 
        /// </summary>
        [JsonProperty("output_image_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OutputImageName { get; set; }

        /// <summary>
        /// 雪碧图子图位置与时间关系的 WebVtt 文件路径。WebVtt 文件表明了各个雪碧图小图对应的时间点，以及在雪碧大图里的坐标位置，一般被播放器用于实现预览。 
        /// </summary>
        [JsonProperty("output_webvtt_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputWebvttName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSpriteInfo {\n");
            sb.Append("  rowCount: ").Append(RowCount).Append("\n");
            sb.Append("  columnCount: ").Append(ColumnCount).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  outputImageName: ").Append(OutputImageName).Append("\n");
            sb.Append("  outputWebvttName: ").Append(OutputWebvttName).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageSpriteInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageSpriteInfo input)
        {
            if (input == null) return false;
            if (this.RowCount != input.RowCount || (this.RowCount != null && !this.RowCount.Equals(input.RowCount))) return false;
            if (this.ColumnCount != input.ColumnCount || (this.ColumnCount != null && !this.ColumnCount.Equals(input.ColumnCount))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.OutputImageName != input.OutputImageName || (this.OutputImageName != null && input.OutputImageName != null && !this.OutputImageName.SequenceEqual(input.OutputImageName))) return false;
            if (this.OutputWebvttName != input.OutputWebvttName || (this.OutputWebvttName != null && !this.OutputWebvttName.Equals(input.OutputWebvttName))) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;

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
                if (this.RowCount != null) hashCode = hashCode * 59 + this.RowCount.GetHashCode();
                if (this.ColumnCount != null) hashCode = hashCode * 59 + this.ColumnCount.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.OutputImageName != null) hashCode = hashCode * 59 + this.OutputImageName.GetHashCode();
                if (this.OutputWebvttName != null) hashCode = hashCode * 59 + this.OutputWebvttName.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                return hashCode;
            }
        }
    }
}
