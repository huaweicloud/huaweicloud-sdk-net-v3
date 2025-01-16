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
    public class VehicleLicenseResult 
    {

        /// <summary>
        /// 行驶证类型：  - normal: 纸质行驶证  - electronic: 电子行驶证 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 号牌号码。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 车辆类型。 
        /// </summary>
        [JsonProperty("vehicle_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleType { get; set; }

        /// <summary>
        /// 所有人。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 住址。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 使用性质。 
        /// </summary>
        [JsonProperty("use_character", NullValueHandling = NullValueHandling.Ignore)]
        public string UseCharacter { get; set; }

        /// <summary>
        /// 品牌型号。 
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// 发动机号码。 
        /// </summary>
        [JsonProperty("engine_no", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineNo { get; set; }

        /// <summary>
        /// 车辆识别代号。 
        /// </summary>
        [JsonProperty("vin", NullValueHandling = NullValueHandling.Ignore)]
        public string Vin { get; set; }

        /// <summary>
        /// 注册日期。 
        /// </summary>
        [JsonProperty("register_date", NullValueHandling = NullValueHandling.Ignore)]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 发证日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 发证机关。 
        /// </summary>
        [JsonProperty("issuing_authority", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuingAuthority { get; set; }

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
        /// 文本框在原图位置。输出左上、右上、右下、左下四个点坐标。  当“return_text_location”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("text_location", NullValueHandling = NullValueHandling.Ignore)]
        public Object TextLocation { get; set; }

        /// <summary>
        /// 能源类型。 
        /// </summary>
        [JsonProperty("energy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EnergyType { get; set; }

        /// <summary>
        /// 车身颜色。 
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// 强制报废日期。 
        /// </summary>
        [JsonProperty("mandatory_scrapping_date", NullValueHandling = NullValueHandling.Ignore)]
        public string MandatoryScrappingDate { get; set; }

        /// <summary>
        /// 状态。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("front", NullValueHandling = NullValueHandling.Ignore)]
        public VehicleLicenseFront Front { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("back", NullValueHandling = NullValueHandling.Ignore)]
        public VehicleLicenseback Back { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VehicleLicenseResult {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  vehicleType: ").Append(VehicleType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  useCharacter: ").Append(UseCharacter).Append("\n");
            sb.Append("  model: ").Append(Model).Append("\n");
            sb.Append("  engineNo: ").Append(EngineNo).Append("\n");
            sb.Append("  vin: ").Append(Vin).Append("\n");
            sb.Append("  registerDate: ").Append(RegisterDate).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  issuingAuthority: ").Append(IssuingAuthority).Append("\n");
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
            sb.Append("  textLocation: ").Append(TextLocation).Append("\n");
            sb.Append("  energyType: ").Append(EnergyType).Append("\n");
            sb.Append("  color: ").Append(Color).Append("\n");
            sb.Append("  mandatoryScrappingDate: ").Append(MandatoryScrappingDate).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  front: ").Append(Front).Append("\n");
            sb.Append("  back: ").Append(Back).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VehicleLicenseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VehicleLicenseResult input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.VehicleType != input.VehicleType || (this.VehicleType != null && !this.VehicleType.Equals(input.VehicleType))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.UseCharacter != input.UseCharacter || (this.UseCharacter != null && !this.UseCharacter.Equals(input.UseCharacter))) return false;
            if (this.Model != input.Model || (this.Model != null && !this.Model.Equals(input.Model))) return false;
            if (this.EngineNo != input.EngineNo || (this.EngineNo != null && !this.EngineNo.Equals(input.EngineNo))) return false;
            if (this.Vin != input.Vin || (this.Vin != null && !this.Vin.Equals(input.Vin))) return false;
            if (this.RegisterDate != input.RegisterDate || (this.RegisterDate != null && !this.RegisterDate.Equals(input.RegisterDate))) return false;
            if (this.IssueDate != input.IssueDate || (this.IssueDate != null && !this.IssueDate.Equals(input.IssueDate))) return false;
            if (this.IssuingAuthority != input.IssuingAuthority || (this.IssuingAuthority != null && !this.IssuingAuthority.Equals(input.IssuingAuthority))) return false;
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
            if (this.TextLocation != input.TextLocation || (this.TextLocation != null && !this.TextLocation.Equals(input.TextLocation))) return false;
            if (this.EnergyType != input.EnergyType || (this.EnergyType != null && !this.EnergyType.Equals(input.EnergyType))) return false;
            if (this.Color != input.Color || (this.Color != null && !this.Color.Equals(input.Color))) return false;
            if (this.MandatoryScrappingDate != input.MandatoryScrappingDate || (this.MandatoryScrappingDate != null && !this.MandatoryScrappingDate.Equals(input.MandatoryScrappingDate))) return false;
            if (this.Status != input.Status || (this.Status != null && input.Status != null && !this.Status.SequenceEqual(input.Status))) return false;
            if (this.Front != input.Front || (this.Front != null && !this.Front.Equals(input.Front))) return false;
            if (this.Back != input.Back || (this.Back != null && !this.Back.Equals(input.Back))) return false;

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
                if (this.VehicleType != null) hashCode = hashCode * 59 + this.VehicleType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.UseCharacter != null) hashCode = hashCode * 59 + this.UseCharacter.GetHashCode();
                if (this.Model != null) hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.EngineNo != null) hashCode = hashCode * 59 + this.EngineNo.GetHashCode();
                if (this.Vin != null) hashCode = hashCode * 59 + this.Vin.GetHashCode();
                if (this.RegisterDate != null) hashCode = hashCode * 59 + this.RegisterDate.GetHashCode();
                if (this.IssueDate != null) hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.IssuingAuthority != null) hashCode = hashCode * 59 + this.IssuingAuthority.GetHashCode();
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
                if (this.TextLocation != null) hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                if (this.EnergyType != null) hashCode = hashCode * 59 + this.EnergyType.GetHashCode();
                if (this.Color != null) hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.MandatoryScrappingDate != null) hashCode = hashCode * 59 + this.MandatoryScrappingDate.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Front != null) hashCode = hashCode * 59 + this.Front.GetHashCode();
                if (this.Back != null) hashCode = hashCode * 59 + this.Back.GetHashCode();
                return hashCode;
            }
        }
    }
}
