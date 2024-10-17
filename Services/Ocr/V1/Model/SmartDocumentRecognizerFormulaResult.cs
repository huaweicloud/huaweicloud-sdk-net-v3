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
    public class SmartDocumentRecognizerFormulaResult 
    {

        /// <summary>
        /// 数学公式数量。 
        /// </summary>
        [JsonProperty("formula_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FormulaCount { get; set; }

        /// <summary>
        /// 数学公式识别结果列表。 
        /// </summary>
        [JsonProperty("formula_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmartDocumentRecognizerFormulaBlock> FormulaList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartDocumentRecognizerFormulaResult {\n");
            sb.Append("  formulaCount: ").Append(FormulaCount).Append("\n");
            sb.Append("  formulaList: ").Append(FormulaList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartDocumentRecognizerFormulaResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerFormulaResult input)
        {
            if (input == null) return false;
            if (this.FormulaCount != input.FormulaCount || (this.FormulaCount != null && !this.FormulaCount.Equals(input.FormulaCount))) return false;
            if (this.FormulaList != input.FormulaList || (this.FormulaList != null && input.FormulaList != null && !this.FormulaList.SequenceEqual(input.FormulaList))) return false;

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
                if (this.FormulaCount != null) hashCode = hashCode * 59 + this.FormulaCount.GetHashCode();
                if (this.FormulaList != null) hashCode = hashCode * 59 + this.FormulaList.GetHashCode();
                return hashCode;
            }
        }
    }
}
