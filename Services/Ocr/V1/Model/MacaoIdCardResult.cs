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
    public class MacaoIdCardResult 
    {

        /// <summary>
        /// 证件图片正反面信息。可选值包括： - \&quot;front\&quot;: 证件图片为正面 - \&quot;back\&quot;: 证件图片为反面 
        /// </summary>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public string Side { get; set; }

        /// <summary>
        /// 姓名。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 英文姓名，姓名单词之间使用空格进行间隔。 
        /// </summary>
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        /// <summary>
        /// 性别，返回“男”或“女”。 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 本次发证日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 证件有效期。 
        /// </summary>
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 出生日期。 
        /// </summary>
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthDate { get; set; }

        /// <summary>
        /// 首次发证日期。 
        /// </summary>
        [JsonProperty("initial_issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string InitialIssueDate { get; set; }

        /// <summary>
        /// 身高。 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }

        /// <summary>
        /// 身份证号。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 身份证上的字母代码，表示出生地等信息。 
        /// </summary>
        [JsonProperty("symbols", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbols { get; set; }

        /// <summary>
        /// 身份证背面第一行机器码。 
        /// </summary>
        [JsonProperty("machine_code1", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode1 { get; set; }

        /// <summary>
        /// 身份证背面第二行机器码。 
        /// </summary>
        [JsonProperty("machine_code2", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode2 { get; set; }

        /// <summary>
        /// 身份证背面第三行机器码。 
        /// </summary>
        [JsonProperty("machine_code3", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode3 { get; set; }

        /// <summary>
        /// 身份证头像照片的Base64编码。 若入参“return_portrait_image”字段缺失时，则此字段不存在。 
        /// </summary>
        [JsonProperty("portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public string PortraitImage { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。注：置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MacaoIdCardResult {\n");
            sb.Append("  side: ").Append(Side).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  expiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  birthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  initialIssueDate: ").Append(InitialIssueDate).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  symbols: ").Append(Symbols).Append("\n");
            sb.Append("  machineCode1: ").Append(MachineCode1).Append("\n");
            sb.Append("  machineCode2: ").Append(MachineCode2).Append("\n");
            sb.Append("  machineCode3: ").Append(MachineCode3).Append("\n");
            sb.Append("  portraitImage: ").Append(PortraitImage).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MacaoIdCardResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MacaoIdCardResult input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NameEn == input.NameEn ||
                    (this.NameEn != null &&
                    this.NameEn.Equals(input.NameEn))
                ) && 
                (
                    this.Sex == input.Sex ||
                    (this.Sex != null &&
                    this.Sex.Equals(input.Sex))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.InitialIssueDate == input.InitialIssueDate ||
                    (this.InitialIssueDate != null &&
                    this.InitialIssueDate.Equals(input.InitialIssueDate))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Symbols == input.Symbols ||
                    (this.Symbols != null &&
                    this.Symbols.Equals(input.Symbols))
                ) && 
                (
                    this.MachineCode1 == input.MachineCode1 ||
                    (this.MachineCode1 != null &&
                    this.MachineCode1.Equals(input.MachineCode1))
                ) && 
                (
                    this.MachineCode2 == input.MachineCode2 ||
                    (this.MachineCode2 != null &&
                    this.MachineCode2.Equals(input.MachineCode2))
                ) && 
                (
                    this.MachineCode3 == input.MachineCode3 ||
                    (this.MachineCode3 != null &&
                    this.MachineCode3.Equals(input.MachineCode3))
                ) && 
                (
                    this.PortraitImage == input.PortraitImage ||
                    (this.PortraitImage != null &&
                    this.PortraitImage.Equals(input.PortraitImage))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameEn != null)
                    hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.Sex != null)
                    hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.InitialIssueDate != null)
                    hashCode = hashCode * 59 + this.InitialIssueDate.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Symbols != null)
                    hashCode = hashCode * 59 + this.Symbols.GetHashCode();
                if (this.MachineCode1 != null)
                    hashCode = hashCode * 59 + this.MachineCode1.GetHashCode();
                if (this.MachineCode2 != null)
                    hashCode = hashCode * 59 + this.MachineCode2.GetHashCode();
                if (this.MachineCode3 != null)
                    hashCode = hashCode * 59 + this.MachineCode3.GetHashCode();
                if (this.PortraitImage != null)
                    hashCode = hashCode * 59 + this.PortraitImage.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
