using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CountTenantResourcesRequest 
    {

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。  格式为(YYYYMMDD&#39;T&#39;HHMMSS&#39;Z&#39;)。
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带项目ID信息。
        /// </summary>
        [SDKProperty("X-Project-Id", IsHeader = true)]
        [JsonProperty("X-Project-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XProjectId { get; set; }

        /// <summary>
        /// 业务类型。可填多个用\&quot;,\&quot;分隔 * VOICE_CLONE：声音制作 * SYNTHETICS_SOUND：声音合成 * ASSET_MANAGER：资产管理 * MODELING_2D：形象制作 * LIVE_2D：分身数字人视频直播 * VIDEO_2D：分身数字人视频制作 * CHAT_2D：分身数字人智能交互 * BUSINESS_CARD_2D：分身数字人名片 * PICTURE_2D：照片数字人视频 * MODELING_3D：3D照片建模 * VDS_3D：3D视觉驱动 * TTSA_3D：3D语音驱动 * FLEXUS_2D：FLEXUS版本资源
        /// </summary>
        [SDKProperty("business", IsQuery = true)]
        [JsonProperty("business", NullValueHandling = NullValueHandling.Ignore)]
        public string Business { get; set; }

        /// <summary>
        /// 资源过期时间段 开始时间。格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;
        /// </summary>
        [SDKProperty("resource_expire_start_time", IsQuery = true)]
        [JsonProperty("resource_expire_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceExpireStartTime { get; set; }

        /// <summary>
        /// 资源过期时间段 结束时间。格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;
        /// </summary>
        [SDKProperty("resource_expire_end_time", IsQuery = true)]
        [JsonProperty("resource_expire_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceExpireEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountTenantResourcesRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  xProjectId: ").Append(XProjectId).Append("\n");
            sb.Append("  business: ").Append(Business).Append("\n");
            sb.Append("  resourceExpireStartTime: ").Append(ResourceExpireStartTime).Append("\n");
            sb.Append("  resourceExpireEndTime: ").Append(ResourceExpireEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CountTenantResourcesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CountTenantResourcesRequest input)
        {
            if (input == null) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.XProjectId != input.XProjectId || (this.XProjectId != null && !this.XProjectId.Equals(input.XProjectId))) return false;
            if (this.Business != input.Business || (this.Business != null && !this.Business.Equals(input.Business))) return false;
            if (this.ResourceExpireStartTime != input.ResourceExpireStartTime || (this.ResourceExpireStartTime != null && !this.ResourceExpireStartTime.Equals(input.ResourceExpireStartTime))) return false;
            if (this.ResourceExpireEndTime != input.ResourceExpireEndTime || (this.ResourceExpireEndTime != null && !this.ResourceExpireEndTime.Equals(input.ResourceExpireEndTime))) return false;

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
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.XProjectId != null) hashCode = hashCode * 59 + this.XProjectId.GetHashCode();
                if (this.Business != null) hashCode = hashCode * 59 + this.Business.GetHashCode();
                if (this.ResourceExpireStartTime != null) hashCode = hashCode * 59 + this.ResourceExpireStartTime.GetHashCode();
                if (this.ResourceExpireEndTime != null) hashCode = hashCode * 59 + this.ResourceExpireEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
