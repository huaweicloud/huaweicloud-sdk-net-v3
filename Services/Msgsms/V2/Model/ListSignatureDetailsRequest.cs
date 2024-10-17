using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Msgsms.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSignatureDetailsRequest 
    {

        /// <summary>
        /// 应用名称
        /// </summary>
        [SDKProperty("app_name", IsQuery = true)]
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 签名ID
        /// </summary>
        [SDKProperty("signature_id", IsQuery = true)]
        [JsonProperty("signature_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureId { get; set; }

        /// <summary>
        /// 签名名称
        /// </summary>
        [SDKProperty("signature_name", IsQuery = true)]
        [JsonProperty("signature_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureName { get; set; }

        /// <summary>
        /// 签名类型。支持枚举值： 1. VERIFY_CODE_TYPE: 验证码类 2. PROMOTION_TYPE: 推广类 3. NOTIFY_TYPE: 通知类
        /// </summary>
        [SDKProperty("signature_type", IsQuery = true)]
        [JsonProperty("signature_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureType { get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [SDKProperty("site", IsQuery = true)]
        [JsonProperty("site", NullValueHandling = NullValueHandling.Ignore)]
        public string Site { get; set; }

        /// <summary>
        /// 排序方式 1. desc：降序 2. asc：升序
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// 状态 1. PENDING_REVIEW：待审核 2. PROCESSING：内容审核通过，签名处理中 3. REVIEW_PASSED：处理完毕 4. REVIEW_NOT_PASS：审核不通过 5. TO_BE_ACTIVATED：待激活 6. PENDING_ACTIVATE：激活审核中
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSignatureDetailsRequest {\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  signatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  signatureName: ").Append(SignatureName).Append("\n");
            sb.Append("  signatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  site: ").Append(Site).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSignatureDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSignatureDetailsRequest input)
        {
            if (input == null) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.SignatureId != input.SignatureId || (this.SignatureId != null && !this.SignatureId.Equals(input.SignatureId))) return false;
            if (this.SignatureName != input.SignatureName || (this.SignatureName != null && !this.SignatureName.Equals(input.SignatureName))) return false;
            if (this.SignatureType != input.SignatureType || (this.SignatureType != null && !this.SignatureType.Equals(input.SignatureType))) return false;
            if (this.Site != input.Site || (this.Site != null && !this.Site.Equals(input.Site))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.SignatureId != null) hashCode = hashCode * 59 + this.SignatureId.GetHashCode();
                if (this.SignatureName != null) hashCode = hashCode * 59 + this.SignatureName.GetHashCode();
                if (this.SignatureType != null) hashCode = hashCode * 59 + this.SignatureType.GetHashCode();
                if (this.Site != null) hashCode = hashCode * 59 + this.Site.GetHashCode();
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
