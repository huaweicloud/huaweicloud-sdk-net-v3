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
    public class SmartDocumentRecognizerFormResult 
    {

        /// <summary>
        /// 模型识别到的有线表单数量。 
        /// </summary>
        [JsonProperty("form_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FormCount { get; set; }

        /// <summary>
        /// 有线表单识别结果列表。 
        /// </summary>
        [JsonProperty("form_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmartDocumentRecognizerTableBlock> FormList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartDocumentRecognizerFormResult {\n");
            sb.Append("  formCount: ").Append(FormCount).Append("\n");
            sb.Append("  formList: ").Append(FormList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartDocumentRecognizerFormResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerFormResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FormCount == input.FormCount ||
                    (this.FormCount != null &&
                    this.FormCount.Equals(input.FormCount))
                ) && 
                (
                    this.FormList == input.FormList ||
                    this.FormList != null &&
                    input.FormList != null &&
                    this.FormList.SequenceEqual(input.FormList)
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
                if (this.FormCount != null)
                    hashCode = hashCode * 59 + this.FormCount.GetHashCode();
                if (this.FormList != null)
                    hashCode = hashCode * 59 + this.FormList.GetHashCode();
                return hashCode;
            }
        }
    }
}
