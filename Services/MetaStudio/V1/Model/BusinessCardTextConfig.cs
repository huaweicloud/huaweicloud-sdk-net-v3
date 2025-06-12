using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 用户输入的数字人名片信息。实际可以填写哪些字段取决于名片模板。
    /// </summary>
    public class BusinessCardTextConfig 
    {

        /// <summary>
        /// 姓名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 企业或组织名称。
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }

        /// <summary>
        /// 职位名称。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 手机号码。
        /// </summary>
        [JsonProperty("mobile_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 固话号码。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// 电子邮件地址。
        /// </summary>
        [JsonProperty("mail", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail { get; set; }

        /// <summary>
        /// 地址。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 其他信息1。可填写一些公司广告语等
        /// </summary>
        [JsonProperty("other1", NullValueHandling = NullValueHandling.Ignore)]
        public string Other1 { get; set; }

        /// <summary>
        /// 其他信息2。可填写一些公司广告语等
        /// </summary>
        [JsonProperty("other2", NullValueHandling = NullValueHandling.Ignore)]
        public string Other2 { get; set; }

        /// <summary>
        /// 其他信息3。可填写一些公司广告语等
        /// </summary>
        [JsonProperty("other3", NullValueHandling = NullValueHandling.Ignore)]
        public string Other3 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessCardTextConfig {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  company: ").Append(Company).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  mobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  mail: ").Append(Mail).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  other1: ").Append(Other1).Append("\n");
            sb.Append("  other2: ").Append(Other2).Append("\n");
            sb.Append("  other3: ").Append(Other3).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessCardTextConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BusinessCardTextConfig input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Company != input.Company || (this.Company != null && !this.Company.Equals(input.Company))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.MobilePhone != input.MobilePhone || (this.MobilePhone != null && !this.MobilePhone.Equals(input.MobilePhone))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Mail != input.Mail || (this.Mail != null && !this.Mail.Equals(input.Mail))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.Other1 != input.Other1 || (this.Other1 != null && !this.Other1.Equals(input.Other1))) return false;
            if (this.Other2 != input.Other2 || (this.Other2 != null && !this.Other2.Equals(input.Other2))) return false;
            if (this.Other3 != input.Other3 || (this.Other3 != null && !this.Other3.Equals(input.Other3))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Company != null) hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.MobilePhone != null) hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Mail != null) hashCode = hashCode * 59 + this.Mail.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Other1 != null) hashCode = hashCode * 59 + this.Other1.GetHashCode();
                if (this.Other2 != null) hashCode = hashCode * 59 + this.Other2.GetHashCode();
                if (this.Other3 != null) hashCode = hashCode * 59 + this.Other3.GetHashCode();
                return hashCode;
            }
        }
    }
}
