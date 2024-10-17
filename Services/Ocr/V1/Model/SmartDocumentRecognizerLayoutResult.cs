using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SmartDocumentRecognizerLayoutResult 
    {

        /// <summary>
        /// 模型识别到的文档版面区域数量。        
        /// </summary>
        [JsonProperty("layout_block_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? LayoutBlockCount { get; set; }

        /// <summary>
        /// 文档版面区域识别结果列表。 
        /// </summary>
        [JsonProperty("layout_block_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmartDocumentRecognizerLayoutBlock> LayoutBlockList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartDocumentRecognizerLayoutResult {\n");
            sb.Append("  layoutBlockCount: ").Append(LayoutBlockCount).Append("\n");
            sb.Append("  layoutBlockList: ").Append(LayoutBlockList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartDocumentRecognizerLayoutResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerLayoutResult input)
        {
            if (input == null) return false;
            if (this.LayoutBlockCount != input.LayoutBlockCount || (this.LayoutBlockCount != null && !this.LayoutBlockCount.Equals(input.LayoutBlockCount))) return false;
            if (this.LayoutBlockList != input.LayoutBlockList || (this.LayoutBlockList != null && input.LayoutBlockList != null && !this.LayoutBlockList.SequenceEqual(input.LayoutBlockList))) return false;

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
                if (this.LayoutBlockCount != null) hashCode = hashCode * 59 + this.LayoutBlockCount.GetHashCode();
                if (this.LayoutBlockList != null) hashCode = hashCode * 59 + this.LayoutBlockList.GetHashCode();
                return hashCode;
            }
        }
    }
}
