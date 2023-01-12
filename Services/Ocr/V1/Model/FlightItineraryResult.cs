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
    public class FlightItineraryResult 
    {

        /// <summary>
        /// 印刷序号。 
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 旅客姓名。 
        /// </summary>
        [JsonProperty("passenger_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PassengerName { get; set; }

        /// <summary>
        /// 有效身份证件号码。 
        /// </summary>
        [JsonProperty("id_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IdNumber { get; set; }

        /// <summary>
        /// 备注。 
        /// </summary>
        [JsonProperty("endorsements_restrictions", NullValueHandling = NullValueHandling.Ignore)]
        public string EndorsementsRestrictions { get; set; }

        /// <summary>
        /// 订单号。 
        /// </summary>
        [JsonProperty("order_number", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// 票价。 
        /// </summary>
        [JsonProperty("fare", NullValueHandling = NullValueHandling.Ignore)]
        public string Fare { get; set; }

        /// <summary>
        /// 民航（CAAC)发展基金。 
        /// </summary>
        [JsonProperty("caac_development_fund", NullValueHandling = NullValueHandling.Ignore)]
        public string CaacDevelopmentFund { get; set; }

        /// <summary>
        /// 燃油附加费。 
        /// </summary>
        [JsonProperty("fuel_surcharge", NullValueHandling = NullValueHandling.Ignore)]
        public string FuelSurcharge { get; set; }

        /// <summary>
        /// 其他税费。 
        /// </summary>
        [JsonProperty("other_taxes", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherTaxes { get; set; }

        /// <summary>
        /// 合计。 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public string Total { get; set; }

        /// <summary>
        /// 电子客票号码。 
        /// </summary>
        [JsonProperty("e_ticket_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ETicketNumber { get; set; }

        /// <summary>
        /// 验证码。 
        /// </summary>
        [JsonProperty("check_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckCode { get; set; }

        /// <summary>
        /// 提示信息。 
        /// </summary>
        [JsonProperty("reference_information", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceInformation { get; set; }

        /// <summary>
        /// 保险费。 
        /// </summary>
        [JsonProperty("insurance", NullValueHandling = NullValueHandling.Ignore)]
        public string Insurance { get; set; }

        /// <summary>
        /// 销售单位代号。 
        /// </summary>
        [JsonProperty("agent_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentCode { get; set; }

        /// <summary>
        /// 填开单位。 
        /// </summary>
        [JsonProperty("issue_organization", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueOrganization { get; set; }

        /// <summary>
        /// 填开日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 机票行程列表。 
        /// </summary>
        [JsonProperty("itinerary_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItineraryList> ItineraryList { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，取值范围0~1。  置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。 置信度由算法给出，不直接等价于对应字段的准确率。  &gt; 说明：  - （1）置信度中的相关字段均与返回值中的相关字段一一对应；  - （2）置信度中的itinerary_list的顺序与返回值中的itinerary_list的顺序是一致的。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightItineraryResult {\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  passengerName: ").Append(PassengerName).Append("\n");
            sb.Append("  idNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  endorsementsRestrictions: ").Append(EndorsementsRestrictions).Append("\n");
            sb.Append("  orderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  fare: ").Append(Fare).Append("\n");
            sb.Append("  caacDevelopmentFund: ").Append(CaacDevelopmentFund).Append("\n");
            sb.Append("  fuelSurcharge: ").Append(FuelSurcharge).Append("\n");
            sb.Append("  otherTaxes: ").Append(OtherTaxes).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  eTicketNumber: ").Append(ETicketNumber).Append("\n");
            sb.Append("  checkCode: ").Append(CheckCode).Append("\n");
            sb.Append("  referenceInformation: ").Append(ReferenceInformation).Append("\n");
            sb.Append("  insurance: ").Append(Insurance).Append("\n");
            sb.Append("  agentCode: ").Append(AgentCode).Append("\n");
            sb.Append("  issueOrganization: ").Append(IssueOrganization).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  itineraryList: ").Append(ItineraryList).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlightItineraryResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlightItineraryResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.PassengerName == input.PassengerName ||
                    (this.PassengerName != null &&
                    this.PassengerName.Equals(input.PassengerName))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.EndorsementsRestrictions == input.EndorsementsRestrictions ||
                    (this.EndorsementsRestrictions != null &&
                    this.EndorsementsRestrictions.Equals(input.EndorsementsRestrictions))
                ) && 
                (
                    this.OrderNumber == input.OrderNumber ||
                    (this.OrderNumber != null &&
                    this.OrderNumber.Equals(input.OrderNumber))
                ) && 
                (
                    this.Fare == input.Fare ||
                    (this.Fare != null &&
                    this.Fare.Equals(input.Fare))
                ) && 
                (
                    this.CaacDevelopmentFund == input.CaacDevelopmentFund ||
                    (this.CaacDevelopmentFund != null &&
                    this.CaacDevelopmentFund.Equals(input.CaacDevelopmentFund))
                ) && 
                (
                    this.FuelSurcharge == input.FuelSurcharge ||
                    (this.FuelSurcharge != null &&
                    this.FuelSurcharge.Equals(input.FuelSurcharge))
                ) && 
                (
                    this.OtherTaxes == input.OtherTaxes ||
                    (this.OtherTaxes != null &&
                    this.OtherTaxes.Equals(input.OtherTaxes))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.ETicketNumber == input.ETicketNumber ||
                    (this.ETicketNumber != null &&
                    this.ETicketNumber.Equals(input.ETicketNumber))
                ) && 
                (
                    this.CheckCode == input.CheckCode ||
                    (this.CheckCode != null &&
                    this.CheckCode.Equals(input.CheckCode))
                ) && 
                (
                    this.ReferenceInformation == input.ReferenceInformation ||
                    (this.ReferenceInformation != null &&
                    this.ReferenceInformation.Equals(input.ReferenceInformation))
                ) && 
                (
                    this.Insurance == input.Insurance ||
                    (this.Insurance != null &&
                    this.Insurance.Equals(input.Insurance))
                ) && 
                (
                    this.AgentCode == input.AgentCode ||
                    (this.AgentCode != null &&
                    this.AgentCode.Equals(input.AgentCode))
                ) && 
                (
                    this.IssueOrganization == input.IssueOrganization ||
                    (this.IssueOrganization != null &&
                    this.IssueOrganization.Equals(input.IssueOrganization))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.ItineraryList == input.ItineraryList ||
                    this.ItineraryList != null &&
                    input.ItineraryList != null &&
                    this.ItineraryList.SequenceEqual(input.ItineraryList)
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
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.PassengerName != null)
                    hashCode = hashCode * 59 + this.PassengerName.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.EndorsementsRestrictions != null)
                    hashCode = hashCode * 59 + this.EndorsementsRestrictions.GetHashCode();
                if (this.OrderNumber != null)
                    hashCode = hashCode * 59 + this.OrderNumber.GetHashCode();
                if (this.Fare != null)
                    hashCode = hashCode * 59 + this.Fare.GetHashCode();
                if (this.CaacDevelopmentFund != null)
                    hashCode = hashCode * 59 + this.CaacDevelopmentFund.GetHashCode();
                if (this.FuelSurcharge != null)
                    hashCode = hashCode * 59 + this.FuelSurcharge.GetHashCode();
                if (this.OtherTaxes != null)
                    hashCode = hashCode * 59 + this.OtherTaxes.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.ETicketNumber != null)
                    hashCode = hashCode * 59 + this.ETicketNumber.GetHashCode();
                if (this.CheckCode != null)
                    hashCode = hashCode * 59 + this.CheckCode.GetHashCode();
                if (this.ReferenceInformation != null)
                    hashCode = hashCode * 59 + this.ReferenceInformation.GetHashCode();
                if (this.Insurance != null)
                    hashCode = hashCode * 59 + this.Insurance.GetHashCode();
                if (this.AgentCode != null)
                    hashCode = hashCode * 59 + this.AgentCode.GetHashCode();
                if (this.IssueOrganization != null)
                    hashCode = hashCode * 59 + this.IssueOrganization.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.ItineraryList != null)
                    hashCode = hashCode * 59 + this.ItineraryList.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
