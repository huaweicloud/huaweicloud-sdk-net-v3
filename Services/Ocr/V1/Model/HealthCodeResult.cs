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
    public class HealthCodeResult 
    {

        /// <summary>
        /// 防疫码类别： - 健康码：health_code - 核酸检测记录：pcr_test_record - 通信行程卡：travel_card - 其他：other 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 姓名 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 身份证号码 
        /// </summary>
        [JsonProperty("idcard_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IdcardNumber { get; set; }

        /// <summary>
        /// 手机号码 
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 省份 
        /// </summary>
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        /// 城市 
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// 健康码或行程卡的更新时间 
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 健康码或行程卡颜色。 健康码颜色可选值包括：  - \&quot;green\&quot;，绿码 - \&quot;yellow\&quot;，黄码 - \&quot;red\&quot;，红码 - \&quot;gray\&quot;，灰码  行程卡颜色可选值包括：  - \&quot;green\&quot;，绿码 - \&quot;yellow\&quot;，黄码 - \&quot;red\&quot;，红码 
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// 疫苗接种情况，可选值包括：  - 未接种 - 接种中 - 无接种记录 - 已接种1针 - 已接种2针 - 已接种3针 - 已完成新冠疫苗接种 
        /// </summary>
        [JsonProperty("vaccination_status", NullValueHandling = NullValueHandling.Ignore)]
        public string VaccinationStatus { get; set; }

        /// <summary>
        /// 核酸检测间隔时长，可选值包括： - 24小时内 - 48小时内 - 72小时内 - 5天内 - 7天内 - 7天外 
        /// </summary>
        [JsonProperty("test_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string TestInterval { get; set; }

        /// <summary>
        /// 核酸检测结果，可选值包括： - \&quot;positive\&quot;,即阳性 - \&quot;negative\&quot;,即阴性 - \&quot;unknown\&quot;,未知 
        /// </summary>
        [JsonProperty("pcr_test_result", NullValueHandling = NullValueHandling.Ignore)]
        public string PcrTestResult { get; set; }

        /// <summary>
        /// 核酸检测机构 
        /// </summary>
        [JsonProperty("pcr_test_organization", NullValueHandling = NullValueHandling.Ignore)]
        public string PcrTestOrganization { get; set; }

        /// <summary>
        /// 核酸检测结果更新时间 
        /// </summary>
        [JsonProperty("pcr_test_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PcrTestTime { get; set; }

        /// <summary>
        /// 核酸检测采样时间 
        /// </summary>
        [JsonProperty("pcr_sampling_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PcrSamplingTime { get; set; }

        /// <summary>
        /// 行程卡的途径地址 
        /// </summary>
        [JsonProperty("reached_city", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReachedCity { get; set; }

        /// <summary>
        /// 各个字段的置信度。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }

        /// <summary>
        /// 代表检测识别出来的文字块数目。 
        /// </summary>
        [JsonProperty("words_block_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? WordsBlockCount { get; set; }

        /// <summary>
        /// 识别文字块列表，输出顺序从左到右，从上到下。 
        /// </summary>
        [JsonProperty("words_block_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<HealthCodeWordsBlockList> WordsBlockList { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HealthCodeResult {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  idcardNumber: ").Append(IdcardNumber).Append("\n");
            sb.Append("  phoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  province: ").Append(Province).Append("\n");
            sb.Append("  city: ").Append(City).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  color: ").Append(Color).Append("\n");
            sb.Append("  vaccinationStatus: ").Append(VaccinationStatus).Append("\n");
            sb.Append("  testInterval: ").Append(TestInterval).Append("\n");
            sb.Append("  pcrTestResult: ").Append(PcrTestResult).Append("\n");
            sb.Append("  pcrTestOrganization: ").Append(PcrTestOrganization).Append("\n");
            sb.Append("  pcrTestTime: ").Append(PcrTestTime).Append("\n");
            sb.Append("  pcrSamplingTime: ").Append(PcrSamplingTime).Append("\n");
            sb.Append("  reachedCity: ").Append(ReachedCity).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  wordsBlockCount: ").Append(WordsBlockCount).Append("\n");
            sb.Append("  wordsBlockList: ").Append(WordsBlockList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HealthCodeResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HealthCodeResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IdcardNumber == input.IdcardNumber ||
                    (this.IdcardNumber != null &&
                    this.IdcardNumber.Equals(input.IdcardNumber))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.VaccinationStatus == input.VaccinationStatus ||
                    (this.VaccinationStatus != null &&
                    this.VaccinationStatus.Equals(input.VaccinationStatus))
                ) && 
                (
                    this.TestInterval == input.TestInterval ||
                    (this.TestInterval != null &&
                    this.TestInterval.Equals(input.TestInterval))
                ) && 
                (
                    this.PcrTestResult == input.PcrTestResult ||
                    (this.PcrTestResult != null &&
                    this.PcrTestResult.Equals(input.PcrTestResult))
                ) && 
                (
                    this.PcrTestOrganization == input.PcrTestOrganization ||
                    (this.PcrTestOrganization != null &&
                    this.PcrTestOrganization.Equals(input.PcrTestOrganization))
                ) && 
                (
                    this.PcrTestTime == input.PcrTestTime ||
                    (this.PcrTestTime != null &&
                    this.PcrTestTime.Equals(input.PcrTestTime))
                ) && 
                (
                    this.PcrSamplingTime == input.PcrSamplingTime ||
                    (this.PcrSamplingTime != null &&
                    this.PcrSamplingTime.Equals(input.PcrSamplingTime))
                ) && 
                (
                    this.ReachedCity == input.ReachedCity ||
                    this.ReachedCity != null &&
                    input.ReachedCity != null &&
                    this.ReachedCity.SequenceEqual(input.ReachedCity)
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.WordsBlockCount == input.WordsBlockCount ||
                    (this.WordsBlockCount != null &&
                    this.WordsBlockCount.Equals(input.WordsBlockCount))
                ) && 
                (
                    this.WordsBlockList == input.WordsBlockList ||
                    this.WordsBlockList != null &&
                    input.WordsBlockList != null &&
                    this.WordsBlockList.SequenceEqual(input.WordsBlockList)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IdcardNumber != null)
                    hashCode = hashCode * 59 + this.IdcardNumber.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.VaccinationStatus != null)
                    hashCode = hashCode * 59 + this.VaccinationStatus.GetHashCode();
                if (this.TestInterval != null)
                    hashCode = hashCode * 59 + this.TestInterval.GetHashCode();
                if (this.PcrTestResult != null)
                    hashCode = hashCode * 59 + this.PcrTestResult.GetHashCode();
                if (this.PcrTestOrganization != null)
                    hashCode = hashCode * 59 + this.PcrTestOrganization.GetHashCode();
                if (this.PcrTestTime != null)
                    hashCode = hashCode * 59 + this.PcrTestTime.GetHashCode();
                if (this.PcrSamplingTime != null)
                    hashCode = hashCode * 59 + this.PcrSamplingTime.GetHashCode();
                if (this.ReachedCity != null)
                    hashCode = hashCode * 59 + this.ReachedCity.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.WordsBlockCount != null)
                    hashCode = hashCode * 59 + this.WordsBlockCount.GetHashCode();
                if (this.WordsBlockList != null)
                    hashCode = hashCode * 59 + this.WordsBlockList.GetHashCode();
                return hashCode;
            }
        }
    }
}
