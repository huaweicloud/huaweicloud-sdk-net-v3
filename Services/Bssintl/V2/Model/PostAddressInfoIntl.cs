using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PostAddressInfoIntl 
    {

        /// <summary>
        /// 收件人地址。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 收件人。
        /// </summary>
        [JsonProperty("recipients", NullValueHandling = NullValueHandling.Ignore)]
        public string Recipients { get; set; }

        /// <summary>
        /// 收件所在地邮政编码。
        /// </summary>
        [JsonProperty("zipCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ZipCode { get; set; }

        /// <summary>
        /// 收件人手机号码。
        /// </summary>
        [JsonProperty("mobilePhone", NullValueHandling = NullValueHandling.Ignore)]
        public string MobilePhone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostAddressInfoIntl {\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  recipients: ").Append(Recipients).Append("\n");
            sb.Append("  zipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  mobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostAddressInfoIntl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostAddressInfoIntl input)
        {
            if (input == null) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.Recipients != input.Recipients || (this.Recipients != null && !this.Recipients.Equals(input.Recipients))) return false;
            if (this.ZipCode != input.ZipCode || (this.ZipCode != null && !this.ZipCode.Equals(input.ZipCode))) return false;
            if (this.MobilePhone != input.MobilePhone || (this.MobilePhone != null && !this.MobilePhone.Equals(input.MobilePhone))) return false;

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
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Recipients != null) hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.ZipCode != null) hashCode = hashCode * 59 + this.ZipCode.GetHashCode();
                if (this.MobilePhone != null) hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                return hashCode;
            }
        }
    }
}
