using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAssetTaskInfoRequest 
    {

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 媒资Id
        /// </summary>
        [SDKProperty("asset_id", IsQuery = true)]
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 根据任务创建时间匹配该时间之后的，包含该时间点，格式按照RFC3339，UTC时间，如2020-09-01T18:50:20Z
        /// </summary>
        [SDKProperty("create_time_after", IsQuery = true)]
        [JsonProperty("create_time_after", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeAfter { get; set; }

        /// <summary>
        /// 根据任务创建时间匹配该时间之前的，不包含该时间点，格式按照RFC3339，UTC时间，如2020-09-01T18:50:20Z
        /// </summary>
        [SDKProperty("create_time_before", IsQuery = true)]
        [JsonProperty("create_time_before", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeBefore { get; set; }

        /// <summary>
        /// 根据任务结束时间匹配该时间之后的，包含该时间点，格式按照RFC3339，UTC时间，如2020-09-01T18:50:20Z
        /// </summary>
        [SDKProperty("end_time_after", IsQuery = true)]
        [JsonProperty("end_time_after", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTimeAfter { get; set; }

        /// <summary>
        /// 根据任务结束时间匹配该时间之前的，不包含该时间点，格式按照RFC3339，UTC时间，如2020-09-01T18:50:20Z
        /// </summary>
        [SDKProperty("end_time_before", IsQuery = true)]
        [JsonProperty("end_time_before", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTimeBefore { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Status { get; set; }

        /// <summary>
        /// 标志位，不传默认表示从第一条开始
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 返回的每页个数，默认10，最大100，最小1
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAssetTaskInfoRequest {\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  createTimeAfter: ").Append(CreateTimeAfter).Append("\n");
            sb.Append("  createTimeBefore: ").Append(CreateTimeBefore).Append("\n");
            sb.Append("  endTimeAfter: ").Append(EndTimeAfter).Append("\n");
            sb.Append("  endTimeBefore: ").Append(EndTimeBefore).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAssetTaskInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAssetTaskInfoRequest input)
        {
            if (input == null) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.CreateTimeAfter != input.CreateTimeAfter || (this.CreateTimeAfter != null && !this.CreateTimeAfter.Equals(input.CreateTimeAfter))) return false;
            if (this.CreateTimeBefore != input.CreateTimeBefore || (this.CreateTimeBefore != null && !this.CreateTimeBefore.Equals(input.CreateTimeBefore))) return false;
            if (this.EndTimeAfter != input.EndTimeAfter || (this.EndTimeAfter != null && !this.EndTimeAfter.Equals(input.EndTimeAfter))) return false;
            if (this.EndTimeBefore != input.EndTimeBefore || (this.EndTimeBefore != null && !this.EndTimeBefore.Equals(input.EndTimeBefore))) return false;
            if (this.Status != input.Status || (this.Status != null && input.Status != null && !this.Status.SequenceEqual(input.Status))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.CreateTimeAfter != null) hashCode = hashCode * 59 + this.CreateTimeAfter.GetHashCode();
                if (this.CreateTimeBefore != null) hashCode = hashCode * 59 + this.CreateTimeBefore.GetHashCode();
                if (this.EndTimeAfter != null) hashCode = hashCode * 59 + this.EndTimeAfter.GetHashCode();
                if (this.EndTimeBefore != null) hashCode = hashCode * 59 + this.EndTimeBefore.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
