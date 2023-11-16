using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFunctionTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 函数模板列表
        /// </summary>
        [JsonProperty("func_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowFunctionTemplateResponseBody> FuncTemplates { get; set; }

        /// <summary>
        /// 函数下次记录读取位置。
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public int? NextMarker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFunctionTemplateResponse {\n");
            sb.Append("  funcTemplates: ").Append(FuncTemplates).Append("\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFunctionTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFunctionTemplateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FuncTemplates == input.FuncTemplates ||
                    this.FuncTemplates != null &&
                    input.FuncTemplates != null &&
                    this.FuncTemplates.SequenceEqual(input.FuncTemplates)
                ) && 
                (
                    this.NextMarker == input.NextMarker ||
                    (this.NextMarker != null &&
                    this.NextMarker.Equals(input.NextMarker))
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
                if (this.FuncTemplates != null)
                    hashCode = hashCode * 59 + this.FuncTemplates.GetHashCode();
                if (this.NextMarker != null)
                    hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                return hashCode;
            }
        }
    }
}
