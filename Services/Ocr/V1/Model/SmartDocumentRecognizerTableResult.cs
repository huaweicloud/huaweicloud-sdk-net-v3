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
    public class SmartDocumentRecognizerTableResult 
    {

        /// <summary>
        /// 模型识别到的表格数量。 
        /// </summary>
        [JsonProperty("table_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TableCount { get; set; }

        /// <summary>
        /// 表格识别结果列表。 
        /// </summary>
        [JsonProperty("table_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmartDocumentRecognizerTableBlock> TableList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartDocumentRecognizerTableResult {\n");
            sb.Append("  tableCount: ").Append(TableCount).Append("\n");
            sb.Append("  tableList: ").Append(TableList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartDocumentRecognizerTableResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerTableResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TableCount == input.TableCount ||
                    (this.TableCount != null &&
                    this.TableCount.Equals(input.TableCount))
                ) && 
                (
                    this.TableList == input.TableList ||
                    this.TableList != null &&
                    input.TableList != null &&
                    this.TableList.SequenceEqual(input.TableList)
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
                if (this.TableCount != null)
                    hashCode = hashCode * 59 + this.TableCount.GetHashCode();
                if (this.TableList != null)
                    hashCode = hashCode * 59 + this.TableList.GetHashCode();
                return hashCode;
            }
        }
    }
}
