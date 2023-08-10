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
    public class MyanmarIdcardResult 
    {

        /// <summary>
        /// 标示正面还是反面，取值为front或back。 
        /// </summary>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public string Side { get; set; }

        /// <summary>
        /// 身份证类型。取值如下所示： - new_version：新版身份证 - old_version：旧版 
        /// </summary>
        [JsonProperty("class", NullValueHandling = NullValueHandling.Ignore)]
        public string Class { get; set; }

        /// <summary>
        /// 身份证号码。 
        /// </summary>
        [JsonProperty("nrc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NrcId { get; set; }

        /// <summary>
        /// 签发日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 姓名。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 父亲名字。 
        /// </summary>
        [JsonProperty("father_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FatherName { get; set; }

        /// <summary>
        /// 出生日期。 
        /// </summary>
        [JsonProperty("birth", NullValueHandling = NullValueHandling.Ignore)]
        public string Birth { get; set; }

        /// <summary>
        /// 族群或宗教。 
        /// </summary>
        [JsonProperty("bloodlines_religion", NullValueHandling = NullValueHandling.Ignore)]
        public string BloodlinesReligion { get; set; }

        /// <summary>
        /// 身高。 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }

        /// <summary>
        /// 血型。 
        /// </summary>
        [JsonProperty("blood_group", NullValueHandling = NullValueHandling.Ignore)]
        public string BloodGroup { get; set; }

        /// <summary>
        /// 身份证的卡号（背面）。 
        /// </summary>
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; set; }

        /// <summary>
        /// 背面的身份证号码。 
        /// </summary>
        [JsonProperty("nrc_id_back", NullValueHandling = NullValueHandling.Ignore)]
        public string NrcIdBack { get; set; }

        /// <summary>
        /// 职业。 
        /// </summary>
        [JsonProperty("profession", NullValueHandling = NullValueHandling.Ignore)]
        public string Profession { get; set; }

        /// <summary>
        /// 地址。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public MyanmarIdcardConfidence Confidence { get; set; }

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
        /// 身份证的类型。取值如下所示： - normal：身份证原件 - copy：复印的身份证 当输入参数“return_idcard_type”为“true”时，才返回该参数。 
        /// </summary>
        [JsonProperty("idcard_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IdcardType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("translation_info", NullValueHandling = NullValueHandling.Ignore)]
        public MyanmarIdcardTranslationInfo TranslationInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MyanmarIdcardResult {\n");
            sb.Append("  side: ").Append(Side).Append("\n");
            sb.Append("  Class: ").Append(Class).Append("\n");
            sb.Append("  nrcId: ").Append(NrcId).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  fatherName: ").Append(FatherName).Append("\n");
            sb.Append("  birth: ").Append(Birth).Append("\n");
            sb.Append("  bloodlinesReligion: ").Append(BloodlinesReligion).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  bloodGroup: ").Append(BloodGroup).Append("\n");
            sb.Append("  cardId: ").Append(CardId).Append("\n");
            sb.Append("  nrcIdBack: ").Append(NrcIdBack).Append("\n");
            sb.Append("  profession: ").Append(Profession).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  portraitImage: ").Append(PortraitImage).Append("\n");
            sb.Append("  portraitLocation: ").Append(PortraitLocation).Append("\n");
            sb.Append("  idcardType: ").Append(IdcardType).Append("\n");
            sb.Append("  translationInfo: ").Append(TranslationInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MyanmarIdcardResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MyanmarIdcardResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.Class == input.Class ||
                    (this.Class != null &&
                    this.Class.Equals(input.Class))
                ) && 
                (
                    this.NrcId == input.NrcId ||
                    (this.NrcId != null &&
                    this.NrcId.Equals(input.NrcId))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FatherName == input.FatherName ||
                    (this.FatherName != null &&
                    this.FatherName.Equals(input.FatherName))
                ) && 
                (
                    this.Birth == input.Birth ||
                    (this.Birth != null &&
                    this.Birth.Equals(input.Birth))
                ) && 
                (
                    this.BloodlinesReligion == input.BloodlinesReligion ||
                    (this.BloodlinesReligion != null &&
                    this.BloodlinesReligion.Equals(input.BloodlinesReligion))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.BloodGroup == input.BloodGroup ||
                    (this.BloodGroup != null &&
                    this.BloodGroup.Equals(input.BloodGroup))
                ) && 
                (
                    this.CardId == input.CardId ||
                    (this.CardId != null &&
                    this.CardId.Equals(input.CardId))
                ) && 
                (
                    this.NrcIdBack == input.NrcIdBack ||
                    (this.NrcIdBack != null &&
                    this.NrcIdBack.Equals(input.NrcIdBack))
                ) && 
                (
                    this.Profession == input.Profession ||
                    (this.Profession != null &&
                    this.Profession.Equals(input.Profession))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.PortraitImage == input.PortraitImage ||
                    (this.PortraitImage != null &&
                    this.PortraitImage.Equals(input.PortraitImage))
                ) && 
                (
                    this.PortraitLocation == input.PortraitLocation ||
                    this.PortraitLocation != null &&
                    input.PortraitLocation != null &&
                    this.PortraitLocation.SequenceEqual(input.PortraitLocation)
                ) && 
                (
                    this.IdcardType == input.IdcardType ||
                    (this.IdcardType != null &&
                    this.IdcardType.Equals(input.IdcardType))
                ) && 
                (
                    this.TranslationInfo == input.TranslationInfo ||
                    (this.TranslationInfo != null &&
                    this.TranslationInfo.Equals(input.TranslationInfo))
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
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Class != null)
                    hashCode = hashCode * 59 + this.Class.GetHashCode();
                if (this.NrcId != null)
                    hashCode = hashCode * 59 + this.NrcId.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FatherName != null)
                    hashCode = hashCode * 59 + this.FatherName.GetHashCode();
                if (this.Birth != null)
                    hashCode = hashCode * 59 + this.Birth.GetHashCode();
                if (this.BloodlinesReligion != null)
                    hashCode = hashCode * 59 + this.BloodlinesReligion.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.BloodGroup != null)
                    hashCode = hashCode * 59 + this.BloodGroup.GetHashCode();
                if (this.CardId != null)
                    hashCode = hashCode * 59 + this.CardId.GetHashCode();
                if (this.NrcIdBack != null)
                    hashCode = hashCode * 59 + this.NrcIdBack.GetHashCode();
                if (this.Profession != null)
                    hashCode = hashCode * 59 + this.Profession.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.PortraitImage != null)
                    hashCode = hashCode * 59 + this.PortraitImage.GetHashCode();
                if (this.PortraitLocation != null)
                    hashCode = hashCode * 59 + this.PortraitLocation.GetHashCode();
                if (this.IdcardType != null)
                    hashCode = hashCode * 59 + this.IdcardType.GetHashCode();
                if (this.TranslationInfo != null)
                    hashCode = hashCode * 59 + this.TranslationInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
