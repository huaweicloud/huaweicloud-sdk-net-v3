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
    public class DriverLicenseResult 
    {

        /// <summary>
        /// 驾驶证类型。 normal：纸质驾驶证 electronic：电子驾驶证 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 驾驶证号。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 姓名。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 性别。 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 国籍。 
        /// </summary>
        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        /// <summary>
        /// 住址。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 出生日期。 
        /// </summary>
        [JsonProperty("birth", NullValueHandling = NullValueHandling.Ignore)]
        public string Birth { get; set; }

        /// <summary>
        /// 初次领证日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 准驾类型。 
        /// </summary>
        [JsonProperty("class", NullValueHandling = NullValueHandling.Ignore)]
        public string Class { get; set; }

        /// <summary>
        /// 有效起始日期。 
        /// </summary>
        [JsonProperty("valid_from", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidFrom { get; set; }

        /// <summary>
        /// 有效结束日期。 
        /// </summary>
        [JsonProperty("valid_to", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidTo { get; set; }

        /// <summary>
        /// 发证机关。 
        /// </summary>
        [JsonProperty("issuing_authority", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuingAuthority { get; set; }

        /// <summary>
        /// 档案编号。 
        /// </summary>
        [JsonProperty("file_number", NullValueHandling = NullValueHandling.Ignore)]
        public string FileNumber { get; set; }

        /// <summary>
        /// 记录。 
        /// </summary>
        [JsonProperty("record", NullValueHandling = NullValueHandling.Ignore)]
        public string Record { get; set; }

        /// <summary>
        /// 累积记分。 
        /// </summary>
        [JsonProperty("accumulated_scores", NullValueHandling = NullValueHandling.Ignore)]
        public string AccumulatedScores { get; set; }

        /// <summary>
        /// 状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Status { get; set; }

        /// <summary>
        /// 生成时间。 
        /// </summary>
        [JsonProperty("generation_date", NullValueHandling = NullValueHandling.Ignore)]
        public string GenerationDate { get; set; }

        /// <summary>
        /// 当前时间。 
        /// </summary>
        [JsonProperty("current_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentTime { get; set; }

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
            sb.Append("class DriverLicenseResult {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  nationality: ").Append(Nationality).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  birth: ").Append(Birth).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  Class: ").Append(Class).Append("\n");
            sb.Append("  validFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("  validTo: ").Append(ValidTo).Append("\n");
            sb.Append("  issuingAuthority: ").Append(IssuingAuthority).Append("\n");
            sb.Append("  fileNumber: ").Append(FileNumber).Append("\n");
            sb.Append("  record: ").Append(Record).Append("\n");
            sb.Append("  accumulatedScores: ").Append(AccumulatedScores).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  generationDate: ").Append(GenerationDate).Append("\n");
            sb.Append("  currentTime: ").Append(CurrentTime).Append("\n");
            sb.Append("  textLocation: ").Append(TextLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DriverLicenseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DriverLicenseResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Sex == input.Sex ||
                    (this.Sex != null &&
                    this.Sex.Equals(input.Sex))
                ) && 
                (
                    this.Nationality == input.Nationality ||
                    (this.Nationality != null &&
                    this.Nationality.Equals(input.Nationality))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Birth == input.Birth ||
                    (this.Birth != null &&
                    this.Birth.Equals(input.Birth))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.Class == input.Class ||
                    (this.Class != null &&
                    this.Class.Equals(input.Class))
                ) && 
                (
                    this.ValidFrom == input.ValidFrom ||
                    (this.ValidFrom != null &&
                    this.ValidFrom.Equals(input.ValidFrom))
                ) && 
                (
                    this.ValidTo == input.ValidTo ||
                    (this.ValidTo != null &&
                    this.ValidTo.Equals(input.ValidTo))
                ) && 
                (
                    this.IssuingAuthority == input.IssuingAuthority ||
                    (this.IssuingAuthority != null &&
                    this.IssuingAuthority.Equals(input.IssuingAuthority))
                ) && 
                (
                    this.FileNumber == input.FileNumber ||
                    (this.FileNumber != null &&
                    this.FileNumber.Equals(input.FileNumber))
                ) && 
                (
                    this.Record == input.Record ||
                    (this.Record != null &&
                    this.Record.Equals(input.Record))
                ) && 
                (
                    this.AccumulatedScores == input.AccumulatedScores ||
                    (this.AccumulatedScores != null &&
                    this.AccumulatedScores.Equals(input.AccumulatedScores))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status != null &&
                    input.Status != null &&
                    this.Status.SequenceEqual(input.Status)
                ) && 
                (
                    this.GenerationDate == input.GenerationDate ||
                    (this.GenerationDate != null &&
                    this.GenerationDate.Equals(input.GenerationDate))
                ) && 
                (
                    this.CurrentTime == input.CurrentTime ||
                    (this.CurrentTime != null &&
                    this.CurrentTime.Equals(input.CurrentTime))
                ) && 
                (
                    this.TextLocation == input.TextLocation ||
                    (this.TextLocation != null &&
                    this.TextLocation.Equals(input.TextLocation))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Sex != null)
                    hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Nationality != null)
                    hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Birth != null)
                    hashCode = hashCode * 59 + this.Birth.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.Class != null)
                    hashCode = hashCode * 59 + this.Class.GetHashCode();
                if (this.ValidFrom != null)
                    hashCode = hashCode * 59 + this.ValidFrom.GetHashCode();
                if (this.ValidTo != null)
                    hashCode = hashCode * 59 + this.ValidTo.GetHashCode();
                if (this.IssuingAuthority != null)
                    hashCode = hashCode * 59 + this.IssuingAuthority.GetHashCode();
                if (this.FileNumber != null)
                    hashCode = hashCode * 59 + this.FileNumber.GetHashCode();
                if (this.Record != null)
                    hashCode = hashCode * 59 + this.Record.GetHashCode();
                if (this.AccumulatedScores != null)
                    hashCode = hashCode * 59 + this.AccumulatedScores.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.GenerationDate != null)
                    hashCode = hashCode * 59 + this.GenerationDate.GetHashCode();
                if (this.CurrentTime != null)
                    hashCode = hashCode * 59 + this.CurrentTime.GetHashCode();
                if (this.TextLocation != null)
                    hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
