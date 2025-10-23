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
    public class VehicleLicenseBack 
    {

        /// <summary>
        /// 号牌号码。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 档案编码。 
        /// </summary>
        [JsonProperty("file_no", NullValueHandling = NullValueHandling.Ignore)]
        public string FileNo { get; set; }

        /// <summary>
        /// 核定载人数。 
        /// </summary>
        [JsonProperty("approved_passengers", NullValueHandling = NullValueHandling.Ignore)]
        public string ApprovedPassengers { get; set; }

        /// <summary>
        /// 总质量。 
        /// </summary>
        [JsonProperty("gross_mass", NullValueHandling = NullValueHandling.Ignore)]
        public string GrossMass { get; set; }

        /// <summary>
        /// 整备质量。 
        /// </summary>
        [JsonProperty("unladen_mass", NullValueHandling = NullValueHandling.Ignore)]
        public string UnladenMass { get; set; }

        /// <summary>
        /// 核定载质量。 
        /// </summary>
        [JsonProperty("approved_load", NullValueHandling = NullValueHandling.Ignore)]
        public string ApprovedLoad { get; set; }

        /// <summary>
        /// 外廓尺寸。 
        /// </summary>
        [JsonProperty("dimension", NullValueHandling = NullValueHandling.Ignore)]
        public string Dimension { get; set; }

        /// <summary>
        /// 准牵引总质量。 
        /// </summary>
        [JsonProperty("traction_mass", NullValueHandling = NullValueHandling.Ignore)]
        public string TractionMass { get; set; }

        /// <summary>
        /// 备注。 
        /// </summary>
        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public string Remarks { get; set; }

        /// <summary>
        /// 检验记录。 
        /// </summary>
        [JsonProperty("inspection_record", NullValueHandling = NullValueHandling.Ignore)]
        public string InspectionRecord { get; set; }

        /// <summary>
        /// 条码号。           
        /// </summary>
        [JsonProperty("code_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeNumber { get; set; }

        /// <summary>
        /// 能源类型。 
        /// </summary>
        [JsonProperty("energy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EnergyType { get; set; }

        /// <summary>
        /// 文本框在原图位置。输出左上、右上、右下、左下四个点坐标。  当“return_text_location”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("text_location", NullValueHandling = NullValueHandling.Ignore)]
        public Object TextLocation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VehicleLicenseBack {\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  fileNo: ").Append(FileNo).Append("\n");
            sb.Append("  approvedPassengers: ").Append(ApprovedPassengers).Append("\n");
            sb.Append("  grossMass: ").Append(GrossMass).Append("\n");
            sb.Append("  unladenMass: ").Append(UnladenMass).Append("\n");
            sb.Append("  approvedLoad: ").Append(ApprovedLoad).Append("\n");
            sb.Append("  dimension: ").Append(Dimension).Append("\n");
            sb.Append("  tractionMass: ").Append(TractionMass).Append("\n");
            sb.Append("  remarks: ").Append(Remarks).Append("\n");
            sb.Append("  inspectionRecord: ").Append(InspectionRecord).Append("\n");
            sb.Append("  codeNumber: ").Append(CodeNumber).Append("\n");
            sb.Append("  energyType: ").Append(EnergyType).Append("\n");
            sb.Append("  textLocation: ").Append(TextLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VehicleLicenseBack);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VehicleLicenseBack input)
        {
            if (input == null) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.FileNo != input.FileNo || (this.FileNo != null && !this.FileNo.Equals(input.FileNo))) return false;
            if (this.ApprovedPassengers != input.ApprovedPassengers || (this.ApprovedPassengers != null && !this.ApprovedPassengers.Equals(input.ApprovedPassengers))) return false;
            if (this.GrossMass != input.GrossMass || (this.GrossMass != null && !this.GrossMass.Equals(input.GrossMass))) return false;
            if (this.UnladenMass != input.UnladenMass || (this.UnladenMass != null && !this.UnladenMass.Equals(input.UnladenMass))) return false;
            if (this.ApprovedLoad != input.ApprovedLoad || (this.ApprovedLoad != null && !this.ApprovedLoad.Equals(input.ApprovedLoad))) return false;
            if (this.Dimension != input.Dimension || (this.Dimension != null && !this.Dimension.Equals(input.Dimension))) return false;
            if (this.TractionMass != input.TractionMass || (this.TractionMass != null && !this.TractionMass.Equals(input.TractionMass))) return false;
            if (this.Remarks != input.Remarks || (this.Remarks != null && !this.Remarks.Equals(input.Remarks))) return false;
            if (this.InspectionRecord != input.InspectionRecord || (this.InspectionRecord != null && !this.InspectionRecord.Equals(input.InspectionRecord))) return false;
            if (this.CodeNumber != input.CodeNumber || (this.CodeNumber != null && !this.CodeNumber.Equals(input.CodeNumber))) return false;
            if (this.EnergyType != input.EnergyType || (this.EnergyType != null && !this.EnergyType.Equals(input.EnergyType))) return false;
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
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.FileNo != null) hashCode = hashCode * 59 + this.FileNo.GetHashCode();
                if (this.ApprovedPassengers != null) hashCode = hashCode * 59 + this.ApprovedPassengers.GetHashCode();
                if (this.GrossMass != null) hashCode = hashCode * 59 + this.GrossMass.GetHashCode();
                if (this.UnladenMass != null) hashCode = hashCode * 59 + this.UnladenMass.GetHashCode();
                if (this.ApprovedLoad != null) hashCode = hashCode * 59 + this.ApprovedLoad.GetHashCode();
                if (this.Dimension != null) hashCode = hashCode * 59 + this.Dimension.GetHashCode();
                if (this.TractionMass != null) hashCode = hashCode * 59 + this.TractionMass.GetHashCode();
                if (this.Remarks != null) hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.InspectionRecord != null) hashCode = hashCode * 59 + this.InspectionRecord.GetHashCode();
                if (this.CodeNumber != null) hashCode = hashCode * 59 + this.CodeNumber.GetHashCode();
                if (this.EnergyType != null) hashCode = hashCode * 59 + this.EnergyType.GetHashCode();
                if (this.TextLocation != null) hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
