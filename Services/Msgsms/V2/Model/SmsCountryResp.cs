using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Msgsms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SmsCountryResp 
    {

        /// <summary>
        /// 国家id
        /// </summary>
        [JsonProperty("country_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CountryId { get; set; }

        /// <summary>
        /// 国家(英文)
        /// </summary>
        [JsonProperty("country_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryNameEn { get; set; }

        /// <summary>
        /// 国家(中文)
        /// </summary>
        [JsonProperty("country_name_zh", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryNameZh { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsCountryResp {\n");
            sb.Append("  countryId: ").Append(CountryId).Append("\n");
            sb.Append("  countryNameEn: ").Append(CountryNameEn).Append("\n");
            sb.Append("  countryNameZh: ").Append(CountryNameZh).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmsCountryResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmsCountryResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
                ) && 
                (
                    this.CountryNameEn == input.CountryNameEn ||
                    (this.CountryNameEn != null &&
                    this.CountryNameEn.Equals(input.CountryNameEn))
                ) && 
                (
                    this.CountryNameZh == input.CountryNameZh ||
                    (this.CountryNameZh != null &&
                    this.CountryNameZh.Equals(input.CountryNameZh))
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
                if (this.CountryId != null)
                    hashCode = hashCode * 59 + this.CountryId.GetHashCode();
                if (this.CountryNameEn != null)
                    hashCode = hashCode * 59 + this.CountryNameEn.GetHashCode();
                if (this.CountryNameZh != null)
                    hashCode = hashCode * 59 + this.CountryNameZh.GetHashCode();
                return hashCode;
            }
        }
    }
}
