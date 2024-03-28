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
    /// 消息积压诊断维度
    /// </summary>
    public class KafkaMessageDiagnosisDimensionEntity 
    {

        /// <summary>
        /// 诊断维度名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 该诊断维度下，异常的诊断项总数
        /// </summary>
        [JsonProperty("abnormal_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AbnormalNum { get; set; }

        /// <summary>
        /// 该诊断维度下，诊断失败的诊断项总和
        /// </summary>
        [JsonProperty("failed_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedNum { get; set; }

        /// <summary>
        /// 诊断项列表
        /// </summary>
        [JsonProperty("diagnosis_item_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<KafkaMessageDiagnosisItemEntity> DiagnosisItemList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KafkaMessageDiagnosisDimensionEntity {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  abnormalNum: ").Append(AbnormalNum).Append("\n");
            sb.Append("  failedNum: ").Append(FailedNum).Append("\n");
            sb.Append("  diagnosisItemList: ").Append(DiagnosisItemList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KafkaMessageDiagnosisDimensionEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KafkaMessageDiagnosisDimensionEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AbnormalNum == input.AbnormalNum ||
                    (this.AbnormalNum != null &&
                    this.AbnormalNum.Equals(input.AbnormalNum))
                ) && 
                (
                    this.FailedNum == input.FailedNum ||
                    (this.FailedNum != null &&
                    this.FailedNum.Equals(input.FailedNum))
                ) && 
                (
                    this.DiagnosisItemList == input.DiagnosisItemList ||
                    this.DiagnosisItemList != null &&
                    input.DiagnosisItemList != null &&
                    this.DiagnosisItemList.SequenceEqual(input.DiagnosisItemList)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AbnormalNum != null)
                    hashCode = hashCode * 59 + this.AbnormalNum.GetHashCode();
                if (this.FailedNum != null)
                    hashCode = hashCode * 59 + this.FailedNum.GetHashCode();
                if (this.DiagnosisItemList != null)
                    hashCode = hashCode * 59 + this.DiagnosisItemList.GetHashCode();
                return hashCode;
            }
        }
    }
}
