using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RunImageWisedesignCombineResponse : SdkResponse
    {

        /// <summary>
        /// 图片合成后图像的64位编码
        /// </summary>
        [JsonProperty("result_base64", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultBase64 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunImageWisedesignCombineResponse {\n");
            sb.Append("  resultBase64: ").Append(ResultBase64).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunImageWisedesignCombineResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunImageWisedesignCombineResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResultBase64 == input.ResultBase64 ||
                    (this.ResultBase64 != null &&
                    this.ResultBase64.Equals(input.ResultBase64))
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
                if (this.ResultBase64 != null)
                    hashCode = hashCode * 59 + this.ResultBase64.GetHashCode();
                return hashCode;
            }
        }
    }
}
