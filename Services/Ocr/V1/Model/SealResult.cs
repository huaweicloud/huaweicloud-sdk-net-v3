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
    public class SealResult 
    {

        /// <summary>
        /// 印章信息列表。 
        /// </summary>
        [JsonProperty("seal_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SealList> SealList { get; set; }

        /// <summary>
        /// 在输入图片基础上进行印章擦除后的base64编码图片。 
        /// </summary>
        [JsonProperty("erased_seal_image", NullValueHandling = NullValueHandling.Ignore)]
        public string ErasedSealImage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SealResult {\n");
            sb.Append("  sealList: ").Append(SealList).Append("\n");
            sb.Append("  erasedSealImage: ").Append(ErasedSealImage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SealResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SealResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SealList == input.SealList ||
                    this.SealList != null &&
                    input.SealList != null &&
                    this.SealList.SequenceEqual(input.SealList)
                ) && 
                (
                    this.ErasedSealImage == input.ErasedSealImage ||
                    (this.ErasedSealImage != null &&
                    this.ErasedSealImage.Equals(input.ErasedSealImage))
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
                if (this.SealList != null)
                    hashCode = hashCode * 59 + this.SealList.GetHashCode();
                if (this.ErasedSealImage != null)
                    hashCode = hashCode * 59 + this.ErasedSealImage.GetHashCode();
                return hashCode;
            }
        }
    }
}
