using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// The address associated with the specified user.
    /// </summary>
    public class AddressDto 
    {

        /// <summary>
        /// 国家/地区
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 包含要显示的地址的格式化版本的字符串
        /// </summary>
        [JsonProperty("formatted", NullValueHandling = NullValueHandling.Ignore)]
        public string Formatted { get; set; }

        /// <summary>
        /// 地址位置
        /// </summary>
        [JsonProperty("locality", NullValueHandling = NullValueHandling.Ignore)]
        public string Locality { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        /// <summary>
        /// 一个布尔值，表示这是否是用户的主地址
        /// </summary>
        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        [JsonProperty("street_address", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// 表示地址类型的字符串
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressDto {\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  formatted: ").Append(Formatted).Append("\n");
            sb.Append("  locality: ").Append(Locality).Append("\n");
            sb.Append("  postalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  primary: ").Append(Primary).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  streetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddressDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddressDto input)
        {
            if (input == null) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.Formatted != input.Formatted || (this.Formatted != null && !this.Formatted.Equals(input.Formatted))) return false;
            if (this.Locality != input.Locality || (this.Locality != null && !this.Locality.Equals(input.Locality))) return false;
            if (this.PostalCode != input.PostalCode || (this.PostalCode != null && !this.PostalCode.Equals(input.PostalCode))) return false;
            if (this.Primary != input.Primary || (this.Primary != null && !this.Primary.Equals(input.Primary))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.StreetAddress != input.StreetAddress || (this.StreetAddress != null && !this.StreetAddress.Equals(input.StreetAddress))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Formatted != null) hashCode = hashCode * 59 + this.Formatted.GetHashCode();
                if (this.Locality != null) hashCode = hashCode * 59 + this.Locality.GetHashCode();
                if (this.PostalCode != null) hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Primary != null) hashCode = hashCode * 59 + this.Primary.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.StreetAddress != null) hashCode = hashCode * 59 + this.StreetAddress.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
