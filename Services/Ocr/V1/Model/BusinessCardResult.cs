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
    public class BusinessCardResult 
    {

        /// <summary>
        /// 姓名列表。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 职位头衔列表。 
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Title { get; set; }

        /// <summary>
        /// 公司列表。 
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Company { get; set; }

        /// <summary>
        /// 部门列表。 
        /// </summary>
        [JsonProperty("department", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Department { get; set; }

        /// <summary>
        /// 联系方式列表。 
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Phone { get; set; }

        /// <summary>
        /// 地址列表。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Address { get; set; }

        /// <summary>
        /// 邮箱列表。 
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Email { get; set; }

        /// <summary>
        /// 传真列表。 
        /// </summary>
        [JsonProperty("fax", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fax { get; set; }

        /// <summary>
        /// 邮编列表。 
        /// </summary>
        [JsonProperty("postcode", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Postcode { get; set; }

        /// <summary>
        /// 公司网址列表。 
        /// </summary>
        [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Website { get; set; }

        /// <summary>
        /// 其余信息列表。 
        /// </summary>
        [JsonProperty("extra_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtraInfoList> ExtraInfoList { get; set; }

        /// <summary>
        /// 返回矫正后的名片图像的BASE64编码。 
        /// </summary>
        [JsonProperty("adjusted_image", NullValueHandling = NullValueHandling.Ignore)]
        public string AdjustedImage { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessCardResult {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  company: ").Append(Company).Append("\n");
            sb.Append("  department: ").Append(Department).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  fax: ").Append(Fax).Append("\n");
            sb.Append("  postcode: ").Append(Postcode).Append("\n");
            sb.Append("  website: ").Append(Website).Append("\n");
            sb.Append("  extraInfoList: ").Append(ExtraInfoList).Append("\n");
            sb.Append("  adjustedImage: ").Append(AdjustedImage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessCardResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BusinessCardResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.Title == input.Title ||
                    this.Title != null &&
                    input.Title != null &&
                    this.Title.SequenceEqual(input.Title)
                ) && 
                (
                    this.Company == input.Company ||
                    this.Company != null &&
                    input.Company != null &&
                    this.Company.SequenceEqual(input.Company)
                ) && 
                (
                    this.Department == input.Department ||
                    this.Department != null &&
                    input.Department != null &&
                    this.Department.SequenceEqual(input.Department)
                ) && 
                (
                    this.Phone == input.Phone ||
                    this.Phone != null &&
                    input.Phone != null &&
                    this.Phone.SequenceEqual(input.Phone)
                ) && 
                (
                    this.Address == input.Address ||
                    this.Address != null &&
                    input.Address != null &&
                    this.Address.SequenceEqual(input.Address)
                ) && 
                (
                    this.Email == input.Email ||
                    this.Email != null &&
                    input.Email != null &&
                    this.Email.SequenceEqual(input.Email)
                ) && 
                (
                    this.Fax == input.Fax ||
                    this.Fax != null &&
                    input.Fax != null &&
                    this.Fax.SequenceEqual(input.Fax)
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    this.Postcode != null &&
                    input.Postcode != null &&
                    this.Postcode.SequenceEqual(input.Postcode)
                ) && 
                (
                    this.Website == input.Website ||
                    this.Website != null &&
                    input.Website != null &&
                    this.Website.SequenceEqual(input.Website)
                ) && 
                (
                    this.ExtraInfoList == input.ExtraInfoList ||
                    this.ExtraInfoList != null &&
                    input.ExtraInfoList != null &&
                    this.ExtraInfoList.SequenceEqual(input.ExtraInfoList)
                ) && 
                (
                    this.AdjustedImage == input.AdjustedImage ||
                    (this.AdjustedImage != null &&
                    this.AdjustedImage.Equals(input.AdjustedImage))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Website != null)
                    hashCode = hashCode * 59 + this.Website.GetHashCode();
                if (this.ExtraInfoList != null)
                    hashCode = hashCode * 59 + this.ExtraInfoList.GetHashCode();
                if (this.AdjustedImage != null)
                    hashCode = hashCode * 59 + this.AdjustedImage.GetHashCode();
                return hashCode;
            }
        }
    }
}
