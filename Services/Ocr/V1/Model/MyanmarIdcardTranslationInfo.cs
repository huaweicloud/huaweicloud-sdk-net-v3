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
    public class MyanmarIdcardTranslationInfo 
    {

        /// <summary>
        /// 名字转译。仅当输入参数return_translation为true时，返回该字段。 
        /// </summary>
        [JsonProperty("name_translation", NullValueHandling = NullValueHandling.Ignore)]
        public string NameTranslation { get; set; }

        /// <summary>
        /// 父亲名字的转译。仅当输入参数return_translation为true时，返回该字段。 
        /// </summary>
        [JsonProperty("father_name_translation", NullValueHandling = NullValueHandling.Ignore)]
        public string FatherNameTranslation { get; set; }

        /// <summary>
        /// 身份证号码转译。仅当输入参数return_translation为true时，返回该字段。 
        /// </summary>
        [JsonProperty("nrc_id_translation", NullValueHandling = NullValueHandling.Ignore)]
        public string NrcIdTranslation { get; set; }

        /// <summary>
        /// 出生日期转译。仅当输入参数return_translation为true时，返回该字段。 
        /// </summary>
        [JsonProperty("birth_translation", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthTranslation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MyanmarIdcardTranslationInfo {\n");
            sb.Append("  nameTranslation: ").Append(NameTranslation).Append("\n");
            sb.Append("  fatherNameTranslation: ").Append(FatherNameTranslation).Append("\n");
            sb.Append("  nrcIdTranslation: ").Append(NrcIdTranslation).Append("\n");
            sb.Append("  birthTranslation: ").Append(BirthTranslation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MyanmarIdcardTranslationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MyanmarIdcardTranslationInfo input)
        {
            if (input == null) return false;
            if (this.NameTranslation != input.NameTranslation || (this.NameTranslation != null && !this.NameTranslation.Equals(input.NameTranslation))) return false;
            if (this.FatherNameTranslation != input.FatherNameTranslation || (this.FatherNameTranslation != null && !this.FatherNameTranslation.Equals(input.FatherNameTranslation))) return false;
            if (this.NrcIdTranslation != input.NrcIdTranslation || (this.NrcIdTranslation != null && !this.NrcIdTranslation.Equals(input.NrcIdTranslation))) return false;
            if (this.BirthTranslation != input.BirthTranslation || (this.BirthTranslation != null && !this.BirthTranslation.Equals(input.BirthTranslation))) return false;

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
                if (this.NameTranslation != null) hashCode = hashCode * 59 + this.NameTranslation.GetHashCode();
                if (this.FatherNameTranslation != null) hashCode = hashCode * 59 + this.FatherNameTranslation.GetHashCode();
                if (this.NrcIdTranslation != null) hashCode = hashCode * 59 + this.NrcIdTranslation.GetHashCode();
                if (this.BirthTranslation != null) hashCode = hashCode * 59 + this.BirthTranslation.GetHashCode();
                return hashCode;
            }
        }
    }
}
