using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 查询对比任务信息体。
    /// </summary>
    public class CompareResultInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("objects_compare_overview_info", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectsCompareTaskInfo ObjectsCompareOverviewInfo { get; set; }

        /// <summary>
        /// 对象级对比详情信息体。
        /// </summary>
        [JsonProperty("objects_compare_detail_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectsCompareDetailInfo> ObjectsCompareDetailInfos { get; set; }

        /// <summary>
        /// 数据对比任务列表。
        /// </summary>
        [JsonProperty("data_compare_task_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CompareJobInfo> DataCompareTaskList { get; set; }

        /// <summary>
        /// 行数对比概览信息体。
        /// </summary>
        [JsonProperty("line_compare_overview_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<LineCompareOverviewInfo> LineCompareOverviewInfos { get; set; }

        /// <summary>
        /// 行数对比任务表级详情。
        /// </summary>
        [JsonProperty("line_compare_detail_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<TableLineCompareDetailInfo> LineCompareDetailInfos { get; set; }

        /// <summary>
        /// 内容对比概览信息体。
        /// </summary>
        [JsonProperty("content_compare_overview_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContentCompareOverviewInfo> ContentCompareOverviewInfos { get; set; }

        /// <summary>
        /// 内容对比详情信息体。
        /// </summary>
        [JsonProperty("content_compare_detail_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContentCompareDetailInfo> ContentCompareDetailInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareResultInfo {\n");
            sb.Append("  objectsCompareOverviewInfo: ").Append(ObjectsCompareOverviewInfo).Append("\n");
            sb.Append("  objectsCompareDetailInfos: ").Append(ObjectsCompareDetailInfos).Append("\n");
            sb.Append("  dataCompareTaskList: ").Append(DataCompareTaskList).Append("\n");
            sb.Append("  lineCompareOverviewInfos: ").Append(LineCompareOverviewInfos).Append("\n");
            sb.Append("  lineCompareDetailInfos: ").Append(LineCompareDetailInfos).Append("\n");
            sb.Append("  contentCompareOverviewInfos: ").Append(ContentCompareOverviewInfos).Append("\n");
            sb.Append("  contentCompareDetailInfos: ").Append(ContentCompareDetailInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareResultInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareResultInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectsCompareOverviewInfo == input.ObjectsCompareOverviewInfo ||
                    (this.ObjectsCompareOverviewInfo != null &&
                    this.ObjectsCompareOverviewInfo.Equals(input.ObjectsCompareOverviewInfo))
                ) && 
                (
                    this.ObjectsCompareDetailInfos == input.ObjectsCompareDetailInfos ||
                    this.ObjectsCompareDetailInfos != null &&
                    input.ObjectsCompareDetailInfos != null &&
                    this.ObjectsCompareDetailInfos.SequenceEqual(input.ObjectsCompareDetailInfos)
                ) && 
                (
                    this.DataCompareTaskList == input.DataCompareTaskList ||
                    this.DataCompareTaskList != null &&
                    input.DataCompareTaskList != null &&
                    this.DataCompareTaskList.SequenceEqual(input.DataCompareTaskList)
                ) && 
                (
                    this.LineCompareOverviewInfos == input.LineCompareOverviewInfos ||
                    this.LineCompareOverviewInfos != null &&
                    input.LineCompareOverviewInfos != null &&
                    this.LineCompareOverviewInfos.SequenceEqual(input.LineCompareOverviewInfos)
                ) && 
                (
                    this.LineCompareDetailInfos == input.LineCompareDetailInfos ||
                    this.LineCompareDetailInfos != null &&
                    input.LineCompareDetailInfos != null &&
                    this.LineCompareDetailInfos.SequenceEqual(input.LineCompareDetailInfos)
                ) && 
                (
                    this.ContentCompareOverviewInfos == input.ContentCompareOverviewInfos ||
                    this.ContentCompareOverviewInfos != null &&
                    input.ContentCompareOverviewInfos != null &&
                    this.ContentCompareOverviewInfos.SequenceEqual(input.ContentCompareOverviewInfos)
                ) && 
                (
                    this.ContentCompareDetailInfos == input.ContentCompareDetailInfos ||
                    this.ContentCompareDetailInfos != null &&
                    input.ContentCompareDetailInfos != null &&
                    this.ContentCompareDetailInfos.SequenceEqual(input.ContentCompareDetailInfos)
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
                if (this.ObjectsCompareOverviewInfo != null)
                    hashCode = hashCode * 59 + this.ObjectsCompareOverviewInfo.GetHashCode();
                if (this.ObjectsCompareDetailInfos != null)
                    hashCode = hashCode * 59 + this.ObjectsCompareDetailInfos.GetHashCode();
                if (this.DataCompareTaskList != null)
                    hashCode = hashCode * 59 + this.DataCompareTaskList.GetHashCode();
                if (this.LineCompareOverviewInfos != null)
                    hashCode = hashCode * 59 + this.LineCompareOverviewInfos.GetHashCode();
                if (this.LineCompareDetailInfos != null)
                    hashCode = hashCode * 59 + this.LineCompareDetailInfos.GetHashCode();
                if (this.ContentCompareOverviewInfos != null)
                    hashCode = hashCode * 59 + this.ContentCompareOverviewInfos.GetHashCode();
                if (this.ContentCompareDetailInfos != null)
                    hashCode = hashCode * 59 + this.ContentCompareDetailInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
