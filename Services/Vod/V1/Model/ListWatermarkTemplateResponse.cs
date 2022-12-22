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
    /// Response Object
    /// </summary>
    public class ListWatermarkTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 水印模板信息。
        /// </summary>
        [JsonProperty("templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<WatermarkTemplate> Templates { get; set; }

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWatermarkTemplateResponse {\n");
            sb.Append("  templates: ").Append(Templates).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWatermarkTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWatermarkTemplateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Templates == input.Templates ||
                    this.Templates != null &&
                    input.Templates != null &&
                    this.Templates.SequenceEqual(input.Templates)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Templates != null)
                    hashCode = hashCode * 59 + this.Templates.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
