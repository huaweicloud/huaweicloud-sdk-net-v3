using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 创建数据级对比任务请求
    /// </summary>
    public class CreateDataLevelTableCompareJobReq 
    {

        /// <summary>
        /// 对比类型。 - lines：行数对比 - contents：内容对比 - random：抽样对比，当前仅支持gaussdbv5、gaussdbv5-to-postgresql、gaussdbv5ha-to-postgresql链路。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 对比任务启动时间，时间戳格式，取值为空代表立即启动。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 数据级对比模式，取值为空时需要在compare_object或者compare_object_with_token传对象信息，quick_comparison-快速对比。 取值：quick_comparison
        /// </summary>
        [JsonProperty("compare_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareMode { get; set; }

        /// <summary>
        /// 数据级对比的对象。
        /// </summary>
        [JsonProperty("compare_object", NullValueHandling = NullValueHandling.Ignore)]
        public List<CompareObjectInfo> CompareObject { get; set; }

        /// <summary>
        /// 对比配置项，key-value形式。 内容对比支持以下配置项： - 对比方式配置，key：contentCompareType，value：dynamic表示动态对比，static表示静态对比。 - lob字段对比类型配置，key：lobCompare，value：ignore表示忽略，length表示长度对比。  行数对比支持以下配置项： - 对比策略配置，多表归一情况下适用，key：comparePolicy，value：normal表示正常对比，manyToOne表示多对一对比。
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// 数据级对比的对象（Cassandra灾备专用，带token信息）。
        /// </summary>
        [JsonProperty("compare_object_with_token", NullValueHandling = NullValueHandling.Ignore)]
        public List<CompareObjectInfoWithToken> CompareObjectWithToken { get; set; }

        /// <summary>
        /// 对比任务线程数量，当前仅cloudDataGuard-cassandra和cloudDataGuard-gausscassandra-to-gausscassandra链路支持。
        /// </summary>
        [JsonProperty("compare_task_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompareTaskNum { get; set; }

        /// <summary>
        /// 过滤数据信息。
        /// </summary>
        [JsonProperty("compare_transformation_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddDataTransformationReq> CompareTransformationInfos { get; set; }

        /// <summary>
        /// 抽样比例，对比类型为抽样对比时填写。
        /// </summary>
        [JsonProperty("proportion_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? ProportionValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDataLevelTableCompareJobReq {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  compareMode: ").Append(CompareMode).Append("\n");
            sb.Append("  compareObject: ").Append(CompareObject).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("  compareObjectWithToken: ").Append(CompareObjectWithToken).Append("\n");
            sb.Append("  compareTaskNum: ").Append(CompareTaskNum).Append("\n");
            sb.Append("  compareTransformationInfos: ").Append(CompareTransformationInfos).Append("\n");
            sb.Append("  proportionValue: ").Append(ProportionValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDataLevelTableCompareJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDataLevelTableCompareJobReq input)
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
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.CompareMode == input.CompareMode ||
                    (this.CompareMode != null &&
                    this.CompareMode.Equals(input.CompareMode))
                ) && 
                (
                    this.CompareObject == input.CompareObject ||
                    this.CompareObject != null &&
                    input.CompareObject != null &&
                    this.CompareObject.SequenceEqual(input.CompareObject)
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.CompareObjectWithToken == input.CompareObjectWithToken ||
                    this.CompareObjectWithToken != null &&
                    input.CompareObjectWithToken != null &&
                    this.CompareObjectWithToken.SequenceEqual(input.CompareObjectWithToken)
                ) && 
                (
                    this.CompareTaskNum == input.CompareTaskNum ||
                    (this.CompareTaskNum != null &&
                    this.CompareTaskNum.Equals(input.CompareTaskNum))
                ) && 
                (
                    this.CompareTransformationInfos == input.CompareTransformationInfos ||
                    this.CompareTransformationInfos != null &&
                    input.CompareTransformationInfos != null &&
                    this.CompareTransformationInfos.SequenceEqual(input.CompareTransformationInfos)
                ) && 
                (
                    this.ProportionValue == input.ProportionValue ||
                    (this.ProportionValue != null &&
                    this.ProportionValue.Equals(input.ProportionValue))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.CompareMode != null)
                    hashCode = hashCode * 59 + this.CompareMode.GetHashCode();
                if (this.CompareObject != null)
                    hashCode = hashCode * 59 + this.CompareObject.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.CompareObjectWithToken != null)
                    hashCode = hashCode * 59 + this.CompareObjectWithToken.GetHashCode();
                if (this.CompareTaskNum != null)
                    hashCode = hashCode * 59 + this.CompareTaskNum.GetHashCode();
                if (this.CompareTransformationInfos != null)
                    hashCode = hashCode * 59 + this.CompareTransformationInfos.GetHashCode();
                if (this.ProportionValue != null)
                    hashCode = hashCode * 59 + this.ProportionValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
