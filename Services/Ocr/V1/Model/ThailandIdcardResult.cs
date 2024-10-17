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
    public class ThailandIdcardResult 
    {

        /// <summary>
        /// 返回证件类型，\&quot;normal\&quot;表示普通泰文证件，\&quot;pink\&quot;表示外国人身份证件 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 英文名。 
        /// </summary>
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        /// <summary>
        /// 参考编码。 
        /// </summary>
        [JsonProperty("ref_number", NullValueHandling = NullValueHandling.Ignore)]
        public string RefNumber { get; set; }

        /// <summary>
        /// 标示正面还是反面，取值为front或back。 
        /// </summary>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public string Side { get; set; }

        /// <summary>
        /// 身份证号。 
        /// </summary>
        [JsonProperty("id_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IdNumber { get; set; }

        /// <summary>
        /// 泰文名字。 
        /// </summary>
        [JsonProperty("name_th", NullValueHandling = NullValueHandling.Ignore)]
        public string NameTh { get; set; }

        /// <summary>
        /// 英文名字。 
        /// </summary>
        [JsonProperty("first_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstNameEn { get; set; }

        /// <summary>
        /// 英文姓氏。 
        /// </summary>
        [JsonProperty("last_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string LastNameEn { get; set; }

        /// <summary>
        /// 泰文出生日期。 
        /// </summary>
        [JsonProperty("date_of_birth_th", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfBirthTh { get; set; }

        /// <summary>
        /// 英文出生日期。 
        /// </summary>
        [JsonProperty("date_of_birth_en", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfBirthEn { get; set; }

        /// <summary>
        /// 宗教。 
        /// </summary>
        [JsonProperty("religion_th", NullValueHandling = NullValueHandling.Ignore)]
        public string ReligionTh { get; set; }

        /// <summary>
        /// 地址。 
        /// </summary>
        [JsonProperty("address_th", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressTh { get; set; }

        /// <summary>
        /// 泰文签发日期。 
        /// </summary>
        [JsonProperty("date_of_issue_th", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfIssueTh { get; set; }

        /// <summary>
        /// 英文签发日期。 
        /// </summary>
        [JsonProperty("date_of_issue_en", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfIssueEn { get; set; }

        /// <summary>
        /// 泰文有效期。 
        /// </summary>
        [JsonProperty("date_of_expiry_th", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfExpiryTh { get; set; }

        /// <summary>
        /// 英文有效期。 
        /// </summary>
        [JsonProperty("date_of_expiry_en", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfExpiryEn { get; set; }

        /// <summary>
        /// 序列号。 
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 身份证反面卡号。 
        /// </summary>
        [JsonProperty("card_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CardNumber { get; set; }

        /// <summary>
        /// 激光码。 
        /// </summary>
        [JsonProperty("laser_number", NullValueHandling = NullValueHandling.Ignore)]
        public string LaserNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public ThailandIdcardConfidence Confidence { get; set; }

        /// <summary>
        /// 头像的base64编码。 当输入参数“return_portrait_image”为“true”时，才返回该参数。 
        /// </summary>
        [JsonProperty("portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public string PortraitImage { get; set; }

        /// <summary>
        /// 头像在原图上的位置。 当输入参数“return_portrait_location”为“true”时，才返回该参数。以列表形式显示，包含头像区域四个顶点的二维坐标（x,y），坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向 
        /// </summary>
        [JsonProperty("portrait_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> PortraitLocation { get; set; }

        /// <summary>
        /// 身份证的类型。取值如下所示： - normal：身份证原件 - copy：复印的身份证 - screen：屏幕翻拍 当输入参数“return_idcard_type”为“true”时，才返回该参数。 
        /// </summary>
        [JsonProperty("idcard_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IdcardType { get; set; }

        /// <summary>
        /// 对应所有在原图上识别到的字段位置信息，包含所有文字区域四个顶点的二维坐标（x,y）。采用图像坐标系，坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("text_location", NullValueHandling = NullValueHandling.Ignore)]
        public Object TextLocation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThailandIdcardResult {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  refNumber: ").Append(RefNumber).Append("\n");
            sb.Append("  side: ").Append(Side).Append("\n");
            sb.Append("  idNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  nameTh: ").Append(NameTh).Append("\n");
            sb.Append("  firstNameEn: ").Append(FirstNameEn).Append("\n");
            sb.Append("  lastNameEn: ").Append(LastNameEn).Append("\n");
            sb.Append("  dateOfBirthTh: ").Append(DateOfBirthTh).Append("\n");
            sb.Append("  dateOfBirthEn: ").Append(DateOfBirthEn).Append("\n");
            sb.Append("  religionTh: ").Append(ReligionTh).Append("\n");
            sb.Append("  addressTh: ").Append(AddressTh).Append("\n");
            sb.Append("  dateOfIssueTh: ").Append(DateOfIssueTh).Append("\n");
            sb.Append("  dateOfIssueEn: ").Append(DateOfIssueEn).Append("\n");
            sb.Append("  dateOfExpiryTh: ").Append(DateOfExpiryTh).Append("\n");
            sb.Append("  dateOfExpiryEn: ").Append(DateOfExpiryEn).Append("\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  cardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  laserNumber: ").Append(LaserNumber).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  portraitImage: ").Append(PortraitImage).Append("\n");
            sb.Append("  portraitLocation: ").Append(PortraitLocation).Append("\n");
            sb.Append("  idcardType: ").Append(IdcardType).Append("\n");
            sb.Append("  textLocation: ").Append(TextLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ThailandIdcardResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ThailandIdcardResult input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.NameEn != input.NameEn || (this.NameEn != null && !this.NameEn.Equals(input.NameEn))) return false;
            if (this.RefNumber != input.RefNumber || (this.RefNumber != null && !this.RefNumber.Equals(input.RefNumber))) return false;
            if (this.Side != input.Side || (this.Side != null && !this.Side.Equals(input.Side))) return false;
            if (this.IdNumber != input.IdNumber || (this.IdNumber != null && !this.IdNumber.Equals(input.IdNumber))) return false;
            if (this.NameTh != input.NameTh || (this.NameTh != null && !this.NameTh.Equals(input.NameTh))) return false;
            if (this.FirstNameEn != input.FirstNameEn || (this.FirstNameEn != null && !this.FirstNameEn.Equals(input.FirstNameEn))) return false;
            if (this.LastNameEn != input.LastNameEn || (this.LastNameEn != null && !this.LastNameEn.Equals(input.LastNameEn))) return false;
            if (this.DateOfBirthTh != input.DateOfBirthTh || (this.DateOfBirthTh != null && !this.DateOfBirthTh.Equals(input.DateOfBirthTh))) return false;
            if (this.DateOfBirthEn != input.DateOfBirthEn || (this.DateOfBirthEn != null && !this.DateOfBirthEn.Equals(input.DateOfBirthEn))) return false;
            if (this.ReligionTh != input.ReligionTh || (this.ReligionTh != null && !this.ReligionTh.Equals(input.ReligionTh))) return false;
            if (this.AddressTh != input.AddressTh || (this.AddressTh != null && !this.AddressTh.Equals(input.AddressTh))) return false;
            if (this.DateOfIssueTh != input.DateOfIssueTh || (this.DateOfIssueTh != null && !this.DateOfIssueTh.Equals(input.DateOfIssueTh))) return false;
            if (this.DateOfIssueEn != input.DateOfIssueEn || (this.DateOfIssueEn != null && !this.DateOfIssueEn.Equals(input.DateOfIssueEn))) return false;
            if (this.DateOfExpiryTh != input.DateOfExpiryTh || (this.DateOfExpiryTh != null && !this.DateOfExpiryTh.Equals(input.DateOfExpiryTh))) return false;
            if (this.DateOfExpiryEn != input.DateOfExpiryEn || (this.DateOfExpiryEn != null && !this.DateOfExpiryEn.Equals(input.DateOfExpiryEn))) return false;
            if (this.SerialNumber != input.SerialNumber || (this.SerialNumber != null && !this.SerialNumber.Equals(input.SerialNumber))) return false;
            if (this.CardNumber != input.CardNumber || (this.CardNumber != null && !this.CardNumber.Equals(input.CardNumber))) return false;
            if (this.LaserNumber != input.LaserNumber || (this.LaserNumber != null && !this.LaserNumber.Equals(input.LaserNumber))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;
            if (this.PortraitImage != input.PortraitImage || (this.PortraitImage != null && !this.PortraitImage.Equals(input.PortraitImage))) return false;
            if (this.PortraitLocation != input.PortraitLocation || (this.PortraitLocation != null && input.PortraitLocation != null && !this.PortraitLocation.SequenceEqual(input.PortraitLocation))) return false;
            if (this.IdcardType != input.IdcardType || (this.IdcardType != null && !this.IdcardType.Equals(input.IdcardType))) return false;
            if (this.TextLocation != input.TextLocation || (this.TextLocation != null && !this.TextLocation.Equals(input.TextLocation))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.NameEn != null) hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.RefNumber != null) hashCode = hashCode * 59 + this.RefNumber.GetHashCode();
                if (this.Side != null) hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.IdNumber != null) hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.NameTh != null) hashCode = hashCode * 59 + this.NameTh.GetHashCode();
                if (this.FirstNameEn != null) hashCode = hashCode * 59 + this.FirstNameEn.GetHashCode();
                if (this.LastNameEn != null) hashCode = hashCode * 59 + this.LastNameEn.GetHashCode();
                if (this.DateOfBirthTh != null) hashCode = hashCode * 59 + this.DateOfBirthTh.GetHashCode();
                if (this.DateOfBirthEn != null) hashCode = hashCode * 59 + this.DateOfBirthEn.GetHashCode();
                if (this.ReligionTh != null) hashCode = hashCode * 59 + this.ReligionTh.GetHashCode();
                if (this.AddressTh != null) hashCode = hashCode * 59 + this.AddressTh.GetHashCode();
                if (this.DateOfIssueTh != null) hashCode = hashCode * 59 + this.DateOfIssueTh.GetHashCode();
                if (this.DateOfIssueEn != null) hashCode = hashCode * 59 + this.DateOfIssueEn.GetHashCode();
                if (this.DateOfExpiryTh != null) hashCode = hashCode * 59 + this.DateOfExpiryTh.GetHashCode();
                if (this.DateOfExpiryEn != null) hashCode = hashCode * 59 + this.DateOfExpiryEn.GetHashCode();
                if (this.SerialNumber != null) hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.CardNumber != null) hashCode = hashCode * 59 + this.CardNumber.GetHashCode();
                if (this.LaserNumber != null) hashCode = hashCode * 59 + this.LaserNumber.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.PortraitImage != null) hashCode = hashCode * 59 + this.PortraitImage.GetHashCode();
                if (this.PortraitLocation != null) hashCode = hashCode * 59 + this.PortraitLocation.GetHashCode();
                if (this.IdcardType != null) hashCode = hashCode * 59 + this.IdcardType.GetHashCode();
                if (this.TextLocation != null) hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
