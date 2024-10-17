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
    public class DriverLicenseBack 
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
        /// 发证机关。 
        /// </summary>
        [JsonProperty("issuing_authority", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuingAuthority { get; set; }

        /// <summary>
        /// 住址。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 档案编号。 &gt; 说明：当驾驶证类型为纸质驾驶证时才返回。 
        /// </summary>
        [JsonProperty("file_number", NullValueHandling = NullValueHandling.Ignore)]
        public string FileNumber { get; set; }

        /// <summary>
        /// 记录。 
        /// </summary>
        [JsonProperty("record", NullValueHandling = NullValueHandling.Ignore)]
        public string Record { get; set; }

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
            sb.Append("class DriverLicenseBack {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  issuingAuthority: ").Append(IssuingAuthority).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  fileNumber: ").Append(FileNumber).Append("\n");
            sb.Append("  record: ").Append(Record).Append("\n");
            sb.Append("  textLocation: ").Append(TextLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DriverLicenseBack);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DriverLicenseBack input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.IssuingAuthority != input.IssuingAuthority || (this.IssuingAuthority != null && !this.IssuingAuthority.Equals(input.IssuingAuthority))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.FileNumber != input.FileNumber || (this.FileNumber != null && !this.FileNumber.Equals(input.FileNumber))) return false;
            if (this.Record != input.Record || (this.Record != null && !this.Record.Equals(input.Record))) return false;
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
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IssuingAuthority != null) hashCode = hashCode * 59 + this.IssuingAuthority.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.FileNumber != null) hashCode = hashCode * 59 + this.FileNumber.GetHashCode();
                if (this.Record != null) hashCode = hashCode * 59 + this.Record.GetHashCode();
                if (this.TextLocation != null) hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
