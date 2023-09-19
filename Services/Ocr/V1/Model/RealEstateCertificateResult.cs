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
    public class RealEstateCertificateResult 
    {

        /// <summary>
        /// 填发单位。 
        /// </summary>
        [JsonProperty("issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string Issuer { get; set; }

        /// <summary>
        /// 填发日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 不动产证编号。 
        /// </summary>
        [JsonProperty("real_estate_certificate_no", NullValueHandling = NullValueHandling.Ignore)]
        public string RealEstateCertificateNo { get; set; }

        /// <summary>
        /// 抵押印章个数。 
        /// </summary>
        [JsonProperty("mortgage_seals", NullValueHandling = NullValueHandling.Ignore)]
        public int? MortgageSeals { get; set; }

        /// <summary>
        /// 注销的抵押印章个数。 
        /// </summary>
        [JsonProperty("canceled_mortgage_seals", NullValueHandling = NullValueHandling.Ignore)]
        public int? CanceledMortgageSeals { get; set; }

        /// <summary>
        /// 房屋坐落。 
        /// </summary>
        [JsonProperty("estate_location", NullValueHandling = NullValueHandling.Ignore)]
        public string EstateLocation { get; set; }

        /// <summary>
        /// 总楼层数。 
        /// </summary>
        [JsonProperty("total_floors", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalFloors { get; set; }

        /// <summary>
        /// 所在层。 
        /// </summary>
        [JsonProperty("floor", NullValueHandling = NullValueHandling.Ignore)]
        public string Floor { get; set; }

        /// <summary>
        /// 建成年份。 
        /// </summary>
        [JsonProperty("year_built", NullValueHandling = NullValueHandling.Ignore)]
        public string YearBuilt { get; set; }

        /// <summary>
        /// 结构。 
        /// </summary>
        [JsonProperty("structure", NullValueHandling = NullValueHandling.Ignore)]
        public string Structure { get; set; }

        /// <summary>
        /// 建筑面积。 
        /// </summary>
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        /// <summary>
        /// 印花税票个数。 
        /// </summary>
        [JsonProperty("revenue_stamps", NullValueHandling = NullValueHandling.Ignore)]
        public int? RevenueStamps { get; set; }

        /// <summary>
        /// 产权证号。 
        /// </summary>
        [JsonProperty("ownership_certificate_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnershipCertificateNo { get; set; }

        /// <summary>
        /// 房屋所有权人。 
        /// </summary>
        [JsonProperty("estate_holder", NullValueHandling = NullValueHandling.Ignore)]
        public string EstateHolder { get; set; }

        /// <summary>
        /// 权利人。 
        /// </summary>
        [JsonProperty("obligee", NullValueHandling = NullValueHandling.Ignore)]
        public string Obligee { get; set; }

        /// <summary>
        /// 共有情况。 
        /// </summary>
        [JsonProperty("ownership", NullValueHandling = NullValueHandling.Ignore)]
        public string Ownership { get; set; }

        /// <summary>
        /// 不动产单元号。 
        /// </summary>
        [JsonProperty("property_unit_no", NullValueHandling = NullValueHandling.Ignore)]
        public string PropertyUnitNo { get; set; }

        /// <summary>
        /// 权利类型。 
        /// </summary>
        [JsonProperty("right_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RightType { get; set; }

        /// <summary>
        /// 权利性质。 
        /// </summary>
        [JsonProperty("right_nature", NullValueHandling = NullValueHandling.Ignore)]
        public string RightNature { get; set; }

        /// <summary>
        /// 使用用途。 
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public string Usage { get; set; }

        /// <summary>
        /// 设计、规划用途。 
        /// </summary>
        [JsonProperty("intended_usage", NullValueHandling = NullValueHandling.Ignore)]
        public string IntendedUsage { get; set; }

        /// <summary>
        /// 各个字段的置信度。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealEstateCertificateResult {\n");
            sb.Append("  issuer: ").Append(Issuer).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  realEstateCertificateNo: ").Append(RealEstateCertificateNo).Append("\n");
            sb.Append("  mortgageSeals: ").Append(MortgageSeals).Append("\n");
            sb.Append("  canceledMortgageSeals: ").Append(CanceledMortgageSeals).Append("\n");
            sb.Append("  estateLocation: ").Append(EstateLocation).Append("\n");
            sb.Append("  totalFloors: ").Append(TotalFloors).Append("\n");
            sb.Append("  floor: ").Append(Floor).Append("\n");
            sb.Append("  yearBuilt: ").Append(YearBuilt).Append("\n");
            sb.Append("  structure: ").Append(Structure).Append("\n");
            sb.Append("  area: ").Append(Area).Append("\n");
            sb.Append("  revenueStamps: ").Append(RevenueStamps).Append("\n");
            sb.Append("  ownershipCertificateNo: ").Append(OwnershipCertificateNo).Append("\n");
            sb.Append("  estateHolder: ").Append(EstateHolder).Append("\n");
            sb.Append("  obligee: ").Append(Obligee).Append("\n");
            sb.Append("  ownership: ").Append(Ownership).Append("\n");
            sb.Append("  propertyUnitNo: ").Append(PropertyUnitNo).Append("\n");
            sb.Append("  rightType: ").Append(RightType).Append("\n");
            sb.Append("  rightNature: ").Append(RightNature).Append("\n");
            sb.Append("  usage: ").Append(Usage).Append("\n");
            sb.Append("  intendedUsage: ").Append(IntendedUsage).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RealEstateCertificateResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RealEstateCertificateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.RealEstateCertificateNo == input.RealEstateCertificateNo ||
                    (this.RealEstateCertificateNo != null &&
                    this.RealEstateCertificateNo.Equals(input.RealEstateCertificateNo))
                ) && 
                (
                    this.MortgageSeals == input.MortgageSeals ||
                    (this.MortgageSeals != null &&
                    this.MortgageSeals.Equals(input.MortgageSeals))
                ) && 
                (
                    this.CanceledMortgageSeals == input.CanceledMortgageSeals ||
                    (this.CanceledMortgageSeals != null &&
                    this.CanceledMortgageSeals.Equals(input.CanceledMortgageSeals))
                ) && 
                (
                    this.EstateLocation == input.EstateLocation ||
                    (this.EstateLocation != null &&
                    this.EstateLocation.Equals(input.EstateLocation))
                ) && 
                (
                    this.TotalFloors == input.TotalFloors ||
                    (this.TotalFloors != null &&
                    this.TotalFloors.Equals(input.TotalFloors))
                ) && 
                (
                    this.Floor == input.Floor ||
                    (this.Floor != null &&
                    this.Floor.Equals(input.Floor))
                ) && 
                (
                    this.YearBuilt == input.YearBuilt ||
                    (this.YearBuilt != null &&
                    this.YearBuilt.Equals(input.YearBuilt))
                ) && 
                (
                    this.Structure == input.Structure ||
                    (this.Structure != null &&
                    this.Structure.Equals(input.Structure))
                ) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.RevenueStamps == input.RevenueStamps ||
                    (this.RevenueStamps != null &&
                    this.RevenueStamps.Equals(input.RevenueStamps))
                ) && 
                (
                    this.OwnershipCertificateNo == input.OwnershipCertificateNo ||
                    (this.OwnershipCertificateNo != null &&
                    this.OwnershipCertificateNo.Equals(input.OwnershipCertificateNo))
                ) && 
                (
                    this.EstateHolder == input.EstateHolder ||
                    (this.EstateHolder != null &&
                    this.EstateHolder.Equals(input.EstateHolder))
                ) && 
                (
                    this.Obligee == input.Obligee ||
                    (this.Obligee != null &&
                    this.Obligee.Equals(input.Obligee))
                ) && 
                (
                    this.Ownership == input.Ownership ||
                    (this.Ownership != null &&
                    this.Ownership.Equals(input.Ownership))
                ) && 
                (
                    this.PropertyUnitNo == input.PropertyUnitNo ||
                    (this.PropertyUnitNo != null &&
                    this.PropertyUnitNo.Equals(input.PropertyUnitNo))
                ) && 
                (
                    this.RightType == input.RightType ||
                    (this.RightType != null &&
                    this.RightType.Equals(input.RightType))
                ) && 
                (
                    this.RightNature == input.RightNature ||
                    (this.RightNature != null &&
                    this.RightNature.Equals(input.RightNature))
                ) && 
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))
                ) && 
                (
                    this.IntendedUsage == input.IntendedUsage ||
                    (this.IntendedUsage != null &&
                    this.IntendedUsage.Equals(input.IntendedUsage))
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
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.RealEstateCertificateNo != null)
                    hashCode = hashCode * 59 + this.RealEstateCertificateNo.GetHashCode();
                if (this.MortgageSeals != null)
                    hashCode = hashCode * 59 + this.MortgageSeals.GetHashCode();
                if (this.CanceledMortgageSeals != null)
                    hashCode = hashCode * 59 + this.CanceledMortgageSeals.GetHashCode();
                if (this.EstateLocation != null)
                    hashCode = hashCode * 59 + this.EstateLocation.GetHashCode();
                if (this.TotalFloors != null)
                    hashCode = hashCode * 59 + this.TotalFloors.GetHashCode();
                if (this.Floor != null)
                    hashCode = hashCode * 59 + this.Floor.GetHashCode();
                if (this.YearBuilt != null)
                    hashCode = hashCode * 59 + this.YearBuilt.GetHashCode();
                if (this.Structure != null)
                    hashCode = hashCode * 59 + this.Structure.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.RevenueStamps != null)
                    hashCode = hashCode * 59 + this.RevenueStamps.GetHashCode();
                if (this.OwnershipCertificateNo != null)
                    hashCode = hashCode * 59 + this.OwnershipCertificateNo.GetHashCode();
                if (this.EstateHolder != null)
                    hashCode = hashCode * 59 + this.EstateHolder.GetHashCode();
                if (this.Obligee != null)
                    hashCode = hashCode * 59 + this.Obligee.GetHashCode();
                if (this.Ownership != null)
                    hashCode = hashCode * 59 + this.Ownership.GetHashCode();
                if (this.PropertyUnitNo != null)
                    hashCode = hashCode * 59 + this.PropertyUnitNo.GetHashCode();
                if (this.RightType != null)
                    hashCode = hashCode * 59 + this.RightType.GetHashCode();
                if (this.RightNature != null)
                    hashCode = hashCode * 59 + this.RightNature.GetHashCode();
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
                if (this.IntendedUsage != null)
                    hashCode = hashCode * 59 + this.IntendedUsage.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
