using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowMessageDiagnosisReportResponse : SdkResponse
    {

        /// <summary>
        /// 诊断异常的诊断项总和
        /// </summary>
        [JsonProperty("abnormal_item_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AbnormalItemNum { get; set; }

        /// <summary>
        /// 诊断失败的诊断项总和
        /// </summary>
        [JsonProperty("failed_item_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedItemNum { get; set; }

        /// <summary>
        /// 诊断正常的诊断项总和
        /// </summary>
        [JsonProperty("normal_item_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NormalItemNum { get; set; }

        /// <summary>
        /// 诊断维度列表
        /// </summary>
        [JsonProperty("diagnosis_dimension_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<KafkaMessageDiagnosisDimensionEntity> DiagnosisDimensionList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMessageDiagnosisReportResponse {\n");
            sb.Append("  abnormalItemNum: ").Append(AbnormalItemNum).Append("\n");
            sb.Append("  failedItemNum: ").Append(FailedItemNum).Append("\n");
            sb.Append("  normalItemNum: ").Append(NormalItemNum).Append("\n");
            sb.Append("  diagnosisDimensionList: ").Append(DiagnosisDimensionList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMessageDiagnosisReportResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMessageDiagnosisReportResponse input)
        {
            if (input == null) return false;
            if (this.AbnormalItemNum != input.AbnormalItemNum || (this.AbnormalItemNum != null && !this.AbnormalItemNum.Equals(input.AbnormalItemNum))) return false;
            if (this.FailedItemNum != input.FailedItemNum || (this.FailedItemNum != null && !this.FailedItemNum.Equals(input.FailedItemNum))) return false;
            if (this.NormalItemNum != input.NormalItemNum || (this.NormalItemNum != null && !this.NormalItemNum.Equals(input.NormalItemNum))) return false;
            if (this.DiagnosisDimensionList != input.DiagnosisDimensionList || (this.DiagnosisDimensionList != null && input.DiagnosisDimensionList != null && !this.DiagnosisDimensionList.SequenceEqual(input.DiagnosisDimensionList))) return false;

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
                if (this.AbnormalItemNum != null) hashCode = hashCode * 59 + this.AbnormalItemNum.GetHashCode();
                if (this.FailedItemNum != null) hashCode = hashCode * 59 + this.FailedItemNum.GetHashCode();
                if (this.NormalItemNum != null) hashCode = hashCode * 59 + this.NormalItemNum.GetHashCode();
                if (this.DiagnosisDimensionList != null) hashCode = hashCode * 59 + this.DiagnosisDimensionList.GetHashCode();
                return hashCode;
            }
        }
    }
}
