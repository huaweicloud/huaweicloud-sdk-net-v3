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
    public class SmartDocumentRecognizerResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ocr_result", NullValueHandling = NullValueHandling.Ignore)]
        public SmartDocumentRecognizerOcrResult OcrResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kv_result", NullValueHandling = NullValueHandling.Ignore)]
        public SmartDocumentRecognizerKvResult KvResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("table_result", NullValueHandling = NullValueHandling.Ignore)]
        public SmartDocumentRecognizerTableResult TableResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("layout_result", NullValueHandling = NullValueHandling.Ignore)]
        public SmartDocumentRecognizerLayoutResult LayoutResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartDocumentRecognizerResult {\n");
            sb.Append("  ocrResult: ").Append(OcrResult).Append("\n");
            sb.Append("  kvResult: ").Append(KvResult).Append("\n");
            sb.Append("  tableResult: ").Append(TableResult).Append("\n");
            sb.Append("  layoutResult: ").Append(LayoutResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartDocumentRecognizerResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OcrResult == input.OcrResult ||
                    (this.OcrResult != null &&
                    this.OcrResult.Equals(input.OcrResult))
                ) && 
                (
                    this.KvResult == input.KvResult ||
                    (this.KvResult != null &&
                    this.KvResult.Equals(input.KvResult))
                ) && 
                (
                    this.TableResult == input.TableResult ||
                    (this.TableResult != null &&
                    this.TableResult.Equals(input.TableResult))
                ) && 
                (
                    this.LayoutResult == input.LayoutResult ||
                    (this.LayoutResult != null &&
                    this.LayoutResult.Equals(input.LayoutResult))
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
                if (this.OcrResult != null)
                    hashCode = hashCode * 59 + this.OcrResult.GetHashCode();
                if (this.KvResult != null)
                    hashCode = hashCode * 59 + this.KvResult.GetHashCode();
                if (this.TableResult != null)
                    hashCode = hashCode * 59 + this.TableResult.GetHashCode();
                if (this.LayoutResult != null)
                    hashCode = hashCode * 59 + this.LayoutResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
