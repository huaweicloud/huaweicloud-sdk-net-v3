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
    public class SmartDocumentRecognizerKvResult 
    {

        /// <summary>
        /// 模型识别到的键值对数量。 
        /// </summary>
        [JsonProperty("kv_block_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? KvBlockCount { get; set; }

        /// <summary>
        /// 键值对识别结果列表。 
        /// </summary>
        [JsonProperty("kv_block_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmartDocumentRecognizerKVBlock> KvBlockList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartDocumentRecognizerKvResult {\n");
            sb.Append("  kvBlockCount: ").Append(KvBlockCount).Append("\n");
            sb.Append("  kvBlockList: ").Append(KvBlockList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartDocumentRecognizerKvResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerKvResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KvBlockCount == input.KvBlockCount ||
                    (this.KvBlockCount != null &&
                    this.KvBlockCount.Equals(input.KvBlockCount))
                ) && 
                (
                    this.KvBlockList == input.KvBlockList ||
                    this.KvBlockList != null &&
                    input.KvBlockList != null &&
                    this.KvBlockList.SequenceEqual(input.KvBlockList)
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
                if (this.KvBlockCount != null)
                    hashCode = hashCode * 59 + this.KvBlockCount.GetHashCode();
                if (this.KvBlockList != null)
                    hashCode = hashCode * 59 + this.KvBlockList.GetHashCode();
                return hashCode;
            }
        }
    }
}
