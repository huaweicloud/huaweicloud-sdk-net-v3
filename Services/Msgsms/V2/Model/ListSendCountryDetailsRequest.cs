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
    /// Request Object
    /// </summary>
    public class ListSendCountryDetailsRequest 
    {

        /// <summary>
        /// 国家(英文)
        /// </summary>
        [SDKProperty("country_name_en", IsQuery = true)]
        [JsonProperty("country_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryNameEn { get; set; }

        /// <summary>
        /// 国家(中文)
        /// </summary>
        [SDKProperty("country_name_zh", IsQuery = true)]
        [JsonProperty("country_name_zh", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryNameZh { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSendCountryDetailsRequest {\n");
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
            return this.Equals(input as ListSendCountryDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSendCountryDetailsRequest input)
        {
            if (input == null) return false;
            if (this.CountryNameEn != input.CountryNameEn || (this.CountryNameEn != null && !this.CountryNameEn.Equals(input.CountryNameEn))) return false;
            if (this.CountryNameZh != input.CountryNameZh || (this.CountryNameZh != null && !this.CountryNameZh.Equals(input.CountryNameZh))) return false;

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
                if (this.CountryNameEn != null) hashCode = hashCode * 59 + this.CountryNameEn.GetHashCode();
                if (this.CountryNameZh != null) hashCode = hashCode * 59 + this.CountryNameZh.GetHashCode();
                return hashCode;
            }
        }
    }
}
