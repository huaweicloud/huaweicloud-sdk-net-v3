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
    public class TaxiInvoiceResult 
    {

        /// <summary>
        /// 归属地区。 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// 发票代码。 
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 发票号码。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 电话（包括电话、监督电话）。 
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 单位。 
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }

        /// <summary>
        /// 车号。 
        /// </summary>
        [JsonProperty("taxi_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxiNumber { get; set; }

        /// <summary>
        /// 证号。 
        /// </summary>
        [JsonProperty("certificate_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 识别编号。 
        /// </summary>
        [JsonProperty("identification_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// 开票日期。 
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// 上车时间。 
        /// </summary>
        [JsonProperty("boarding_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BoardingTime { get; set; }

        /// <summary>
        /// 下车时间。 
        /// </summary>
        [JsonProperty("alighting_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AlightingTime { get; set; }

        /// <summary>
        /// 时间(起止时间、上下车时间)。 
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 单价。 
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// 总里程。 
        /// </summary>
        [JsonProperty("distance", NullValueHandling = NullValueHandling.Ignore)]
        public string Distance { get; set; }

        /// <summary>
        /// 等候时间。 
        /// </summary>
        [JsonProperty("waiting_time", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitingTime { get; set; }

        /// <summary>
        /// 金额。 
        /// </summary>
        [JsonProperty("fare", NullValueHandling = NullValueHandling.Ignore)]
        public string Fare { get; set; }

        /// <summary>
        /// 燃油附加费。 
        /// </summary>
        [JsonProperty("fuel_oil_surcharge", NullValueHandling = NullValueHandling.Ignore)]
        public string FuelOilSurcharge { get; set; }

        /// <summary>
        /// 电调费（预约费）。 
        /// </summary>
        [JsonProperty("call_service_surcharge", NullValueHandling = NullValueHandling.Ignore)]
        public string CallServiceSurcharge { get; set; }

        /// <summary>
        /// 实收金额。 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public string Total { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。 置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }

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
            sb.Append("class TaxiInvoiceResult {\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  phoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  company: ").Append(Company).Append("\n");
            sb.Append("  taxiNumber: ").Append(TaxiNumber).Append("\n");
            sb.Append("  certificateNumber: ").Append(CertificateNumber).Append("\n");
            sb.Append("  identificationNumber: ").Append(IdentificationNumber).Append("\n");
            sb.Append("  date: ").Append(Date).Append("\n");
            sb.Append("  boardingTime: ").Append(BoardingTime).Append("\n");
            sb.Append("  alightingTime: ").Append(AlightingTime).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  unitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  distance: ").Append(Distance).Append("\n");
            sb.Append("  waitingTime: ").Append(WaitingTime).Append("\n");
            sb.Append("  fare: ").Append(Fare).Append("\n");
            sb.Append("  fuelOilSurcharge: ").Append(FuelOilSurcharge).Append("\n");
            sb.Append("  callServiceSurcharge: ").Append(CallServiceSurcharge).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  textLocation: ").Append(TextLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaxiInvoiceResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaxiInvoiceResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.TaxiNumber == input.TaxiNumber ||
                    (this.TaxiNumber != null &&
                    this.TaxiNumber.Equals(input.TaxiNumber))
                ) && 
                (
                    this.CertificateNumber == input.CertificateNumber ||
                    (this.CertificateNumber != null &&
                    this.CertificateNumber.Equals(input.CertificateNumber))
                ) && 
                (
                    this.IdentificationNumber == input.IdentificationNumber ||
                    (this.IdentificationNumber != null &&
                    this.IdentificationNumber.Equals(input.IdentificationNumber))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.BoardingTime == input.BoardingTime ||
                    (this.BoardingTime != null &&
                    this.BoardingTime.Equals(input.BoardingTime))
                ) && 
                (
                    this.AlightingTime == input.AlightingTime ||
                    (this.AlightingTime != null &&
                    this.AlightingTime.Equals(input.AlightingTime))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.WaitingTime == input.WaitingTime ||
                    (this.WaitingTime != null &&
                    this.WaitingTime.Equals(input.WaitingTime))
                ) && 
                (
                    this.Fare == input.Fare ||
                    (this.Fare != null &&
                    this.Fare.Equals(input.Fare))
                ) && 
                (
                    this.FuelOilSurcharge == input.FuelOilSurcharge ||
                    (this.FuelOilSurcharge != null &&
                    this.FuelOilSurcharge.Equals(input.FuelOilSurcharge))
                ) && 
                (
                    this.CallServiceSurcharge == input.CallServiceSurcharge ||
                    (this.CallServiceSurcharge != null &&
                    this.CallServiceSurcharge.Equals(input.CallServiceSurcharge))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.TaxiNumber != null)
                    hashCode = hashCode * 59 + this.TaxiNumber.GetHashCode();
                if (this.CertificateNumber != null)
                    hashCode = hashCode * 59 + this.CertificateNumber.GetHashCode();
                if (this.IdentificationNumber != null)
                    hashCode = hashCode * 59 + this.IdentificationNumber.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.BoardingTime != null)
                    hashCode = hashCode * 59 + this.BoardingTime.GetHashCode();
                if (this.AlightingTime != null)
                    hashCode = hashCode * 59 + this.AlightingTime.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.WaitingTime != null)
                    hashCode = hashCode * 59 + this.WaitingTime.GetHashCode();
                if (this.Fare != null)
                    hashCode = hashCode * 59 + this.Fare.GetHashCode();
                if (this.FuelOilSurcharge != null)
                    hashCode = hashCode * 59 + this.FuelOilSurcharge.GetHashCode();
                if (this.CallServiceSurcharge != null)
                    hashCode = hashCode * 59 + this.CallServiceSurcharge.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.TextLocation != null)
                    hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
