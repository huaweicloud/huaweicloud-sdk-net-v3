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
    public class TollInvoiceResult 
    {

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
        /// 入口。 
        /// </summary>
        [JsonProperty("entry", NullValueHandling = NullValueHandling.Ignore)]
        public string Entry { get; set; }

        /// <summary>
        /// 出口。 
        /// </summary>
        [JsonProperty("exit", NullValueHandling = NullValueHandling.Ignore)]
        public string Exit { get; set; }

        /// <summary>
        /// 收费金额。 
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 收费员。 
        /// </summary>
        [JsonProperty("cashier", NullValueHandling = NullValueHandling.Ignore)]
        public string Cashier { get; set; }

        /// <summary>
        /// 车辆类型。 
        /// </summary>
        [JsonProperty("vehicle_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleType { get; set; }

        /// <summary>
        /// 日期。 
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// 时间。 
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

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
            sb.Append("class TollInvoiceResult {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  entry: ").Append(Entry).Append("\n");
            sb.Append("  exit: ").Append(Exit).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  cashier: ").Append(Cashier).Append("\n");
            sb.Append("  vehicleType: ").Append(VehicleType).Append("\n");
            sb.Append("  date: ").Append(Date).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
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
            return this.Equals(input as TollInvoiceResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TollInvoiceResult input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Entry != input.Entry || (this.Entry != null && !this.Entry.Equals(input.Entry))) return false;
            if (this.Exit != input.Exit || (this.Exit != null && !this.Exit.Equals(input.Exit))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.Cashier != input.Cashier || (this.Cashier != null && !this.Cashier.Equals(input.Cashier))) return false;
            if (this.VehicleType != input.VehicleType || (this.VehicleType != null && !this.VehicleType.Equals(input.VehicleType))) return false;
            if (this.Date != input.Date || (this.Date != null && !this.Date.Equals(input.Date))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;
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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Entry != null) hashCode = hashCode * 59 + this.Entry.GetHashCode();
                if (this.Exit != null) hashCode = hashCode * 59 + this.Exit.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Cashier != null) hashCode = hashCode * 59 + this.Cashier.GetHashCode();
                if (this.VehicleType != null) hashCode = hashCode * 59 + this.VehicleType.GetHashCode();
                if (this.Date != null) hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.TextLocation != null) hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
