using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 修改文档分段参数。
    /// </summary>
    public class DocumentSegmentParam 
    {

        /// <summary>
        /// 分段类型 * 1: 自动分段 * 2: 手动分段
        /// </summary>
        [JsonProperty("split_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SplitType { get; set; }

        /// <summary>
        /// 分段长度。
        /// </summary>
        [JsonProperty("chunk_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// 分段策略，如果添加多个策略用逗号隔开。 取值示例： - title：用标题把一段话分割为多个段落。 - separator：用分隔符把一段话分割为多个段落。
        /// </summary>
        [JsonProperty("chunk_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ChunkType { get; set; }

        /// <summary>
        /// 分隔符
        /// </summary>
        [JsonProperty("separators", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Separators { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentSegmentParam {\n");
            sb.Append("  splitType: ").Append(SplitType).Append("\n");
            sb.Append("  chunkSize: ").Append(ChunkSize).Append("\n");
            sb.Append("  chunkType: ").Append(ChunkType).Append("\n");
            sb.Append("  separators: ").Append(Separators).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocumentSegmentParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DocumentSegmentParam input)
        {
            if (input == null) return false;
            if (this.SplitType != input.SplitType || (this.SplitType != null && !this.SplitType.Equals(input.SplitType))) return false;
            if (this.ChunkSize != input.ChunkSize || (this.ChunkSize != null && !this.ChunkSize.Equals(input.ChunkSize))) return false;
            if (this.ChunkType != input.ChunkType || (this.ChunkType != null && !this.ChunkType.Equals(input.ChunkType))) return false;
            if (this.Separators != input.Separators || (this.Separators != null && input.Separators != null && !this.Separators.SequenceEqual(input.Separators))) return false;

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
                if (this.SplitType != null) hashCode = hashCode * 59 + this.SplitType.GetHashCode();
                if (this.ChunkSize != null) hashCode = hashCode * 59 + this.ChunkSize.GetHashCode();
                if (this.ChunkType != null) hashCode = hashCode * 59 + this.ChunkType.GetHashCode();
                if (this.Separators != null) hashCode = hashCode * 59 + this.Separators.GetHashCode();
                return hashCode;
            }
        }
    }
}
