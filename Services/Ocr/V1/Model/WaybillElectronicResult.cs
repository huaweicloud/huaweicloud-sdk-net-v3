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
    public class WaybillElectronicResult 
    {

        /// <summary>
        /// 三段码。 
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 收件人姓名。 
        /// </summary>
        [JsonProperty("receiver_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收件人电话。 
        /// </summary>
        [JsonProperty("receiver_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 收件人地址。 
        /// </summary>
        [JsonProperty("receiver_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 寄件人姓名。 
        /// </summary>
        [JsonProperty("sender_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderName { get; set; }

        /// <summary>
        /// 寄件人电话。 
        /// </summary>
        [JsonProperty("sender_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderPhone { get; set; }

        /// <summary>
        /// 寄件人地址。 
        /// </summary>
        [JsonProperty("sender_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderAddress { get; set; }

        /// <summary>
        /// 条形码运单号。 
        /// </summary>
        [JsonProperty("waybill_number", NullValueHandling = NullValueHandling.Ignore)]
        public string WaybillNumber { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，取值范围0~1。 置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。 置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaybillElectronicResult {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  receiverName: ").Append(ReceiverName).Append("\n");
            sb.Append("  receiverPhone: ").Append(ReceiverPhone).Append("\n");
            sb.Append("  receiverAddress: ").Append(ReceiverAddress).Append("\n");
            sb.Append("  senderName: ").Append(SenderName).Append("\n");
            sb.Append("  senderPhone: ").Append(SenderPhone).Append("\n");
            sb.Append("  senderAddress: ").Append(SenderAddress).Append("\n");
            sb.Append("  waybillNumber: ").Append(WaybillNumber).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WaybillElectronicResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WaybillElectronicResult input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.ReceiverName != input.ReceiverName || (this.ReceiverName != null && !this.ReceiverName.Equals(input.ReceiverName))) return false;
            if (this.ReceiverPhone != input.ReceiverPhone || (this.ReceiverPhone != null && !this.ReceiverPhone.Equals(input.ReceiverPhone))) return false;
            if (this.ReceiverAddress != input.ReceiverAddress || (this.ReceiverAddress != null && !this.ReceiverAddress.Equals(input.ReceiverAddress))) return false;
            if (this.SenderName != input.SenderName || (this.SenderName != null && !this.SenderName.Equals(input.SenderName))) return false;
            if (this.SenderPhone != input.SenderPhone || (this.SenderPhone != null && !this.SenderPhone.Equals(input.SenderPhone))) return false;
            if (this.SenderAddress != input.SenderAddress || (this.SenderAddress != null && !this.SenderAddress.Equals(input.SenderAddress))) return false;
            if (this.WaybillNumber != input.WaybillNumber || (this.WaybillNumber != null && !this.WaybillNumber.Equals(input.WaybillNumber))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;

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
                if (this.ReceiverName != null) hashCode = hashCode * 59 + this.ReceiverName.GetHashCode();
                if (this.ReceiverPhone != null) hashCode = hashCode * 59 + this.ReceiverPhone.GetHashCode();
                if (this.ReceiverAddress != null) hashCode = hashCode * 59 + this.ReceiverAddress.GetHashCode();
                if (this.SenderName != null) hashCode = hashCode * 59 + this.SenderName.GetHashCode();
                if (this.SenderPhone != null) hashCode = hashCode * 59 + this.SenderPhone.GetHashCode();
                if (this.SenderAddress != null) hashCode = hashCode * 59 + this.SenderAddress.GetHashCode();
                if (this.WaybillNumber != null) hashCode = hashCode * 59 + this.WaybillNumber.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
