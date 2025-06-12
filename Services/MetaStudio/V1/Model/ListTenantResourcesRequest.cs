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
    public class ListTenantResourcesRequest 
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
        /// 每页显示的条目数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量，表示从此偏移量开始查询。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 资源类型。可填多个，用\&quot;,\&quot;分隔。详见[资源类型](metastudio_02_0042.xml)。
        /// </summary>
        [SDKProperty("resource", IsQuery = true)]
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        /// <summary>
        /// 业务类型。可填多个，用\&quot;,\&quot;分隔。 * VOICE_CLONE：声音制作 * SYNTHETICS_SOUND：声音合成 * ASSET_MANAGER：资产管理 * MODELING_2D：形象制作 * LIVE_2D：分身数字人视频直播 * VIDEO_2D：分身数字人视频制作 * CHAT_2D：分身数字人智能交互 * BUSINESS_CARD_2D：分身数字人名片 * PICTURE_2D：照片数字人视频 * MODELING_3D：3D照片建模 * VDS_3D：3D视觉驱动 * TTSA_3D：3D语音驱动 * FLEXUS_2D：FLEXUS版本资源
        /// </summary>
        [SDKProperty("business", IsQuery = true)]
        [JsonProperty("business", NullValueHandling = NullValueHandling.Ignore)]
        public string Business { get; set; }

        /// <summary>
        /// 资源来源,可填多个 例如:PURCHASED,ADMIN_ALLOCATED,将返回商用资源与管理员分配资源。 * PURCHASED: 用户购买的资源 * SP_ALLOCATED: SP分配的资源 * ADMIN_ALLOCATED: 系统管理员分配的资源
        /// </summary>
        [SDKProperty("resource_source", IsQuery = true)]
        [JsonProperty("resource_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSource { get; set; }

        /// <summary>
        /// 资源id。
        /// </summary>
        [SDKProperty("resource_id", IsQuery = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 订单id。
        /// </summary>
        [SDKProperty("order_id", IsQuery = true)]
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 计费类型。  * PERIODIC: 包周期  * ONE_TIME：一次性  * ON_DEMAND：按需 计费模式。
        /// </summary>
        [SDKProperty("charging_mode", IsQuery = true)]
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargingMode { get; set; }

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
        /// 子资源类型。当前只有flexus套餐包存在该字段 * voice_clone_flexus: 语音克隆Flexus版 * modeling_count_2d_model_flexus: 分身数字人形象制作Flexus版 * video_time_flexus_2d_model: 分身数字人Flexus版本视频制作
        /// </summary>
        [SDKProperty("sub_resource", IsQuery = true)]
        [JsonProperty("sub_resource", NullValueHandling = NullValueHandling.Ignore)]
        public string SubResource { get; set; }

        /// <summary>
        /// 资源状态。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTenantResourcesRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  xProjectId: ").Append(XProjectId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  business: ").Append(Business).Append("\n");
            sb.Append("  resourceSource: ").Append(ResourceSource).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  resourceExpireStartTime: ").Append(ResourceExpireStartTime).Append("\n");
            sb.Append("  resourceExpireEndTime: ").Append(ResourceExpireEndTime).Append("\n");
            sb.Append("  subResource: ").Append(SubResource).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTenantResourcesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTenantResourcesRequest input)
        {
            if (input == null) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.XProjectId != input.XProjectId || (this.XProjectId != null && !this.XProjectId.Equals(input.XProjectId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.Business != input.Business || (this.Business != null && !this.Business.Equals(input.Business))) return false;
            if (this.ResourceSource != input.ResourceSource || (this.ResourceSource != null && !this.ResourceSource.Equals(input.ResourceSource))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.ResourceExpireStartTime != input.ResourceExpireStartTime || (this.ResourceExpireStartTime != null && !this.ResourceExpireStartTime.Equals(input.ResourceExpireStartTime))) return false;
            if (this.ResourceExpireEndTime != input.ResourceExpireEndTime || (this.ResourceExpireEndTime != null && !this.ResourceExpireEndTime.Equals(input.ResourceExpireEndTime))) return false;
            if (this.SubResource != input.SubResource || (this.SubResource != null && !this.SubResource.Equals(input.SubResource))) return false;
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
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.XProjectId != null) hashCode = hashCode * 59 + this.XProjectId.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Business != null) hashCode = hashCode * 59 + this.Business.GetHashCode();
                if (this.ResourceSource != null) hashCode = hashCode * 59 + this.ResourceSource.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.ResourceExpireStartTime != null) hashCode = hashCode * 59 + this.ResourceExpireStartTime.GetHashCode();
                if (this.ResourceExpireEndTime != null) hashCode = hashCode * 59 + this.ResourceExpireEndTime.GetHashCode();
                if (this.SubResource != null) hashCode = hashCode * 59 + this.SubResource.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
